using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
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

//Parameter Placeholders(@id, @dept, @sal):
//  These symbols are a common way to represent parameters in SQL queries within various
//  programming languages, including C#.
//  They act as variables within the query that will be replaced with actual values later
//  in the code.
                    SqlCommand cmd = new SqlCommand(query, conn4);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@sal", sal);

//  Cmd.parameters Create Parameter Objects:
//      They create SqlParameter objects within the SqlCommand object(cmd) These objects store information
//      about the parameters, including their names(@id, @dept, @sal) and the data types of the values
//      they will hold.
//  AddWithValue method Assign Values:
//      This is used to assign the actual values retrieved from the user input(id, dept, and sal) to the
//      corresponding parameter objects.

                    conn4.Open();
                   int queryexecution= cmd.ExecuteNonQuery();
                    if(queryexecution > 0)
                    {
                        Console.WriteLine("success");
                    }else
                    { Console.WriteLine("failed"); }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
