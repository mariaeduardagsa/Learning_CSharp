using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount(50, "Bob");
            BankAccount bank2 = new BankAccount(150, "Fred");

            BankAccount bank3 = bank1 + bank2;

            Console.WriteLine(bank3.Owner);
            Console.WriteLine(bank3.Money);

            BankAccount bank4 = bank3 + 500;
            Console.WriteLine(bank4.Owner);
            Console.WriteLine(bank4.Money);
        }
    }
}
