using System;

class BitPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to check (counting starts from 0)");
        int p = int.Parse(Console.ReadLine());

        int mask = (1 << p);
        int vAndMask = v & mask;
        int bit = v >> p;
        Console.WriteLine("The bit at position p has value of 1: " + (bit == 1));
    }
}
/*Write a boolean expression that returns if the bit at 
 * position p (counting from 0) in a given integer number v 
 * has value of 1. Example: v=5; p=1  false*/
