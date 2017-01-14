using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command_and_Challenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
            float myfloat = 45.54f;
            string mystring, substring;

            mystring = Convert.ToString(myfloat);

            substring = mystring.Substring(2,3);

            Console.WriteLine($"my var = {mystring} \n my substring ={substring} ");
            Console.ReadKey();

        }
    }
}
