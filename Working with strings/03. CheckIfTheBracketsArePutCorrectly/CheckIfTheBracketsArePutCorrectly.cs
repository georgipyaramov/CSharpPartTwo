//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckIfTheBracketsArePutCorrectly
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();
        int numberOfOpeningBrackets = 0;
        int numberOfClosingBrackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                numberOfOpeningBrackets++;
            }
            else if (expression[i] == ')')
            {
                numberOfClosingBrackets++;
            }
        }
        if (numberOfOpeningBrackets == numberOfClosingBrackets)
        {
            Console.WriteLine("The expression is correct.");
        }
        else
        {
            Console.WriteLine("The expression is incorrect.");
        }
    }
}

