using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loop_and_challenge_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge 14
            // Q1 : create multiplication table from 1-5 for all over numbers to 10  ??

            for (int i = 1; i <= 5; i++)
            {  
                int multiply = 0;
                for (int x = 1; x <= 10; x++)
                {
                    multiply = i * x;
                    Console.WriteLine("{0}*{1}={2}",i,x, multiply);
                }
               
                Console.WriteLine("\n");
            }

            // Q2 : create multiplication table from 1-6 for even numbers to 10  ??

            for (int i = 2 ; i <= 6; i+=2)
            {
                
                int multiply = 0;
                for (int x = 1; x <= 10; x++)
                {    
                    multiply = i * x;
                    Console.WriteLine("{0}*{1}={2}", i, x, multiply);
                }

                Console.WriteLine("\n");
            }
            // Q3 : create multiplication table from 1-6 for odd numbers to 10  ??

            for (int i = 1; i <= 6; i += 2)
            {
                
                int multiply = 0;
                for (int x = 1; x <= 10; x++)
                {
                    multiply = i * x;
                    Console.WriteLine("{0}*{1}={2}", i, x, multiply);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
