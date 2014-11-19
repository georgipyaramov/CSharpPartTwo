/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;

class SquareThatHasMaximalSum
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter number M: ");
        int numM = int.Parse(Console.ReadLine());
        int[,] arrOfNums = new int[numN, numM];
        for (int i = 0; i < numN; i++)
        {
            for (int j = 0; j < numM; j++)
            {
                Console.Write("Enter value for [{0}, {1}]: ", i, j);
                arrOfNums[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < numN; i++)
        {
            for (int j = 0; j < numM; j++)
            {
                Console.Write(arrOfNums[i, j] + " ");
            }
            Console.WriteLine();
        }
        int currentSum = 0;
        int maxSum = int.MinValue;
        int coordI = 0;
        int coordJ = 0;
        for (int i = 0; i < numN - 2; i++)
        {
            for (int j = 0; j < numM - 2; j++)
            {
                currentSum = arrOfNums[i, j] + arrOfNums[i, j + 1] + arrOfNums[i + 1, j + 1] + arrOfNums[i + 1, j] +
                    arrOfNums[i, j + 2] + arrOfNums[i + 2, j + 2] + arrOfNums[i + 2, j];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    coordI = i;
                    coordJ = j;
                }
            }
        }
        Console.WriteLine();
        for (int i = coordI; i < coordI + 3; i++)
        {
            for (int j = coordJ; j < coordJ + 3; j++)
            {
                Console.Write(arrOfNums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

