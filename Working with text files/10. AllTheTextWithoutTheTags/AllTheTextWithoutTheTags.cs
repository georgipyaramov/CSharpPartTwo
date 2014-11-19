/*Write a program that extracts from given XML file all the text without the tags. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class AllTheTextWithoutTheTags
{
    static void Main()
    {

        string currentLine;
        string textToExtract = null;
        int index;
        using (StreamReader reader = new StreamReader("textFile.txt"))
        {
            currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                textToExtract = null;
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (currentLine[i] == '<')
                    {
                        index = currentLine.IndexOf('>', i);
                        i = index;
                    }
                    else
                    {
                        textToExtract += currentLine[i];
                    }
                }
                currentLine = reader.ReadLine();
                Console.WriteLine(textToExtract);
            } 
        }
    }
}

