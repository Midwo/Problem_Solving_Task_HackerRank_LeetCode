using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1550
    {
        ////(1550.) Three Consecutive Odds (EASY)
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            return false;
        }
    }
}
