using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_148
    {
        ////(148.) Sort List  (MEDIUM)
        public ListNode SortList(ListNode head)
        {
            List<int> allValues = new List<int>();

            while (head != null) 
            { 
                allValues.Add(head.val);
                head = head.next;
            }

            allValues.Sort();

            if(allValues.Count == 0)
            {
                return head;
            }

            ListNode newListNode = new ListNode(allValues[0]);
            ListNode copy = newListNode;

            for (int i = 1; i < allValues.Count; i++)
            {
                ListNode currNode = new ListNode(allValues[i]);
                copy.next = currNode; 
                copy = copy.next;
            }
            
            return newListNode;
        }
    }
}
