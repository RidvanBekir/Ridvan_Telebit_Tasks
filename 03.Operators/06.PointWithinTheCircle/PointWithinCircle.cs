using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointWithinCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking if given point is within the circle K(0,5)");
            int x;
            int y;
            bool a = true;
            bool b = false;
            Console.Write("Enter a number for x:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for y:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Is the point within the circle:");
            if (Math.Sqrt((x * x) + (y * y)) < 5)
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(b);
            }
            Console.WriteLine("\n\n");
        }
    }
}
