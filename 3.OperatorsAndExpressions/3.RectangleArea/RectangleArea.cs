using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Now it's height:");
        int height = int.Parse(Console.ReadLine());
        int area = width * height;
        Console.WriteLine("The rectangle's area is: {0}", area);
    }
}

//Write an expression that calculates rectangle’s area by given width and height.

