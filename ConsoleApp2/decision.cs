using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void greeting()
        {
            Console.WriteLine("good morning");
        }
        static void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void  sum(float a, float b) // if in place of void we put int or float or something else then error
            // means in overloading if we change the return type then error
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            greeting();
            sum(6, 7);
            sum(20.90F, 70.86F);

            Console.WriteLine("***** IF ELSE STATEMENT *****");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18 && age<40)
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
            Console.WriteLine("***** SWITCH CASE STATEMENT *****");

            switch (age)
            {
                case 18:
                    Console.WriteLine("wait for 1 year");
                break;
                case 40:
                    Console.WriteLine("not eligible");
                    break;
                default:
                    Console.WriteLine("ok");
                    break;
            }
            Console.WriteLine("***** LOOPS *****");
            Console.WriteLine("***** FOR LOOPS *****");

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
                break;// it will print only 0 
            }
            Console.WriteLine("***** WHILE LOOPS *****");
            int i = 15;
            while (i < 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
            Console.WriteLine("***** DO WHILE LOOPS *****");
            int k = 50;
            do
            {
                Console.WriteLine(k);
                k += 5;
            } while (k < 100);


            Console.ReadLine();

            
        }
    }
}
