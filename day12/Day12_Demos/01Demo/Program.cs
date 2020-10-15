using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Select Query
            //SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB; database=SunbeamDB; Integrated Security = true");

            //con.Open();

            //SqlCommand cmd = new SqlCommand("select * from Emp", con);

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    string dataForPrinting = 
            //        string.Format("{0} ---- {1} --- {2}", 
            //                            reader["No"], 
            //                            reader["Name"], 
            //                            reader["Address"]);
            //    Console.WriteLine(dataForPrinting);
            //}

            //con.Close(); 
            #endregion

            #region Insert Query
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SunbeamDB;Integrated Security=True");

                con.Open();

                Console.WriteLine("Enter No");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Address");
                string address = Console.ReadLine();

                string queryTemplate = "insert into Emp values({0}, '{1}', '{2}')";
                string finalInsertQuery = string.Format(queryTemplate, no, name, address);

                cmd = new SqlCommand(finalInsertQuery, con);

                int noofRowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine("No of Rows Affected = " + noofRowsAffected.ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is not right here . try again!! ");
                Console.WriteLine("Technical Details: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            Console.ReadLine();
            #endregion
        }
    }
}
