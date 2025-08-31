using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2859
    {
        ////(2859.) Sum of Values at Indices With K Set Bits (EASY)
        public int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < nums.Count; i++) 
            {
                string tempBits = Convert.ToString(i, 2);
                int currCountOne = 0;
                for (int j = 0; j < tempBits.Length; j++) 
                { 
                    if (tempBits[j] == '1')
                    {
                        currCountOne++;
                        if(currCountOne > k)
                        {
                            break;
                        }
                    }
                }

                if (currCountOne == k)
                {
                    sum += nums[i];
                }
            }

            return sum;

        }
    }
}
