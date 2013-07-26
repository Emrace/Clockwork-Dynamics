using System;

class MaxPlatform
{
    static void Main()
    {
        // Declare and initialize the matrix
        int[,] matrix = 
		{
			{0, 2, 4, 0, 9,},
			{7, 1, 3, 3, 2,},
			{1, 3, 9, 8, 5,},
			{4, 6, 7, 9, 1,},
            {5, 1, 6, 0, 8,},
		};    
              
        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow, bestCol],
            matrix[bestRow, bestCol + 1],
            matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow + 1, bestCol],
            matrix[bestRow + 1, bestCol + 1],
            matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow + 2, bestCol],
            matrix[bestRow + 2, bestCol + 1],
            matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}
