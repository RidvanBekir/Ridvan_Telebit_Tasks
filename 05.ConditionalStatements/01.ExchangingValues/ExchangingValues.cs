using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangingValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchanging values of two integer variables.");
            Console.Write("Enter value for the first variable:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second variable:");
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                firstNum = firstNum + secondNum;
                secondNum = firstNum - secondNum;
                firstNum = firstNum - secondNum;
                Console.WriteLine("The exchanged values of the variables are:");
                Console.WriteLine("The first number becomes:{0}", firstNum);
                Console.WriteLine("The second number becomes:{0}", secondNum);
            }
            else
            {
                Console.WriteLine("The first variable is not greater than the second one.");
            }
            Console.WriteLine("\n\n");
        }
    }
}
