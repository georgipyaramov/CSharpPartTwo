//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class DateAndTimeAfterSixHours
{
    static void Main()
    {
        Console.Write("Enter date and time: ");
        string dateAndTime = "21.01.2014 21:25:48"; Console.WriteLine(dateAndTime);
        DateTime now = DateTime.ParseExact(dateAndTime, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        now = now.AddHours(6);
        now = now.AddMinutes(30);
        Console.WriteLine("{0} {1}",now, now.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
