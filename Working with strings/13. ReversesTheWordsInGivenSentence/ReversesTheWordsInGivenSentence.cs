//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReversesTheWordsInGivenSentence
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] separators = new string[] {" ", ",", "!"};
        string[] wordsAsTheyAre = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(wordsAsTheyAre);
        Console.WriteLine(sentence);
        Console.WriteLine(string.Join(" ", wordsAsTheyAre) + "!");
    }
}

