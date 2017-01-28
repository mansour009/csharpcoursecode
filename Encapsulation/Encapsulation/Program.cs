using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " AHMED MANSOUR";
            int age = 24;

            Person myobj = new Person() ;
            myobj.SetName (name);
            myobj.SetAge(age);

            Console.WriteLine("my name is" + myobj.GetName());
            Console.WriteLine("my age is" + myobj.GetAge());
            Console.ReadKey();



        }
    }
}
