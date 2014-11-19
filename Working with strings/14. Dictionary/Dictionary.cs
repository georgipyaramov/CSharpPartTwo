//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Dictionary
{
    static void Main()
    {
        Console.Write("Enter a word (.NET, CLR or namespace): ");
        string word = Console.ReadLine();
        string[] dictionary = new string[3];
        dictionary[0] = "Platform for applications from Microsoft";
        dictionary[1] = "Managed execution environment for .NET";
        dictionary[2] = "Hierarchical organization of classes";
        if (word == ".NET")
        {
            Console.WriteLine("{0} is {1}", word, dictionary[0]);
        }
        else if (word == "CLR")
        {
            Console.WriteLine("{0} is {1}", word, dictionary[1]);
        }
        else if (word == "namespace")
        {
            Console.WriteLine("{0} is {1}", word, dictionary[2]);
        }
        else
        {
            Console.WriteLine("This word is not in the dictionary.");
        }



    }
}

