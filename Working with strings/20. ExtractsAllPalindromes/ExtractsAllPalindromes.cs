//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractsAllPalindromes
{
    static void Main()
    {
        string text = "blabla ABBA exe almal lamal something";
        string[] allWord = text.Split(' ');
        Console.WriteLine(string.Join(" ", allWord));
        bool isSimetricle = false;
        for (int i = 0; i < allWord.Length; i++)
        {
            for (int j = 0; j < allWord[i].Length / 2; j++)
            {
                if (allWord[i][j] == allWord[i][allWord[i].Length - 1 - j])
                {
                    isSimetricle = true;
                }
                else
                {
                    isSimetricle = false;
                }
            }
            if (isSimetricle)
            {
                Console.WriteLine(allWord[i]);
            }
        }
    }
}

