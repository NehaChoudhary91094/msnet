using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m1 = new Maths();
            int result1 = m1.Add(10, 20);
            int result2 = m1.Add(10, 20, 30);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    public class Maths
    {
        public int Add(int x , int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
