/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter the length of the first array: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the first array: ");
        int secArrLength = int.Parse(Console.ReadLine());
        char[] firstArr = new char[firstArrLength];
        char[] secArr = new char[secArrLength];
        Console.WriteLine("Enter values for the first array");
        for (int i = 0; i < firstArrLength; i++)
        {
            Console.Write("Enter character: ");
            firstArr[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter values for the second array");
        for (int i = 0; i < secArrLength; i++)
        {
            Console.Write("Enter character: ");
            secArr[i] = char.Parse(Console.ReadLine());
        }
        int shorterArrLength = Math.Min(firstArrLength, secArrLength);
        Console.WriteLine();
        for (int i = 0; i < shorterArrLength; i++)
        {
            if ((int)firstArr[i] < (int)secArr[i])
            {
                Console.WriteLine("The first array is before the second array lexicographically.");
                return;
            }
            else if ((int)firstArr[i] > (int)secArr[i])
            {
                Console.WriteLine("The second array is before the first array lexicographically.");
                return;
            }
            else if (i != shorterArrLength - 1)
            {
                continue;
            }
            else 
            {
                if (firstArrLength == secArrLength)
                {
                    Console.WriteLine("Both arrays are the same");
                    return;
                }
                else if (firstArrLength > secArrLength)
                {
                    Console.WriteLine("The second array is before the first array lexicographically.");
                    return;
                }
                else
                {
                    Console.WriteLine("The first array is before the second array lexicographically.");
                    return;
                }
            }
        }
    }
}

