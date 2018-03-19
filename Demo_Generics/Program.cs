using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> intClass = new GenericClass<int>();

            intClass.SetSomeVar(10);
            Console.WriteLine("intClass Var = {0}", intClass.GetSomevar());

            GenericClass<string> strClass = new GenericClass<string>();

            strClass.SetSomeVar("hello");
            Console.WriteLine("strClass Var = {0}", strClass.GetSomevar());

            Console.ReadKey();

        }
    }

    public class GenericClass<T>
    {
        private T _somevar;

        public  T GetSomevar()
        {
            return _somevar;
        }

        public void SetSomeVar(T var)
        {
            _somevar = var;
        }
    }
}

