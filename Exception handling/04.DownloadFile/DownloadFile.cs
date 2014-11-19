using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        /*Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
         * Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.*/

        string server = "http://www.devbg.org/img/";
        string file = "Logo-BASD.jpg";
        string webAddress = null;
        WebClient download = new WebClient();
        webAddress = server + file;

        try
        {
            download.DownloadFile(webAddress, file);
            Console.WriteLine("Successfully downloaded!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        catch (WebException)
        {
            Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.\n-or- \nfilename is null or Empty.\n-or-\nThe file does not exist.\n-or- An error occurred while downloading data.");
        }
        finally
        {
            download.Dispose();
        }
    }
}

