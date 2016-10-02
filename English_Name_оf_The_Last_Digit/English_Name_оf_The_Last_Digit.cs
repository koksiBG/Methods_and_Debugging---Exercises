using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_оf_The_Last_Digit
{
    class English_Name_оf_The_Last_Digit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            long digitToName = GetLastDigit(n);
            for (int i = 0; i <= digitToName; i++)
            if (i == digitToName) Console.WriteLine("{0}", numbers[i]);
        }

        private static long GetLastDigit(long n)
        {
            int lastDigit = (int)Math.Abs(n % 10);
            return lastDigit;
        }
    }
}