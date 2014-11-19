/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.*/

using System;

class MaxSumOfKElements
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        int[] arrOfNums = new int[numN];
        for (int i = 0; i < arrOfNums.Length; i++)
        {
            arrOfNums[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrOfNums);
        Console.Write("{");
        for (int i = arrOfNums.Length - numK; i < arrOfNums.Length; i++)
        {
            if (i == arrOfNums.Length - 1)
            {
                Console.Write(arrOfNums[i]);
            }
            else
            {
                Console.Write(arrOfNums[i] + ", ");
            }
        }
        Console.WriteLine("}");
    }
}

