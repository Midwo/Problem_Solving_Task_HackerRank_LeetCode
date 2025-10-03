using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2130
    {
        ////(2130.) Maximum Twin Sum of a Linked List (MEDIUM)
        public int PairSum(ListNode head)
        {
            List<int> numsHead = new List<int>();
            int maxSum = int.MinValue;
            
            while (head != null) 
            {
                numsHead.Add(head.val);
                head = head.next;
            }
            int length = numsHead.Count;

            for (int i = 0; i < numsHead.Count / 2; i++) 
            {
                maxSum = Math.Max(maxSum, numsHead[i] + numsHead[length-1-i]);    
            }

            return maxSum;
        }
    }
}
