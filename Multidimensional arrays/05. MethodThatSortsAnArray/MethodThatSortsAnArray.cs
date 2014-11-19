/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/

using System;

class MethodThatSortsAnArray
{
    static void SortArrayOfStrings(string[] arrOfStrings)
    {
        int[] orderedArr = new int[arrOfStrings.Length];
        for (int i = 0; i < arrOfStrings.Length; i++)
        {
            orderedArr[i] = arrOfStrings[i].Length;
        }
        Array.Sort(orderedArr, arrOfStrings);
    }
    static void Main()
    {
        Console.Write("Enter the array's length N: ");
        int numN = int.Parse(Console.ReadLine());
        string[] stringArr = new string[numN];
        for (int i = 0; i < numN; i++)
        {
            Console.Write("Enter value for [{0}]: ", i);
            stringArr[i] = Console.ReadLine();
        }
        SortArrayOfStrings(stringArr);

        for (int i = 0; i < stringArr.Length; i++)
        {
            Console.WriteLine(stringArr[i]);
        }
    }
}

