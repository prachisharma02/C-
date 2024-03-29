using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Class1
    {
        public void Aese()
        {
            Console.WriteLine("non virtual");
        }
    }
    class Class2 :Class1 { 
    public void Aese()
        {
            Console.WriteLine("NON VIRTUAL");
        }
    }
}
