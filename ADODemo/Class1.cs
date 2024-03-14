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
    internal class Connectioncls
    {
        public static void Connection1()
        {
            string cs = "Data Source=LAPTOP-ERN1FTED; Initial Catalog=StudDb; Integrated security=true;";
            SqlConnection conn1 = new SqlConnection(cs);
            try
            {
                conn1.Open();
                if (conn1.State == ConnectionState.Open)
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
                conn1.Close();  // Ensure connection is closed even on exceptions
            }
        }
    }
}
