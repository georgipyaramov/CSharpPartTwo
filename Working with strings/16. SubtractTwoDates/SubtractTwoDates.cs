//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


class SubtractTwoDates
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secDate = Console.ReadLine();        
        DateTime dateOne = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime dateTwo = DateTime.ParseExact(secDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        TimeSpan diff = dateTwo.Subtract(dateOne);
        Console.WriteLine("Distance: {0}", diff.ToString("%d"));
    }
}

