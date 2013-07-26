using System;

/*We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v 
 * at the position p from the binary representation of n.*/

class ModifyToHoldValue
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number \"n\":");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"v\" (0 or 1)");
        byte v = byte.Parse(Console.ReadLine());
        if ( v < 0 || v > 1)
        {
            Console.WriteLine("The value you've entered is invalid");
            return;
        }
        Console.WriteLine("Enter bit position \"p\" (counting starts from 0):");
        int p = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The bit at position {0} now holds value {1}. The new number is: {2}",
                p, v, result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("The bit at position {0} now holds value {1}. The new number is: {2})",
                p, v, result);
        }

    }
}

