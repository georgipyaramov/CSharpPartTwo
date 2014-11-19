using System;


class MaxElementInAPortion
{
    static int MaxElementInPortionOfArray(int[] array, int start)
    {
        int maxNum = int.MinValue;
        int indexMax = 0;
        for (int i = start; i < array.Length; i++)
        {
            if (maxNum < array[i])
            {
                maxNum = array[i];
                indexMax = i;
            }
        }
        return indexMax;
    }
    static int MaxElementInPortionOfArray(int[] array, int start, out int result)
    {
        int maxNum = int.MinValue;
        int indexMax = 0;
        for (int i = start; i < array.Length; i++)
        {
            if (maxNum < array[i])
            {
                maxNum = array[i];
                indexMax = i;
            }
        }
        result = maxNum;
        return indexMax;
    }
    static void SortArrayDescending(int[] array)
    {
        int temp = 0;
        int index = 0;
        int[] newArr = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            index = MaxElementInPortionOfArray(array, i);
            temp = array[i];
            array[i] = array[index];
            array[index] = temp;                
            
            
        }
    }
    static void SortArrayAscending(int[] array)
    {
        int temp = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            index = MaxElementInPortionOfArray(array, i);
            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
        Array.Reverse(array);
    }
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[length];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < length; i++)
        {
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the position you want to start from: ");
        int start = int.Parse(Console.ReadLine());
        int number;
        MaxElementInPortionOfArray(arrOfNums, start, out number);
        Console.WriteLine("The biggest number in that portion of the array is: " + number);        
        SortArrayDescending(arrOfNums);
        Console.WriteLine("The array sorted in descending order: " + string.Join(", ", arrOfNums));
        SortArrayAscending(arrOfNums);
        Console.WriteLine("The array sorted in ascending order: " + string.Join(", ", arrOfNums));
    }
}

