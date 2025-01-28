using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_234
    {
        ////(234.) Palindrome Linked List (EASY)
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            List<int> list = new List<int>();
            while (head != null) 
            {
                list.Add(head.val);
                head = head.next;
            }
            int countList = list.Count;
            for (int i = 0; i < countList; i++)
            {
                if (list[i] != list[countList-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
