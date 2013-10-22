using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    public int WeekSalary { get; set; }
    public int WorkHoursPerDay { get; set; }

    public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public int MoneyPerHour()
    {
        int weeklyHours = this.WorkHoursPerDay * 5;
        int moneyPerHour = this.WeekSalary / weeklyHours;

        return moneyPerHour;
    }
}