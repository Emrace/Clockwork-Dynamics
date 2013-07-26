using System;

class BitThree
{
    static void Main()
    {
        Console.WriteLine("Type an integer number");
        
        int p = 3;                         
        int n = int.Parse(Console.ReadLine());                        
        int mask = 1 << p;                 
        int nAndMask = n & mask;
        int bit = nAndMask >> p;           
        Console.Write("The bit 3 of your number is 1: ");
        Console.WriteLine(bit == 1);
       
    }
}

