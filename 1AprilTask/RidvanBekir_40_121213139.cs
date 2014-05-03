using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RidvanBekir_40_121213139
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, k = 0, s = 0;

            Console.WriteLine("Enter a number:");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("The lenght of the array is:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sums in the array are:");
            for (i = 0; i < n; i++)
            {
                k = array[i] + array[i];
                Console.WriteLine("{0}={1}+{2}", k, array[i], array[i]);

                if (k == z)
                {
                    s++;
                }
            }
            Console.WriteLine("{0} number's sum is {1}", s, z);
        }
    }
}

