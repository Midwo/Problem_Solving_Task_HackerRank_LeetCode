using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_61
    {
        ////(61.) Rotate List (MEDIUM)
        public ListNode RotateRight(ListNode head, int k)
        {
            var ListNodeCheckLength = head;
            int length = 0;

            while (ListNodeCheckLength != null)
            {
                length++;
                ListNodeCheckLength = ListNodeCheckLength.next;
            }

            //Console.WriteLine(length);
            if (k == 0 || length == 0)
            {
                return head;
            }

            int howManyOperations = k % length;

            if (howManyOperations == 0 || length == 0)
            {
                return head;
            }

            ListNode fastPointer = head;
            ListNode slowPointer = head;

            for (int i = 0; i < howManyOperations; i++)
            {
                fastPointer = fastPointer.next;
            }

            while (fastPointer.next != null)
            {
                fastPointer = fastPointer.next;

                slowPointer = slowPointer.next;
            }

            ListNode resultListNode = slowPointer.next;
            slowPointer.next = null;

            fastPointer.next = head;

            return resultListNode;
        }
    }
}
