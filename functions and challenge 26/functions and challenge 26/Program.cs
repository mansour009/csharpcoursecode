using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_and_challenge_26
{
    class Program
    {
       

        static int average (int[]array)
        {
            int average = array[0];
            for (int i =1; i<array.Length;i++)
            {
               
            }
            return average;
        }
  
        static void Main(string[] args)
        {
            int[] array = { 9, 10, 8, 7, 6, 6, 4, 7, 6, 8};
            int average = array.Sum();
            Console.WriteLine("this is the average of the student = {0}", average/10);
   
            Console.ReadKey();
        }
    }
}
