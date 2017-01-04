using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_char_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int charmin = char.MinValue;
            int charmax = char.MaxValue;

            char myvar = 'G';
            int myvarvariabe = 'G';
            char myvarvariabe2 = Convert.ToChar(myvarvariabe);

            Console.WriteLine("\n min char = {0} \n max char={1}\n my char={2}\n my variabe number= {3}\n my conversion value ={4}", 
                charmin, charmax, myvar, myvarvariabe, myvarvariabe2);

            string myString = "this is my variable";
            Console.WriteLine("{0}", myString);

            bool mybool = true;
            Console.WriteLine("my boolean value is={0}", mybool);

            //chalenge number 2

            char var = 'A';
            char var1 = 'a';
            int var2 = 'A';
            int var3 = 'a';

            Console.WriteLine("\nmy char variable is {0} and equal :{2} \nmy char variable is {1} and equal :{3}", var, var1, var2, var3);


            Console.ReadKey();

        }
    }
}
