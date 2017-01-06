using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //= ,+= ,-= ,*= , /= , %=

            int temp, var1 = 10, var2 = 5;

           // var1 /= var2;

            Console.WriteLine("equation equal={0}", var1);

           // var1 *= var2++;
            Console.WriteLine("equation equal={0}", var1);

            int var3 = 16;

            var3 %= var2;

            Console.WriteLine("{0}",var3);
            Console.ReadKey();


      
        }
    }
}
