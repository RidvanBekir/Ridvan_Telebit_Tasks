using System;

class EqualElements
{
    static void Main()
    {
        Console.WriteLine("Enter array length");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        for (int i = 1; i < length + 1; i++)
        {
            Console.WriteLine("Enter element number {0} of the array.", i);
            arr[i - 1] = int.Parse(Console.ReadLine());
        }

        int sequence = 1;
        int maxSequence = 0;
        int element = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                sequence++;
            }
            else
            {
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    element = arr[i];
                }
                sequence = 1;
            }
        }

        if (sequence > maxSequence)
        {
            maxSequence = sequence;
            element = arr[arr.Length - 1];
        }

        Console.WriteLine("The maximal sequence of equal elements consists of {0} {1}s.", maxSequence, element);
    }
}
