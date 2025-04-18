using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_876
    {
        ////(876.) Middle of the Linked List (EASY)
        public ListNode MiddleNode(ListNode head)
        {
            ListNode ordinaryCopyHead = head;
            int countValue = 0;
            
            while (head != null)
            {
                countValue++;
                head = head.next;
            }
            int middle = countValue / 2;
             
            while(middle != 0)
            {
                ordinaryCopyHead = ordinaryCopyHead.next;
                middle--;
            }

            return ordinaryCopyHead;
        }
    }
}
