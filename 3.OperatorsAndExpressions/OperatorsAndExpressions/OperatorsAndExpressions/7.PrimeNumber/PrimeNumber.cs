using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter an integer between 0 and 100 to check if it's prime.");
        int n = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int) Math.Sqrt(n);
        bool prime = true;

        while (prime && (divider <= maxDivider))
        {
            if (n % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("It's prime {0}", prime);       
    }
}