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
            //List_Demo();
            //List_Demo_2();
            //ArrayList_Demo();
            Dictionary_Demo();

            Console.ReadKey();
        }

        private static void Dictionary_Demo()
        {
            var colors = new List<string>() { "violet", "indigo", "blue", "green", "yellow", "orange", "red" };
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();


            int idx = 0;
            foreach (var color in colors)
            {
                myDictionary.Add(color, idx);
                idx++;
            }

            myDictionary.Add("violet", 999);

            if (myDictionary.ContainsKey("blue"))
            {
                Console.WriteLine("Key = {0}; Val = {1}", "blue", myDictionary["blue"]);
            }
        }

        private static void List_Demo_2()
        {
            List<int> numbers = new List<int>() { 10, 46, 13, 37, 28, 21, 88, 100 };

            // Write code to remove odd numbers from the above number list

            List<int> oddList = new List<int>();
            oddList.AddRange(numbers);
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                    oddList.Remove(num);
            }

            ;
        }

        private static void List_Demo()
        {
            List<string> colors = new List<string>() {"violet", "indigo", "blue", "green", "yellow", "orange", "red" };

            colors.AddRange(new List<string>() {"black", "white" });


            if (colors.Contains("red"))
                Console.WriteLine("red is present");

            Console.WriteLine("Element at idx 4 = {0}", colors.ElementAt(4));

            colors.Find(x => x == "violet");

            foreach (string color in colors)
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
