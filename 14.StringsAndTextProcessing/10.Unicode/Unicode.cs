using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings.

class Unicode
{
    static void Main()
    {
        Console.WriteLine(ConvertToUnicode("Hi!"));
    }

    static string ConvertToUnicode(string str)
    {
        StringBuilder utf = new StringBuilder();
        foreach (char ch in str)
        {
            utf.AppendFormat("\\u{0:X4}", (int)ch);
        }

        return utf.ToString();
    }
}