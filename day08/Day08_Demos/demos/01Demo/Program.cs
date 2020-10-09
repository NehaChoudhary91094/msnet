using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            A obj1 = new Maths();
            Console.WriteLine(obj1.Add(10, 20));

            B obj2 = new Maths();
            Console.WriteLine(obj2.Add(10, 20));


            // A obj = new Maths();
            //int result = obj.Add(10, 20);
            //Console.WriteLine(result);
        }
    }


 

    //Client 1
    public interface A
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }

    //Client2
    public interface B
    {
        int Add(int x, int y);
        int Mult(int x, int y);
    }

    public class SomeBase
    {

    }

    public class Maths : SomeBase, A, B
    {
        int A.Add(int x, int y)
        {
            return x + y + 100;
        }

        int B.Add(int x, int y)
        {
            return x + y;
        }

        int B.Mult(int x, int y)
        {
            return x * y;
        }

        int A.Sub(int x, int y)
        {
            return x - y;
        }

        public int div(int x, int y)
        {
            return x / y;
        }
    }















    public interface Database
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class SQLServer:Database
    {
        public void Insert()
        {
            Console.WriteLine("SQL Server Data Inserted");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server Data Updated");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Data Deleted");
        }
    }

    public class Oracle: Database
    {
        public void Insert()
        {
            Console.WriteLine("Oracle Data Inserted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Data Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Data Deleted");
        }
    }
}
