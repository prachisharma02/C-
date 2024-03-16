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
    internal class ExecuteReader
    {
        public static void Connection3()
        {
            SqlConnection conn = null;
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            try
            {
                using(conn=new SqlConnection(cs))
                {
                    string query = "select * from Employee ";
                        //first way to execute a query by using 1st constructor
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                    //Second way to eecute by using second constructor
                    //SqlCommand cmd = new SqlCommand(query,conn3);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("id :" + dr["empid"] + "  " + "Department Name: " + dr["dept"] + " " + "Salary: " + dr["sal"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
