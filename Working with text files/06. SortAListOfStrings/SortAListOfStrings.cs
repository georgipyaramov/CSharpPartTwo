/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.*/
using System;
using System.IO;
using System.Collections.Generic;
class SortAListOfStrings
{
    static void Main()
    {
        List<string> allString = new List<string>();
        string currentLine = null;
        using (StreamReader reader = new StreamReader("textFile.txt"))
        {
            currentLine = reader.ReadLine();
            for (int i = 0; currentLine != null; i++)
            {
                allString.Add(currentLine);
                currentLine = reader.ReadLine();
            }
        }
        allString.Sort();
        using (StreamWriter writer = new StreamWriter("outputTextFile.txt"))
        {
            for (int i = 0; i < allString.Count; i++)
            {
                writer.WriteLine(allString[i]);
            }
        }
    }
}

