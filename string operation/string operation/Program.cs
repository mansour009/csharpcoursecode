using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            string myvar = "I AM smart";
            myvar = myvar.Substring(4);
            myvar = "he is" + myvar;

            char[] myvar1 = myvar.ToCharArray();
           

            Console.WriteLine("{0}",myvar1.Length);
            for(int i=0;i<myvar1.Length;i++)
            {
               


                Console.Write($"{myvar1[i]}");
                
            }


            Console.ReadKey();
        }
    }
}
