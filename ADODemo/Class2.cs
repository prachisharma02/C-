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
    internal class ConfigUsing
    {
        public static void Connection2()
        {

            SqlConnection conn2 = null;
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            // we have taken here cs from app.config file
            try
            {
                // then we have used using statement to automatically close the connection
                using (conn2 = new SqlConnection(cs))
                    conn2.Open();
                Console.WriteLine("Connection created Successfully");
                if (conn2.State == ConnectionState.Open)
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
                conn2.Close();  // Ensure connection is closed even on exceptions
            }


        }
    }
}
