using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_for_each__and_challenge23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q: 
            const int myarray = 15;
            int[] mynumbers = new int[myarray] { 12, 15, 18, 14, 36, 25, 89, 51, 98, 36, 36,25,69,97,61 };
            int i =0;

            foreach(int item in mynumbers)
            {
                i++;
                if (i > 14)
                    break;

                Console.WriteLine("my numbers ({0}) = {1}",i,item);    
            }
            Console.ReadKey();
        }
    }
}
