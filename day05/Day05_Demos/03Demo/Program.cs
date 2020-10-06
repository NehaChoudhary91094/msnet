using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object s = 100;
                s = "abcd";
                s = 10.2;
                s = new Emp();

                Logger.CurrentLogger.Log("Main is getting called...");

                Emp e1 = new Emp();
                e1.GetDetails();

                Maths m = new Maths();
                Console.WriteLine("Enter X");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Y");
                int y = Convert.ToInt32(Console.ReadLine());

                m.Add(x, y);
                
            }
            catch (Exception ex)
            {
                Logger.CurrentLogger.Log("Main Failed!! Details:  " + ex.Message);
            }
        }
    }

    public class Emp
    {
        public void GetDetails()
        {
            Logger.CurrentLogger.Log("Emp GetDeails is getting called...");
        }
    }

    public class Maths
    {
        public int Add(int x , int y)
        {
            Logger.CurrentLogger.Log("Add called with x = " + x.ToString() + " and y = " + y.ToString());
            return x + y;
        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger();
        private Logger()
        {
            Console.WriteLine("Logger Object Created...");
        }

        public static Logger CurrentLogger
        {
            get 
            {
                return _logger; 
            } 
        }

        public void Log(string msg)
        {
            Console.WriteLine("Logged : " 
                                + msg 
                                + " @ " 
                                + DateTime.Now.ToString());
        }
    }
}
