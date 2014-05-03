using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }

        //int[] myArray = { 12, 12, 12, 11, 11, 11, 7, 8, 9 };

        string bestSeq = "";
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLen = myArray.Length;

        for (int i = 0; i < arrayLen; i++)
        {
            string currentSeq = "";

            if (i + k > arrayLen)
            {
                break;
            }
            for (int j = i; j < i + k; j++)
            {
                sum += myArray[j];
                currentSeq = currentSeq + ' ' + myArray[j];
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                bestSeq = currentSeq;
            }
            
            sum = 0;
        }
        Console.WriteLine(bestSeq);
        Console.WriteLine(bestSum);
    }
}