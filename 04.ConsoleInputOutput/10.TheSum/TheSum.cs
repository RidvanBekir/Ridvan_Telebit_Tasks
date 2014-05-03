using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Canlculating the sum:1 + 1/2 - 1/3 + 1/4....");
            Console.Write("Enter a number for the last divisor: ");
            var n = int.Parse(Console.ReadLine());
            decimal sum = 1;
            for (int i = 2; i <= n; i++)
            {
                if ((i & 1) == 1)
                {
                    sum -= 1m / i;
                }
                else
                {
                    sum += 1m / i;
                }
            }
            Console.WriteLine("The sum is: {0:F3}", sum);
            Console.WriteLine("\n\n");

        }
    }
}
