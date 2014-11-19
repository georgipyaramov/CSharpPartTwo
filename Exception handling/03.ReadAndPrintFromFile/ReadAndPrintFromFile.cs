using System;
using System.IO;

class ReadAndPrintFromFile
{
    static void Main()
    {
        /*Write a program that enters file name along with its full file path (e.g. C:/WINDOWS\win.ini), 
         * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
         * Be sure to catch all possible exceptions and print user-friendly error messages.*/

        Console.WriteLine("Enter file path and file name: (e.g. C:\\WINDOWS\\win.ini)");
        string file = Console.ReadLine();

        try
        {
            string readText = File.ReadAllText(file);
            Console.WriteLine(readText);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space,\n or contains one or more invalid characters");
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.\nFor example, on Windows-based platforms, paths must be less than 248 characters, \nand file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("path specified a file that is read-only.\n-or-\nThis operation is not supported on the current platform.\n-or-\npath specified a directory.\n-or-\nThe caller does not have the required permission.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
    }
}

