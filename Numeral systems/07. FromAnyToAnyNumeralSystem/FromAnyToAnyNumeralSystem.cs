//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
//Site for tests: http://www.kaagaard.dk/service/convert.htm
using System;

class FromAnyToAnyNumeralSystem
{  

    static string AnyNumeralToDec(string num, int numberBase, int numBase)
    {
        int number = 0;
        int count = 0; //count for proper array index access
        string newNum = string.Empty;
        string result = string.Empty;

        for (int i = num.Length - 1; i >= 0; i--) //starts from the highest point for correct power of the numbers
        {
            switch (num[count])
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    newNum = num[count].ToString();
                    break;
                case 'A':
                    newNum = "10";
                    break;
                case 'B':
                    newNum = "11";
                    break;
                case 'C':
                    newNum = "12";
                    break;
                case 'D':
                    newNum = "13";
                    break;
                case 'E':
                    newNum = "14";
                    break;
                case 'F':
                    newNum = "15";
                    break;
                default:
                    break;
            }
            number += int.Parse(newNum) * (int)Math.Pow(numberBase, i);
            count++;
        }

        result = DecToAnyNumeral(number, numBase);

        return result;
    }

    static string DecToAnyNumeral(int num, int numBase)
    {
        string result = string.Empty;
        string newNum = string.Empty;
        int remainder = 0;

        while (num > 0)
        {
            remainder = num % numBase;
            num /= numBase;

            //If the remainder is < 9 puts the remainder as newNum else checks the remainder to which leter correspondents
            if (remainder < 9)
            {
                newNum = remainder.ToString();
            }
            else if (remainder == 10)
            {
                newNum = "A";
            }
            else if (remainder == 11)
            {
                newNum = "B";
            }
            else if (remainder == 12)
            {
                newNum = "C";
            }
            else if (remainder == 13)
            {
                newNum = "D";
            }
            else if (remainder == 14)
            {
                newNum = "E";
            }
            else if (remainder == 15)
            {
                newNum = "F";
            }

            result = newNum + result; //every loop add the result
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        Console.Write("Enter the number's base: ");
        int numberBase = int.Parse(Console.ReadLine());
        Console.Write("Enter the base you want for convert: ");
        int numBase = int.Parse(Console.ReadLine());
        Console.WriteLine(AnyNumeralToDec(num, numberBase, numBase));
    }
}
