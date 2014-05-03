using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving a quadratic equation.");
            Console.WriteLine("The equation have the form: a*x^2 + b*x + c.");
            Console.Write("Enter a number a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a number for c:");
            double c = double.Parse(Console.ReadLine());
            double Discriminant = b * b - 4 * a * c;
            double x1, x2;
            double root = System.Math.Sqrt(Discriminant);
            if (Discriminant < 0)
            {
                Console.WriteLine("This equation has no real roots!");
            }
            else if (Discriminant == 0)
            {
                x1 = x2 = (-b) / 4 * a;
                Console.WriteLine("The root of the equation is:{0}", x1);
            }
            else
            {
                x1 = ((-b) + root) / 2 * a;
                x2 = ((-b) - root) / 2 * a;
                Console.WriteLine("The roots of the equation are:{0:0.00} and {1:0.00}", x1, x2);
            }

            Console.WriteLine("\n\n");
        }
    }
}
