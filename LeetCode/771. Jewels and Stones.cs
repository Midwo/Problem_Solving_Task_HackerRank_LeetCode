using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_771
    {
        ////(771.) Jewels and Stones (EASY)
        public int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    result++;
                } 
            }
            return result;
        }
    }
}
