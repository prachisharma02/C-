using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class ExecuteScaler
    {
        public static void Connection6()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn6 = null;
            try
            {
                using (conn6 = new SqlConnection(cs))
                {
                    string query1 = "select  max(empid) from employee";
                    SqlCommand cmd = new SqlCommand(query1, conn6);            
                    conn6.Open();
                    object result = cmd.ExecuteScalar(); // as if we were taking int value was not showing up
                    Console.WriteLine(result);
                  


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
