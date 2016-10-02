using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Max_Method
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int getMax = GetMax(a, b, c);
            Console.WriteLine(getMax);
        }

        static int GetMax(int a, int b, int c)
        {
            int maxIntaIntb = Math.Max(a, b);
            int maxIntaIntbIntc = Math.Max(maxIntaIntb, c);
            return maxIntaIntbIntc;
        }
    }
}