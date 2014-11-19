/*Write a program to convert decimal numbers to their hexadecimal representation.*/

using System;
class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimNum = int.Parse(Console.ReadLine());
        string tempHexNum = null;
        int tempNum = 0;
        string tempString = null;
        string hexNum = null;
        while (decimNum > 0)
        {
            tempNum = decimNum % 16;
            if (tempNum > 9)
            {
                switch (tempNum)
                {
                    case 10: tempString = "A";
                        break;
                    case 11: tempString = "B";
                        break;
                    case 12: tempString = "C";
                        break;
                    case 13: tempString = "D";
                        break;
                    case 14: tempString = "E";
                        break;
                    case 15: tempString = "F";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                tempString = tempNum.ToString();
            }
            tempHexNum += tempString;
            decimNum /= 16;            
        }
        for (int i = tempHexNum.Length - 1; i >= 0; i--)
        {
            hexNum += tempHexNum[i];
        }
        Console.WriteLine();
        Console.WriteLine("The number {0} in decimal numberal system is number {1} in hexadecimal numeral system.", hexNum, decimNum);
    }
}

