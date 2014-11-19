/*Write a program to convert binary numbers to their decimal representation.*/

using System;
using System.Numerics;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binNum = Console.ReadLine();
        int decimNum = 0;
        int tempNum = 0;
        int index = 0;
        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            tempNum = int.Parse(binNum[index].ToString());
            decimNum += tempNum * (int)Math.Pow(2, i);
            index++;
        }
        Console.WriteLine();
        Console.WriteLine("The number {0} in binary numberal system is number {1} in decimal numeral system.",binNum ,decimNum);
    }
}

