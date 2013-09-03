using System;
using System.Globalization;

class CalculateDays
{
    static void Main()
    {
        string firstDate = "27.02.2006";
        string secondDate = "3.03.2006";

        DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: {0} days", Math.Abs((startDate - endDate).TotalDays));
    }
}