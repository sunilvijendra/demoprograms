using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List_Demo();
            //List_Demo_2();
            //ArrayList_Demo();
            //Dictionary_Demo();

            Console.ReadKey();
        }

        private static void Dictionary_Demo()
        {
            var colors = new List<string>() { "violet", "indigo", "blue", "green", "yellow", "orange", "red" };
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            int idx = 0;
            foreach (var color in colors)
            {
                myDictionary.Add(idx, color);
                idx++;
            }

            if (myDictionary.ContainsKey(5))
            {
                Console.WriteLine("Key = {0}; Val = {1}", 5, myDictionary[5]);
            }
        }

        private static void List_Demo_2()
        {
            var numbers = new List<int>() { 10, 46, 13, 37, 28, 21, 88, 100 };

            // Write code to remove odd numbers from the above number list
        }

        private static void List_Demo()
        {
            List<string> colors = new List<string>() {"violet", "indigo", "blue", "green", "yellow", "orange", "red" };

            colors.AddRange(new List<string>() {"black", "white" });


            if (colors.Contains("red"))
                Console.WriteLine("red is present");

            Console.WriteLine("Element at idx 4 = {0}", colors.ElementAt(4));

            foreach (var color in colors)
            {
                Console.WriteLine("Color = {0}", color);
            }
        }

        private static void ArrayList_Demo()
        {
            ArrayList arr = new ArrayList();

            // Add at the end of list
            arr.Add(10);
            arr.Add("Hello");
            arr.Add(3.5);
            arr.Add(10);
            arr.Add("Hi");
            arr.Add('c');

            arr.Remove(10);

            arr.RemoveAt(0);

            arr.Add("this is an element in ArrayList");
            arr.Add(10);

            arr.RemoveRange(0, 2);

            if (arr.Contains("Hi"))
            {
                arr.Insert(arr.IndexOf("Hi") + 1, "Halo!");
            }

        }
    }
}
