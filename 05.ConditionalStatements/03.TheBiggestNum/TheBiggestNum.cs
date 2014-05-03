using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding the biggest number of 3 integers");
            Console.Write("Enter value for the first variable:");
            int firstNum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second variable:");
            int secondNum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the third variable:");
            int thirdNum = int.Parse(Console.ReadLine());
            int biggestNum;
            if (secondNum1 > firstNum1 && secondNum1 > thirdNum)
            {
                biggestNum = secondNum1;
                Console.WriteLine("The biggest number is : {0}", biggestNum);
            }
            if (thirdNum > firstNum1 && thirdNum > secondNum1)
            {
                biggestNum = thirdNum;
                Console.WriteLine("The biggest number is : {0}", biggestNum);
            }
            if (firstNum1 > secondNum1 && firstNum1 > thirdNum)
            {
                biggestNum = firstNum1;
                Console.WriteLine("The biggest number is : {0}", biggestNum);
            }
            Console.WriteLine("\n\n");
        }
    }
}
