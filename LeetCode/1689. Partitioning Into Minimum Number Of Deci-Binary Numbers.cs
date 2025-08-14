using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1689
    {
        ////(1689.) Partitioning Into Minimum Number Of Deci-Binary Numbers (MEDIUM)
        public int MinPartitions(string n)
        {
            char currHighChar = n[0];

            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > currHighChar)
                {
                    currHighChar = n[i];
                    if (currHighChar == '9')
                    {
                        return 9;
                    }
                }
            }

            return currHighChar - '0';
        }
    }
}
