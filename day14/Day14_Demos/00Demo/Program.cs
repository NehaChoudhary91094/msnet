using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SunbeamDBEntities dbObject = new SunbeamDBEntities();

            #region Select Using EF
            //var allEmps = dbObject.Emps.ToList();

            //foreach (var emp in allEmps)
            //{
            //    Console.WriteLine(emp.Name + " | "  + emp.Address);
            //}
            #endregion

            #region Insert Using EF
            //dbObject.Emps.Add(
            //    new Emp() { No = 99, Name = "Rutuja", Address = "Delhi" });

            //dbObject.SaveChanges();
            #endregion

            #region Update using EF
            //var empToBeModified = (from emp in dbObject.Emps.ToList()
            //                       where emp.No == 99
            //                       select emp).First();
            //empToBeModified.Name = "Shweta";
            //empToBeModified.Address = "Pune";

            //dbObject.SaveChanges();
            #endregion

            #region Delete using EF
            //var empToBeDeleted = (from emp in dbObject.Emps.ToList()
            //                       where emp.No == 99
            //                       select emp).First();

            //dbObject.Emps.Remove(empToBeDeleted);

            //dbObject.SaveChanges();
            //Console.WriteLine("Done");
            #endregion

            #region Stored Procedure CallUsing EF
            //dbObject.spInsert(99, "Ketan", "Karad");
            #endregion

            #region Calling Updated Customer mapping 
            //var customers = dbObject.Customers.ToList();
            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.CName);
            //}
            #endregion
        }
    }
}
