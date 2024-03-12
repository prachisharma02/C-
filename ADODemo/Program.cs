using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; // for configurationmanager
namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection1();
            //Class1.Connection2();
            //Class1.Connection1();
            Console.ReadLine();
        }

        static void Connection1()
        {

            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn = null;

            try
            {
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();


                    if (conn.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection created Successfully");
                    }
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
