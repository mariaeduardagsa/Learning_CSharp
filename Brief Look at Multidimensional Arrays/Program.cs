using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brief_Look_at_Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] myArray = new int[3, 4];
            //     // i, j
            //myArray[0, 0] = 5;
            //myArray[0, 1] = 6;
            //myArray[0, 2] = 7;
            //myArray[0, 3] = 8;

            //myArray[1, 0] = 5;
            //myArray[1, 1] = 6;
            //myArray[1, 2] = 7;
            //myArray[1, 3] = 8;

            //myArray[2, 0] = 5;
            //myArray[2, 1] = 6;
            //myArray[2, 2] = 7;
            //myArray[2, 3] = 8;

            ////int[,] myA = { { 5, 6, 7, 8 },
            ////               { 5, 6, 7, 8},
            ////               { 5, 6, 7, 8 } }; // shorthand


            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write(myArray[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            int[][] myArray = new int[3][];
            myArray[0] = new int[4] { 5, 6, 7, 8 }; 
            myArray[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            myArray[2] = new int[2] { 1, 2 };

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
