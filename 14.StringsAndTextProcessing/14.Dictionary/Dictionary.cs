using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical organization of classes"
        };

        string word = Console.ReadLine();
        string regex = @"(.*?) - (.*)";

        foreach (string item in dictionary)
        {
            var fragment = Regex.Split(item, regex);

            if (fragment[1].ToUpper() == word.ToUpper())
            {
                Console.WriteLine(fragment[2]);
                return;
            }
        }
    }
}