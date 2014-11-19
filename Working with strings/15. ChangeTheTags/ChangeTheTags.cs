//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ChangeTheTags
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http:/" + "/academy.telerik.com\">our site</a> to choose a training course."
        + "Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string[] wordsToReplace = new string[] { "</a>", "<a href=\"", "\">" };
        string[] replacementWords = new string[] { "/URL]", "[URL=",  "]" };
        for (int i = 0; i < wordsToReplace.Length; i++)
        {
            text = text.Replace(wordsToReplace[i], replacementWords[i]);
        }
        Console.WriteLine(text);
    }
}

