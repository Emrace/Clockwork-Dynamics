using System;

//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a 
//fixed list of public holidays specified preliminary as array.


class Workdays
{
    static DateTime[] holidays = { new DateTime(2013, 12, 24), new DateTime(2013, 12,  25), 
                                     new DateTime(2013, 12, 26), new DateTime(2013, 12, 31),
                                     new DateTime(2013, 1, 1), new DateTime(2013, 5, 1), 
                                     new DateTime(2013, 5, 6), new DateTime(2013, 9, 6), 
                                     new DateTime(2013, 9, 22), new DateTime(2013, 3, 3) };

    static int WorkdaysInPeriod(DateTime endDate)
    {
        DateTime startDate = DateTime.Today;
        int days = Math.Abs((endDate - startDate).Days);
        int daysOff = 0;
        startDate = startDate.AddDays(1);
        if (startDate > endDate)
        {
            startDate = endDate;
            endDate = DateTime.Today;
        }
        for (int i = startDate.DayOfYear; i <= endDate.DayOfYear; i++)
        {
            foreach (var holiday in holidays)
            {
                if (startDate == holiday)
                {
                    daysOff++;
                    break;
                }
            }
            if ((startDate.DayOfWeek == DayOfWeek.Saturday) || (startDate.DayOfWeek == DayOfWeek.Sunday))
            {
                daysOff++;
            }
        }
        int workdays = days - daysOff;
        return workdays;
    }

    static void Main()
    {
        Console.Write("Enter an end date in the format YYYY/MM/DD: ");
        string[] dateString = Console.ReadLine().Split('/');
        int day = int.Parse(dateString[2]);
        int month = int.Parse(dateString[1]);
        int year = int.Parse(dateString[0]);
        DateTime endDate = new DateTime(year, month, day);
        int workdays = WorkdaysInPeriod(endDate);
        Console.WriteLine("There are {0} workdays in that period.", workdays);
    }
}