/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;

class CovnvertBinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binNum = Console.ReadLine();
        int hexArrLength = binNum.Length / 4;
        int remainder = binNum.Length % 4;
        if (remainder != 0)
        {
            hexArrLength++;
        }
        string[] binNumArr = new string[hexArrLength];
        int stringIndex = 0;
        for (int i = 0; i < hexArrLength; i++)
        {
            if (remainder != 0 && i == 0)
            {
                remainder = 4 - remainder;
                for (int k = 0; k < remainder; k++)
                {
                    binNumArr[i] += "0";
                }
                
            }
            for (int j = 0 + remainder; j < 4 && stringIndex < binNum.Length; j++)
            {

                binNumArr[i] += binNum[stringIndex];
                stringIndex++;
                remainder = 0;
            }
            
        }
        string[] hexNum = new string[hexArrLength];
        string temp = null;
        for (int i = 0; i < binNumArr.Length; i++)
        {
            switch (binNumArr[i])
            {
                case "0000": temp = "0";
                    break;
                case "0001": temp = "1";
                    break;
                case "0010": temp = "2";
                    break;
                case "0011": temp = "3";
                    break;
                case "0100": temp = "4";
                    break;
                case "0101": temp = "5";
                    break;
                case "0110": temp = "6";
                    break;
                case "0111": temp = "7";
                    break;
                case "1000": temp = "8";
                    break;
                case "1001": temp = "9";
                    break;
                case "1010": temp = "A";
                    break;
                case "1011": temp = "B";
                    break;
                case "1100": temp = "C";
                    break;
                case "1101": temp = "D";
                    break;
                case "1110": temp = "E";
                    break;
                case "1111": temp = "F";
                    break;
                default:
                    break;
            }
            hexNum[i] = temp;
        }
        Console.WriteLine(string.Join("", hexNum));
    }
}

