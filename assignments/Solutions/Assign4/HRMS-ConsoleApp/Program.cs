using HRMSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "Log" + DateTime.Now.ToString() + ".csv";
            Console.WriteLine(filename);
            //TestClasses();

         //  Person emp1 = EmployeeFactory.CreateObject(1);
           //Console.WriteLine(emp1.ToString());

            Employee sp = new Salesperson();
            sp.Salary = 2;
            Console.WriteLine(sp.NetSalary);
            Console.WriteLine(sp.ToString());

            Employee labour = new WageEmp();
            labour.Salary = 2;
            Console.WriteLine(labour.NetSalary);
            Console.WriteLine(labour.ToString());
            Console.ReadLine();
        }

        static void TestClasses()
        {
            Department dept = new Department();
            Console.WriteLine(dept.ToString());

            //Person p1 = new Person();
            //Console.WriteLine(p1.ToString());

            Person p2 = new Employee();
            Console.WriteLine(p2.ToString());

            Person p3 = new Salesperson();
            Console.WriteLine(p3.ToString());

            Person p4 = new WageEmp();
            
            Console.WriteLine(p4.ToString());

        }
    }

}
