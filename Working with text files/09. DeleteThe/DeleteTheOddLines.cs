/*Write a program that deletes from given text file all odd lines. The result should be in the same file.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeleteTheOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("textFile.txt");
        List<string> list = new List<string>();
        using (reader)
        {
            int lineNumber = 0;
            string lineOfText = reader.ReadLine();
            while (lineOfText != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 0) //If you delete this line you can see the whole text
                {
                    list.Add(lineOfText);
                }
                lineOfText = reader.ReadLine();
            }
        }
        using (StreamWriter writer = new StreamWriter("textFile.txt"))
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }
        }
    }
}

