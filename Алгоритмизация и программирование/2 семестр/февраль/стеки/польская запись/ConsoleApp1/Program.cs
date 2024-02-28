using System;
using System.Collections.Generic;

class Program
{
    static bool IsOperator(char ch)
    {
        return ch == '+' || ch == '-' || ch == '*' || ch == '/';
    }

    static int GetPrecedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

    static string ConvertToPOL(string expression)
    {
        Stack<char> stack = new Stack<char>();
        string result = "";

        foreach (char ch in expression)
        {
            if (char.IsLetterOrDigit(ch))
            {
                result += ch;
            }
            else if (IsOperator(ch))
            {
                while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(ch))
                {
                    result += stack.Pop();
                }
                stack.Push(ch);
            }
            else if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    result += stack.Pop();
                }
                stack.Pop(); // удаляет '('
            }
        }

        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }

    static void Main()
    {
        string expression = Console.ReadLine();
        string rpn = ConvertToPOL(expression);

        Console.WriteLine($"Обратная польская запись: {rpn}");
        Console.ReadKey();
    }
}