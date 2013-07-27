using System;

class IsBiggerIndex
{
    static int IsBigger(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
            {
                index = i;
                return index;
            }
        }
        return index;
    }

    static void Main()
    {
        int[] array = { 15, 12, 17, 98, 13, 14, 9, 85, 79, 35, 99, 69, 83, };
        int index = IsBigger(array);
        Console.WriteLine("The first element that is bigger than it's neighbours is at position {0}.", index);
        if (index == -1)
            Console.WriteLine("(There's no such element.)");
    }
}