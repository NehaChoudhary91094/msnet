using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    delegate int mydelegate(int p, int q);
    delegate void yourdelegate(string s);

    class Program
    {
        static void Main(string[] args)
        {
            

            mydelegate pointer = new mydelegate(Sub);
            int result = pointer(10, 20);
            //int result = Add(10, 20);

            Console.WriteLine("Result is " + result.ToString());


            yourdelegate pointer2 = new yourdelegate(SayHi);
            pointer2("mahesh");
        }

        public static void SomeFunction()
        {
            //unsafe
            //{
            //    int* ptr;
            //}
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x -  y;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
