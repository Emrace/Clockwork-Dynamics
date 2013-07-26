using System;

class ExtractBitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the value of integer i.");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of the bit b you wish to extract.");
        int b = int.Parse(Console.ReadLine());

        int mask = (1 << b);
        int iAndMask = i & mask;
        int value = i >> b;

        Console.WriteLine("The value of the bit number {0} is {1}", b, value);
    }
}

/*Write an expression that extracts from a given integer i 
 * the value of a given bit number b. Example: i=5; b=2  value=1.*/
