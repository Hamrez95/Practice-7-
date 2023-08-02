using Practice_7.Practice7Part1;
using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstPractice   
            CharChecker checker = new CharChecker();

            Console.WriteLine("Example 1:");
            Console.WriteLine("Input: '(', ')' ");
            Console.WriteLine("Output: " + checker.IsValid(new char[] { '(', ')' }));

            Console.WriteLine("\nExample 2:"); // \n for new line
            Console.WriteLine("Input: '(', '[', ']', '{', '}', ')' ");
            Console.WriteLine("Output: " + checker.IsValid(new char[] { '(', '[', ']', '{', '}', ')' }));

            Console.WriteLine("\nExample 3:");
            Console.WriteLine("Input: '(', ']' ");
            Console.WriteLine("Output: " + checker.IsValid(new char[] { '(', ']' }));

            Console.WriteLine("\nExample 4:");
            Console.WriteLine("Input: '(', '[', ']', ')', '{', '}', '[', ']', '{', '(', ')' ");
            Console.WriteLine("Output: " + checker.IsValid(new char[] { '(', '[', ']', ')', '{', '}', '[', ']', '{', '(', ')' }));
            #endregion

        }

    }
}


