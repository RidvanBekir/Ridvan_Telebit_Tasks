using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting 3 real values in descending order");
            Console.Write("Enter value for the first variable:");
            int firstNum2 = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the second variable:");
            int secondNum2 = int.Parse(Console.ReadLine());
            Console.Write("Enter value for the third variable:");
            int thirdNum2 = int.Parse(Console.ReadLine());
            if (thirdNum2 > secondNum2 && thirdNum2 > firstNum2)
            {
                if (secondNum2 > firstNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", thirdNum2, secondNum2, firstNum2);
                }
                else if (firstNum2 > secondNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", thirdNum2, firstNum2, secondNum2);
                }
            }
            if (secondNum2 > thirdNum2 && secondNum2 > firstNum2)
            {
                if (thirdNum2 > firstNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", secondNum2, thirdNum2, firstNum2);
                }
                else if (firstNum2 > thirdNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", secondNum2, firstNum2, thirdNum2);
                }
            }
            if (firstNum2 > thirdNum2 && firstNum2 > secondNum2)
            {
                if (thirdNum2 > secondNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", firstNum2, thirdNum2, secondNum2);
                }
                else if (secondNum2 > thirdNum2)
                {
                    Console.WriteLine("The descending order of the values is:{0} {1} {2}", firstNum2, secondNum2, thirdNum2);
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
