using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatingFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating N!/K! for given N and K.");
            Console.Write("Enter a number for N=");
            int Nfac = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for K=");
            int Kfac = int.Parse(Console.ReadLine());
            int factorial = 1;
            int factorial1 = 1;
            if (Nfac > Kfac)
            {
                do
                {
                    factorial *= Nfac;
                    Nfac--;
                    factorial1 *= Kfac;
                    Kfac--;
                }
                while (Nfac > 0 && Kfac > 0);
                float result = factorial / factorial1;
                Console.Write("The result N!/K!={0:0.00}", result);
            }
            else
            {
                Console.WriteLine("N must be greater than K !!!");
            }
            Console.WriteLine("\n\n");
        }
    }
}
