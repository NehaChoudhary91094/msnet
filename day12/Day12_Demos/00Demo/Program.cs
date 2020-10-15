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
            #region Partial Method Demo
            //Emp emp = new Emp();
            //emp.Age = 9;
            #endregion

            #region Dynamic Type
            //Factory factory = new Factory();
            //Console.WriteLine("Enter choice as number:");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //dynamic obj = factory.GetMeSomeTypeObject(choice);
            //Console.WriteLine(obj.GetDetails());

            //object obj = factory.GetMeSomeTypeObject(choice);

            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    Console.WriteLine(e.GetDetails());
            //}
            //else if (obj is Book)
            //{
            //    Book b = (Book)obj;
            //    Console.WriteLine(b.GetBookDetails());
            //}


            #endregion

            #region Optional & Named Parameters
            //Player player1 = new Player();
            //string details = player1.GetDetails(10, "Sachin", "Mumbai");

            //string details = player1.GetDetails(10, "Sachin");
            //string details = player1.GetDetails(10);

            //string details = player1.GetDetails(10, address: "Kolkata");

            //string details = player1.GetDetails(10, address: "Kolkata", name: "Sourav");
            //Console.WriteLine(details);
            #endregion
        }
    }

    public class Player
    {
        public string GetDetails(int no, string name = "ABCD", string address="Pune")
        {
            return string.Format("Details are: No is {0}. Your name is {1} and Address is {2}", no, name, address);

        }

        //public string GetDetails(int no, string name, string address)
        //{
        //   return  string.Format("Details are: No is {0}. Your name is {1} and Address is {2}", no, name, address);

        //}
    }
    public class Book
    {
        public string GetBookDetails()
        {
            return "Some book Details...";
        }
    }

    public class Factory
    {
        public object GetMeSomeTypeObject(int choice)
        {
            if (choice == 1)
            {
                return new Emp();
            }
            else
            {
                return new Book();
            }
        }
    }
}
