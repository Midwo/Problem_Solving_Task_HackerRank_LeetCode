using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1290
    {
        ////(1290.) Convert Binary Number in a Linked List to Integer (EASY)
        public int GetDecimalValue(ListNode head)
        {
            int sum = 0;

            while(head != null)
            {
                if(head.val == 1)
                {
                    sum = sum * 2 + 1;
                }
                else
                {
                    sum *= 2;
                }

                head = head.next;
            }

            return sum;
        }
    }
}
