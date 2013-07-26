using System;

class BinSearch
{
    static void Main()
    {
        int numberK = 15;
        int[] arrayOfIntegers = { 47, 13, 27, 35, 26, 78, 34, 4, 0, 17, 36, 72, 5, 9, 8 };

        //Sorting the array
        Array.Sort(arrayOfIntegers);

        
        int answer = 0;

        for (int i = numberK; i >= arrayOfIntegers[0]; i--)
        {
            if (Array.BinarySearch(arrayOfIntegers, i) >= 0)
            {
                answer = arrayOfIntegers[Array.BinarySearch(arrayOfIntegers, i)];
                break;
            }
        }

        Console.WriteLine("The largest integer (<=K) is {0} ", answer);
    }
}
