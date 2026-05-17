using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2095
    {
        ////(2095.) Delete the Middle Node of a Linked List (MEDIUM)
        public ListNode DeleteMiddle(ListNode head)
        {
            var dummyListNode = new ListNode(0, head);
            var slowListNode = dummyListNode;
            var fastListNode = head;

            while (fastListNode != null && fastListNode.next != null)
            {
                fastListNode = fastListNode.next.next;
                slowListNode = slowListNode.next;
            }

            slowListNode.next = slowListNode.next.next;

            return dummyListNode.next;
        }
    }
}
