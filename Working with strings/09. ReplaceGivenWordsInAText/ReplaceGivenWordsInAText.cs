//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReplaceGivenWordsInAText
{
    static void Main(string[] args)
    {
        string text = "Microsoft announced its next generation PHP compiler today."
        + "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] wordsToReplace = new string[] { "PHP", "CLR", "Microsoft" };
        string[] replacementWords = new string[] { "***", "***", "*********" };
        string result = text;        
        for (int j = 0; j < wordsToReplace.Length; j++)
        {
            result = result.Replace(wordsToReplace[j], replacementWords[j]);
        }        
        Console.WriteLine(result);
    }
}

