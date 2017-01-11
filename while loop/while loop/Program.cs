using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int myweight = 120 , x=0 ;
          
            while (myweight > 83) 
            {
                myweight--;
                x++;
            }
            Console.WriteLine("this is how many exercise i should workout = {0}", x);
                Console.ReadKey();
            
        }
    }
}
