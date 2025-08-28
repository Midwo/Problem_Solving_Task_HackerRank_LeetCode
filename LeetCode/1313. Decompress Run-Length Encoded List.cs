using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1313
    {
        ////(1313.) Decompress Run-Length Encoded List (EASY)
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++) 
                {
                    resultList.Add(nums[i+1]);
                }
            }

            return resultList.ToArray();
        }
    }
}
