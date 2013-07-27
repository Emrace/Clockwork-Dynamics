using System;
class GetMaxMethod
{
    static int GetMax(int firstNum, int secondNum)
    {
        int bigger = firstNum;
        if (secondNum > firstNum)
        {
            bigger = secondNum;
        }
        return bigger;
    }

    static void Main()
    {
        Console.WriteLine("Enter the three integers to be compared:");
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        int bigger = GetMax(firstInt, secondInt);
        Console.WriteLine("The biggest of the three integers is: {0}", GetMax(bigger, thirdInt));
        Console.WriteLine();
    }
}
