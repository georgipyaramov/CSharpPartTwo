/*Write a method GetMax() with two parameters that returns the bigger of two integers. 
 *Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class MethodGetMax
{
    static int GetMax(int firstNumber, int secNumber)
    {
        int biggerNum = 0;
        if (firstNumber > secNumber)
        {
            biggerNum = firstNumber;
        }
        else
        {
            biggerNum = secNumber;
        }
        return biggerNum;
    }
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        int biggerNum = GetMax(firstNum, secNum);
        int biggestNum = GetMax(thirdNum, biggerNum);
        Console.WriteLine("The biggest number is: {0}", biggestNum);
    }
}

