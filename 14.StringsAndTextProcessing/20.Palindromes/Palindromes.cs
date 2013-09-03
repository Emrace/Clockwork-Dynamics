using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe"

class Palindromes
{
    static bool IsPalindrome(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        string text = "ABBA, lamal, exe more to come. Do not miss musesum";
        MatchCollection matches = Regex.Matches(text, @"\w+");
        foreach (Match match in matches)
        {
            if (IsPalindrome(match.Value))
            {
                Console.WriteLine(match);
            }
        }
    }
}