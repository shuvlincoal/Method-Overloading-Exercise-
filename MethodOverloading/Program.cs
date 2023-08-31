using System.Diagnostics;
using System;
namespace MethodOverloading
{
    public class Program
    {

        public static int   Add(int num1, int num2) {
            Console.WriteLine($"{num1 + num2}");
            return num1 + num2;
        }//method ADD1


        public static double Add(double dbl1, double dbl2)
        {
            Console.WriteLine($"{(dbl1 + dbl2).ToString()} dollar");
            return dbl1 + dbl2;
        }//method ADD2


        public static string Add(int num1, int num2, bool zupDawg)
        {
            if (zupDawg)
            {

                if (num1 + num2 > 1)
                {
                    Console.WriteLine($"{num1 + num2} dollars");
                    return (num1 + num2).ToString() + "dollars";
                }//if
                else
                {
                    Console.WriteLine($"{num1 + num2} +dollar");
                    return (num1 + num2).ToString() + "dollar";
                }

            }   
            else  //zupDawg = false
            {
                Console.WriteLine($"{num1 + num2}");
                return (num1 + num2).ToString();
            }
        }//method ADD3


        public static void Main(string[] args)
        {
            Add(1, 2);  //Add #1
            Add(3.2, 2.999);  //Add #2
            Add(199, 245, true);  //Add #3
            //Console.WriteLine("Hello, World!");

        }
    }
}
