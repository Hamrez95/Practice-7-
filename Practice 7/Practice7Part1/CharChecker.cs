#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion


namespace Practice_7.Practice7Part1
{
    public class CharChecker
    {
        public bool IsValid(char[] s)
        {
            Stack<char> stack = new Stack<char>(); //store char in the stack

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c); //add char to stack
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || !IsMatchingBracket(stack.Pop(), c))
                        return false; // check empty stack and dismached char
                }
                
            }

            return stack.Count == 0; // Return true if all brackets are balanced
        }

        private bool IsMatchingBracket(char open, char close) //logic section of chars
        {
            return (open == '(' && close == ')') || (open == '{' && close == '}') || (open == '[' && close == ']');
        }
    }
}
