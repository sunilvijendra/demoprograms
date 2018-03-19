using Demo_Database.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductReader reader = new ProductReader("select * from Product");

            Collection<Product> productList = reader.Execute();
            foreach (Product p in productList)
            {
                Console.WriteLine("id = {0}; name = {1}", p.id, p.name);
            }
            Console.ReadKey();

        }
    }
}

