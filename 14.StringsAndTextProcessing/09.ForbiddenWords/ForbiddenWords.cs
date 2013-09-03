using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks. 

class ForbiddenWords
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string forbiddenWords = @"(?<forbiddenWords>\b(Microsoft|CLR|PHP)\b)";
        Console.WriteLine(Regex.Replace(text, forbiddenWords, m => new String('*', m.Length)));
    }
}