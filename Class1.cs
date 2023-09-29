using System;
using System.Collections.Generic;

public class ParenthesesChecker
{
    public bool CheckParentheses(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false; // Stängande parentes utan motsvarande öppnande parentes
                }

                char open = stack.Pop();
                if (c == ')' && open != '(' || c == ']' && open != '[' || c == '}' && open != '{')
                {
                    return false; // Parenteserna matchar inte
                }
            }
        }

        return stack.Count == 0; // Om stacken är tom är parenteserna korrekt matchade
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParenthesesChecker checker = new ParenthesesChecker();
        Console.Write("Enter a string with parentheses: ");
        string input = Console.ReadLine();
        bool isValid = checker.CheckParentheses(input);
        if (isValid)
        {
            Console.WriteLine("The parentheses are correctly matched.");
        }
        else
        {
            Console.WriteLine("The parentheses are not correctly matched.");
        }
    }
}
