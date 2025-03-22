using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_24
    {
        ////(24.) Swap Nodes in Pairs (MEDIUM)
        public ListNode SwapPairs(ListNode head)
        {
            ListNode result = new ListNode(0, head);
            ListNode currResult = result;

            int firstValueToSecondPlace = 0;
            int secondValueToFirstPlace = 0;

            while (head != null)
            {
                firstValueToSecondPlace = head.val;
                head = head.next;
                if (head == null)
                {
                    result.next = new ListNode(firstValueToSecondPlace);
                    break;
                }
                secondValueToFirstPlace = head.val;
                head = head.next;
                result.next = new ListNode(secondValueToFirstPlace);
                result = result.next;
                result.next = new ListNode(firstValueToSecondPlace);
                result = result.next;
            }
            
            return currResult.next;
        }
    }
}
