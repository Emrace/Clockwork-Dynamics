using System;
using System.Text.RegularExpressions;

class EmailValidation
{
    static void Main()
    {
        string mails = "svirka@kaval.com sladurana@duduk.net -123--@usa.net test.test123@en.some-host.12345.com .ala.@bala.com test@-host.com user@.test.ru user@test.ru. alabala@ user@host @eu.net";
        string[] arrMails = mails.Split(' ');
        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
                       @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";
        
        MatchCollection matches = Regex.Matches(mails, regex);
        foreach (var mail in arrMails)
        {
            if (Regex.IsMatch(mail, regex))
            {
                Console.WriteLine(mail); 
            }
        }
    }
}