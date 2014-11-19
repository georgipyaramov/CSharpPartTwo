using System;

class DoManyThingsWithNumbers
{
    static int GetMaximumNumber(params int[] numbers)
    {
        int maxNum = 0;
        foreach (int number in numbers)
        {
            if (number > maxNum)
            {
                maxNum = number;
            }
        }
        return maxNum;
    }
    static int GetMinimumNumber(params int[] numbers)
    {
        int minNum = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number < minNum)
            {
                minNum = number;
            }
        }
        return minNum;
    }
    static int GetAverageOf(params int[] numbers)
    {
        int averageNum = 0;
        foreach (int number in numbers)
        {
            averageNum += number;
        }
        averageNum /= 2;
        return averageNum;
    }
    static int GetSumOf(params int[] numbers)
    {
        int sumOfNum = 0;
        foreach (int number in numbers)
        {
            sumOfNum += number;
        }
        return sumOfNum;
    }
    static int GetProductOf(params int[] numbers)
    {
        int product = 1;
        foreach (int number in numbers)
        {
            product *= number;
        }
        return product;
    }
    static void Main()
    {
        Console.Write("How many numbers would you like to work with: ");
        int arrLength = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLength];
        Console.WriteLine("Enter the numbers (each on a new line)");
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("To get the biggest number press 1");
        Console.WriteLine("To get the smallest number press 2");
        Console.WriteLine("To get the average of the numbers press 3");
        Console.WriteLine("To get the sum of the numbers press 4");
        Console.WriteLine("To get the product of the numbers press 5");
        string condition = Console.ReadLine();
        int outNum = 0;
        if (condition == "1")
        {
            outNum = GetMaximumNumber(arr);
        }
        else if (condition == "2")
        {
            outNum = GetMinimumNumber(arr);
        }
        else if (condition == "3")
        {
            outNum = GetAverageOf(arr);
        }
        else if (condition == "4")
        {
            outNum = GetSumOf(arr);
        }
        else if (condition == "5")
        {
            outNum = GetProductOf(arr);
        }
        Console.WriteLine(outNum);

    }
}

