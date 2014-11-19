/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;

class ComapareTwoArrays
{
    static void Main()
    {
        int[] firstArr = new int[10];
        Console.WriteLine("Enter 10 values for the first array:");
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter 10 values for the second array:");
        int[] secArr = new int[10];
        for (int i = 0; i < firstArr.Length; i++)
        {
            secArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < firstArr.Length; i++)
        {
            if (firstArr[i] == secArr[i])
            {
                Console.WriteLine("Element [{0}] of the first array is the same as element [{0}] of the second array", i);
            }
        }
    }
}

