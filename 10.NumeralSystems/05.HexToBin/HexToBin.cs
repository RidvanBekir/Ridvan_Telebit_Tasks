using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToBin
{
    static string DecimalToBin(int decimalNum)
    {
        List<int> binNum = new List<int>();
        StringBuilder binNumSB = new StringBuilder();

        while (decimalNum > 0)
        {
            int remainder = decimalNum % 2;
            decimalNum /= 2;
            binNum.Add(remainder);
        }

        binNum.Reverse();
        foreach (var item in binNum)
        {
            binNumSB.Append(item);
        }
        string binaryNum = binNumSB.ToString();
        switch (binaryNum.Length)
        {
            case 1:
                binaryNum = "000" + binaryNum;
                break;
            case 2:
                binaryNum = "00" + binaryNum;
                break;
            case 3:
                binaryNum = "0" + binaryNum;
                break;
            default:
                break;
        }
        return binaryNum;
    }

    static void Main()
    {
        Console.Write("Enter a number in hex with the prefix 0x: ");
        string numWithPrefix = Console.ReadLine();
        string numInHex = numWithPrefix.Substring(numWithPrefix.IndexOf('x') + 1);
        List<char> inHex = new List<char>();
        foreach (char item in numInHex)
        {
            inHex.Add(item);
        }
        inHex.Reverse();
        int count = inHex.Count;
        int index = 0;
        List<string> numInBin = new List<string>();
        while (index < count)
        {
            switch (inHex[index])
            {
                case 'A':
                case 'a':
                    numInBin.Add(DecimalToBin(10));
                    break;
                case 'B':
                case 'b':
                    numInBin.Add(DecimalToBin(11));
                    break;
                case 'C':
                case 'c':
                    numInBin.Add(DecimalToBin(12));
                    break;
                case 'D':
                case 'd':
                    numInBin.Add(DecimalToBin(13));
                    break;
                case 'E':
                case 'e':
                    numInBin.Add(DecimalToBin(14));
                    break;
                case 'F':
                case 'f':
                    numInBin.Add(DecimalToBin(15));
                    break;
                default:
                    int actualNum = (int)inHex[index] - 48;
                    numInBin.Add(DecimalToBin(actualNum));
                    break;
            }
            index++;
        }
        numInBin.Reverse();
        Console.Write("The number in binary is: ");
        foreach (var item in numInBin)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}