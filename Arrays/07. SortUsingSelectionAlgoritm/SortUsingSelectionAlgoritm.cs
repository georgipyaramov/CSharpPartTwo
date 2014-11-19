/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.*/

using System;

class SortUsingSelectionAlgoritm
{
    static void Main()
    {
        int arrLength = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[arrLength];
        int[] arrOfNumsSorted = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        int min = 0;
        int temp = 0;
        for (int i = 0; i < arrLength - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < arrLength; j++)
            {
                if (arrOfNums[j] < arrOfNums[min])
                {
                    min = j;
                }
            }
            temp = arrOfNums[i];
            arrOfNums[i] = arrOfNums[min];
            arrOfNums[min] = temp;
        }
        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine(arrOfNums[i]);
        }
    }
}

