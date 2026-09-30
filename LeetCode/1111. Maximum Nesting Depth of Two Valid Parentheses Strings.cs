using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1111
    {
        ////(1111.) Maximum Nesting Depth of Two Valid Parentheses Strings (MEDIUM)
        public int[] MaxDepthAfterSplit(string seq)
        {
            int length = seq.Length;
            int[] result = new int[length];
            int countOpen = 0;

            for(int index = 0; index < length; index++)
            {
                char currChar = seq[index];

                if (currChar == '(')
                {
                    countOpen++;
                    result[index] = countOpen % 2;
                }
                else
                {
                    result[index] = countOpen % 2;
                    countOpen--;
                }
            }

            return result;
        }
    }
}
