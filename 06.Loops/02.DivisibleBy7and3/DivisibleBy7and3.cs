using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers that are not divisible by 7 and 3 from 1 to N.");
            Console.Write("Enter a number:");
            int Num = int.Parse(Console.ReadLine());
            int divider1 = 3;
            int divider2 = 7;
            for (int counter1 = 1; counter1 < Num; counter1++)
            {
                if (counter1 % divider1 != 0 && counter1 % divider2 != 0)
                {
                    Console.WriteLine("Number:{0}", counter1);
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
