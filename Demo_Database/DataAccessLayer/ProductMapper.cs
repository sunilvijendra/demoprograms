using Demo_Database.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database.DataAccessLayer
{
    public class ProductMapper : MapperBase<Product>
    {
        protected override Product Map(IDataRecord record)
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
