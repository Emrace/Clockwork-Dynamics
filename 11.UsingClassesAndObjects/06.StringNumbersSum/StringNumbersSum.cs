using System;

    class StringNumbersSum
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers on one line separated by spaces:");
            string[] strNums = Console.ReadLine().Split(' ');
            int numCount = strNums.Length;
            int[] numbers = new int[numCount];
            int sum = 0;
            for (int i = 0; i < numCount; i++)
            {
                numbers[i] = int.Parse(strNums[i]);
                sum += numbers[i];
            }
            Console.WriteLine("Their sum is: {0}", sum);
        }
    }