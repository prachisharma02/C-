using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class CopyandClone
    {
        public static void Connection()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;// connection string late hain pehle database se
                SqlConnection conn = new SqlConnection(cs); // connection establish krte hain cs se
                string query = "Select * from Employee"; // data fetch krte hain db se
                SqlDataAdapter sd = new SqlDataAdapter(query,conn); // dataadapter query ko read krta hai 
                DataTable customer = new DataTable("customer"); // datatable create kerte hain data jo fetch hora hai use storekrne k liy
                sd.Fill(customer); // basically fill method dataadapter ka hota hai vo store krta hai datatable me fetch kiya hua data 
                Console.WriteLine("original");
                foreach (DataRow ds in customer.Rows) // datarow looping k liy hota hai jo ek ek kkrke record fetch krta hai
                {
                    Console.WriteLine("{0} , {1} , {2}", ds[0], ds[1], ds[2]);
                }

                DataTable copied=customer.Copy();
                Console.WriteLine("copied");
                foreach (DataRow ds in copied.Rows)
                {
                    Console.WriteLine("{0} , {1} , {2}", ds[0], ds[1], ds[2]);
                }

                DataTable cloned = customer.Clone();

                Console.WriteLine("cloned");
                if(cloned.Rows.Count>0) {
                    foreach (DataRow ds in cloned.Rows)
                    {
                        Console.WriteLine("{0} , {1} , {2}", ds[0], ds[1], ds[2]);
                    }
                }
                else
                {
                    Console.WriteLine("no rows");
                    cloned.Rows.Add(1, "hm", 89000);
                }

                foreach (DataRow ds in cloned.Rows)
                {
                    Console.WriteLine("{0} , {1} , {2}", ds[0], ds[1], ds[2]);
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
