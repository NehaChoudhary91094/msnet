using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //First Program

            int result = Add();

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add()
        {
            Console.WriteLine("Please Enter First Value");
            string s1 = Console.ReadLine();

            Console.WriteLine("Please Enter Second Value");
            string s2 = Console.ReadLine();

            int x = Convert.ToInt32(s1);
            int y = Convert.ToInt32(s2);

            int result = x + y;
            return result;
        }
    }
}
