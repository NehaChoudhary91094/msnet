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

            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1: PDF, 2: Word, 3: Excel");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PDF obj = new PDF();
                    obj.Parse();
                    obj.Validate();
                    obj.Save();
                    break;
                case 2:
                    Word obj1 = new Word();
                    obj1.Parse();
                    obj1.Validate();
                    obj1.Save();
                    break;
                case 3:
                    Excel obj2 = new Excel();
                    obj2.Parse();
                    obj2.Validate();
                    obj2.Save();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadLine();

        }

    }

    public class PDF
    {
     
        public void Parse()
        {
            Console.WriteLine("PDF parsing is Done");
        }

        public void Validate()
        {
            Console.WriteLine("PDF Validation is Done");
        }

        public void Save()
        {
            Console.WriteLine("PDF Saving is Done");
        }

    }

    public class Excel
    {

        public void Parse()
        {
            Console.WriteLine("Excel parsing is Done");
        }

        public void Validate()
        {
            Console.WriteLine("Excel Validation is Done");
        }

        public void Save()
        {
            Console.WriteLine("Excel Saving is Done");
        }

    }

    public class Word
    {

        public void Parse()
        {
            Console.WriteLine("WORD parsing is Done");
        }

        public void Validate()
        {
            Console.WriteLine("WORD Validation is Done");
        }

        public void Save()
        {
            Console.WriteLine("WORD Saving is Done");
        }

    }

}
