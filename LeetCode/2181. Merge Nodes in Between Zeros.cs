using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2181
    {
        ////(2181.) Merge Nodes in Between Zeros (MEDIUM)
        public ListNode MergeNodes(ListNode head)
        {
            ListNode dummy = head;
            ListNode copyDummy = dummy;
            List<int> MergeNodes = new List<int>();

            int currSum = 0;

            while (copyDummy != null)
            {
                if(copyDummy.val == 0)
                {
                    if(currSum > 0)
                    {
                        MergeNodes.Add(currSum);
                        currSum = 0;
                    }
                    else
                    {
                        currSum = 0;
                    }
                }
                else
                {
                    currSum += copyDummy.val;
                }
                copyDummy = copyDummy.next;
            }

            bool first = true;
            for (int i = 0; i < MergeNodes.Count; i++)
            {
                if (first)
                {
                    dummy.val = MergeNodes[i];
                    first = false;
                }
                else
                {
                    dummy.next = new ListNode(MergeNodes[i]);
                    dummy = dummy.next;
                }
            }
            dummy.next = null;

            return head;
        }
    }
}
