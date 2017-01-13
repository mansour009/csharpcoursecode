using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_Break_Command_and_challenge_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1 :write multiply table from 1-10 and stop the loop when it is 7

            int multi = 0;
            for (int i = 1; i <= 10; i++) 
            {
                if (i > 7)
                    break;
                for (int j = 1; j <= 5; j++)
                {
                    multi = i * j;
                    Console.WriteLine("{0}*{1}={2}", i, j, multi);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
