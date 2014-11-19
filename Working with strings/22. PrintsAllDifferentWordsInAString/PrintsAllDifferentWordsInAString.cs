//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintsAllDifferentWordsInAString
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        //string text = Console.ReadLine();
        string text = "Write a program that reads a string from the console and lists all different"
        + "words in the string along with information how many times each word is found ."
        + "words in the string along with information Write a program that reads a string .";
        List<string> uniqeWords = new List<string>();
        string[] allWords = text.Split(' ', '.');
        bool isNotTheSame = true;
        int counter = 0;
        for (int i = 0; i < allWords.Length; i++)
        {
            isNotTheSame = true;
            for (int j = 0; j < uniqeWords.Count; j++)
            {
                if (allWords[i] == uniqeWords[j])
                {
                    isNotTheSame = false;
                    break;
                }
            }
            if (isNotTheSame)
            {
                uniqeWords.Add(allWords[i]);
            }
        }        
        for (int i = 0; i < uniqeWords.Count; i++)
        {
            for (int j = 0; j < allWords.Length; j++)
            {
                if (uniqeWords[i] == allWords[j])
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine("{0} ---> {1} times", uniqeWords[i], counter);
            }
            counter = 0;
        }

    }
}

