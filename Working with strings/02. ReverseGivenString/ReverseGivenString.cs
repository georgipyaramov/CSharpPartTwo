//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseGivenString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inString = Console.ReadLine();
        string revString = null;
        for (int i = 0; i < inString.Length; i++)
        {
            revString += inString[inString.Length - 1 - i];
        }
        Console.WriteLine("The reversed string is: " + revString);
    }
}

