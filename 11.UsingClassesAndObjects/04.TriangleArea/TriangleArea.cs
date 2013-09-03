using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class TriangleAreaFormulas
{
    public static double TriangleArea(double side, double altitude)
    {
        double area = (side * altitude) / 2;
        return area;
    }

    public static double TriangleArea(double firstSide, double secondSide, double thirdSide = 0, double angle = 0)
    {
        if (angle == 0)
        {
            //Heron's formula
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double formulaWithoutRadical = halfPerimeter * (halfPerimeter - firstSide) *
                (halfPerimeter - secondSide) * (halfPerimeter - thirdSide);
            double area = Math.Sqrt(formulaWithoutRadical);
            return area;
        }
        else
        {
            double angleInRadians = (angle * Math.PI) / 180;
            double angleSine = Math.Sin(angleInRadians);
            double numerator = firstSide * secondSide * angleSine;
            double area = numerator / 2;
            return area;
        }
    }
}

class TriangleAreaCalculation
{

    static void Main()
    {
        Console.WriteLine("Choose how you want to calculate the triangle's area: ");
        Console.WriteLine("1. Side and an altitude to it.");
        Console.WriteLine("2. Three sides.");
        Console.WriteLine("3. Two sides and an angle between them");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter the side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter the altitude to it: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.Write("The triangle's area is: ");
                Console.WriteLine(TriangleAreaFormulas.TriangleArea(side, altitude));
                break;
            case "2":
                Console.Write("Enter the first side: ");
                double firstSide = double.Parse(Console.ReadLine());
                Console.Write("Enter the second side: ");
                double secondSide = double.Parse(Console.ReadLine());
                Console.Write("Enter the third side: ");
                double thirdSide = double.Parse(Console.ReadLine());
                Console.Write("The triangle's area is: ");
                Console.WriteLine(TriangleAreaFormulas.TriangleArea(firstSide, secondSide, thirdSide));
                break;
            case "3":
                Console.Write("Enter the first side: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter the second side: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle between them: ");
                double angle = double.Parse(Console.ReadLine());
                Console.Write("The triangle's area is: ");
                Console.WriteLine(TriangleAreaFormulas.TriangleArea(sideA, sideB, angle: angle));
                break;
            default:
                break;
        }
    }
}