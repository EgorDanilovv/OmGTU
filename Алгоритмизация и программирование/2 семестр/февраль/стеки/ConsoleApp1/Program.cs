using System;
using System.Collections.Generic;

class Program
{
    static bool AreBracketsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in expression)
        {
            if (ch == '(' ||  ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string expression = Console.ReadLine();


        if (AreBracketsBalanced(expression))
        {
            Console.WriteLine("Скобки в выражении сбалансированы.");
        }
        else
        {
            Console.WriteLine("Скобки в выражении не сбалансированы.");
        }
        Console.ReadKey();
    }
}