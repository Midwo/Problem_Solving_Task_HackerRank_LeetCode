using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_203
    {
        ////(203.) Remove Linked List Elements (EASY)
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode copyHeadWithAddFirstRecord = new ListNode(0);
            copyHeadWithAddFirstRecord.next = head;
            ListNode correctedList = copyHeadWithAddFirstRecord;

            while (correctedList.next != null)
            {
                if (correctedList.next.val == val)
                {
                    correctedList.next = correctedList.next.next;
                }
                else
                {
                    correctedList = correctedList.next;
                }
            }
            return copyHeadWithAddFirstRecord.next;
        }
    }
}
