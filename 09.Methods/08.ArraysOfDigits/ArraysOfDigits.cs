using System;
using System.Numerics;
using System.Text;

class ArraysOfDigits
{
    static BigInteger AddTwoIntegers(BigInteger[] firstArray, BigInteger[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        
        StringBuilder firstNumAsString = new StringBuilder();
        StringBuilder secondNumAsString = new StringBuilder();
        
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstNumAsString.Append(firstArray[i]);
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondNumAsString.Append(secondArray[i]);
        }

        BigInteger firstNum = BigInteger.Parse(firstNumAsString.ToString());
        BigInteger secondNum = BigInteger.Parse(secondNumAsString.ToString());

        BigInteger result = firstNum + secondNum;
        return result;
    }

    static void Main()
    {
        BigInteger[] firstNumber = { 1, 5, 4, 7, 9, 8, 3, };
        BigInteger[] secondNumber = { 0, 1, 7, 8, 9, 7, 6, };

        Console.Write("The first number is: ");
        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(firstNumber[i]);
        }
        Console.WriteLine();

        Console.Write("The second number is: ");
        for (int i = secondNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(secondNumber[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Their sum is {0}.", AddTwoIntegers(firstNumber, secondNumber));
    }
}