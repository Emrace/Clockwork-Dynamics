using System;
using System.Text;

public class ReverseNumbers
{
    public static decimal ReverseNumberOrder(decimal number)
    {
        string digitCount = number.ToString();
        string digitsAfterSeparator = "";
        
        //check if the number has a floating point
        if (number != (int)number)
        {
            //save the digits after the floating point in a new string
            digitsAfterSeparator = digitCount.Substring(digitCount.IndexOf('.') + 1);
            
            //remove the floating point and the digits after it
            digitCount = digitCount.Remove(digitCount.IndexOf('.'));
        }
        string numberWithoutSeparator = digitCount + digitsAfterSeparator;
        int numberAsInt = int.Parse(numberWithoutSeparator);
        
        //check if the number is negative, if so make it positive
        if (numberAsInt < 0)
        {
            numberAsInt *= -1;
        }
        StringBuilder sb = new StringBuilder();
        int remainder = 0;
        
        //reverse the number and save it in a StringBuilder
        for (int i = 0; i < numberWithoutSeparator.Length; i++)
        {
            remainder = numberAsInt % 10;
            numberAsInt /= 10;
            sb.Append(remainder);
        }

        decimal reversedIntNumber = int.Parse(sb.ToString());
        decimal reversedNumber;

        //determine the position of the floating point
        if (number != (int)number)
        {
            decimal divider = (decimal)Math.Pow(10, digitCount.Length);
            reversedNumber = reversedIntNumber / divider;
        }
        reversedNumber = (decimal)reversedIntNumber;
        
        //if the input number was negative, it was converted into a positive one, so we 
        //should make it a negative number again
        if (number < 0)
        {
            reversedNumber = -reversedNumber;
        }
        return reversedNumber;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The reversed number is: {0}.", ReverseNumberOrder(number));
    }
}