/*Write a program that finds the maximal sequence of equal elements in an array.*/

using System;

class SequenceOfEqualElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int numberInQuestion = 0;
        int staticCounter = 0;
        int nextCounter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] > arr[i]) //Pravim proverka dali sledvashtiq element e po-golqm
            {
                nextCounter++;
            }
            else if (nextCounter > staticCounter)
            {
                staticCounter = nextCounter; //Zapisvame poslednata nai-dulga poredica ot ednakvi elementi
                numberInQuestion = i - staticCounter; //Zapisvame purviq elementa na tazi poredica
                nextCounter = 1; //Nulirame broyacha
            }
            if (i == arr.Length - 2 && nextCounter > staticCounter) //Pravim proverka za posledniq element
            {
                staticCounter = nextCounter;
                numberInQuestion = i - (staticCounter - 1);
            }

        }
        Console.WriteLine();
        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.Write("} ");
        Console.Write("--->");
        Console.Write(" {");

        for (int i = numberInQuestion; i < numberInQuestion + staticCounter + 1; i++)
        {
            Console.Write(arr[i]);
        }
        Console.Write("}");
        Console.WriteLine();

    }
}

