using System;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class IsLeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("The year you've entered is leap: {0}.", isLeap);
    }
}