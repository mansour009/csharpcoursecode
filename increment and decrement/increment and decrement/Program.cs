using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increment_and_decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5;
            int temp = ++var1;
            int temp1 = var1++;
            double var2 = 7;
            double var3 = 2.0;
            double temp2 = var2-- / ++var3;

            Console.WriteLine("prefix={0}\npostfix={1}",temp,temp1);
            Console.WriteLine("equation ={0}", temp2);
            //why ?
            //because the decrement postfix assign the value of the temporary ,
            //while the increment prefix assign it as new value after storing it as variable 

            Console.ReadKey();
        }
    }
}
