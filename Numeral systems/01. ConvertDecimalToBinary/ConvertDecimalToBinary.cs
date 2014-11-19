/*Write a program to convert decimal numbers to their binary representation.*/

using System;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimNum = int.Parse(Console.ReadLine());
        string tempBinNum = null;
        string binNum = null;
        while (decimNum > 0)
        {
            tempBinNum += decimNum % 2;
            decimNum /= 2;
        }
        for (int i = tempBinNum.Length - 1; i >= 0; i--)
        {
            binNum += tempBinNum[i];
        }
        Console.WriteLine();
        Console.WriteLine("The number {0} in decimal numberal system is number {1} in binary numeral system.", decimNum, binNum);

    }
}

