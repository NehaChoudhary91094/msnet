using HRMSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_ConsoleApp
{
    class EmployeeFactory
    {
        static public Person CreateObject(int cChoice)
        {
            Person ObjSelector = null;
            
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter email-id: ");
            string emailId = Console.ReadLine();

            Console.Write("Enter gender: ");
            bool gender = Console.ReadLine().ToLower().StartsWith("f");

            Console.Write("Enter Date (dd/MM/yyyy) : ");
            string[] dateparts = Console.ReadLine().Split('/');
            int year = 0;
            int.TryParse(dateparts[2], out year);
            Date date = new Date(Convert.ToInt32(dateparts[0]), int.Parse(dateparts[1]), year);

            string designation;  EmployeeTypes employeeType=0; double salary=0; double commision=0;  int hours=0; int rate=0;
            string passcode="";  int deptNo=0; Date hireDate=null; 
            //if (cChoice == 1)
            //{
            //    ObjSelector = new Person(name, gender, address, date, emailId);
            //}
            if (cChoice > 1)
            {
                Console.Write("Select Employee Type 1. Trainee, 2. Permanent, 3. Temporary: ");
                employeeType = (EmployeeTypes)int.Parse(Console.ReadLine());

                Console.Write("Enter Passcode: ");
                passcode= Console.ReadLine();

                Console.Write("Enter DeptNo: ");
                deptNo= int.Parse(Console.ReadLine());

                Console.Write("Enter Hire Date (dd/MM/yyyy) : ");
                dateparts = Console.ReadLine().Split('/');
                year = 0;
                int.TryParse(dateparts[2], out year);
                hireDate= new Date(Convert.ToInt32(dateparts[0]), int.Parse(dateparts[1]), year);

            }
            if (cChoice == 2 )
            {
                Console.Write("Enter Designation: ");
                designation = Console.ReadLine();

                Console.Write("Enter Salary: ");
                salary = double.Parse(Console.ReadLine());
                ObjSelector = new Employee(passcode, deptNo, hireDate, salary, designation, employeeType, name, gender, address, date, emailId);
            }
            if (cChoice==3)
            {
                Console.Write("Enter Salary: ");
                salary = double.Parse(Console.ReadLine());

                Console.Write("Enter Commision: ");
                commision = double.Parse(Console.ReadLine());

                ObjSelector = new Salesperson(commision, passcode, deptNo, hireDate, salary, employeeType, name, gender, address, date,emailId);
            }
            if (cChoice == 4)
            {
                Console.Write("Enter Hours: ");
                hours = int.Parse(Console.ReadLine());

                Console.Write("Enter Rate: ");
                rate = int.Parse(Console.ReadLine());

                ObjSelector = new WageEmp(hours, rate, passcode, deptNo, hireDate, employeeType, name, gender, address, date,emailId);
            }
            return ObjSelector;

        }
    }
}
