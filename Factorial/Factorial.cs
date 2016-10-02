using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactoriel(N);
            Console.WriteLine(factorial);
        }

        static BigInteger GetFactoriel(int N)
        {
            BigInteger multiplicationN = 1;
            for (int i = 1; i <= N; i++)
            {
                multiplicationN *= i;
            }
            return multiplicationN;
        }
    }
}