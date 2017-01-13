using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop___Continue_Command_and_challenge_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int multi = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}", i);
                if (i > 7)
                  
                continue;

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
