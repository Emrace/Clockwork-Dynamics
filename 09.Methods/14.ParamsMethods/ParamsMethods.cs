using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers
class ParamsMethods
{
    static int MinOfSet(params int[] array)
    {
        int minNum = array[0];
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if (array[i] < minNum)
            {
                minNum = array[i];
            }
        }
        return minNum;
    }

    static int MaxOfSet(params int[] array)
    {
        int maxNum = array[0];
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if (array[i] > maxNum)
            {
                maxNum = array[i];
            }
        }
        return maxNum;
    }

    static int AverageOfSet(params int[] array)
    {
        int average;
        int sum = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }
        average = sum / length;

        return average;
    }

    static int Sum(params int[] array)
    {
        int sum = 0;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int Product(params int[] array)
    {
        int product = 1;
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine(MinOfSet(1, 2, 3, 4));
        Console.WriteLine(MaxOfSet(1, 2, 3, 4));
        Console.WriteLine(AverageOfSet(1, 2, 3, 4));
        Console.WriteLine(Sum(1, 2, 3, 4));
        Console.WriteLine(Product(1, 2, 3, 4));
    }
}