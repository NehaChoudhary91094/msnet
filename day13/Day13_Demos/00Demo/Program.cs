using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace _00Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Configuration Manager, SQL Injection
            //string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

            //SqlConnection con = new SqlConnection(constr);

            //Console.WriteLine("Enter Name");
            ////Mahesh'OR Name like '%
            //string cmdText = "select count(*) from Emp where Name = '" +  Console.ReadLine()  + "'";

            //SqlCommand cmd = new SqlCommand(cmdText, con);
            //con.Open();

            //object result = cmd.ExecuteScalar();
            //int count = Convert.ToInt32(result);
            //if (count > 0)
            //{
            //    Console.WriteLine("You are a valid user");
            //}
            //else
            //{
            //    Console.WriteLine("You are invalid user!");
            //}

            ////SqlDataReader reader = cmd.ExecuteReader();

            ////while (reader.Read())
            ////{
            ////    Console.WriteLine(string.Format("{0} | {1}", reader["Name"], reader["Address"]));
            ////}

            //con.Close();
            #endregion

            #region Call Procedure
            //SqlConnection con = null;
            //try
            //{
            //    string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

            //    con = new SqlConnection(constr);

            //    SqlCommand cmd = new SqlCommand("spInsert", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter parameter1 = new SqlParameter("@no", SqlDbType.Int);
            //    Console.WriteLine("Enter No");
            //    parameter1.Value = Convert.ToInt32(Console.ReadLine());


            //    SqlParameter parameter2 = new SqlParameter("@name", SqlDbType.VarChar, 50);
            //    Console.WriteLine("Enter Name");
            //    parameter2.Value = Console.ReadLine();


            //    SqlParameter parameter3 = new SqlParameter("@address", SqlDbType.VarChar, 50);
            //    Console.WriteLine("Enter Address");
            //    parameter3.Value = Console.ReadLine();

            //    cmd.Parameters.Add(parameter1);
            //    cmd.Parameters.Add(parameter2);
            //    cmd.Parameters.Add(parameter3);

            //    con.Open();

            //    cmd.ExecuteNonQuery();

               
            //    Console.WriteLine("Record Inserted using Stored Procedure...");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Record Insertion Failed using Stored Procedure...");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
            #endregion
        }
    }
}
