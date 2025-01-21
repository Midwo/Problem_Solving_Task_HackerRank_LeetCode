using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_206
    {
        ////(206.) Reverse Linked List (EASY)
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode next;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
}
