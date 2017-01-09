using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 10;
            string value ;
            if (myvar < 10) 
            {
                value = "less than 10";
                Console.WriteLine(value);

            }
           
                if (myvar > 10) 
            {
                value = "greater than 10";
                Console.WriteLine(value);
            }
            
                if (myvar == 10) 
            {
                value = "equal to 10";
                Console.WriteLine(value);
            }


            
          
            
            int var1 = 8;

            if (var1 <= 8)
            {
                Console.WriteLine("my variable less than 8");
            }
            if (var1 >= 8)
            {
                Console.WriteLine("my variable greater than 8");
            }
            
             int var = 10, var2 = 5, var3 = 9;

             if ((var <= 11)|| (var2 == 5) && (var3 >= 8))

            Console.WriteLine("true");

            else
            
                Console.WriteLine("false");

            bool mybool = (var <= 11) && (var2 == 5) && (var3 >= 8);
            Console.WriteLine("{0}", mybool);


            Console.ReadKey();



        }
    }
}
