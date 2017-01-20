using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_values_and_challenge_27
{
    class Program
    {
        static void myltiply (ref int myvar1 ,ref int myvar2)
        {
            myvar1 *= 4; myvar2 *= 4; 

            Console.WriteLine("{0},{1}",myvar1,myvar2);
        }
      
        static void Main(string[] args)
        {
            int number = 6, number1 = 10;

            Console.WriteLine("my first int{0},my secound int{1}",number,number1);
            myltiply(ref number,ref number1);
            Console.WriteLine("my first int{0},my secound int{1}", number, number1);


            Console.ReadKey();
        }
    }
}
