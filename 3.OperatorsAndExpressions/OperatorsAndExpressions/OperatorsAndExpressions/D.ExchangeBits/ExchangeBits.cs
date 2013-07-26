using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

    class ExchangeBits
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number:");
            int n = int.Parse(Console.ReadLine());
            int positionA = 3;
            int positionB = 24;
            Console.WriteLine("You're number is: {0}", n);
            Console.WriteLine("\nThat's the binary representation of {0}:", n);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

            for (positionA = 3; positionA <= 5; positionA++)
            {
                int mask = 1 << positionA;
                int juniorBit = (n & mask) >> positionA;
                mask = 1 << positionB;
                int seniorBit = (n & mask) >> positionB;
                

                if (juniorBit == seniorBit)
                {                    
                    Console.WriteLine("\nAfter the exchange of bits n becomes {0}", n);
                    Console.WriteLine("\nThat's the binary representation of {0}:", n);
                    Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));                    
                    return;
                }
                
                if (juniorBit == 0)
                {
                    //set seniorBit to 0
                    mask = ~(1 << positionB);
                    n = n & mask;
                }
                else if (juniorBit == 1)
                {
                    //set seniorBit to 1
                    mask = 1 << positionB;
                    n = n | mask;
                }

                if (seniorBit == 0)
                {
                    //set juniorBit to 0
                    mask = ~(1 << positionA);
                    n = n & mask;
                }
                else if (seniorBit == 1)
                {
                    //set juniorBit to 1
                    mask = 1 << positionA;
                    n = n | mask;
                }
                positionB++;
            }

            Console.WriteLine(n);
            Console.WriteLine("After the exchange of bits n becomes {0}", n);
            Console.WriteLine("That's the binary representation of {0}:", n);
            Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));
            
        }
    }

