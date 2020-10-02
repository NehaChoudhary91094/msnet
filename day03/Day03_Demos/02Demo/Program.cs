using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalciLib;

namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string iscontinue = "y";
            do
            {
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1: Add, 2: Sub, 3: Mult, 4: Div");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Value for X");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Value for Y");
                int y = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                Maths obj = new Maths();

                switch (choice)
                {
                    case 1:
                        result = obj.Add(x,y);
                        break;
                    case 2:
                        result = obj.Sub(x, y);
                        break;
                    case 3:
                        result = obj.Mult(x, y);
                        break;
                    case 4:
                        result = obj.Div(x, y);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice..Try Again!");
                        break;
                }

                Console.WriteLine(result);

                Console.WriteLine("Would you like to continue? y/n");
                iscontinue = Console.ReadLine();

            } while (iscontinue == "y");

            Console.ReadLine();
        }
    }

   
}
