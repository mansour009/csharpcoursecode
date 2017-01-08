using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean__operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //boolean operators == ,!= ,<= , >=, < , >
            //boolean conditions && , ||

            bool result;
            int var1 = 10, var2 = 11, var3 = 3, var4 = 7;
            // result= var1 == var2;
            // result = var2 <= 10;
            // result = var3 != 4;
            //  Console.WriteLine("{0}",result);
            //Console.ReadKey();

            //CHALLENGE :
            //result = (var1 > var3) && (var2 > var4);
           // result = (var1 < var3) || (var2 > var4);
            result = (var1 < var3) && (var2 > var4);

            Console.WriteLine("{0}",result);


            Console.ReadKey();



        }
    }
}
