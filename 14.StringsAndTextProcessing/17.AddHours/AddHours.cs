using System;
using System.Globalization;

    class AddHours
    {
        static void Main()
        {
            string str = "03.09.2013 21:41:00";

            DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6.5);

            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }