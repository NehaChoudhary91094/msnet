using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace _03Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fetch Data Using Disconnected Architecture
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SunbeamDB;Integrated Security=True");

            SqlDataAdapter da = new SqlDataAdapter("select * from Emp", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            da.Fill(ds, "abc");
            #endregion

            #region Insert using Disconnected Architecture
            ////Insert a New Row
            //DataRow completeNewRow = ds.Tables["abc"].NewRow();
            //completeNewRow["No"] = 10;
            //completeNewRow["Name"] = "Akshay";
            //completeNewRow["Address"] = "Pune";
            //ds.Tables[0].Rows.Add(completeNewRow);
            //da.Update(ds, "abc");
            #endregion

            #region Update using Disconnected Architecture
            //Console.WriteLine("Enter a No os a Emp whose record you wish to find:");
            //int no = Convert.ToInt32(Console.ReadLine());

            //DataRow refToTheRowToBeModified = ds.Tables[0].Rows.Find(no);

            //if (refToTheRowToBeModified !=null)
            //{
            //    Console.WriteLine("Record Found");

            //    Console.WriteLine("Current Name: " + refToTheRowToBeModified["Name"].ToString());
            //    Console.WriteLine("Current Address: " + refToTheRowToBeModified["Address"].ToString());
            //    Console.WriteLine("--------------------------------------------------------");

            //    Console.WriteLine("Please Enter New Name");
            //    refToTheRowToBeModified["Name"] = Console.ReadLine();

            //    Console.WriteLine("Please Enter New Address");
            //    refToTheRowToBeModified["Address"] = Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Sorry! No record Found");
            //}

            //da.Update(ds,"abc"); 
            #endregion

            #region Delete Using Disconencted Architecture
            //Console.WriteLine("Enter a No of a Emp whose record you wish to Delete:");

            //int no = Convert.ToInt32(Console.ReadLine());

            //DataRow refToTheRowToBeDeleted = ds.Tables[0].Rows.Find(no);

            //if (refToTheRowToBeDeleted != null)
            //{
            //    Console.WriteLine("Record Found .. Deleting the same..");
            //    refToTheRowToBeDeleted.Delete();
            //}
            //else
            //{
            //    Console.WriteLine("Sorry! No record Found");
            //}

            //da.Update(ds, "abc");
            #endregion
        }
    }
}
