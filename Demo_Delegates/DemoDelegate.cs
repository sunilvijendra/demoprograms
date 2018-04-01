using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegates
{
    public class DemoDelegate
    {
        public delegate void DelegateType(int x);
        public DelegateType handler = null;

        public void MyMethod(string str, int handlerType)
        {
            if (handler != null)
                handler(handlerType);
        }

        
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            DemoDelegate demo = new DemoDelegate();

            demo.handler = Handler1;
            demo.handler += Handler2;
            demo.handler -= Handler1;

            demo.MyMethod("", 2);

            //demo.handler = Handler2;
            //demo.MyMethod("", 99);

            Console.ReadKey();

        }

        public static void Handler1(int a)
        {
            Console.WriteLine("Handler1; a = {0}", a);
        }
        public static void Handler2(int a)
        {
            Console.WriteLine("Handler2; a = {0}", a);
        }
    }
}
