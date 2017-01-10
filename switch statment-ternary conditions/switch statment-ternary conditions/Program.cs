using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statment_ternary_conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            string whathesay = "HELLO";
            switch (whathesay)
            {
                case "hello":
                    {
                        Console.WriteLine("this is my word");
                        break;
                    }
                case "bye":
                    {
                        Console.WriteLine("my word is bye");
                        break;
                    }
                case "welcome":
                    {
                        Console.WriteLine("my word is welcom");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("none of these my word");
                        break;
                    }
            }

            //ternary condition :

            int var = 9;
            string myresult = (var == 10) ? "this is the answer" : "this is wrong answer";
            Console.WriteLine("my result : {0}", myresult);
            string result = (var <= 9) ? "correct answer" : "wrong answer";
            Console.WriteLine("my result {0}", result);

            string myname = "mansour", result1;
            result1 = (myname.Equals("mansour")) ? "yes" : "no";
            Console.WriteLine(" my name is mansour ,{0}", result1);

            Console.ReadKey();
        }
    }
}
