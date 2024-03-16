using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class Connectioncls
    {
        public static void Connection1()
        {
            string cs = "Data Source=LAPTOP-ERN1FTED; Initial Catalog=StudDb; Integrated security=true;";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("success");
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();// Ensure connection is closed even on exceptions
            }
        }
    }
}
