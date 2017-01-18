using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensional_and_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myarray = { {2,3,5,6 } ,
            //                   {7,6,9,5 } , 
            //                   {9,3,4,5} };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}", myarray[i, j] + " ");

            //    }
            //    Console.WriteLine("");
            //}

            //           "multidimensional array " 
            /*
            int[,,] myarray1 = new int[3, 2, 3]
                {
                    {
                        {1,2,3 }, {3,5,4 }
                    },
                    {
                        {0,2,8 }, {4,7,8 }
                    },
                    {
                        {9,6,1 }, {1,4,6 }
                    }
                };
            for(int i=0;i<3;i++)
            {
                for(int j=0; j<2;j++)
                {
                    for(int y=0;y<3;y++)
                    {
                        Console.Write("{0}",myarray1[i , j, y] +" ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
            */
            // jagged array

            int[][] myarray2 = new int[3][];
            myarray2[0] = new int[3] { 1, 2, 3 };
            myarray2[1] = new int[5] { 3, 4, 5, 6, 7 };
            myarray2[2] = new int[3] { 7, 8, 9 };
            for(int i=0;i<myarray2.Length;i++)
            {
                Console.WriteLine("element({0}):",i);
                for(int j=0;j<myarray2[i].Length;j++)
                {
                    Console.Write("{0}", myarray2[i][j]+" ");
                    
                }
                Console.WriteLine(" ");
            }
            
            Console.ReadKey();
            }
            
        }

    }

