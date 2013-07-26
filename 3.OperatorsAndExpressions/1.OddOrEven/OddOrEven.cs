using System;
//Check if a given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer to check if it's odd or even");
        int i = int.Parse(Console.ReadLine());
        Console.Write("\nThe integer {0} is even: ", i);
        Console.WriteLine(i % 2 == 0);
    }
}

