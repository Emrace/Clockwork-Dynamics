using System;
using System.Text.RegularExpressions;

    class FindSubstring
    {
        static void Main()
        {
            string text = @"We are living in an yellow submarine. 
                            We don't have anything else. Inside the submarine is very tight. 
                            So we are drinking all the day. We will move out of it in 5 days.";

            string substr = "in";

            Console.WriteLine(Regex.Matches(text, substr, RegexOptions.IgnoreCase).Count);
        }
    }