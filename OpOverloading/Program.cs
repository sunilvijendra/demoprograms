using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex1 = new Example("Hello,", 10);
            Example ex2 = new Example("World", 5);

            Example ex3 = ex1 + ex2;
        }
    }

    public class Example
    {
        public string str;
        public int val;

        public Example() { }

        public Example(string str, int val)
        {
            this.str = str;
            this.val = val;
        }

        public static Example operator +(Example a, Example b)
        {
            Example e = new Example();

            e.str = a.str + b.str;
            e.val = a.val + b.val;

            return e;
        }
    }
}
