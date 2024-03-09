using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }

        static void Connection()
        {
            string cs = "Data Source=LAPTOP-ERN1FTED; Initial Catalog=StudDb; Integrated security=true;";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                if (conn.State != ConnectionState.Open)
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
