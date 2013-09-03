using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.


class ReversingString
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        Console.WriteLine(reversed.ToString());
    }
}