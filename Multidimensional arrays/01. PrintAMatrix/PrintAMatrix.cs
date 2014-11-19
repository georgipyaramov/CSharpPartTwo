/*Write a program that fills and prints a matrix of size (n, n) */
using System;

class PrintAMatrix
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numN = int.Parse(Console.ReadLine());
        int rows = numN;
        int cols = numN;
        int[,] arrOfNums = new int[rows, cols];
        int k = 0;
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                arrOfNums[i, j] = k + 1;
                k++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("a)");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arrOfNums[j, i] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("b)");
        k = cols - 1;
        for (int i = 0; i < rows; i++)
        {            
            for (int j = 0; j < cols; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(arrOfNums[j, i] + " ");
                }
                else
                {
                    Console.Write(arrOfNums[j, k - i] + " ");                    
                }                
            }            
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("c)");
        int[,] arrOfNumsTwo = new int[numN, numN];
        int lengthOfDiagonal = 1;
        k = 0;
        for (int i = numN - 1; i >= numN - 1 ; i--)
        {
            for (int j = 0; j < numN; j++)
            {
                arrOfNumsTwo[i, j] = k + lengthOfDiagonal;
                k = arrOfNumsTwo[i, j];
                lengthOfDiagonal++;
            }
        }
        for (int i = numN - 2; i >= 0; i--)
        {
            for (int j = 0; j < numN; j++)
            {
                if (j != numN - 1)
                {
                    arrOfNumsTwo[i, j] = arrOfNumsTwo[i + 1, j + 1] - 1;
                }
                else
                {
                    arrOfNumsTwo[i, j] = arrOfNumsTwo[i, j - 1] + lengthOfDiagonal - 1;
                    lengthOfDiagonal--;
                }
            }
        }
        for (int i = 0; i < numN; i++)
        {
            for (int j = 0; j < numN; j++)
            {
                Console.Write(arrOfNumsTwo[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

