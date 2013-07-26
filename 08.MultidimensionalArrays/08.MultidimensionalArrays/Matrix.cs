using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("First Matrix:");
        //Console.Write("Enter matrix size (N x N):");
        //int num = int.Parse(Console.ReadLine());
        int num = 4;
        int[,] matrix = new int[num, num];
        int filling = 1;
        //FIRST MATRIX
        //filling the matrix
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                matrix[cols, rows] = filling;
                filling++;
            }
        }

        //printing the matrix
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        matrix = new int[num, num];
        int row = 0;
        int col = 0;
        string direction = "down";
        int maxRotations = num * num;
        //SECOND MATRIX
        //filling the matrix
        Console.WriteLine("Second Matrix:");
        for (int i = 1; i <= maxRotations; i++)
        {
            matrix[col, row] = i;
            if (direction == "down")
            {
                row++;
            }
            else
            {
                row--;
            }

            if (direction == "down" && row > num - 1)
            {
                row--;
                col++;
                direction = "up";
            }
            else if (direction == "up" && row < 0)
            {
                row++;
                col++;
                direction = "down";
            }
        }
        //printing the matrix
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.Write("{0,4}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        matrix = new int[num, num];
        row = 0;
        col = 0;
        direction = "down";
        //FOURTH MATRIX
        Console.WriteLine("Fourth Matrix:");
        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "down" && ((row > num - 1) || matrix[row, col] != 0))
            {
                row--;
                col++;
                direction = "right";
            }
            if (direction == "right" && ((col > num - 1) || matrix[row, col] != 0))
            {
                row--;
                col--;
                direction = "up";
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                col--;
                row++;
                direction = "left";
            }
            if (direction == "left" && ((col < 0) || matrix[row, col] != 0))
            {
                col++;
                row++;
                direction = "down";
            }

            matrix[row, col] = i;
            
            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            else if (direction == "left")
            {
                col--;
            }
        }


        //printing the matrix
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                Console.Write("{0,4}", matrix[cols, rows]);
            }
            Console.WriteLine();
        }
    }
}