using System;
using System.Collections;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        public static string isBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char item in expression.ToCharArray())
            {
                if((item=='(') || (item=='{') || (item == '['))
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return "NO";
                    }
                    else
                    {
                        char topStack = stack.Pop();
                        if((item==')') && topStack != '(')
                        {
                            return "NO";
                        }
                        else if ((item == '}') && topStack != '{')
                        {
                            return "NO";
                        }
                        else if ((item == ']') && topStack != '[')
                        {
                            return "NO";
                        }
                    }
                }
            }
            if (stack.Count == 0)
            {
                return "YES";
            }
            else
                return "NO";
            
        }

     

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string expression = Console.ReadLine();

                string res = isBalanced(expression);

                Console.WriteLine(res);
            }
        }
    }
}
