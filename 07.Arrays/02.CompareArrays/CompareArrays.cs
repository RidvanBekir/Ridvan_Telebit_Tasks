using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array length:");
        int length = int.Parse(Console.ReadLine());

        int[] firstArr = new int[length];
        int[] secondArr = new int[length];

        Console.WriteLine("Enter first array:");

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter a number:");
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the second array:");

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter a number:");
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i] > secondArr[i])
            {
                Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
            }
            else if (firstArr[i] < secondArr[i])
            {
                Console.WriteLine("{0} < {1}", firstArr[i], secondArr[i]);
            }
            else if (firstArr[i] == secondArr[i])
            {
                Console.WriteLine("{0} = {1}", firstArr[i], secondArr[i]);
            }
        }
    }
}
