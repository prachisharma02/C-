using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine(" ***** HOW TO PRINT ON CONSOLE ******");
              Console.WriteLine("hello world");



            Console.WriteLine("***** DATA  TYPES *****");
            int a = 5;              
            float b = 67.89F;
            double myDoubleNum = 5.99D;  
            char myLetter = 'D';        
            bool myBool = true;         
            string myText = "Hello";
            const int myNum = 15;

            Console.WriteLine("***** TAKING INPUT *****");           
           // string inp = Console.ReadLine();
            // The Console.ReadLine() method returns a string. Therefore, you cannot get information
            // from another data type, such as int
          //  int roll=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***** PRINTING INPUT *****");
           // Console.WriteLine("here is the output of takingstring input  "+inp);
           // Console.WriteLine("here is the output of taking integer input  " + roll);



            Console.WriteLine(" ***** + OPERATOR ***** ");
            /* IF WE ARE USING + WITH INT, FLOAT AND CHAR  IT WILL ADD THE VALUES 
             * BUT WITH  BOOL IT WILL GIVE YOU ERROR 
             * BUT WITH STRING IT WILL DO STRING INTERPOLATION LIKE "HEELLOO80"
            */
            Console.WriteLine("***** ADDING BOTH THE VALUES WHEN INTEGER a is 5 and b is 67.89 *****");
            Console.Write("Result of a+b is :");
            Console.WriteLine(a + b);
            Console.WriteLine("now here we are starting with string then a and b will also become string a:5 b:67.89   " + a + b);
            // so to make it a a+b as int we will do type casting so heres it is done 
            Console.WriteLine(" ***** TYPE CASTING *****");
            Console.WriteLine("now here we are starting with string then a and b will also become string a:5 b:67.89   " + (int)(a + b));
            Console.WriteLine("now here we are starting with string then a and b will also become string a:5 b:67.89   " + Convert.ToInt32(a+b));


            Console.WriteLine(" ***** IMPLICIT TYPE CASTING *****");
            int ch = 'g';
            long lng = 76;
            double d = 78.90;
            Console.WriteLine(ch);
            Console.WriteLine(lng);
            Console.WriteLine(d);
            Console.WriteLine(" ***** EXPLICIT TYPE CASTING *****");
            int x = (int)56.89;
            string y = (string)"67";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(" ***** BY METHODS TYPE CASTING *****");

            int myInt = 10;
            double myDouble = 5.25;
            bool bol = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(bol));   // convert bool to string


            Console.WriteLine(" ***** Math Class *****");
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64)); //8 it only return double vale
            double sixtyfour = Math.Sqrt(64); // so if you try to store into int variable then error
            Console.WriteLine(Math.Abs(-5.9)); //5.9
            Console.WriteLine(Math.Round(78.56)); //79

           
            Console.WriteLine(" ***** String Class *****");
            string me = "my name is prachi";
            Console.WriteLine(me.Length);//17
            Console.WriteLine(me.ToUpper());
            Console.WriteLine(me[6]);//e
            Console.WriteLine(me.LastIndexOf('a'));//13
            Console.WriteLine(me.Substring(1));//y name is prachi
            Console.WriteLine(me.Substring(5));//me is prachi
            Console.WriteLine(me.Substring(3,9));// name is p






            Console.WriteLine("***** STRING INTERPOLATION *****");
            //string name = Console.ReadLine();
            //int age =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine($" my name is { name } and age is { age }");

           









            Console.ReadLine();

        }
    }
}
