using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject.StackPracticeProblem
{
    public class PostFixEvaluator
    {
        public string EvaluatePostFix(string expression)
        {
            Stack<int> stack = new Stack<int>();
            char[] tokens = expression.ToCharArray();
            foreach (char token in tokens)
            {
                if (int.TryParse(token.ToString(), out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    int result = token switch
                    {
                        '+' => a + b,
                        '-' => a - b,
                        '*' => a * b,
                        '/' => a / b,
                        _ => throw new InvalidOperationException($"Invalid operator: {token}")
                    };
                    stack.Push(result);
                }
            }
            return stack.Pop().ToString();
        }

    }












public class PostFixGenerator
    {
        public string GeneratePostfix(string expression)
        {
            expression = expression.Replace(" ", "");
            Stack<char> ops = new Stack<char>();
            StringBuilder output = new StringBuilder();

            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    output.Append(c);
                }
                else if (c == '(')
                {
                    ops.Push(c);
                }
                else if (c == ')')
                {
                    while (ops.Peek() != '(')
                        output.Append(ops.Pop());
                    ops.Pop(); // remove '('
                }
                else // operator
                {
                    while (ops.Count > 0 && Precedence(ops.Peek()) >= Precedence(c))
                        output.Append(ops.Pop());
                    ops.Push(c);
                }
            }

            while (ops.Count > 0)
                output.Append(ops.Pop());

            return output.ToString();
        }

        private int Precedence(char op)
        {
            if (op == '*' || op == '/') return 2;
            if (op == '+' || op == '-') return 1;
            return 0;
        }
    }
}