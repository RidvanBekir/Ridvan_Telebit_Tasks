using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToHex
{
    static string BinToDecimal(string binNum)
    {
        int length = binNum.Length;
        int numInBinary = int.Parse(binNum);
        int[] inBinary = new int[length];
        int inDecimal = 0;
        string hexPart = "";

        for (int i = 0; i < length; i++)
        {
            inBinary[i] = numInBinary % 10;
            numInBinary /= 10;
        }
        for (int i = 0; i < length; i++)
        {
            int binPosValue = (int)Math.Pow(2, i) * inBinary[i];
            inDecimal += binPosValue;
        }
        switch (inDecimal)
        {
            case 10:
                hexPart = "A";
                break;
            case 11:
                hexPart = "B";
                break;
            case 12:
                hexPart = "C";
                break;
            case 13:
                hexPart = "D";
                break;
            case 14:
                hexPart = "E";
                break;
            case 15:
                hexPart = "F";
                break;
            default:
                hexPart = inDecimal.ToString();
                break;
        }
        return hexPart;
    }
    static void Main()
    {
        Console.Write("Enter the binary number: ");
        string binNum = Console.ReadLine();
        List<string> hexNumReversed = new List<string>();
        int length = binNum.Length;
        int index = 0;
        string quarter = "";
        while (index < length)
        {
            quarter += binNum[index];
            if (quarter.Length == 4)
            {
                hexNumReversed.Add(BinToDecimal(quarter));
                quarter = "";
            }
            else if (index + 1 == length)
            {
                hexNumReversed.Add(BinToDecimal(quarter));
            }
            index++;
        }
        hexNumReversed.Reverse();
        Console.Write("The number in hex is: ");
        foreach (var item in hexNumReversed)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}