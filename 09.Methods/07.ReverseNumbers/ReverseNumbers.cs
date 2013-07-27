using System;
using System.Text;

class ReverseNumbers
{
    static decimal ReverseNumberOrder(decimal number)
    {
        string digitCount = number.ToString();
        string digitsAfterSeparator = "";
        if (number != (int)number)
        {
            digitsAfterSeparator = digitCount.Substring(digitCount.IndexOf('.') + 1);
            digitCount = digitCount.Remove(digitCount.IndexOf('.'));
        }
        string numberWithoutSeparator = digitCount + digitsAfterSeparator;
        int numberAsInt = int.Parse(numberWithoutSeparator);
        StringBuilder sb = new StringBuilder();
        int remainder = 0;
        for (int i = 0; i < numberWithoutSeparator.Length; i++)
        {
            remainder = numberAsInt % 10;
            numberAsInt /= 10;
            if (remainder > 9)
            {
                ReverseNumberOrder(number);

            }
            sb.Append(remainder);
        }
        decimal reversedIntNumber = int.Parse(sb.ToString());
        decimal divider = (decimal)Math.Pow(10, digitCount.Length);
        decimal reversedNumber = reversedIntNumber / divider;
        return reversedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The reversed number is: {0}.", ReverseNumberOrder(number));
    }
}