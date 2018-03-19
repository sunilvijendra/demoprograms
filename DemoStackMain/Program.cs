
using DemoStackLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStackMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            try
            {
                Console.WriteLine("Pop = {0}", s.Pop());
                s.Push(10);
                s.Push(100);
                s.Push(999);
                Console.WriteLine("Pop = {0}", s.Pop());
                Console.WriteLine("Pop = {0}", s.Pop());
                Console.WriteLine("TOS = {0}", s.TOS());
                Console.WriteLine("Pop = {0}", s.Pop());
            }
            catch (MyOverflowException e)
            {
                Console.WriteLine("MyOverflowException - Msg = {0}", e.Message);
            }
            catch (MyUnderflowException e)
            {
                Console.WriteLine("MyUnderflowException - Msg = {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
