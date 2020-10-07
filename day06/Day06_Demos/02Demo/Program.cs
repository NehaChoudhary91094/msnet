using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            while (true)
            {
                Console.WriteLine("1: Emp, 2: Book");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Emp emp = new Emp();

                    Console.WriteLine("Enter No");
                    emp.No = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter Name");
                    emp.Name = Console.ReadLine();

                    arr.Add(emp);
                }
                else
                {
                    Book book = new Book();

                    Console.WriteLine("Enter Title");
                    book.Title   = Console.ReadLine();

                    Console.WriteLine("Enter Author");
                    book.Author = Console.ReadLine();

                    arr.Add(book);
                }

                Console.WriteLine("Would you like to continue? yes / no");
                string continueorNot = Console.ReadLine();
                if (continueorNot != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("You entered below data");

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] is Emp)
                {
                    Emp emp = (Emp)arr[i];
                    Console.WriteLine(emp.getDetails());
                }
                else if (arr[i] is Book)
                {
                    Book b = (Book)arr[i];
                    Console.WriteLine(b.getBookDetails());
                }
            }
            Console.ReadLine();
        }
    }

    public class Emp
    {
        private int _No;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        public string getDetails()
        {
            return this.No.ToString() + this.Name;
        }

    }

    public class Book
    {
        private string _Author;
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public string getBookDetails()
        {
            return this.Title+ this.Author;
        }
    }
}
