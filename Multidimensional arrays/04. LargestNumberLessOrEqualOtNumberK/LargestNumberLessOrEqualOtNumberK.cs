/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. */

using System;

class LargestNumberLessOrEqualOtNumberK
{
    static void Main()
    {
        Console.Write("Enter the array's length N: ");
        int numN = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[numN];
        for (int i = 0; i < numN; i++)
        {
            Console.Write("Enter value for [{0}]: ", i);
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrOfNums);
        Console.Write("Enter number K: ");
        int numK = int.Parse(Console.ReadLine());
        int index = Array.BinarySearch(arrOfNums, numK);
        if (index >= 0)
        {
            Console.WriteLine("The number you are looking for is {0} at position {1} in the array.", arrOfNums[index], index);
        }
        else
        {
            index = (~index) - 1;
            Console.WriteLine("The number you are looking for is {0} at position {1} in the array.", arrOfNums[index], index);
        }
    }
}

