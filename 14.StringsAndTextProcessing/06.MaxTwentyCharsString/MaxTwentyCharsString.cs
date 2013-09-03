using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.


class MaxTwentyCharsString
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length>20)
        {
            Console.WriteLine("The string you've entered is too long. It must have maximum 20 characters.");
            input = Console.ReadLine();
        }
        StringBuilder result = new StringBuilder();
        result.Append(input);
        if (input.Length < 20)
        {
            int asterisks = 20 - input.Length;
            result.AppendFormat(new String('*', asterisks));
        }
        Console.WriteLine(result);
    }
}