using System;
//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


public class NumberOfAppearances
{
    public static int AppearanceCount(int[] array, int givenNumber)
    {
        int count = 0;
        foreach (int element in array)
        {
            if (element == givenNumber)
                count++;
        }
        return count;
    }

    static void Main()
    {
        int[] array = { 15, 34, 75, 56, 15, 49, 23, 75, 1, 9, 15, 9, 27, 75, 85, 96, 69, 83, 15, };
        int wantedNumber = 15;
        Console.WriteLine("The number {0} appears {1} times in the array.",
            wantedNumber, AppearanceCount(array, wantedNumber));
    }
}