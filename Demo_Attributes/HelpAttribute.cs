using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class CheckAttribute : Attribute
    {
        public int MaxLength { get; set; }
    }

    //[Check(MaxLength = 20)]
    class Customer
    {
        [Check(MaxLength = 10)]
        public string CustomerName { get; set; }

        public void Add()
        {
        }
    }

    public class Demo
    {
        public static void DemoMethod()
        {
            Customer obj = new Customer();
            obj.CustomerName = "0123456789000";

            // loop using reflection and read the attribute
            Type t = obj.GetType();

            foreach (PropertyInfo p in t.GetProperties())
            {
                if (p.Name == "CustomerName")
                {
                    CheckAttribute c = (CheckAttribute) p.GetCustomAttribute(typeof(CheckAttribute));
                    if (obj.CustomerName.Length > c.MaxLength )
                    {
                        throw new Exception("Not allowed");
                    }
                }

                    
            }
        }
    }
}
