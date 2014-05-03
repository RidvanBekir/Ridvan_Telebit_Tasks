using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers: such that 1 < a1 < … < a10 < 100


class ReadNumberStartEnd
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException("The number is either too big or too small");
        }
        return number;
    }

    static void Main()
    {
        int end = 100;
        int start = 1;
        for (int i = 1; i < end; i++)
        {
            start = ReadNumber(start, end);
        }
    }
}