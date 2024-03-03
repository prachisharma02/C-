using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                int age = 45;
                if (age > 18)
                {
                    Console.WriteLine("you can drive ");
                }
                else if (age >40)
                {
                    Console.WriteLine("you can't drive ");
                }
                else
            {
                Console.WriteLine("not eligible");
            }
                Console.ReadLine();

            
        }
    }
}
