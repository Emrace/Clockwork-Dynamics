using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that extracts from a given text all sentences containing given word.


class ExtractSentences
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string regex = @"\s*(?<sentence>[^\.]*?\bin\b(.|\s)*?\.)";
        MatchCollection matches = Regex.Matches(text, regex, RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups["sentence"].Value);
        }
    }
}