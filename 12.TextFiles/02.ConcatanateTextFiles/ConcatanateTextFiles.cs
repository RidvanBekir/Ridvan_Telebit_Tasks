using System;
using System.IO;

class ConcatanateTextFiles
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader(@"..\..\firstTest.txt");
        StreamReader secondReader = new StreamReader(@"..\..\secondTest.txt");
        StreamWriter writer = new StreamWriter("endFile.txt");
        using (firstReader)
        {
            using (writer)
            {
                using (secondReader)
                {
                    string firstFile = firstReader.ReadToEnd();
                    string secondFile = secondReader.ReadToEnd();
                    writer.WriteLine(firstFile + secondFile);
                    //writer.WriteLine(secondFile, true);
                }
            }
        }
    }
}