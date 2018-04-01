using HelloFSharpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine("Hello, {0}! Today's date is {1}", input, 12);

            //IControl control = new EditBox();

            //INewControl newcontrol = new EditBox();

            //EditBox e = new EditBox();

            //IDataBound db = e;

            Say.hello("Fsharp");

            Console.ReadKey();
        }
    }

    interface IControl
    {
        void Paint();
    }

    interface IDataBound
    {
        void Bind();
    }

    interface INewControl : IControl
    {
        void FillColor();
    }

    class EditBoxBasic
    {
        public void Paint()
        {
            throw new NotImplementedException();
        }
    }

    class EditBox : INewControl, IDataBound
    {
        public void Bind()
        {
            throw new NotImplementedException();
        }

        public void FillColor()
        {
            throw new NotImplementedException();
        }

        public void Paint()
        {
            throw new NotImplementedException();
        }

    }
}
