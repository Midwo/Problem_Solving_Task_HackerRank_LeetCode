using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_19
    {
        ////(19.) Remove Nth Node From End of List (MEDIUM)
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode result = new ListNode(0, head);
            ListNode beforePoint = result;
            ListNode afterPoint = result;

            while(0 < n--)
            {
                afterPoint = afterPoint.next;
            }

            while (afterPoint.next != null)
            {
                afterPoint = afterPoint.next;
                beforePoint = beforePoint.next;
            }

            beforePoint.next = beforePoint.next.next;
            return result.next;
        }
    }
}
