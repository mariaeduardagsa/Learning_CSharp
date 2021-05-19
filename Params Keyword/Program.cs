using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            PrintArray(5, 6, 7, 8, 9, 10);
        }
        public static void PrintArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
