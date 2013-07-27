using System;
    class HelloMethod
    {
        static void Greeting()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine();
        }

        static void Main()
        {
            Greeting();
        }
    }