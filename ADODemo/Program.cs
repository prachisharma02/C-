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
            //Connectioncls.Connection1();
            //ConfigUsing.Connection2();
            // Executereader.Connection3();
            //Storedproc.Connection4();
            //NonExecute.Connection5();
            ExecuteScaler.Connection6();
            //Readerproperties.Connection7();
            Console.ReadLine();
        }

    
            

        }
    }
