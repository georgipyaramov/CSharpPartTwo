/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.*/

using System;

class PrintTheNewArray
{
    static void Main()
    {
        int[] firstArr = new int[20];
        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = i * 5;
            Console.WriteLine(firstArr[i]);
        }
    }
}

