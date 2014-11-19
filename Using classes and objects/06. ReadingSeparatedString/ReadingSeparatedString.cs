/*You are given a sequence of positive integer values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461*/

using System;
using System.Collections.Generic;

class ReadingSeparatedString
{
    static int SomOfNumbersInString(string s)
    {
        int sum = 0;
        bool canBe;
        int someNum = 0;
        string tempStrToParse = null;
        List<int> list = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            canBe = int.TryParse(s[i].ToString(), out someNum);
            if (canBe)
            {
                tempStrToParse += someNum.ToString();
            }
            else
            {
                list.Add(int.Parse(tempStrToParse));
                tempStrToParse = null;
            }
            if (i == s.Length - 1)
            {
                list.Add(int.Parse(tempStrToParse));
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum;
    }
    static void Main()
    {
        string num = "43 68 9 23 318";
        Console.WriteLine(SomOfNumbersInString(num));
    }
}

