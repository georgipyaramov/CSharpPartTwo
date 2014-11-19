/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines.*/

using System;
using System.IO;
class ComparesTwoTextFiles
{
    static void Main()
    {        
        string lineOfText;
        int sameText = 0;
        int differentText = 0;
        using (StreamReader reader = new StreamReader("textFile.txt"), readerTwo = new StreamReader("otherTextFile.txt"))
        {
		    lineOfText = reader.ReadLine();
            string lineOfTheOtherText = readerTwo.ReadLine();
            while (lineOfTheOtherText != null)
            {
                
                if (string.Compare(lineOfText, lineOfTheOtherText) == 0)
                {
                    sameText++;
                }
                else
                {
                    differentText++;
                }
                lineOfText = reader.ReadLine();
                lineOfTheOtherText = readerTwo.ReadLine();
            }
        }
        Console.WriteLine("In the two texts there are {0} same lines \nand {1} different lines.", sameText, differentText);
    }
}

