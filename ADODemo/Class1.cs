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
    internal class Class1
    {
        public static void Connection2()
        {

            SqlConnection conn = null;
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            try
            {
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
        public static void Connection1()
        {
            string cs = "Data Source=LAPTOP-ERN1FTED; Initial Catalog=StudDb; Integrated security=true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
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
