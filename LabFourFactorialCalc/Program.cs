using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_30_Aug

{
    class Program
    {
        static string ans;
        static int valueInt;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!\n");
            Console.Write("Enter an integer that's greater than 1 but less than 10 : ");

            do
            {
               
                                
                valueInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Factorial of {valueInt} is {Factorial(valueInt)}");
              
                                               
                Console.Write("\nContinue ?(y/n) :");
                ans = Console.ReadLine();
                Console.WriteLine();
                if (ans == "y")
                    Console.Write($"Enter an integer that's greater than 1 but less than {Factorial(valueInt)}: ");
            } while (ans == "y");
        }
        static long Factorial(int num)
        {
            if (num == 0) return 1; return num * Factorial(num - 1);
        }        //static  long FactorialValue(int num)        
                   
    }
}