using System;

class AlphabetArray
{
    static void Main()
    {
        int[] letters = new int[53];
        for (int i = 1; i < letters.Length / 2 + 1; i++)
        {
            letters[i] = ('a' - 1) + i;
        }
        for (int i = letters.Length / 2 + 1, j = 0; i < letters.Length; i++, j++)
        {
            letters[i] = 'A' + j;
        }

        Console.WriteLine("Enter a word");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (word[i] == letters[j])
                {
                    Console.WriteLine("{0} has index {1} ", word[i], letters[j]);
                    break;
                }
            }
        }
    }
}