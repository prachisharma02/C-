using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class StoredprocdataSet
    {
        public static void connection()
        {
            try {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection conn = new SqlConnection(cs);
                string query = "spemp";
                int empid = 1006;
                SqlDataAdapter sd=new SqlDataAdapter(query, conn);
                sd.SelectCommand.CommandType = CommandType.StoredProcedure;
                sd.SelectCommand.Parameters.AddWithValue("@empid", empid);

                DataSet ds =new DataSet();
                sd.Fill(ds);

                // foreach (DataRow data in ds.Tables["employee"].Rows) 
                //nullrefernce error aayga but webform me aese krsakte hain bs console me nhi krsakte
                //so we can set table name as
               // ds.Tables[0].TableName = "Employee";
                // now no error
                
                foreach (DataRow data in ds.Tables[0].Rows)
                {
                    Console.WriteLine(data[0]+" " + data[1]+" " + data[2]);
                }
            }catch(Exception e) {


            Console.WriteLine(e.ToString());}
        }
    }
}
