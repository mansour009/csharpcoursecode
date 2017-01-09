using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 10, var1 = 6 , var2 = 8;

            if (var == 10)
            {
                Console.WriteLine("my variable equal 10");

                if ((var1 >= 5) && (var2 < 9))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine("false");
                }

            }

            else
            { 
                Console.WriteLine(var != 10);
               
                }
            if ((var >= 10) && (var1 == var2))
            {
                Console.WriteLine("comdition one right");
            }
            else if ((var2 == 8) && (var1 != 6))
            {
                Console.WriteLine("condition two right");
            }
            else if (var1 == var)
            {
                Console.WriteLine("condition 3 is right");
            }
            else if ((var == 6) || (var1 == 6))
            {
                Console.WriteLine("condition four right");
            }
            else
                Console.WriteLine("zero"); 


            Console.ReadKey();


        }
    }
}
