//Write a program that parses an URL address given in the format:
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractElementsFromURL
{
    static void Main()
    {
        Console.WriteLine("Enter a URL: ");
        //string url = Console.ReadLine();
        string url = "http://www.devbg.org/forum/index.php"; //This URL is for testing.
        int indexOfProtocol = url.IndexOf("://");
        int indexOfServer = url.IndexOf("/", indexOfProtocol + 3);
        int indexOfResource = url.IndexOf("/", indexOfServer + 1);
        string protocol = null;
        string server = null;
        string resource = null;
        for (int i = 0; i < url.Length; i++)
        {
            if (i < indexOfProtocol)
            {
                protocol += url[i];
            }
            else if (i == indexOfProtocol)
            {
                i += 2;
            }
            else if (i > indexOfProtocol && i < indexOfServer)
            {
                server += url[i];
            }            
            else
            {
                resource += url[i];
            }
        }
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
        
    }
}

