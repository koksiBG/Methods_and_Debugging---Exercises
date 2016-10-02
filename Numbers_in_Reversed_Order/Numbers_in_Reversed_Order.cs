using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Numbers_in_Reversed_Order
    {
        static void Main(string[] args)
        {
            PrintReverseNumber();
        }

        static void PrintReverseNumber()
        {
            string number = Console.ReadLine();
            number = new string(number.ToCharArray().Reverse().ToArray());
            Console.WriteLine(number);
        }
    }
}