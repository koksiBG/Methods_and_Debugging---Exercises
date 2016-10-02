using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Name
{
    class Hello_Name
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            PrintHello();
            Console.WriteLine(Name + "!");
        }

       static void PrintHello()
        {
            Console.Write("Hello, ");
        }
    }
}