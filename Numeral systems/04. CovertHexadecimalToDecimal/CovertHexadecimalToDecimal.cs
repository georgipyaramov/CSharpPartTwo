/*Write a program to convert hexadecimal numbers to their decimal representation.*/

using System;

class CovertHexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();
        int decimNum = 0;
        int tempNum = 0;
        int index = 0;
        bool canBeParsed;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            canBeParsed = int.TryParse(hexNum[index].ToString(), out tempNum);
            if (canBeParsed == false)
            {
                switch (hexNum[index])
                {
                    case 'A': tempNum = 10;
                        break;
                    case 'B': tempNum = 11;
                        break;
                    case 'C': tempNum = 12;
                        break;
                    case 'D': tempNum = 13;
                        break;
                    case 'E': tempNum = 14;
                        break;
                    case 'F': tempNum = 15;
                        break;
                    default:
                        break;
                }
            }
            decimNum += tempNum * (int)Math.Pow(16, i);
            index++;
        }
        Console.WriteLine();
        Console.WriteLine("The number {0} in hexadecimal numberal system \nis number {1} in decimal numeral system.", hexNum, decimNum);
    }
}

