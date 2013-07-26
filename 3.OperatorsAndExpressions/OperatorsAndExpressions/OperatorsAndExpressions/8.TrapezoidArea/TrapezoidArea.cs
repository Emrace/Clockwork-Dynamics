using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("You want to calculate a trapezoids area? Let's see if I can help you!");
        Console.Write("First, enter the value of base \"a\" \n a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Second, enter the value of base \"b\" \n b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Now enter the value of the height \"h\" and I will calculate the area \n  h = ");
        double h = double.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("That's not a trapezoid!");
            return;
        }

        double sumBases = (a + b);
        double trapezoidArea = (sumBases / 2.0) * h;
        Console.WriteLine("The trapezoid's area is: {0}", trapezoidArea);       
    }
}

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
