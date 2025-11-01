using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3217
    {
        ////(3217.) Delete Nodes From Linked List Present in Array (MEDIUM)
        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            ////Solution #1

            bool[] statusNums = new bool[100001];

            foreach (var item in nums)
            {
                statusNums[item] = true;
            }

            while (head != null & statusNums[head.val] == true)
            {
                head = head.next;
            }

            if (head == null)
            {
                return null;
            }

            ListNode dummy = head;

            while (dummy.next != null)
            {
                if (statusNums[dummy.next.val] == true)
                {
                    dummy.next = dummy.next.next;
                }
                else
                {
                    dummy = dummy.next;
                }
            }

            return head;

            ////Solution #2
            
            //HashSet<int> numsToDelete = new HashSet<int>();

            //foreach (var item in nums)
            //{
            //    numsToDelete.Add(item);
            //}

            //while (head != null & numsToDelete.Contains(head.val))
            //{
            //    head = head.next;
            //}

            //if (head == null)
            //{
            //    return null;
            //}

            //ListNode dummy = head;

            //while (dummy.next != null)
            //{
            //    if (numsToDelete.Contains(dummy.next.val))
            //    {
            //        dummy.next = dummy.next.next;
            //    }
            //    else
            //    {
            //        dummy = dummy.next;
            //    }
            //}

            //return head;
        }
    }
}
