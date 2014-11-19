/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/
using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrLength = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum S: ");
        int sumS = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.Write("Enter a value for the array: ");
            arrOfNums[i] = int.Parse(Console.ReadLine());            
        }
        int counter = 2;
        int actualSum = 0;
        int currentPosition = 0;
        int resultSequenceLength = 0;
        for (int i = 0; i < arrOfNums.Length; i++)
        {
            for (int j = 0; j < arrOfNums.Length - counter; j++)
            {
                for (int k = j; k < j + counter; k++)
                {
                    actualSum += arrOfNums[k];
                    if (actualSum == sumS)
                    {
                        currentPosition = j;
                        resultSequenceLength = j + counter;
                        Console.WriteLine();
                        Console.Write("{");
                        for (int m = 0; m < arrOfNums.Length; m++)
                        {
                            Console.Write(arrOfNums[m]);
                        }
                        Console.Write("} ");
                        Console.Write("--->");
                        Console.Write(" S={0}", sumS);
                        Console.Write(" {");
                        for (int l = currentPosition; l < resultSequenceLength; l++)
                        {
                            Console.Write(arrOfNums[l]);
                        }
                        Console.WriteLine("}");
                        return;
                    }
                }
                actualSum = 0;
            }
            counter++;
        }
    }
}

