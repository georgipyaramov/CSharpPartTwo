//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class HowManyTimesASubstringОccurs
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else."
            +"\nInside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        int index = -1;
        int counter = 0;
        do
        {
            index = text.ToLower().IndexOf(substring, index + 1);
            if (index != -1)
            {
                counter++;
            }            
        } while (index != -1);
        Console.WriteLine("The substring \"in\" ocurres {0} times in the text.", counter);
    }
}

