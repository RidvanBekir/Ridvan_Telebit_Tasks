using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[] myArray = { 2, 3, -6, 36, 12, -1, 6, 4, -8, 8 };
        int currentSum = 0;
        int maxSum = int.MinValue;
        StringBuilder maxSequenceBuild = new StringBuilder();
        string maxSequnce = "";

        for (int i = 0; i < myArray.Length; i++)
        {
            currentSum += myArray[i];
            maxSequenceBuild.AppendFormat("{0} ", myArray[i]);
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxSequnce = maxSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                currentSum = 0;
                maxSequenceBuild.Clear();
            }
        }
        Console.WriteLine("The max sequence is: \"{0}\"", maxSequnce);
        Console.WriteLine("The max sum is: {0} ", maxSum);
    }
}
