using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_944
    {
        ////(944.) Delete Columns to Make Sorted (EASY)
        public int MinDeletionSize(string[] strs)
        {
            int result = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j-1][i] > strs[j][i])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
