using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Factorial_Trailing_Zeroes
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactoriel(N);
            BigInteger Zeroes = Zeros(factorial);
            Console.WriteLine(Zeroes);
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

       static int Zeros(BigInteger factorial)
        {
            int zero = 0;
            while (factorial % 10 == 0)
            {
                zero++;
                factorial /= 10;
            }
            return zero;
        }
    }
}