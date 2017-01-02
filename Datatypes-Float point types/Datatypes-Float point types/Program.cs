using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_Float_point_types
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;

            Console.WriteLine("minvalue={0} maxvalue={1}", flmin, flmax);

            float flvar = 1f / 3;
            double dlvar = 1d / 3;
            decimal dcvar = 1m / 3;

            Console.WriteLine("\n floatvalue ={0}\n double= {1}\n decimal ={2}", flvar, dlvar, dcvar);
         

            Console.ReadKey();
            
            
            
            

            
        }
    }
}
