using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class DataAdapterDataSet
    {
        public static void Connection()
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            string query = "select * from employee";
            SqlDataAdapter sda= new SqlDataAdapter(query,conn);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            foreach(DataRow ds in dataSet.Tables[0].Rows)
            {
                Console.WriteLine("{0} , {1} , {2}", ds[0], ds[1], ds[2]);
            }

        }
    }
}
