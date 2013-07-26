using System;

class StringMatrix
{
    static void Main()
    {
        //Three variables to hold the three best sums for each loop.
        int currentSeqOne = 1;
        int currentSeqTwo = 1;
        int currentSeqThree = 1;
        int sequence = 1;                //every element represents a sequence with length 1
        int bestSeq = 1;                 //holds the best sequence
        string element = "";
        string[,] matrix = 
            {
                {"fi", "ho", "s",},
                {"ha", "hi", "s",},
                {"ho", "ha", "s",},
            };
        
        //The element at a given position can be equal to another element at one of the three adjacent position.
        //For a group of elements to be considered a sequence, the elements should neighbour each other and go in 
        //one direction, thus the three loops.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    sequence++;
                }

                if (sequence > bestSeq)
                {
                    bestSeq = sequence;
                    currentSeqOne = bestSeq;
                    element = matrix[row, col];
                }
            }
        }

        //reverting the value of sequence to default after each loop 
        sequence = 1;
        
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    element = element + " ";
                    sequence++;
                }

                if (sequence > bestSeq)
                {
                    bestSeq = sequence;
                    if (currentSeqOne >= bestSeq)
                    {
                        break;
                    }
                    currentSeqTwo = bestSeq;
                    element =  matrix[row, col];
                }
            }
        }

        sequence = 1;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    sequence++;
                }

                if (sequence > bestSeq)
                {
                    bestSeq = sequence;
                    if (currentSeqOne >= bestSeq || currentSeqTwo >= bestSeq)
                    {
                        break;
                    }
                    currentSeqThree = bestSeq;
                    element = matrix[row, col];
                }
            }
        }

        if (currentSeqOne > currentSeqTwo && currentSeqOne > currentSeqTwo)
        {
            bestSeq = currentSeqOne;
        }
        else if (currentSeqTwo > currentSeqOne && currentSeqTwo > currentSeqThree)
        {
            bestSeq = currentSeqTwo;
        }
        else if (currentSeqThree > currentSeqOne && currentSeqThree > currentSeqTwo)
        {
            bestSeq = currentSeqTwo;   
        }
        string[] seqElements = new string[bestSeq];
        Console.Write("The longest sequence is: ");
        for (int el = 0; el < bestSeq; el++)
        {
            seqElements[el] = element;
            Console.Write(seqElements[el] + " ");
        }
        Console.WriteLine();
    }
}