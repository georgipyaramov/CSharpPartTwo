/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).*/

using System;
using System.IO;
using System.Diagnostics;
using System.Text;

class ReplaceSubstring
{
    static void Main()
    {
        string[] words = { "something", " ", "\r\n", "start", " start " };

        string fileName = "testFile.txt";
        string resultFileName = "resultFile.txt";
        Random randomGenerator = new Random();

        StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
        using (writer)
        {
            for (int i = 0; i < 100; i++)
            {
                writer.Write(words[randomGenerator.Next(words.Length)]);
            }
        }

        writer = new StreamWriter(resultFileName, false, Encoding.GetEncoding("windows-1251"));
        StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));

        string line;
        using (writer)
        {
            using (reader)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }

        Process openFile = new Process();
        openFile.StartInfo.FileName = fileName;
        openFile.Start();

        openFile.StartInfo.FileName = resultFileName;
        openFile.Start();
    }
}