using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsItPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking if a number is prime.");
            int theNum;
            Console.Write("Enter a number:");
            theNum = int.Parse(Console.ReadLine());
            if (theNum > 100)
            {
                Console.WriteLine("You have entered a number bigger than 100!");
            }
            else
            {
                if (theNum < 3)
                {
                    if (theNum == 2)
                    {
                        Console.WriteLine("{0} is a prime!", theNum);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a prime", theNum);
                    }
                }
                else
                {
                    if (theNum % 2 == 0)
                    {
                        Console.WriteLine("{0} is not a prime", theNum);
                    }
                    else
                    {
                        int div;
                        for (div = 3; theNum % div != 0; div += 2) ;
                        if (div == theNum)
                        {
                            Console.WriteLine("{0} is a prime!", theNum);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not a prime", theNum);
                        }
                    }
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
