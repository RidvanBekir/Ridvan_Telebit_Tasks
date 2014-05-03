using System;
using System.IO;
using System.Security;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.


class ReadTextFromFile
{
    static void Main()
    {
        try
        {
            string path = @"C:\Users\Mumun\Desktop\MoviesToWatch.txt";
            string fileContent = File.ReadAllText(path);
            Console.WriteLine("The file contains the following information: ");
            Console.WriteLine(fileContent);
        }
        catch (ArgumentNullException )
        {
            Console.WriteLine("No file path was given!");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}