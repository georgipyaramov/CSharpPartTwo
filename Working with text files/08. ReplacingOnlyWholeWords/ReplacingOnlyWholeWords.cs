/*Modify the solution of the previous problem to replace only whole words (not substrings).*/

using System;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

class ReplacingOnlyWholeWords
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
                    writer.WriteLine(Regex.Replace(line, @"(\W|^)start(\W|$)", "$1finish$2"));
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