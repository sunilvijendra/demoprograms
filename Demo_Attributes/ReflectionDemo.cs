using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Attributes
{
    class ReflectionDemo
    {
        void Run()
        {

        }

        void RunNow()
        {

        }
    }

    class Program
    {
        public static void Main111(string[] args)
        {
           ReflectionDemo rf = new ReflectionDemo();

            //rf.
            //Type t = rf.GetType();


            Assembly a = Assembly.LoadFile(@"C:\Users\sunilvijendra\Documents\GitHub\demoprograms\DemoStackLib\bin\Debug\DemoStackLib.dll");

            var obj = a.CreateInstance("DemoStackLib.Stack", true);

            Type t1 = obj.GetType();
            MethodInfo method = t1.GetRuntimeMethod("Push1", new Type[] { typeof(int) });
            method.Invoke(obj, new object[] { 5 });

            foreach (Type t in a.GetTypes())
            {
                Console.WriteLine("Type = {0}", t.Name);

            }
            ;
        }
    }
}
