using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class NonExecute
    {
        public static void Connection5()
        {
            string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            SqlConnection conn4 = null;
            try
            {
                using (conn4 = new SqlConnection(cs))
                {
                    Console.WriteLine("Enter Empid");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter Department");
                    string dept = Console.ReadLine();
                    Console.WriteLine("Enter Salary "); // its int and  storing in string but after inserting into db it gets converted into int
                    string sal = Console.ReadLine();
                    string query = "insert into Employee values(@id,@dept,@sal)"; // these symbols are used in sql for adding parameters 
                    SqlCommand cmd = new SqlCommand(query, conn4);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@sal", sal);



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
