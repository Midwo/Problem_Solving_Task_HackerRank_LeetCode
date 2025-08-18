using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2220
    {
        ////(2220.) Minimum Bit Flips to Convert Number (EASY)
        public int MinBitFlips(int start, int goal)
        {
            int resultSumHowManyFlip = 0;

            string resultXOR = Convert.ToString(start ^ goal, 2);

            for (int i = 0; i < resultXOR.Length; i++)
            {
                if (resultXOR[i] == '1')
                {
                    resultSumHowManyFlip++;
                }
            }

            return resultSumHowManyFlip;
        }
    }
}
