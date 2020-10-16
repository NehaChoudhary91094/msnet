using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _02Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataTable Concept
            //DataTable table = new DataTable("myTable");

            //DataColumn column1 = new DataColumn("No", typeof(int));
            //DataColumn column2 = new DataColumn("Name", typeof(string));
            //DataColumn column3 = new DataColumn("Address", typeof(string));


            //table.Columns.Add(column1);
            //table.Columns.Add(column2);
            //table.Columns.Add(column3);

            //table.PrimaryKey = new DataColumn[] { column1 };

            //DataRow r1 = table.NewRow();
            //r1["No"] = 1;
            //r1["Name"] = "Mahesh";
            //r1["Address"] = "Pune";

            //DataRow r2 = table.NewRow();
            //r2["No"] = 2;
            //r2["Name"] = "Rahul";
            //r2["Address"] = "Karad";


            //DataRow r3 = table.NewRow();
            //r3["No"] = 3;
            //r3["Name"] = "Akash";
            //r3["Address"] = "Panji";

            //table.Rows.Add(r1);
            //table.Rows.Add(r2);
            //table.Rows.Add(r3); 
            #endregion

            DataSet ds = new DataSet();

            DataTable table = new DataTable("myTable");

            DataColumn column1 = new DataColumn("No", typeof(int));
            DataColumn column2 = new DataColumn("Name", typeof(string));
            DataColumn column3 = new DataColumn("Address", typeof(string));


            table.Columns.Add(column1);
            table.Columns.Add(column2);
            table.Columns.Add(column3);

            table.PrimaryKey = new DataColumn[] { column1 };

            //-------------------------------------------------------


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SunbeamDB;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from Emp", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DataRow r = table.NewRow();
                r["No"] = Convert.ToInt32(reader["No"]);
                r["Name"] = reader["Name"].ToString();
                r["Address"] = reader["Address"].ToString();

                table.Rows.Add(r);
            }

            con.Close();
//-----------------------------------------------------
            ds.Tables.Add(table);  //Table data is from SQL server
//-----------------------------------------------------

            DataRow completeNewRow = ds.Tables[0].NewRow();
            completeNewRow["No"] = 9;
            completeNewRow["Name"] = "Akshay";
            completeNewRow["Address"] = "Pune";

            ds.Tables[0].Rows.Add(completeNewRow);



            DataTable t2 = new DataTable("Book");
            DataColumn c1 = new DataColumn("ISBN", typeof(int));
            DataColumn c2 = new DataColumn("Title", typeof(string));

            t2.Columns.Add(c1);
            t2.Columns.Add(c2);

            DataRow r1 = t2.NewRow();
            r1["ISBN"] = 182345;
            r1["Title"] = "Let us C";

            t2.Rows.Add(r1);
//-----------------------------------------------------
            ds.Tables.Add(t2);//Table data is Hardcodes/can be from other DB
//-----------------------------------------------------

        }
    }
}
