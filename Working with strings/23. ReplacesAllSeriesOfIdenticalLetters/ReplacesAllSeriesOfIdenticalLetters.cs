//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class ReplacesAllSeriesOfIdenticalLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        //string text = Console.ReadLine();
        string text = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));
    }
}

