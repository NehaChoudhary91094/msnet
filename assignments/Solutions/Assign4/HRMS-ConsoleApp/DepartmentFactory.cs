using HRMSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_ConsoleApp
{
    class DepartmentFactory
    {
        static public Department CreateObject()
        {
            Department ObjSelector = null;

            Console.Write("Enter Dept No: ");
            int deptno = int.Parse(Console.ReadLine());

            Console.Write("Enter Dept Name: ");
            string deptName = Console.ReadLine();

            Console.Write("Enter Location: ");
            string location = Console.ReadLine();
            ObjSelector = new Department(deptno, deptName, location);
            return ObjSelector;
        }
    }
}
