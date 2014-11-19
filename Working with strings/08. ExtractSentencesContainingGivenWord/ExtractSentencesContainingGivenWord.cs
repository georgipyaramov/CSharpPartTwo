//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractSentencesContainingGivenWord
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. "
        + "o we are drinking all the day. We will move out of it in 5 days.";
        string[] separator = new string[] {". ", "."};
        string[] result;
        result = text.Split(separator, StringSplitOptions.None);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] += ".";
            if (result[i].IndexOf(" in ") != -1)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}

