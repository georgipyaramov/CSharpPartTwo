/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).*/
using System;

class IsNumberBiggerThanItsNeighbors
{
    static bool BiggerThanItsNeighbors(int[] arr, int checkNum)
    {
        bool isBigger = false;
        if (checkNum == 0)
        {
            return isBigger;
        }
        if (checkNum == arr.Length - 1)
        {
            return isBigger;
        }
        if (arr[checkNum] > arr[checkNum - 1] && arr[checkNum] > arr[checkNum + 1])
        {
            isBigger = true;
        }
        return isBigger;
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
        Console.Write("Enter the position of the number you want to check (counting from zero): ");
        int numToCheck = int.Parse(Console.ReadLine());
        bool isBigger = BiggerThanItsNeighbors(arrOfNums, numToCheck);
        Console.WriteLine("The number at the position you entered is bigger then its neighbors ----> {0}", isBigger);
    }
}

