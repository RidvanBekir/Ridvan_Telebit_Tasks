using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHex
{
    static void Main()
    {
        Console.Write("Enter a number in decimal: ");
        int numDecimal = int.Parse(Console.ReadLine());
        List<string> inHex = new List<string>();
        while (numDecimal > 0)
        {
            int remainder = numDecimal % 16;
            numDecimal /= 16;
            switch (remainder)
            {
                case 10:
                    inHex.Add("A");
                    break;
                case 11:
                    inHex.Add("B");
                    break;
                case 12:
                    inHex.Add("C");
                    break;
                case 13:
                    inHex.Add("D");
                    break;
                case 14:
                    inHex.Add("E");
                    break;
                case 15:
                    inHex.Add("F");
                    break;
                default:
                    inHex.Add(remainder.ToString());
                    break;
            }
        }
        inHex.Reverse();
        Console.Write("It's hexadecimal representation is: 0x");
        foreach (var item in inHex)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}