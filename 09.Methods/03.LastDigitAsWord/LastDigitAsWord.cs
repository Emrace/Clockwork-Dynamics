using System;

class LastDigitAsWord
{
    static string LastDigitName(int givenInteger)
    {
        int lastDigit = givenInteger % 10;
        switch (lastDigit)
        {
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "zero";
        }
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of {0} is {1}.", number, LastDigitName(number));
    }
}