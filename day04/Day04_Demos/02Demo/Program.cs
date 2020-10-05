using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Demo
{
    class Program
    {
        //Developer 4
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Report Type Needed:");
            Console.WriteLine("1: PDF, 2: Word, 3: Excel");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PDF obj = new PDF();
                   
                    obj.Generate();
                    break;
                case 2:
                    Word obj1 = new Word();
                    obj1.Generate();
                    break;
                case 3:
                    Excel obj2 = new Excel();
                    obj2.Generate();
                    break;
                case 4:
                    TXT obj3 = new  TXT();
                    obj3.Generate();
                     break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadLine();

        }

    }

    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        
        public virtual void Generate()
        {
            Parse();
            Validate();
            Save();
        }
    }


    //Developer 1
    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF parsing is Done");
        }

        protected override void Validate()
        {
            Console.WriteLine("PDF Validation is Done");
        }

        protected override void Save()
        {
            Console.WriteLine("PDF Saving is Done");
        }
    }

    //Developer 2
    public class Excel: Report
    {

        protected override void Parse()
        {
            Console.WriteLine("Excel parsing is Done");
        }

        protected override void Validate()
        {
            Console.WriteLine("Excel Validation is Done");
        }

        protected override void Save()
        {
            Console.WriteLine("Excel Saving is Done");
        }

    }

    //Developer 3
    public class Word: Report
    {

        protected override void Parse()
        {
            Console.WriteLine("WORD parsing is Done");
        }

        protected override void Validate()
        {
            Console.WriteLine("WORD Validation is Done");
        }

        protected override void Save()
        {
            Console.WriteLine("WORD Saving is Done");
        }
    }

    //Developer 4
    public class TXT : Report
    {
    
        protected override void Parse()
        {
            Console.WriteLine("TXT Parse Done");
        }

        protected override void Save()
        {
            Console.WriteLine("TXT SAVE Done");
        }

        protected override void Validate()
        {
            Console.WriteLine("TXT VALIDATE Done");
        }

        private void ReValidate()
        {
            Console.WriteLine("TXT ReValidate Done");
        }

        public override void Generate()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }
}
