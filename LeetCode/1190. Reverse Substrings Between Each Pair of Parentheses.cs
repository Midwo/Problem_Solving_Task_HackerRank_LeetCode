using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1190
    {
        ////(1190.) Reverse Substrings Between Each Pair of Parentheses (MEDIUM)
        
        ////Solution 1
        public string ReverseParentheses(string s)
        {
            StringBuilder sbResult = new StringBuilder();

            int length = s.Length;

            Stack<int> stackIndexOpened = new Stack<int>();

            for (int index = 0; index < length; index++)
            {
                char currChar = s[index];

                if (currChar == '(')
                {
                    stackIndexOpened.Push(sbResult.Length);
                }
                else if (currChar == ')')
                {
                    int lIndex = stackIndexOpened.Pop();
                    int rIndex = sbResult.Length-1;

                    while (lIndex < rIndex)
                    {
                        char temp = sbResult[lIndex];
                        sbResult[lIndex++] = sbResult[rIndex];
                        sbResult[rIndex--] = temp;
                    }
                }
                else
                {
                    sbResult.Append(currChar);
                }
            }
            return sbResult.ToString();
        }

        ////Solution 2
        //public string ReverseParentheses(string s)
        //{
        //    StringBuilder sbTemp = new StringBuilder();
        //    StringBuilder sbResult = new StringBuilder();

        //    int length = s.Length;

        //    Stack<int> stackIndexOpened = new Stack<int>();

        //    for (int index = 0; index < length; index++)
        //    {
        //        char currChar = s[index];
        //        sbTemp.Append(currChar);

        //        if (currChar == '(')
        //        {
        //            stackIndexOpened.Push(index);
        //        }
        //        else if (currChar == ')')
        //        {
        //            int lIndex = stackIndexOpened.Pop();
        //            int rIndex = index;

        //            while(lIndex < rIndex)
        //            {
        //                char temp = sbTemp[lIndex];
        //                sbTemp[lIndex++] = sbTemp[rIndex];
        //                sbTemp[rIndex--] = temp;
        //            }
        //        }
        //    }

        //    for (int index = 0; index < sbTemp.Length; index++)
        //    {
        //        char currChar = sbTemp[index];
        //        if (currChar != '(' && currChar != ')')
        //        {
        //            sbResult.Append(currChar);
        //        }
        //    }

        //    return sbResult.ToString();
        //}
    }
}
