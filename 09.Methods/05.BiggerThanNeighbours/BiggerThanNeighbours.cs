using System;
//Write a method that checks if the element at given position in given array of integers is bigger than
//its two neighbors (when such exist).


class BiggerThanNeighbours
{
    static bool IsBigger(int[] array, int position)
    {
        bool isBigger = false;
        if (array[position] > array[position - 1] && array[position] > array[position + 1])
        {
            isBigger = true;
        }
        return isBigger;
    }

    static void Main()
    {
        bool isBigger = false;
        int pos = 12;
        int[] array = { 15, 23, 17, 98, 13, 14, 9, 85, 79, 35, 99, 69, 83, };
        if ((pos - 1 >= 0) && (pos + 1 <= array.Length - 1))
        {
            isBigger = IsBigger(array, pos);
            Console.WriteLine("The element at position {0} is bigger than it's neighbours: {1}.", pos, isBigger);
        }
        else if (pos - 1 < 0)
        {
            isBigger = array[pos] > array[pos + 1];
            Console.WriteLine("The element has only one neighbour at position {0}.", pos + 1);
            Console.WriteLine("Our element is bigger than it: {0}.", isBigger);
        }
        else
        {
            isBigger = array[pos] > array[pos - 1];
            Console.WriteLine("The element has only one neighbour at position {0}.", pos - 1);
            Console.WriteLine("Our element is bigger than it: {0}.", isBigger);
        }
    }
}
