using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2
    {
        /////(2.) Add Two Numbers (MEDIUM)
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sumVal = 0;
            int restDivinity = 0;
            ListNode result = new ListNode(0);
            ListNode current = result;
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    sumVal += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null) 
                {
                    sumVal += l2.val;
                    l2 = l2.next;
                }
                if (current != null)
                {
                    sumVal = sumVal + restDivinity;
                    restDivinity = 0;
                    if (sumVal < 10)
                    {
                        current.next = new ListNode(sumVal);
                    }
                    else
                    {
                        restDivinity = 1;
                        sumVal -= 10;
                        current.next = new ListNode(sumVal);
                    }
                    current = current.next;
                }
                else
                {
                    sumVal = sumVal + restDivinity;
                    restDivinity = 0;
                    if (sumVal < 10)
                    {
                        current = new ListNode(sumVal);
                    }
                    else
                    {
                        restDivinity = 1;
                        sumVal -= 10;
                        current = new ListNode(sumVal);
                    }
                }
                sumVal = 0;
            }
            if (restDivinity != 0)
            {
                current.next = new ListNode(1);
            }
            return result.next;
        }
    }
}
