/*Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array.*/

using System;

class PrintTheIndexOfEveryLetter
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65);
        }
        Console.Write("Type in a word : ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("The index of char {0}  in the word is {1}", word[i], j);
                    break;
                }
            }
        }
    }
}

