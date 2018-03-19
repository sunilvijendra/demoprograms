using Demo_Database.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database.DataAccessLayer
{
    class ProductReader : ObjectReaderWithConnection<Product>
    {
        public ProductReader(string cmdTxt)
        {
            CommandText = cmdTxt;
        }

        protected override CommandType CommandType
        {
            get { return System.Data.CommandType.Text; }
        }

        protected override MapperBase<Product> GetMapper()
        {
            MapperBase<Product> mapper = new ProductMapper();
            return mapper;
        }

        protected override Collection<IDataParameter> GetParameters(IDbCommand command)
        {
            Collection<IDataParameter> collection = new Collection<IDataParameter>();
            return collection;

            //// USE THIS IF YOU ACTUALLY HAVE PARAMETERS
            //IDataParameter param1 = command.CreateParameter();
            //param1.ParameterName = "paramName 1"; // put parameter name here
            //param1.Value = 5; // put value here;

            //collection.Add(param1);

            //return collection;
        }
    }
}
