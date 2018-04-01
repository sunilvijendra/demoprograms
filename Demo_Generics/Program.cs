using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Database
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }


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


            GenericClass<Student> studentClass = new GenericClass<Student>();
            studentClass.SetSomeVar(new Student(1, "Sunil"));
            Console.WriteLine("student id = {0}, name = {1}", studentClass.GetSomevar().id, studentClass.GetSomevar().name);
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

