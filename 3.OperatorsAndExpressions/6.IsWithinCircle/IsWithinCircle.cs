using System;

    class IsWithinCircle
    {
        static void Main()
        {
            Console.WriteLine("Is a point with coordinates \"x\" and \"y\" within a circle K with radius 5");
            Console.WriteLine("Enter value for \"x\": ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for \"y\": ");
            double y = double.Parse(Console.ReadLine());
            
            double r = 5;
            if((x*x) + (y*y) <= (r*r))
            {
                Console.WriteLine("The point is within the circle.");
            }
            else
            {
                Console.WriteLine("The point is outside the circle.");
            }
        }
    }

