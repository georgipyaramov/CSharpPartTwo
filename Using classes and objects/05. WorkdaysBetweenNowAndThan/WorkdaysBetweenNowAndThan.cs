/*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;

class WorkdaysBetweenNowAndThan
{
    static int WorkDays(DateTime today, DateTime endDay, DateTime[] holydaysArr)
    {
        int workDays = 0;
        bool isAWorkDay = true;
        DayOfWeek currentDayOfWeek = today.DayOfWeek;
        int isBeforeEnd;
        isBeforeEnd = today.CompareTo(endDay);
        while (isBeforeEnd <= 0)
        {
            for (int i = 0; i < holydaysArr.Length; i++)
            {
                if (today == holydaysArr[i])
                {
                    isAWorkDay = false;
                }
            }
            if (isAWorkDay)
            {
                workDays++;
            }
            today = today.AddDays(1);
            isBeforeEnd = today.CompareTo(endDay);
            isAWorkDay = true;
        }
        return workDays;
    }
    static void Main()
    {
        DateTime now = DateTime.Today;
        DateTime then = new DateTime(2014, 1, 28);//Change vlues if you want
        DateTime[] holydays = new DateTime[3];
        holydays[0] = new DateTime(2014, 1, 16);//Change vlues if you want
        holydays[1] = new DateTime(2014, 1, 21);//Change vlues if you want
        holydays[2] = new DateTime(2014, 1, 27);//Change vlues if you want
        int workDays = WorkDays(now, then, holydays);
        Console.WriteLine("The number of workdays in the given period is {0}", workDays);        
    }
}

