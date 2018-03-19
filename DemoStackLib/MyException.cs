using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStackLib
{
    public class MyOverflowException : Exception
    {
        public override string Message
        {
            get { return "Stack overflow Exception "; }
        }
    }

    public class MyUnderflowException : Exception
    {
        public override string Message
        {
            get { return "Stack underflow Exception "; }
        }
    }
}
