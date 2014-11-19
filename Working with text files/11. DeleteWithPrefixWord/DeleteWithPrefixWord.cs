//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWithPrefixWord
{
    static void Main()
    {
        List<string> array = new List<string>();
        string file = "file.txt";

        //Writes test file 
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("This is test line - (remains the same)");
            writer.WriteLine("This is just a testtext text - (testtext word removed)");

        }

        //Print and delete words with test prefix
        Console.WriteLine("Original:");
        Console.WriteLine("----------");
        StreamReader reader = new StreamReader(file);
        string pattern = @"\stest\w+";
        Regex rgx = new Regex(pattern);
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = rgx.Replace(line, " ");
                array.Add(line);
                line = reader.ReadLine();
            }
        }

        //Write the new text to file
        using (StreamWriter writer = new StreamWriter(file))
        {
            for (int i = 0; i < array.Count; i++)
            {
                writer.WriteLine(array[i]);
            }
        }
        Console.WriteLine();

        //Print file after remove
        Console.WriteLine("With removed words with test prefix:");
        Console.WriteLine("----------");
        using (reader = new StreamReader(file))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}
