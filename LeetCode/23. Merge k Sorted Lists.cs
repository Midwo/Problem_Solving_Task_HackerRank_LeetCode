using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_23
    {
        ////(23.) Merge k Sorted Lists (HARD)

        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode mergeList = new ListNode();
            ListNode result = new ListNode(0, mergeList);

            List<int> allValue = new List<int>();

            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    allValue.Add(lists[i].val);
                    lists[i] = lists[i].next;
                }
            }

            allValue.Sort();

            foreach (int i in allValue)
            {
                mergeList.next = new ListNode(i);
                mergeList = mergeList.next;
            }

            return result.next.next;
        }
    }
}
