//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintANumberDifferentWays
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        string numAsHex = "0x" + number.ToString("X").PadLeft(4, '0');
        Console.WriteLine("{0,15:F}", number);
        Console.WriteLine("{0,15}",numAsHex);
        Console.WriteLine("{0,15:P}", number);
        Console.WriteLine("{0,15:E}", number);
    }
}

