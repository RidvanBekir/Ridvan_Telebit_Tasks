using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string file = @"...\...\test.txt";
        StreamReader reader = new StreamReader(file);
        using (reader)
        {
            int line = 0;
            string lineContent = reader.ReadLine();
            while (lineContent != null)
            {
                if (line % 2 != 0)
                {
                    Console.WriteLine(lineContent);
                }
                lineContent = reader.ReadLine();
                line++;
            }
        }
    }
}