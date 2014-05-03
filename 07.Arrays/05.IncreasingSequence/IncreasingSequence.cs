using System;

class IncreasingSequence
{
    static void Main()
    {
        //Console.WriteLine("Enter array length");
        //int length = int.Parse(Console.ReadLine());
        int[] arr = { 0, 1, 2, 3, 4, 2, 3, 4, 5, 6, 7, 8, 30, 2, 3 };

        //for (int i = 1; i < length + 1; i++)
        //{
        //    Console.WriteLine("Enter element number {0} of the array.", i);
        //    arr[i - 1] = int.Parse(Console.ReadLine());
        //}

        int sequence = 1;
        int maxSequence = 0;
        int endIndex = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                sequence++;
            }
            else
            {
                if (sequence > maxSequence)
                {
                    maxSequence = sequence;
                    endIndex = i;
                }
                sequence = 1;
            }
        }

        if (sequence > maxSequence)
        {
            maxSequence = sequence;
            endIndex = arr.Length - 1;
        }

        sequence = 1;
        Console.WriteLine("The longest sequence of increasing elements is:");
        Console.Write("{");
        for (int i = endIndex - maxSequence + 1; i < endIndex + 1; i++)
        {
            if (i != endIndex)
            {
                Console.Write("{0},", arr[i]);
            }
            else
            {
                Console.Write("{0}", arr[i]);
            }
        }
        Console.WriteLine("}");
    }
}
