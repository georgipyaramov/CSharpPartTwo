/*Write a program that concatenates two text files into another text file.*/

using System;
using System.IO;
using System.Text;


class ConcatenateTwoTextFiles
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter("wholeText.txt");
        StringBuilder wholeText = new StringBuilder();
        StreamReader reader = new StreamReader("textFile.txt");
        using (writer)
        {
            using (reader)
            {
                string lineOfText = reader.ReadLine();
                while (lineOfText != null)
                {
                    lineOfText = reader.ReadLine();
                    writer.WriteLine(lineOfText);

                }
            }
            reader = new StreamReader("otherTextFile.txt");
            using (reader)
            {
                string lineOfText = reader.ReadLine();
                while (lineOfText != null)
                {
                    lineOfText = reader.ReadLine();
                    writer.WriteLine(lineOfText);
                }
            }
        }
        
        
    }
}

