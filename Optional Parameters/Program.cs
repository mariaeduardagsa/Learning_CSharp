using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters
{
    class Program
    {


        public static void Func1()

        {

            Func2();

            Console.WriteLine("Hello");

        }

        public static void Func2()

        {

            Func1();

        }

        static void Main(string[] args)

        {

            Func1();

        }



    }
}
