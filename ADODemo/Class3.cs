using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Class3
    {
        public static void Connection3()
        {
            
                string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn3 = null;
            try
            {
                using (conn3=new SqlConnection(cs))
                {
                    string query = "select * from Employee ";
                    SqlCommand cmd = new SqlCommand(query,conn3);
                    conn3.Open();
                   SqlDataReader dr= cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("id :" + dr["empid"] +"  "+"Department Name: "+ dr["dept"] +" "+"Salary: " + dr["sal"]);
                    }
               
                }

            }
            catch (Exception e) {
                Console.WriteLine(e);
        }
        }
    }
}
