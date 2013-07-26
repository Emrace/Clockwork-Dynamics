using System;
/* Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
 * and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

class CircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Is a point with coordinates x and y within a circle ((1,1), 3) and outside \n \r a" + 
        " rectangle" +" with width = 6 and height = 2");
        Console.WriteLine("Enter coordinate x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate y: ");
        int y = int.Parse(Console.ReadLine());
        int r = 3;

        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= r * r)
        {
            Console.WriteLine("The point is inside the circle.");
            if ((x < (-1) || x > 5))
            {
                Console.WriteLine("It is outside the rectangle, though.");
            }
            else if (y > 1 || y < -1)
                {
                    Console.WriteLine("It is also outside the rectangle.");
                }
            else
                {
                    Console.WriteLine("It is also inside the rectangle");
                }                   
        }
        else
        {
           Console.WriteLine("The point is outside the circle.");
            if((x < (-1)) || x > 5)
            {
                Console.WriteLine("It is also outside the rectangle.");
            }
            else if (y > 1 || y < (-1))
            {
                Console.WriteLine("It is also outside the rectangle.");
            }
            else
            {
                Console.WriteLine("It is also inside the rectangle.");
            }
        }
                                
    }
}


