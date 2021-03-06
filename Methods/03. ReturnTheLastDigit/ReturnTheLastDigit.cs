﻿/*Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".*/

using System;

class ReturnTheLastDigit
{
    static string GetTheLastDigit(string num)
    {
        char dig = num[num.Length - 1];
        switch (dig)
        {
            case '1': return "One";
            case '2': return "Two";
            case '3': return "Three";
            case '4': return "Four";
            case '5': return "Five";
            case '6': return "Six";
            case '7': return "Seven";
            case '8': return "Eight";
            case '9': return "Nine";
            default: return "Zero";
        }
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine(GetTheLastDigit(number));
    }
}

