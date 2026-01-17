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
       

        public  string GeneratePostfix(string expression)
        {
            Stack<string> stack = new Stack<string>();

            
            expression = CheckExpressionBetweenParentheses(expression);
            expression = CheckExpressionMultipliedOrDivided(expression);
            expression = CheckExpressionAddedOrSubtracted(expression);
            expression = this.moveOperatorToEndOfExpression(expression);
            
            return expression;
        }




        private string CheckExpressionBetweenParentheses(string expression)
        {
            int index = 0;
            while (index < expression.Length)
            {

                if (index + 5 <= expression.Length)
                {
                    if (Regex.Match(expression.Substring(index, 5), @"[(]\d[+]\d[)]|[(]\d[\/]\d[)]|[(]\d[*]\d[)]|[(]\d[-]\d[)]").Success)
                    {
                        string subexpression = expression.Substring(index, 5);
                        string temp = subexpression.Substring(1, 1) + subexpression.Substring(3, 1) + subexpression.Substring(2, 1);

                        expression = expression.Replace(subexpression, temp);
                       


                    }
                }
                index++;
            }
            return expression;
        }
        private string CheckExpressionMultipliedOrDivided(string expression)
        {
            int index = 0;
            while (index < expression.Length)
            {

                if (index + 3 <= expression.Length)
                {
                    if (Regex.Match(expression.Substring(index, 3), @"\d[\/]\d[)]|\d[*]\d").Success)
                    {
                        string subexpression = expression.Substring(index, 3);
                        string temp = subexpression.Substring(0, 1) + subexpression.Substring(2, 1) + subexpression.Substring(1, 1);

                        expression = expression.Replace(subexpression, temp);


                    }
                }
                index++;
            }
            return expression;
        }
        private string CheckExpressionAddedOrSubtracted(string expression)
        {
            int index = 0;
            while (index < expression.Length)
            {

                if (index + 3 <= expression.Length)
                {
                    if (Regex.Match(expression.Substring(index, 3), @"\d[-]\d[)]|\d[+]\d").Success)
                    {
                        string subexpression = expression.Substring(index, 3);
                        string temp = subexpression.Substring(0, 1) + subexpression.Substring(2, 1) + subexpression.Substring(1, 1);

                        expression = expression.Replace(subexpression, temp);


                    }
                }
                index++;
            }
            return expression;
        }
        private string moveOperatorToEndOfExpression(string expression)
        {
            int index = 0;
            while (index < expression.Length)
            {
                string subexpression;
                if (index + 2 <= expression.Length)
                {
                    if (Regex.Match(expression.Substring(index, 2), @"(?<=[+]|[-]|[*]|[\/])(\d+)").Success)
                    {
                        subexpression = expression.Substring(index,1);
                        string temp;
                        if (index + 4 <= expression.Length)
                        {
                             temp = expression.Substring(index + 1, 3) + subexpression;
                            expression = expression.Replace(expression.Substring(index, 4), temp);
                        }
                        else
                        {
                            temp = expression.Substring(index + 1) + subexpression;
                            expression = expression.Replace(expression.Substring(index, 2), temp);
                        }

                            
                    }
                    else
                    {
                        if (Regex.Match(expression.Substring(index, 1), @"(?<=[+]|[-]|[*]|[\/])(\d+)").Success)
                        {
                            subexpression = expression.Substring(index, 1);
                            string temp = subexpression + expression.Substring(index - 1);
                            expression = expression.Replace(expression.Substring(index ,3), temp);
                        }
                    }



                    

                   
                   
            }
                index++;

            }
            return expression;
        }

        
    }

  

}
