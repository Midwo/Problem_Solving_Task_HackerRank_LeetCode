using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_25
    {
        ////(25.) Reverse Nodes in k-Group (HARD)
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode result = new ListNode(0, head);
            ListNode currResult = result;
            int counter = 0;
            List<int> listValueHead = new List<int>();

            while (head != null)
            {
                counter++;
                listValueHead.Add(head.val);
                head = head.next;

                if (counter == k)
                {
                    counter = 0;
                    for (int i = 0; i < k; i++) 
                    {
                        result.next = new ListNode(listValueHead[k-1-i]);
                        result = result.next;
                    }
                    listValueHead.Clear();
                }
            }
            if (listValueHead.Count > 0)
            {
                for (int i = 0; i < listValueHead.Count; i++)
                {
                    result.next = new ListNode(listValueHead[i]);
                    result = result.next;
                }
            }

            return currResult.next;
        }
    }
}
