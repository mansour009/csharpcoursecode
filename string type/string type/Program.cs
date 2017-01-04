using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_type
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring1 = "ahmed said \"you should practice to achieve \"";
            string mystring2 = "ahmed said\\you should practice to achieve \\";
            string mystring3 = "ahmed said you should practice to achieve \0 ";
            string mystring4 = "ahmed said you should practice to achieve \a ";
            string mystring5 = "ahmed said\\you should\b practice to achieve \\";
            string mystring6 = "ahmed said\\you should \r practice to achieve \\";
            string mystring7 = "ahmed said\\you should \t practice to achieve \\";
            string mystring8 = "ahmed said \f you should practice to achieve \v ";
            string mystring9 = @"M:\visual studio c#\first lesson\string type\string type";
            string mystring10 =@"ahmed said it is a "" unique course"",and i think it is ";



            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4},{5}\n{6}\n{7}\n{8}\n{9}",mystring1,mystring6, mystring2,mystring3,mystring4,
                mystring5,mystring7,mystring8,mystring9,mystring10);

            Console.WriteLine($"{mystring1}:{mystring10}");

            Console.ReadKey();

        }
    }
}
