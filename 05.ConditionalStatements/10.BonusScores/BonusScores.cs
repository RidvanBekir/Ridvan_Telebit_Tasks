using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonus Scores.");
            Console.Write("Enter a number in the interval [1,9]:");
            int digit1 = int.Parse(Console.ReadLine());
            int newValue = 0;
            switch (digit1)
            {
                case 1:
                case 2:
                case 3: newValue = digit1 * 10; break;
                case 4:
                case 5:
                case 6: newValue = digit1 * 100; break;
                case 7:
                case 8:
                case 9: newValue = digit1 * 1000; break;
                default: Console.WriteLine("You have entered an invalid number"); break;
            }
            Console.WriteLine("Your bonus is:{0}", newValue);
            Console.WriteLine("\n\n");
        }
    }
}
