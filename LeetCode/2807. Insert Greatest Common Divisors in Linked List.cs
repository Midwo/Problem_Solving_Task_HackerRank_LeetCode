using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2807
    {
        ////(2807.) Insert Greatest Common Divisors in Linked List (MEDIUM)
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode resultListNode = dummyHead;

            dummyHead.next = new ListNode(head.val);
            dummyHead = dummyHead.next;
            int last = head.val;
            int curr = 0;
            head = head.next;
            int a = 0;
            int b = 0;

            if (head != null)
            {
                while (head != null)
                {
                    curr = head.val;
                    a = curr;
                    b = last;

                    //while(a != b)
                    //{
                    //    if (a > b)
                    //    {
                    //        a = a - b;
                    //    }
                    //    else
                    //    {
                    //        b = b - a;
                    //    }
                    //}

                    //Console.WriteLine(head.val);

                    dummyHead.next = new ListNode(GCD(a, b));
                    dummyHead = dummyHead.next;
                    dummyHead.next = new ListNode(curr);
                    dummyHead = dummyHead.next;

                    head = head.next;
                    last = curr;
                }
            }

            return resultListNode.next;
        }
        public int GCD(int a, int b)
        {
            int rem = 0;

            while (b != 0)
            {
                rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
    }
}
