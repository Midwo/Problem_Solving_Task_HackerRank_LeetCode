using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1669
    {
        ////(1669.) Merge In Between Linked Lists (MEDIUM)
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode resultListNode = new ListNode(0);
            ListNode dummyResultListNode = resultListNode;
            int indexList1 = 0;
            bool runLoop = false;
            while (list1 != null)
            {
                if(indexList1 == a && !runLoop)
                {
                    while(list2 != null)
                    {
                        dummyResultListNode.next = list2;
                        dummyResultListNode = dummyResultListNode.next;
                        list2 = list2.next;
                    }
                    runLoop = true;
                }
                else
                {   
                    indexList1++;
                    if (runLoop)
                    {
                        for(int i = a; i <= b; i++)
                        {
                            list1 = list1.next;
                        }
                        runLoop = false;
                    }
                    else
                    {
                        dummyResultListNode.next = list1;
                        dummyResultListNode = dummyResultListNode.next;
                        list1 = list1.next;
                    }
                }

            }

            return resultListNode.next;
        }
    }
}
