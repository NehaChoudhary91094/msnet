using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:SQL Server, 2: Oracle");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1: Insert, 2: Update, 3: Delete");
            int opChoice = Convert.ToInt32(Console.ReadLine());

            ObjectFactory of = new ObjectFactory();
            Database db = of.GetMeSomeObject(choice);
            
            switch (opChoice)
            {
                case 1:
                    db.Insert();
                    break;
                case 2:
                    db.Update();
                    break;
                case 3:
                    db.Delete();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public class ObjectFactory
    {
        public Database GetMeSomeObject(int choice)
        {
            if (choice == 1)
            {
                return new SQLServer();
            }
            else
            {
                return new Oracle();
            }
        }
    }
    public abstract class Database
    {
        public abstract void Insert();

        public abstract void Update();

        public abstract void Delete();
    }

    public class SQLServer: Database
    {
        public void Test()
        {

        }
        public override void Insert()
        {
            Console.WriteLine("SQL Insert Is Done");
        }

        public override void Update()
        {
            Console.WriteLine("SQL Update Is Done");
        }

        public override void Delete()
        {
            Console.WriteLine("SQL Delete Is Done");
        }
    }

    public class Oracle: Database
    {
        public override void Insert()
        {
            Console.WriteLine("Oracle Insert Is Done");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle Update Is Done");
        }

        public override void Delete()
        {
            Console.WriteLine("Oracle Delete Is Done");
        }
    }
}
