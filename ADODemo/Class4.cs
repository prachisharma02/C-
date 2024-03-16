using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Storedproc
    {
        public static void Connection4()
        {

            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn4 = null;
            try
            {
                using (conn4 = new SqlConnection(cs))
                {
                    string query = "spemp";

                    //first way to execute a query by using 1st constructor
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = conn4;
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Second way to eecute by using second constructor
                    //SqlCommand cmd = new SqlCommand(query,conn3);

                    conn4.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("id :" + dr["empid"] + "  " + "Department Name: " + dr["dept"] + " " + "Salary: " + dr["sal"]);//concatenation syntax
                        Console.WriteLine("id : {0} Department Name: {1} Salary : {2}", dr["empid"], dr["dept"], dr["sal"]);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
