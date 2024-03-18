using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    class Readerproperties
    {
        public static void Connection7()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn7 = new SqlConnection(cs);
            try
            {

                string query = "select * from employee";
                SqlCommand cmd = new SqlCommand(query, conn7);
                conn7.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine(dr.FieldCount); // tells the no of column 
                    Console.WriteLine(dr.HasRows); // means it has rows or not
                    Console.WriteLine(dr.IsClosed); // sql reader obj close or not
                    Console.WriteLine(dr.GetName(0));
                    //getresult if there are multiple queries like
                   // string query = "select * from employee;select id from test;
                   //so in these case we use nextresult

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
