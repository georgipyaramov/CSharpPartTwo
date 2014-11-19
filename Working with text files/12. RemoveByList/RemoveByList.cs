//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

class RemoveByList
{
    static void Main()
    {
        string words = "words.txt";
        string text = "text.txt";
        string cleared = "cleared.txt";

        try
        {
            string regex = @"\b(" + String.Join("|", File.ReadAllLines(words)) + @")\b";
            string fileContent = File.ReadAllText(text);
            File.WriteAllText(cleared, Regex.Replace(fileContent, regex, String.Empty, RegexOptions.IgnoreCase));
            Console.WriteLine("Replace Complete!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found!");
        }
        catch (IOException)
        {
            Console.WriteLine("Input/Output Error!");
        }
        catch (SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("File Access Error!");
        }
    }
}