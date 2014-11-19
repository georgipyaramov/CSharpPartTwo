//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ChangeATextInSomeRegions
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        List<string> textParts = new List<string>();
        string changedText = null;
        string toAppend = null;
        int indexOpenTag = text.IndexOf("<upcase>");
        int indexCloseTag = text.IndexOf("</upcase>");
        for (int i = 0; i < text.Length; i++)
        {
            if (i < indexOpenTag && indexOpenTag < indexCloseTag)
            {
                toAppend += text[i];                
            }
            else if (i == indexOpenTag)
            {
                textParts.Add(toAppend);
                toAppend = null;
                i += 7;
                indexOpenTag = text.IndexOf("<upcase>", i);
            }
            else if (i < indexCloseTag)
            {
                toAppend += text[i];
            }
            else if (i == indexCloseTag)
            {
                textParts.Add(toAppend.ToUpper());
                toAppend = null;
                i += 9;
                indexCloseTag = text.IndexOf("</upcase>", i);
            }
            if (indexOpenTag == -1 && indexCloseTag == -1)
            {
                toAppend += text[i];
                if (true)
                {
                    if (i == text.Length - 1)
                    {
                        textParts.Add(toAppend);                        
                    }
                }
            }
        }
        changedText = string.Join("", textParts);
        Console.WriteLine("Original text:");
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("Edited text:");
        Console.WriteLine(changedText);
    }
}

