using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Square[] squares = new Square[10];

            for(int i = 0; i < 10; i++)
            {
                squares[i] = new Square(i + 1);
                Console.WriteLine("{0}, {1}", squares[i].Side, squares[i].Area);
            }
        }
    }
}
