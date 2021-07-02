using System;
using System.Collections;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        public static char[,] Tokens = new char[,]
        {
                {'{', '}' },
                {'[', ']' },
                {'(', ')'}
                
        };

        //version 2.0
        public static bool isBalanced(string expression)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (char item in expression.ToCharArray())
            {
                if (isOpenTerms(item))
                {
                    myStack.Push(item);
                }
                else
                {
                    if ((myStack.Count == 0) || !matches(myStack.Pop(), item))
                    {
                        return false;
                    }
                }
            }
            if (myStack.Count == 0)
            {
                return true;
            }
            else
                return false;
        }

        private static bool matches(char openTerm, char closeTerm)
        {
            for (int i = 0; i <= Tokens.Rank; i++)
            {
                if (Tokens[i, 0] == openTerm)
                {
                    var res = Tokens[i, 1] == closeTerm;
                    return res;
                }
            }
            return false;
        }

        private static bool isOpenTerms(char item)
        {
            for (int i = 0; i <= Tokens.Rank; i++)
            {
                if (Tokens[i, 0] == item)
                {
                    return true;
                }
            }
            return false;
        }


        //version 1.0
        //public static string isBalanced(string expression)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char item in expression.ToCharArray())
        //    {
        //        if((item=='(') || (item=='{') || (item == '['))
        //        {
        //            stack.Push(item);
        //        }
        //        else
        //        {
        //            if (stack.Count == 0)
        //            {
        //                return "NO";
        //            }
        //            else
        //            {
        //                char topStack = stack.Pop();
        //                if((item==')') && topStack != '(')
        //                {
        //                    return "NO";
        //                }
        //                else if ((item == '}') && topStack != '{')
        //                {
        //                    return "NO";
        //                }
        //                else if ((item == ']') && topStack != '[')
        //                {
        //                    return "NO";
        //                }
        //            }
        //        }
        //    }
        //    if (stack.Count == 0)
        //    {
        //        return "YES";
        //    }
        //    else
        //        return "NO";

        //}



        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string expression = Console.ReadLine();

                //string res = isBalanced(expression);
                var res = isBalanced(expression);

                if(res)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
