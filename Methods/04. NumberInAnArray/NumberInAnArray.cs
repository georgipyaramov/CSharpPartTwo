/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.*/
using System;

class NumberInAnArray
{
    static int CountOfNumberInArray(int[] arr, int num)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter value for [{0}]: ", i);
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Enter the number you want to check: ");
        int numToCheck = int.Parse(Console.ReadLine());
        int count = CountOfNumberInArray(arrOfNums, numToCheck);
        Console.WriteLine();
        Console.WriteLine("Number {0} appears in the array {1} times", numToCheck, count);
    }
}

