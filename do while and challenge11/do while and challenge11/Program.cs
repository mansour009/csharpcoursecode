using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_and_challenge11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double mysalary = 1000.2, total= 0.0;

            int i = 0;
            do
            {
                total += mysalary;
                i++;
                Console.WriteLine("i value equal {0}", i);
            }
            while (i < 10);
            Console.WriteLine("salary value equal {0}", total);

    */
            //challenge

            double salary = 1020, increase = 20;
            int x = 0;
            do
            {
                salary += increase;
                x++;
               
            } while (salary < 2000);
            int year = x / 12, month = x % 12;
            
            Console.WriteLine("this is the duration required to increase the salary {0} year and {1} month", year,month);
 

            Console.ReadKey();


            
        }
    }
}
