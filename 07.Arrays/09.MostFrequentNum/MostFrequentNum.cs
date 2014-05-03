using System;
using System.Collections.Generic;

class MostFrequentNum
{
    static void Main()
    {
        int[] myArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Dictionary<int, int> mostFrequent = new Dictionary<int, int>();
        int bestElement = 0;
        int bestFrequnecy = int.MinValue;
        for (int i = 0; i < myArray.Length; i++)
        {            
            int tempValue;
            if (mostFrequent.TryGetValue(myArray[i], out tempValue))
            {
                mostFrequent[myArray[i]] = tempValue + 1;
            }
            else
            {
                mostFrequent.Add(myArray[i], 1);
            }
        }
        foreach (var item in mostFrequent)
        {
            if (item.Value > bestFrequnecy)
            {
                bestElement = item.Key;
                bestFrequnecy = item.Value;
            }
        }
        Console.WriteLine("The number {0} appears {1} times", bestElement, bestFrequnecy);
    }
}
