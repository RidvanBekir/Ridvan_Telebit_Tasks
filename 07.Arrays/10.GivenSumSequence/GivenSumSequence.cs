using System;
using System.Text;

class GivenSumSequence
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
        string sequence = "";
        StringBuilder sequenceBuild = new StringBuilder();
        int sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = i; j < myArray.Length; j++)
            {
                sum += myArray[j];
                sequenceBuild.AppendFormat("{0} ", myArray[j]);
                if (sum > s)
                {
                    sequenceBuild.Clear();
                    sum = 0;
                    break;
                }
                if (sum == s)
                {
                    sequence = sequenceBuild.ToString();
                    Console.WriteLine("This sequence adds up to {0} : {1}", s, sequence);
                }
            }
        }
    }
}