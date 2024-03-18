using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AdoClassess
{
    internal class ManualDatatable
    {
        public static void Connection()
        {
            try { 
            DataTable User=new DataTable("User");

                //1st way of adding column
            DataColumn userid = new DataColumn("userid");
                userid.Caption="id";
                userid.DataType=typeof(int); // 1st way to define datatype
                userid.AllowDBNull = false;
                User.Columns.Add(userid);

                //2nd way of adding column
                DataColumn name = new DataColumn("name")
                {
                    Caption = "name",
                    DataType = typeof(string), 
                    MaxLength = 20,
                    AllowDBNull = false

                };
                User.Columns.Add(name);


            DataColumn phoneno = new DataColumn("phoneno");
                phoneno.Caption = "phoneno";
                phoneno.DataType = System.Type.GetType("System.Int32"); // 2nd way to define datatype
                phoneno.AllowDBNull = false;
                User.Columns.Add(phoneno);

                DataRow row1 = User.NewRow();
                row1["userid"] = 1;
                row1["name"] = "prachi";
                row1["phoneno"] = 1234;
                // easy way to add rows
                User.Rows.Add(2, "khushi", 5678);
                User.Rows.Add(3, "avi", 9078);

                foreach(DataRow row in User.Rows)
                {
                    Console.WriteLine(row["userid"]+" " + row["name"]+" " + row["no"]);
                }
                Console.ReadLine();


            }
            catch (Exception e) {
            Console.WriteLine(e.Message);
          }
        }
    }
}
