using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trapezoid_sArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating trapezoid's area");
            int b2, b1, h;
            Console.Write("Enter the side a:");
            b1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the side b:");
            b2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the height h:");
            h = int.Parse(Console.ReadLine());
            int area;
            if (b1 == b2)
            {
                Console.WriteLine("Such trapezoid can not exist!");
            }
            if (b1 < 0 || b2 < 0 || h < 0)
            {
                Console.WriteLine("Such trapezoid can not exist!");
            }
            else
            {
                area = ((b1 + b2) / 2) * h;
                Console.WriteLine("The area of the chosen trapezoid is {0}", area);
            }

            Console.WriteLine("\n\n");
        }
    }
}
