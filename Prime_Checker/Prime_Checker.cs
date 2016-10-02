using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Prime_Checker
    {
        static void Main(string[] args)
        {
            {
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine(IsPrime(number));
            }
        }

        static bool IsPrime(long number)
        {
            bool checkPrime = true;

            if (number < 2) checkPrime = false;
            else
            {
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
            }
            return checkPrime;
        }
    }
}