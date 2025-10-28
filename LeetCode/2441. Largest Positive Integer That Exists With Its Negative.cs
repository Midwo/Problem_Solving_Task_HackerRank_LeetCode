using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2441
    {
        ////(2441.) Largest Positive Integer That Exists With Its Negative (EASY)
        public int FindMaxK(int[] nums)
        {
            int[] intsTablePlus = new int[1001];
            int[] intsTableMinus = new int[1001];

            foreach (int i in nums) 
            {
                if(i > 0)
                {
                    intsTablePlus[i]++;
                }
                else
                {
                    intsTableMinus[i*-1]++;
                }
            }

            for (int i = 1000; i > 0; i--)
            {
                if (intsTableMinus[i] > 0 & intsTablePlus[i] > 0)
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
}
