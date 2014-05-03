using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perimeter and area of a circle.");
            string radius;
            Console.Write("Enter a number for radius:");
            radius = Console.ReadLine();
            double radius1 = double.Parse(radius);

            if (radius1 <= 0)
            {
                Console.WriteLine("The radius can not be negative or 0!");
            }
            else
            {
                double Perimeter = 2 * Math.PI * radius1;
                Console.WriteLine("The perimeter of the circle is {0:0.00}:", Perimeter);
                double Area = Math.PI * radius1 * radius1;
                Console.WriteLine("The area of the circle is {0:0.00}", Area);
            }
            Console.WriteLine("\n\n");
        }
    }
}
