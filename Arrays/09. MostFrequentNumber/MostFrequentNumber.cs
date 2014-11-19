/*Write a program that finds the most frequent number in an array.*/
using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter a number: ");
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        int counter = 0;
        int totalCount = 0;
        int currentMostFrequentInt = 0;
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (arrOfNums[i] == arrOfNums[j])
                {
                    counter++;
                }
            }
            if (totalCount < counter)
            {
                totalCount = counter;
                currentMostFrequentInt = arrOfNums[i];
            }
            counter = 0;
        }
        Console.WriteLine();
        Console.WriteLine("The most frequent number in the array is " + currentMostFrequentInt + " ({0} times)", totalCount);
    }
}

