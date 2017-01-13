using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_challenge_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //how many years needed to get 2000 $ if your salary is 1020 $ and and increase by 20$ monthly ??

            int mysalary = 1020 , total = 0;
            for (total = 0; mysalary < 2000; total ++) 
            {
                mysalary = mysalary + 20;
                
            }
            Console.WriteLine("this is my salary after{0}years", total / 12);

            //Q2: how many excrsise do you need to decrease your wieght from 120 to 83 kg if every exercise decrease 1kg?

            int myweight = 120, i = 0;
            for (i = 0; i < 83; i++)
            {
                myweight = myweight - 1;
            }
            Console.WriteLine("I loss my weight after {0} exercise", myweight);

            Console.ReadKey();
        }
    }
}
