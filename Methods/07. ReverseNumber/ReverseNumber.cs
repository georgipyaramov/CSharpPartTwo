using System;
using System.Text;

class ReverseNumber
{
    static string ReverseGivenNumber(string strNum)
    {
        char[] arrOfChars = new char[strNum.Length];
        for (int i = 0; i < strNum.Length; i++)
        {
            arrOfChars[i] = strNum[i];
        }
        Array.Reverse(arrOfChars);
        StringBuilder reversed = new StringBuilder();
        reversed.Append(arrOfChars);
        string revNum = reversed.ToString();
        return revNum;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        string inputNum = Console.ReadLine();
        string reversed = ReverseGivenNumber(inputNum);
        Console.WriteLine(reversed);
    }
}

