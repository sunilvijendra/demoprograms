using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Statements
{
    public class ExampleA
    {
        private int i = 10;
        private protected int j = 20;
    }

    public class ExampleB : ExampleA
    {
        public int GetValueI()
        {
            return this.j;
        }
    }

    public class ExampleC : ExampleB
    {
        public int GetValueI()
        {
            return this.j;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExampleC ec = new ExampleC();
            Console.WriteLine("j = {0}", ec.GetValueI());
            Console.ReadKey();
        }
    }
}
