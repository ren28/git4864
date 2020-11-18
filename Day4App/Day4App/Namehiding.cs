using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class A1
    {
        public int i = 0;

        public void Method1(String s)
        {
            Console.WriteLine("Message from Base class{0}", s);

        }
    }

    class B1:A1
    {
        new int i; //hiding the member from the base class

        public B1(int a, int b)
        {
            base.i = a;
            i = b;

        }

        public void Method1(string str)
        {

            Console.WriteLine("i from A1 {0}", base.i);
            Console.WriteLine("i from B1 {0}", i);
        }
    }
    class Namehiding
    {
        static void Main()
        {
            B1 obj = new B1(5, 15);
            obj.Method1("Hello i am hidig details from ");
            Console.Read();
        }
    }
}
