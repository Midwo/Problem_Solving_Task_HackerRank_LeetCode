using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3314
    {
        ////(3314.) Construct the Minimum Bitwise Array I (EASY)
        public int[] MinBitwiseArray(IList<int> nums)
        {
            int length = nums.Count;
            int[] ans = new int[length];

            for (int i = 0; i < length; i++) 
            {
                bool notFound = true;
                int currNum = nums[i];
                for (int j = 1; j <= currNum; j++)
                {
                    int temp1 = j | (j+1);
                    int temp2 = j | (j + 1);
                    if (temp1 == temp2 && temp1 == currNum)
                    {
                        notFound = false;
                        ans[i] = j;
                        break;
                    }
                    if (notFound) ans[i] = -1;
                }
            }

            return ans;
        }
    }
}
