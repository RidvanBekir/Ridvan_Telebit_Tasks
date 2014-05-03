using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hex number with the prefix \"0x\": ");
        string inputNum = Console.ReadLine();
        string numHex = inputNum.Substring(inputNum.IndexOf("x") + 1);
        int inDecimal = 0;
        int index = 0;
        List<char> hexList = new List<char>();
        foreach (char item in numHex)
        {
            hexList.Add(item);
        }
        hexList.Reverse();
        int length = hexList.Count;
        while (index < length)
        {
            int posValue = 0;
            switch (hexList[index])
            {
                case 'A':
                case 'a':
                    posValue = 10 * (int)Math.Pow(16, index);
                    break;
                case 'B':
                case 'b':
                    posValue = 11 * (int)Math.Pow(16, index);
                    break;
                case 'C':
                case 'c':
                    posValue = 12 * (int)Math.Pow(16, index);
                    break;
                case 'D':
                case 'd':
                    posValue = 13 * (int)Math.Pow(16, index);
                    break;
                case 'E':
                case 'e':
                    posValue = 14 * (int)Math.Pow(16, index);
                    break;
                case 'F':
                case 'f':
                    posValue = 15 * (int)Math.Pow(16, index);
                    break;
                default:
                    //the character '1' has an ASCII code of 49, so casting '1' to int returns 49
                    //by substracting 48 from the result we get the actual number
                    int num = (int)hexList[index] - 48;
                    posValue = num * (int)Math.Pow(16, index);
                    break;
            }
            inDecimal += posValue;
            index++;
        }
        Console.Write("It's decimal representation is: ");
        Console.WriteLine(inDecimal);
    }
}