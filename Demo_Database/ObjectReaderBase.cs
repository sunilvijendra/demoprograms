using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Demo_Database.DataAccess
{
    abstract class ObjectReaderBase<T>
    {
        protected abstract IDbConnection GetConnection();
        protected abstract CommandType CommandType { get; }
        protected abstract Collection<IDataParameter> GetParameters(IDbCommand command);
        protected abstract MapperBase<T> GetMapper();

        protected string CommandText { get; set; }

        public Collection<T> Execute()
        {
            Collection<T> collection = new Collection<T>();

            using (IDbConnection connection = GetConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = this.CommandText;
                command.CommandType = this.CommandType;
                
                foreach (IDataParameter param in this.GetParameters(command))
                    command.Parameters.Add(param);

                try
                {
                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            MapperBase<T> mapper = GetMapper();
                            collection = mapper.MapAll(reader);
                            return collection;
                        }
                        catch (Exception e)
                        {
                            throw e;


                            // NOTE: 
                            // consider handling exeption here instead of re-throwing
                            // if graceful recovery can be accomplished
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;

                    // NOTE: 
                    // consider handling exeption here instead of re-throwing
                    // if graceful recovery can be accomplished
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int ExecuteNonQuery()
        {
            using (IDbConnection connection = GetConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = this.CommandText;
                command.CommandType = this.CommandType;

                foreach (IDataParameter param in this.GetParameters(command))
                    command.Parameters.Add(param);

                try
                {
                    connection.Open();

                    try
                    {
                        int rows_affected = command.ExecuteNonQuery();
                        return rows_affected;
                    }
                    catch (SqlException sqle)
                    {
                        throw sqle;

                        // NOTE: 
                        // consider handling exeption here instead of re-throwing
                        // if graceful recovery can be accomplished
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {

                    }
                }
                catch (Exception e)
                {
                    throw e;

                    // NOTE: 
                    // consider handling exeption here instead of re-throwing
                    // if graceful recovery can be accomplished
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}