using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using ADODemo; // for configurationmanager

namespace AdoClassess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Connectioncls.Connection1();
            //ConfigUsing.Connection2();
            //ExecuteReader.Connection3();
            //Storedproc.Connection4();
            //NonExecute.Connection5();
            //ExecuteScaler.Connection6();
            //Readerproperties.Connection7();
            //DataAdapterDataset.Connection();
            //Datatable.Connection();
            //Proceduresparameters.Connection();
            //ManualDatatable.Connection();
            CopyandClone.Connection();
            Console.ReadLine();
        }
    }
}
