using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4.Checking if the third digit is 7");
            int myDigit;
            bool a = true;
            bool b = false;
            Console.Write("enter a number:");
            myDigit = int.Parse(Console.ReadLine());
            int third = (myDigit / 100) % 10;
            Console.Write("Is the third digit 7:");
            if (third == 7)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.Write(b);
            }
            Console.WriteLine("\n\n");
        }
    }
}
