using Demo_Database.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductReader reader = new ProductReader("select * from Product");

            //Collection<Product> productList = reader.Execute();
            //foreach (Product p in productList)
            //{
            //    Console.WriteLine("id = {0}; name = {1}", p.id, p.name);
            //}

            DatabaseAccess dbAccess = new DatabaseAccess();
            Collection<Product> productList = dbAccess.GetProducts("select * from Product");

            foreach (Product p in productList)
            {
                Console.WriteLine("id = {0}; name = {1}", p.id, p.name);
            }
            Console.ReadKey();

        }

    }

    class DatabaseAccess
    {
        public Collection<Product> GetProducts(string sqlQuery)
        {
            string m_connectionString = @"Data Source=C:\Users\sunilvijendra\Documents\rockwell_csharp\DemoPrograms\Demo_Database\testDB.db;Version=3;";
            // update to get your connection here

            IDbConnection connection = new SQLiteConnection(m_connectionString);
 
            Collection<Product> collection = new Collection<Product>();

            IDbCommand command = connection.CreateCommand();
            command.Connection = connection;
            command.CommandText = sqlQuery;
            command.CommandType = CommandType.Text;

            try
            {
                connection.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            Product p = MapProduct(reader);
                            collection.Add(p);
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
            return collection;
        }

        private Product MapProduct(IDataReader record)
        {
            Product prod = new Product();

            try
            {
                prod.id = (DBNull.Value == record["ProductID"]) ? 0 : (int)record["ProductId"];

                prod.name = (DBNull.Value == record["ProductName"]) ? "" : (string)record["ProductName"];
            }
            catch (Exception e)
            {
                throw e;
            }

            return prod;
        }
    }
}

