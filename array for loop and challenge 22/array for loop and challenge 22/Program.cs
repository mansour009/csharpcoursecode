using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_loop_and_challenge_22
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myarray = 6;
            int[] mynumbers = new int [myarray] { 1, 5, 9, 11, 12,15 };
            int[] mynumbers1 = new int[myarray] { 5, 10, 15, 20, 25, 30 };
            int max ;
            for (int i = 0; i < 6; i++)
            {
               
                Console.WriteLine("my numbers " + (i + 1) + " = {0}", mynumbers1[i]);
            }
                max = mynumbers1.Max();
                Console.WriteLine("\nmy maximum value = {0}",max);
            
            Console.ReadKey();
            
        }
    }
}
