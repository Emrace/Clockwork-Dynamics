using System;
using System.Collections.Generic;

class MultiTaskProgram
{
    static void Main()
    {
        Console.Write(new string('-', 80));
        Console.WriteLine("Hi, this is a multi-task program.");
        Console.Write("Enter \"start\" to see the menu: ");
        string command = Console.ReadLine();
        Console.WriteLine("If you want to bring up the menu again at any given time, just enter \"menu\".");
        while (true)
        {
            if ((command == "start") || (command == "menu"))
            {
                Console.Write(new string('-', 80));
                Console.WriteLine("\nChoose what you want to do:\n");
                Console.WriteLine("1. Reverse the digits of a given number.");
                Console.WriteLine("2. Calculate the average of a sequence of numbers.");
                Console.WriteLine("3. Solve a linear equation. \n(a * x + b = 0)\n");
                Console.Write(new string('-', 80));
                Console.WriteLine("Use the keywords \"reverse\", \"calc\" and \"solve\".");
                Console.WriteLine("If you think the screen is too messy, you can clean up everything with \"clear\".");
                Console.WriteLine();
                command = "";
            }
            Console.Write("Enter command: ");
            string choice = Console.ReadLine();

            if (choice == "menu")
            {
                command = "menu";
                continue;
            }
            else if (choice == "clear")
            {
                Console.Clear();
                continue;
            }
            if (choice == "reverse")
            {
                Console.Write("Enter a number: ");
                decimal number = decimal.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("The number should be non-negative!");
                    Console.Write("Enter a new number: ");
                    number = decimal.Parse(Console.ReadLine());
                }
                decimal reversedNum = ReverseNumbers.ReverseNumberOrder(number);
                Console.WriteLine("The reversed number is: {0}", reversedNum);
            }
            else if (choice == "calc")
            {
                List<int> sequence = new List<int>(16);
                Console.WriteLine("Enter the numbers of the sequence (one number per line).");
                Console.WriteLine("When you're finished, enter \"end\" to stop the sequence.");
                int number;
                while (true)
                {
                    bool result = int.TryParse(Console.ReadLine(), out number);
                    if (result)
                    {
                        sequence.Add(number);
                    }
                    else if (sequence.Count == 0)
                    {
                        Console.WriteLine("The sequence should not be empty!");
                        Console.WriteLine("Enter numbers:");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequence.Count != 0)
                {
                    int sum = 0;
                    int members = sequence.Count;
                    for (int i = 0; i < members; i++)
                    {
                        sum += sequence[i];
                    }
                    int average = sum / members;
                    Console.WriteLine("The average of the sequence is: {0}.", average);
                }
            }
            else if (choice == "solve")
            {
                int counter = 0;
                Console.WriteLine("Enter the coefficients of the linear equation \"a * x + b = 0\".");
                Console.Write("Enter \"a\": ");
                decimal firstNum = decimal.Parse(Console.ReadLine());
                if (firstNum == 0)
                {
                    if (counter >= 10)
                    {
                        Console.WriteLine("Apparenty you're not so smart and can't understand");
                        Console.WriteLine("THAT \"a\" SHOULD BE DIFFERENT THAN 0!");
                    }
                    Console.WriteLine("\"a\" should be different than 0");
                    Console.Write("Enter \"a\": ");
                    firstNum = decimal.Parse(Console.ReadLine());
                    counter++;
                }
                counter = 0;
                Console.Write("Enter \"b\": ");
                decimal secondNum = decimal.Parse(Console.ReadLine());
                decimal result = (-secondNum) / firstNum;
                Console.WriteLine("\"x\" = {0}", result);
            }
        }
    }
}