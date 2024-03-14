using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; // for configurationmanager
namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.Connection1();
            //Class2.Connection2();
            Class3.Connection3();
            Console.ReadLine();
        }

    
            

        }
    }
