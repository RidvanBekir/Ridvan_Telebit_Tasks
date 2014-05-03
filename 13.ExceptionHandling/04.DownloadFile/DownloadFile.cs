using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        string destination = @"C:\Users\Mumun\Desktop\logo.jpg";
        string urlPath = "http://www.devbg.org/img/Logo-BASD.jpg";
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile(urlPath, destination);
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid.");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }        
    }
}