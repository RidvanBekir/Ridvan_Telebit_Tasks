using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Compare two words lexicographically.");
        Console.WriteLine("Enter a word:");
        string firstWord = Console.ReadLine();
        Console.WriteLine("Enter a word:");
        string secondWord = Console.ReadLine();

        int length = secondWord.Length;

        if (firstWord.Length != secondWord.Length)
        {
            Console.WriteLine("{0} != {1}", firstWord, secondWord);
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                if (firstWord[i] == secondWord[i])
                {
                    Console.WriteLine("{0} = {1}", firstWord[i], secondWord[i]);
                }
                else
                {
                    Console.WriteLine("{0} != {1}", firstWord[i], secondWord[i]);
                }
            }
        }
    }
}