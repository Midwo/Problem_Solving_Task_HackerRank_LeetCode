using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2748
    {
        ////(2748.) Number of Beautiful Pairs (EASY)
        public int CountBeautifulPairs(int[] nums)
        {
            int beautifulPairsCount = 0;
            int length = nums.Length;

            for (int i = 0; i < length -1; i++)
            {
                string stringCurrNumber1 = nums[i].ToString();
                int currNumber1 = stringCurrNumber1[0] - '0';
                for (int j = i + 1; j < length; j++)
                {
                    string stringCurrNumber2 = nums[j].ToString();
                    if (GCD_CountBeautifulPairs(currNumber1, stringCurrNumber2[stringCurrNumber2.Length-1] - '0') == 1) beautifulPairsCount++;
                }
            }

            return beautifulPairsCount;
        }

        private int GCD_CountBeautifulPairs(int x, int y)
        {
            while(y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }

            return x;
        }
    }
}
