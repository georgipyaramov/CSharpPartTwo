//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FillingIncompleteString
{
    static void Main()
    {
        Console.Write("Enter a string, no more than 20 chars long: ");
        string inText = Console.ReadLine();
        string resultText = inText;
        for (int i = inText.Length; i < 20; i++)
        {
            resultText += "*";
        }
        Console.WriteLine("Result:");
        Console.WriteLine(resultText);
    }
}

