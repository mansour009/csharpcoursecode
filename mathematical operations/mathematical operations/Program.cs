using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematical_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 10;
            int myvar2 = 15;
            int myvar3 = 30;
            int temp = myvar1 + myvar2;
            Console.WriteLine("the result is {0}",temp);
            int temp1 = myvar2 - myvar1;
            int temp2 = myvar2 + myvar1 * myvar3 / myvar1;
            Console.WriteLine($"the minus result is  {temp1} and this equation equal = {temp2}");

            string mystr = "iam";
            string mystr1 = "smart";
            string mystr2 = mystr + mystr1;
            Console.WriteLine("{0}",mystr2);

        
            Console.ReadKey();


        }
    }
}
