using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace Demo_Database.DataAccess
{
    abstract class ObjectReaderWithConnection<T> : ObjectReaderBase<T>
    {
        private static string m_connectionString = @"Data Source=C:\Users\sunilvijendra\Documents\rockwell_csharp\DemoPrograms\Demo_Database\testDB.db;Version=3;";

        protected override System.Data.IDbConnection GetConnection()
        {
            // update to get your connection here

            IDbConnection connection = new SQLiteConnection(m_connectionString);
            return connection;
        }
    }
}