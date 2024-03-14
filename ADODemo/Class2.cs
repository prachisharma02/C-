using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Class2
    {
        public static void Connection2()
        {

            SqlConnection conn = null;
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            // we have taken here cs from app.config file
            try
            {
                // then we have used using statement to automatically close the connection
                using (conn = new SqlConnection(cs))
                    conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection created Successfully");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();  // Ensure connection is closed even on exceptions
            }


        }
    }
}
