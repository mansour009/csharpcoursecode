using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type_and_Challenge_21
{
    class Program
    {
        enum toyota : sbyte
        {
            camry = 1,
            corola = 2,
            yaris = 3,
            avalon = 4,
            prado = 5
        }
        enum orientation :byte
        {
            north=1,
            south= 2,
            east=3,
            west= 4
        }

        struct cartype
        {
            public toyota modelname;
            public int modelyear;
        }
        struct directions
        {
            public orientation mydirection;
            public int distance;
        }

        static void Main(string[] args)
        {
  /*          cartype mycartype;
            int cartype = 1;
            int modelyear;
            Console.WriteLine("1)camry\n2)corola\n3)yaris\n4)avalon\n5)prado ");
            do
            {
                Console.WriteLine("\nenter your car typ index");
                cartype = Convert.ToInt16(Console.ReadLine());

            }
          while ((cartype <1)|| (cartype > 5));
            Console.WriteLine("input a model year");
            modelyear = Convert.ToInt32(Console.ReadLine());
            mycartype.modelname = (toyota)cartype;
            mycartype.modelyear = modelyear;
            Console.WriteLine($"my cartype is { mycartype.modelname}" + $" and it's model is { mycartype.modelyear}");
*/
            //challenge 21 :

            directions mydirections;
            int directions = 1;
            int distance;
            Console.WriteLine("\nmy directions are\n1)north\n2)east\n3)south\n4)west");
            do
            {
                Console.WriteLine("my direction is");
                directions = Convert.ToInt16(Console.ReadLine());
            }
            while ((directions < 1) || (directions > 4));
            Console.WriteLine("what is the distance");
            distance = Convert.ToInt32(Console.ReadLine());
            mydirections.distance = distance;
            mydirections.mydirection = (orientation)directions;
            Console.WriteLine(" my direction {0} and  {1} to reach to it ", mydirections.mydirection, mydirections.distance);
            Console.ReadKey();
        }
    }
}
