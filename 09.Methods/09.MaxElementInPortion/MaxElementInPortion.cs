using System;
//Write a method that return the maximal element in a portion of array of integers 
//starting at given index. Using it write another method that sorts an array in ascending / descending order.


class MaxElementInPortion
{
    static int MaxElement(int[] array, int startIndex, int endIndex)
    {
        int maxEl = int.MinValue;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] > maxEl)
            {
                maxEl = array[i];
            }
        }
        return maxEl;
    }

    static int MaxElementIndex(int[] array, int startIndex, int endIndex)
    {
        int maxEl = int.MinValue;
        int maxElIndex = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (array[i] > maxEl)
            {
                maxEl = array[i];
                maxElIndex = i;
            }
        }
        return maxElIndex;
    }

    static void SortArrayDescending(int[] array)
    {
        int endIndex = array.Length - 1;
        for (int i = 0; i < array.Length; i++)
        {
            int maxEl = MaxElement(array, i, endIndex);
            int maxElIndex = MaxElementIndex(array, i, endIndex);
            int temp = array[i];
            array[i] = array[maxElIndex];
            array[maxElIndex] = temp;
        }
    }

    static void SortArrayAscending(int[] array)
    {
        int startIndex = 0;
        int endIndex = array.Length - 1;
        for (int i = endIndex; i >= 0; i--)
        {
            int maxEl = MaxElement(array, startIndex, i);
            int maxElIndex = MaxElementIndex(array, startIndex, i);
            int temp = array[i];
            array[i] = array[maxElIndex];
            array[maxElIndex] = temp;
        }
    }

    static void Main()
    {
        Console.Write("Array before sorting: ");
        int[] myArray = { 15, 47, 39, -7, -19, -45, -8, 15, -1, 1, };
        foreach (var item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        int endIndex = myArray.Length - 1;
        int startIndex = 5;
        int maxEl = MaxElement(myArray, startIndex, endIndex);
        
        SortArrayDescending(myArray);
        Console.Write("Array sorted descending order: ");
        foreach (int item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        Console.Write("Array sorted in ascending order: ");
        SortArrayAscending(myArray);
        foreach (int item in myArray)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}