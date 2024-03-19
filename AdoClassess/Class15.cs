using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class Datasettable
    {
        public static void Connection()
        {
            try {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection conn = new SqlConnection(cs);
                string query1 = "select * from employee";
                string query2 = "select * from students";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1,conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2,conn);
                DataTable emp=new DataTable();
                DataTable stud = new DataTable();
                sda1.Fill(emp);
                sda2.Fill(stud);
                DataSet ds = new DataSet();
                ds.Tables.Add(emp);
                ds.Tables.Add (stud);

                ds.Tables[0].TableName = "Employee";
                ds.Tables[1].TableName = "students";
                foreach (DataRow data in ds.Tables[0].Rows)
                {
                    Console.WriteLine(data[0] + " " + data[1] + " " + data[2]);
                }

                foreach (DataRow data in ds.Tables[0].Rows)
                {
                    Console.WriteLine(data[0] + " " + data[1]);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
    
}
