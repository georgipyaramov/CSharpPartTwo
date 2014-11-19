//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertStringToUnicodeLiterals
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] arrStringToChar = input.ToCharArray();
        string escape = null;
        string result = null;
        for (int i = 0; i < arrStringToChar.Length; i++)
        {
            escape = "\\u" + ((int)arrStringToChar[i]).ToString("X").PadLeft(4, '0');
            result += escape;
            escape = null;
        }
        Console.WriteLine(result);
    }
}

