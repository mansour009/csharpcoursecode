using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_prameter_challeng_28
{
    class Program
    {
        //Q.28 write an out prameter programe
        static int mygrades(int[]myarray,out int myindex)
        {
            int maxvalue = myarray[0];
            myindex = 0;
            for(int i=1;i<myarray.Length;i++)
            {
                if (myarray[i] > maxvalue)
                {
                    
                    maxvalue = myarray[i];
                    myindex = i;
                }

            }
            return maxvalue;
        }
        static void Main(string[] args)
{
            int myindex;
            int[] myarray = { 12, 52, 36, 40, 60, 26, 36, 89, 54};
          int maxvalue=  mygrades(myarray, out myindex);
            Console.Write($"{maxvalue},{myindex}");
            Console.ReadKey();

        }
    }
}
