using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit___explicit_challenge_17
{
    class Program
    {
        static void Main(string[] args)
        {/*
            decimal x = decimal.MaxValue;
            int y = int.MaxValue;
            Console.WriteLine("{0},{1}", x,y);
            */
            decimal var =98998;
            int var2=10256684 ;

            var2= checked ((int) var); 

            Console.WriteLine($"this is my deci {var}");
            Console.WriteLine($"this is my int {var2}");
            Console.ReadKey();


            // implicit conversions 

            // byte  -->   short, ushort, int, uint, long, ulong, float, double, decimal
            //sbyte  -->   short, int, long, float, double, decimal
            //short  -->   int, long, float, double, decimal
            //ushort -->   int, uint, long, ulong, float, double, decimal
            //int    -->   long, float, double, decimal
            //uint   -->   long, ulong, float, double, decimal
            //long   -->   float, double, decimal
            //ulong  -->   float, double, decimal
            //float  -->   double
            //char   -->   ushort, int, uint, long, ulong, float, double, decimal


        }
    }
}
