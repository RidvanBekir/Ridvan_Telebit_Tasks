using System;

class Sorting
{
    static void Main()
    {
        int[] myArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 132, 45, -2, 333 };

        Console.WriteLine("Array before sorting:");
        foreach (var item in myArray)
        {
            Console.Write("{0}, ", item);
        }
        Console.WriteLine();
        for (int i = 0; i < myArray.Length - 1; i++)
        {
            int minElement = i;
            for (int j = i + 1; j < myArray.Length; j++)
            {
                if (myArray[j] < myArray[minElement])
                {
                    minElement = j;
                }
                if (minElement != i)
                {
                    int temp = 0;
                    temp = myArray[i];
                    myArray[i] = myArray[minElement];
                    myArray[minElement] = temp;
                }
            }
        }
        Console.WriteLine("After sorting:");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("{0}, ", myArray[i]);
        }
        Console.WriteLine();
    }
}