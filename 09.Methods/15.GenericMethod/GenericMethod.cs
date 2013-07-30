using System;

//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).
class ParamsMethods
{
    static T MinOfSet<T>(params T[] array)
    {
        dynamic minNum = array[0];
        dynamic length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if (array[i] < minNum)
            {
                minNum = array[i];
            }
        }
        return minNum;
    }

    static T MaxOfSet<T>(params T[] array)
    {
        dynamic maxNum = array[0];
        dynamic length = array.Length;
        for (int i = 0; i < length; i++)
        {
            if (array[i] > maxNum)
            {
                maxNum = array[i];
            }
        }
        return maxNum;
    }

    static T AverageOfSet<T>(params T[] array)
    {
        dynamic average;
        dynamic sum = 0;
        dynamic length = array.Length;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }
        average = sum / length;

        return average;
    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        dynamic length = array.Length;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        dynamic length = array.Length;
        for (int i = 0; i < length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine(MinOfSet(1, 2, 3, 4));
        Console.WriteLine(MaxOfSet(1, 2, 3, 4, 5, 7, 7.15));
        Console.WriteLine(AverageOfSet(1, 2, 3, 4, 4.3));
        Console.WriteLine(Sum(1, 2, 4));
        Console.WriteLine(Product(1, 2, 3, 4));
        Console.WriteLine(Product(0));
    }
}