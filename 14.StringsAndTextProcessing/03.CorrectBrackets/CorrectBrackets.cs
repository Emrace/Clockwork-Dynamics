using System;
//Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        string exprCorrect = "((a+b)/5-d)";
        string exprIncorrect = ")a + b(";
        Console.WriteLine(CheckExpression(exprCorrect));
        Console.WriteLine(CheckExpression(exprIncorrect));
    }

    static bool CheckExpression(string expression)
    {
        char[] expressionArr = expression.ToCharArray();
        bool isCorrect = true;
        int bracketsOpen = 0;

        int openBracketIndex = expression.IndexOf('(');
        int closeBracketIndex = expression.IndexOf(')');

        if (openBracketIndex > closeBracketIndex)
        {
            return false;
        }

        for (int i = 0; i < expressionArr.Length; i++)
        {
            if (expressionArr[i] == '(')
            {
                bracketsOpen++;
            }
            else if (expressionArr[i] == ')')
            {
                bracketsOpen--;
            }
        }

        if (bracketsOpen != 0)
        {
            isCorrect = false;
        }
        return isCorrect;
    }
}