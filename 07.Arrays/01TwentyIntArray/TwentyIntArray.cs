using System;

class TwentyIntArray
{
    static void Main()
    {
        int[] arr = new int[20];

        for (int i = 0; i < 20; i++)
        {
            arr[i] = i * 5;
        }

        foreach (var number in arr)
        {
            Console.WriteLine(number);
        }
    }
}
