using System;

class CheckIntegerForExceptions
{
    /*Write a program that reads an integer number and calculates and prints its square root. 
     * If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

    public static double Sqrt(double value)
    {
        if (value < 0 || value > double.MaxValue)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return Math.Sqrt(value);
    }

    static void Main()
    {
        Console.WriteLine("Enter a number for square root");
        string num = Console.ReadLine();

        try
        {
            double number = double.Parse(num);
            Console.WriteLine("Square root of {0} is {1}", num, Sqrt(number));
        }
        catch (FormatException) //when it's not a valid double
        {
            Console.WriteLine("Invalid number!");
            throw;
        }
        catch (ArgumentOutOfRangeException) //when < 0 and > MaxValue
        {
            Console.WriteLine("Invalid number!");
            throw;
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

}

