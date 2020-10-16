using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Demo.POCO;
using System.Configuration;
using System.Data.SqlClient;
namespace _01Demo.DAL
{
   public class SQLServer: IDatabase
    {
        public List<Emp> Select()
        {
            List<Emp> allEmployees = new List<Emp>();

            string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from Emp", con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Emp emp = new Emp()
                {
                    No = Convert.ToInt32(reader["No"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                };

                allEmployees.Add(emp);
            }

            con.Close();
            return allEmployees;
        }

        public int Insert(Emp emp)
        {
            string constr = ConfigurationManager.ConnectionStrings["sqlconstring"].ToString();

            SqlConnection con = new SqlConnection(constr);

            string queryFormat = "insert into Emp values({0}, '{1}', '{2}')";
            string finalQuery = string.Format(queryFormat, emp.No, emp.Name, emp.Address);
            
            SqlCommand cmd = new SqlCommand(finalQuery, con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            return rowsAffected;
        }



        public int Update(Emp emp)
        {
            return 0;
        }

        public int Delete(Emp emp)
        {
            return 0;
        }
    }
}
