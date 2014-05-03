using System;

class BinarySearch
{
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array);
        int maxIndex = array.Length - 1;
        int minIndex = 0;
        while (maxIndex >= minIndex)
        {
            int iMidpoint = (minIndex + maxIndex) / 2;
            if (array[iMidpoint] < key)
            {
                minIndex = iMidpoint + 1;
            }
            else if (array[iMidpoint] > key)
            {
                maxIndex = iMidpoint - 1;
            }
            else
            {
                return iMidpoint;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] myArray = { 4, 3, 1, 4, 2, 5, 8, 21, 13, 180 };
        int key = 8;
        Console.WriteLine(BinSearch(myArray, key));
    }
}