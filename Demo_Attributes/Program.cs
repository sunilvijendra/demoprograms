using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Attributes
{
    class BasicAttributeDemo
    {
        [Obsolete]
        public void MyFirstdeprecatedMethod()
        {
            Console.WriteLine("Called MyFirstdeprecatedMethod().");
        }

        [ObsoleteAttribute]
        public void MySecondDeprecatedMethod()
        {
            Console.WriteLine("Called MySecondDeprecatedMethod().");
        }

        [Obsolete("You shouldn't use this method anymore.")]
        public void MyThirdDeprecatedMethod()
        {
            Console.WriteLine("Called MyThirdDeprecatedMethod().");
        }

        // make the program thread safe for COM
        [STAThread]
        static void Main(string[] args)
        {
            BasicAttributeDemo attrDemo = new BasicAttributeDemo();

            attrDemo.MyFirstdeprecatedMethod();
            attrDemo.MySecondDeprecatedMethod();
            attrDemo.MyThirdDeprecatedMethod();

            Demo.DemoMethod();
            Console.ReadKey();
        }
    }

    class AttributeParamsDemo
    {
        [DllImport("User32.dll", EntryPoint = "MessageBox")]
        static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);

        [STAThread]
        static void Main1(string[] args)
        {
            MessageDialog(0, "MessageDialog Called!", "DllImport Demo", 0);
        }
    }



}
