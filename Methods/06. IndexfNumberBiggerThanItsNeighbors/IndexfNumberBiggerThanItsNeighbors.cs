using System;

class IndexfNumberBiggerThanItsNeighbors
{
    static int BiggerThanItsNeighbors(int[] arr)
    {
        int isBigger = -1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                isBigger = i;
            }
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
        Console.WriteLine();
        int index = BiggerThanItsNeighbors(arrOfNums);
        if (index >= 0)
        {
            Console.WriteLine("The first number that is bigger then its neighbors \n is {0} at position {1} in the array", arrOfNums[index], index);
        }
        else
        {
            Console.WriteLine("There isn't a number that is bigger then its neighbors in the array");
        }
        
    }
}
