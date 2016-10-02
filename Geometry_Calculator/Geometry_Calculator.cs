using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Geometry_Calculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            if (figureType == "triangle")
            {
                double sideTriangle = double.Parse(Console.ReadLine());
                double heightTriangle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", PrintTriangleArea(sideTriangle, heightTriangle));
            }
            else if (figureType == "square")
            {
                double sideSquare = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", PrintSquareArea(sideSquare));
            }
            else if (figureType == "rectangle")
            {
                double widthReactangle = double.Parse(Console.ReadLine());
                double heightReactangle = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", PrintRectangleArea(widthReactangle, heightReactangle));
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", PrintCircleArea(radius));
            }
        }

        static double PrintTriangleArea(double sideTriangle, double heightTriangle)
        {
            double area = (sideTriangle * heightTriangle) / 2;
            return area;
        }


        static double PrintSquareArea(double sideSquare)
        {
            double area = sideSquare * sideSquare;
            return area;
        }


        static double PrintRectangleArea(double widthReactangle, double heightReactangle)
        {
            double area = widthReactangle * heightReactangle;
            return area;
        }

        static double PrintCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}