using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());
        List<int> binNum = new List<int>();

        while (decimalNum > 0)
        {
            int remainder = decimalNum % 2;
            decimalNum /= 2;
            binNum.Add(remainder);
        }

        binNum.Reverse();
        Console.Write("It's binary representation is: ");
        foreach (int item in binNum)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}