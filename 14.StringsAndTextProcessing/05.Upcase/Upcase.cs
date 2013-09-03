using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class Upcase
{
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string regex = @"<upcase>(?<capitalise>(.|\s)*?)</upcase>";

        Console.WriteLine(Regex.Replace(text, regex, m => m.Groups["capitalise"].Value.ToUpper()));
    }
}