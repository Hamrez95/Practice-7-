using Practice_7.Practice7Part1;
using Practice_7.Practice7Part2;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstPractice   
            CharChecker checker = new CharChecker();

            Console.WriteLine("Practice7-Part1");

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
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            #endregion

            #region SecondPractice

            Console.WriteLine("\nPractice7-Part2");
            // Sample 
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 66, 77, 77, 777 };

            
            UniqueElementChecker uniqueElementChecker = new UniqueElementChecker();

            // Call the CountOfUniqueItems method 
            int countOfUniqueItems = uniqueElementChecker.CountOfUniqueItems(nums1);

            
            Console.WriteLine("\nInput: nums1 = [ 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 66, 77, 77, 777 ]");
            Console.WriteLine("Output: " + countOfUniqueItems);
            #endregion
        }

    }
}


