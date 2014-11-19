/*Write a program that reads a text file and prints on the console its odd lines.*/
using System;
using System.IO;
class ReadTextFileAndPrintTheOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("textFile.txt");
        using (reader)
        {
            int lineNumber = 0;
            string lineOfText = reader.ReadLine();
            while (lineOfText != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0) //If you delete this line you can see the whole text
                {
                    Console.WriteLine(lineOfText);
                }
                lineOfText = reader.ReadLine();
            }

        }
    }
}

