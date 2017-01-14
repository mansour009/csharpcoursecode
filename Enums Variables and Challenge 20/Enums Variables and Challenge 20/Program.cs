using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Variables_and_Challenge_20
{
    class Program
    {
        enum orientation : sbyte
        { 
            north =2,
            east = 3,
            south =4,
            west = 5
            }
        static void Main(string[] args)
        {
            orientation mynorth = orientation.north, myeast = orientation.east, mysouth = orientation.south, mywest = orientation.west;
            sbyte myval, myval1, myval2 ,myval3;

            myval = (sbyte)(mynorth);
            myval1 = (sbyte)(mysouth);
            myval2 = (sbyte)(myeast);
            myval3 = (sbyte)(mywest);

            Console.WriteLine($"my directions is:\n{mynorth}and equal= {myval}\n{myeast}and equal= {myval2}\n{mysouth}and equal= {myval1}\n{mywest}and equal= {myval3}");
            Console.ReadKey();



        }
    }
}
