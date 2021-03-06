﻿/*Write a program to convert hexadecimal numbers to binary numbers (directly).*/

using System;
class ConvertHexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        string[] binNum = new string[4];
        string temp = null;
        int i;
        for (i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[i])
            {
                case '0': temp = "0000";
                    break;
                case '1': temp = "0001";
                    break;
                case '2': temp = "0010";
                    break;
                case '3': temp = "0011";
                    break;
                case '4': temp = "0100";
                    break;
                case '5': temp = "0101";
                    break;
                case '6': temp = "0110";
                    break;
                case '7': temp = "0111";
                    break;
                case '8': temp = "1000";
                    break;
                case '9': temp = "1001";
                    break;
                case 'A': temp = "1010";
                    break;
                case 'B': temp = "1011";
                    break;
                case 'C': temp = "1100";
                    break;
                case 'D': temp = "1101";
                    break;
                case 'E': temp = "1110";
                    break;
                case 'F': temp = "1111";
                    break;
                default:
                    break;
            }
            binNum[i] = temp;
        }
        int howManyMore = 4 - hexNum.Length;
        for (int j = 0; j < howManyMore; j++)
        {
            binNum[i] = "0000";
            Array.Reverse(binNum);
        }        
        Console.WriteLine(string.Join("", binNum));
    }
}