using System;

    class Check
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer to check if it can be divided without remainder by 7 and 5");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("It can?");
            Console.WriteLine((i % 5 == 0) && (i % 7 == 0));
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
        }
    }

/* Write a boolean expression that checks for given integer if it can 
   be divided (without remainder) by 7 and 5 in the same time.*/

