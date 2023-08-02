#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion


namespace Practice_7.Practice7Part2
{
    public class UniqueElementChecker
    {
        public int CountOfUniqueItems(int[] nums)
        {
            // Check if the input array is empty.
            if (nums.Length == 0)
            {
                return 0;
            }
                

            // use stack for create ordered list.
            Stack<int> uniqueStack = new Stack<int>();

            
            foreach (int num in nums)
            {
                // Check if the element is not already in the Stack.
                if (!uniqueStack.Contains(num))
                {
                    uniqueStack.Push(num);    // If its not in the Stack, add it to the Stack.
                }
            }

            // items in the Stack.
            return uniqueStack.Count;
        }
    }
}
