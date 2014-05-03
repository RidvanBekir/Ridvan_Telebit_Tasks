using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingFactorials2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating N!*K! / (K-N)! for given N and K (1<N<K).");
            Console.WriteLine("K must be grater than N !!!");
            Console.Write("Enter a number for N=");
            int Nfac1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for K=");
            int Kfac1 = int.Parse(Console.ReadLine());
            int factorial2 = 1;
            int factorial3 = 1;
            int factorial4 = 1;
            int res = (Kfac1 - Nfac1);

            if (Kfac1 > Nfac1)
            {
                do
                {
                    factorial4 *= res;
                    res--;
                    factorial2 *= Nfac1;
                    Nfac1--;
                    factorial3 *= Kfac1;
                    Kfac1--;
                }
                while (Nfac1 > 0 && Kfac1 > 0 && res > 0);
                float result1 = (factorial3 * factorial2) / factorial4;
                Console.Write("The result N!*K! / (K-N)!= {0:0.00}", result1);
            }
            else
            {
                Console.WriteLine("K must be grater than N");
            }
            Console.WriteLine("\n\n");
        }
    }
}
