/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.*/
using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter a number: ");
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrOfNums);
        Console.WriteLine();
        Console.Write("Enter the element: ");
        int element = int.Parse(Console.ReadLine());
        //int index = 0;
        int middle = (arrLength / 2);
        while (element != arrOfNums[middle])
        {
            if (element < arrOfNums[middle])
            {
                middle -= middle / 2;
            }
            else
            {
                middle += middle / 2;
            }
        }
        Console.WriteLine();
        if (element == arrOfNums[middle])
        {
            Console.WriteLine("The index of the element is {0}", middle);
        }

    }
}

