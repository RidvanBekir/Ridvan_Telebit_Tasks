using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing all numbers from 1 to N.");
            Console.Write("Enter a number:");
            int N = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < N)
            {
                Console.WriteLine("Number:{0}", counter);
                counter++;
            }
            Console.WriteLine("\n\n");
        }
    }
}
