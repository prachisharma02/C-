using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Class3
    {
        public static void Connection3()
        {
            try{
                string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            }
            catch(Exception e){
            Console.WriteLine(e)
        }
    }
}
