/*Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.*/

using System;
using System.IO;

class AddLineNumberToText
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter("wholeText.txt");
        StreamReader reader = new StreamReader("textFile.txt");
        using (writer)
        {
            using (reader)
            {
                int lineNumber = 1;
                string lineOfText = reader.ReadLine();
                while (lineOfText != null)
                {
                    writer.WriteLine(lineNumber + " " + lineOfText);
                    lineOfText = reader.ReadLine();
                    lineNumber++;

                }
            }
        }
    }
}

