using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinAndMaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min and max number in a sequence.");
            int number;
            Console.Write("Enter how many numbers you want in the sequence:");
            number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            Console.WriteLine("Enter the sequence:");
            for (int i = 0; i < number; i++)
            {
                Console.Write("Number {0}:", i + 1);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The max number in the sequence is:{0}", array.Max());
            Console.WriteLine("The min number in the sequence is:{0}", array.Min());
            Console.WriteLine("\n\n");

        }
    }
}
