/*Write a program that finds the maximal sequence of equal elements in an array.*/

using System;

class SequenceOfEqualElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        string numberInQuestion = null;
        int staticCounter = 0;
        int nextCounter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1]) //Pravim proverka dali sledvashtiq element e sushtiq
            {
                nextCounter++;
            }
            else if (nextCounter > staticCounter)
            {               
                staticCounter = nextCounter; //Zapisvame poslednata nai-dulga poredica ot ednakvi elementi
                numberInQuestion = arr[i]; //Zapisvame elementa na tazi poredica
                nextCounter = 1; //Nulirame broyacha
            }
            if (i == arr.Length - 2 && nextCounter > staticCounter) //Pravim proverka za posledniq element
            {
                staticCounter = nextCounter;
                numberInQuestion = arr[i];

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
        for (int i = 0; i < staticCounter; i++)
        {
            Console.Write(numberInQuestion);
        }
        Console.Write("}");
        Console.WriteLine();

    }
}

