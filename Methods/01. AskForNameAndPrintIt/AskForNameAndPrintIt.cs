/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.*/
using System;

class AskForNameAndPrintIt
{
    static void GetNameAndPrint()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Hello " + name);
    }

    static void Main()
    {
        GetNameAndPrint();
    }
}

