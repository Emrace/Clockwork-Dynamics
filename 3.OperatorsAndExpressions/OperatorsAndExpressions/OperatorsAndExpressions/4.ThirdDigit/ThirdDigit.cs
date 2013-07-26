using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter a number, that consists of at least four digits");            
            int number = int.Parse(Console.ReadLine());
            int newNumber = number / 100;
            int thirdNumber = Math.Abs(newNumber) % 10;
            bool check = thirdNumber == 7;

            string @true = "The third digit of your number (right-to-left) is 7";
            string @false = "The third digit of your number (right-to-left) is not 7 ";

            Console.WriteLine(check ? @true : @false);
                        
        }
    }
    //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.