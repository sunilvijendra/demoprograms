using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;

            Console.WriteLine("Name = {0}; Priority = {1}; State = {2}", th.Name, th.Priority, th.ThreadState);

            // CreateNewThreads();
            //UseThreadPool();
            UseTasks();
            Console.ReadKey();
        }

        static void CreateNewThreads()
        {
            Thread child = new Thread(new ThreadStart(ChildMethod));
            child.Start();
            Thread.Sleep(500);
            Console.WriteLine("CreateNewThreads: after creating child thread");
        }

        public static void ChildMethod()
        {
            Console.WriteLine("In ChildMethod");
        }

        public static void ChildMethod (object state)
        {
            Console.WriteLine("In ChildMethod(state)");

        }
        static void UseThreadPool()
        {
            Console.WriteLine("UseThreadPool: main thread");
 
            ThreadPool.QueueUserWorkItem(ChildMethod);

            Thread.Sleep(1000);
            Console.WriteLine("CreateNewThreads: after queuing to pool");

        }

        static void UseTasks()
        {
            Console.WriteLine("UseTasks: main thread");

            Task t = new Task(ChildMethod, null);
            t.Start();

            Thread.Sleep(1000);
            Console.WriteLine("UseTasks: after creating task");
        }
    }
}
