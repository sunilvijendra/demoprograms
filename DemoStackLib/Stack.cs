using System;
using System.Runtime.InteropServices;

namespace DemoStackLib
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IStack
    {
        void Push(int data);
        int Pop();
        int TOS();
    }

    [ClassInterface(ClassInterfaceType.None)]
    public class Stack : IStack
    {
        private const int MAX_SIZE = 100;
        private int[] data;
        private int tos = -1;

        public Stack()
        {
            data = new int[MAX_SIZE];
            tos = -1;
        }

        public void Push(int i)
        {
            if (tos == MAX_SIZE-1)
            {
                Console.WriteLine("Stack overflow");
                throw new MyOverflowException();
            }
            tos++;
            data[tos] = i;
        }

        public int Pop()
        {
            if (tos == -1)
            {
                Console.WriteLine("Stack underflow");
                throw new MyUnderflowException();
            }
            return data[tos--];
        }


        public int TOS()
        {
            if (tos == -1)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            return data[tos];
        }
    }
}
