using System;
using System.Collections.Generic;
using System.Configuration; // if using this you have to add the system configuration by right clicking on References then add references then tick on system.configuration (this is assemy which is required for adding namespace )
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class ConfigUsing
    {
        public static void Connection2()
        {
            SqlConnection conn = null;
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            // we have taken here cs from app.config file

            try
            {
                // then we have used using statement to automatically close the connection

                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        Console.WriteLine("success");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

