using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Demo.POCO;
using _01Demo.DAL;
namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory dbFactory = new DBFactory();
            IDatabase db = dbFactory.GetDatabase();

            Console.WriteLine("1: Select; 2: Insert, 3: Update, 4: Delete");
            int opChoice = Convert.ToInt32(Console.ReadLine());

            switch (opChoice)
            {
                case 1:
                    var data = db.Select();
                    foreach (var item in data)
                    {
                        Console.WriteLine(item.Name + " | " + item.Address);
                    }
                    break;
                case 2:
                    Emp emp = new Emp();
                    
                    Console.WriteLine("Enter No");
                    emp.No = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Enter Name");
                    emp.Name = Console.ReadLine();

                    Console.WriteLine("Enter Address");
                    emp.Address = Console.ReadLine();

                    int rowsAffected = db.Insert(emp);
                    Console.WriteLine("Rows Inserted = " + rowsAffected.ToString());

                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
