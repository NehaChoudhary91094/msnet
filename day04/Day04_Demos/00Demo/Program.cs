using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second;
using Second.Third;
namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            Console.WriteLine(m.Add(10, 20));

            Test t = new Test();
            Console.WriteLine(t.Sample());

            DB dbObj = new DB();

            dbObj.Insert();
        }
    }
}

namespace Second
{
    public class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is MAIN method in Maths class");
        }
    }


    public class Test
    {
        public string Sample()
        {
            return "This is Test";
        }
    }

    namespace Third
    {
        public class DB
        {

            static void Main(string[] args)
            {
                Console.WriteLine("This is MAIN method in DB class");
            }
            public void Insert()
            {
                Console.WriteLine("Data Inserted Successfully");
            }
        }
    }
}
