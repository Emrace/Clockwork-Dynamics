using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomValues
{
    static Random randomValue = new Random();

    static void Main()
    {
        Console.WriteLine("Those are random values in the range [100, 200]");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", randomValue.Next(100, 200));
        }
        Console.WriteLine();
    }
}