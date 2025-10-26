using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1295
    {
        ////(1295.) Find Numbers with Even Number of Digits (EASY)
        public int FindNumbers(int[] nums)
        {
            ////0ms, Beats: 100.00%
            
            int countEvenLength = 0;

            foreach (var item in nums)
            {
                if(item.ToString().Length % 2 == 0)
                {
                    countEvenLength++;
                }
            }

            return countEvenLength;
        }
    }
}
