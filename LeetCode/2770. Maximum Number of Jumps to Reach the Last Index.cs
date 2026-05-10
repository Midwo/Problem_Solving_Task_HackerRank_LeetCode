using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2770
    {
        ////(2770.) Maximum Number of Jumps to Reach the Last Index (MEDIUM)
        public int MaximumJumps(int[] nums, int target)
        {
            int length = nums.Length;
            int[] dpCountJumps = new int[length];
            Array.Fill(dpCountJumps, int.MinValue);

            dpCountJumps[0] = 0;

            for (int indexStart = 1; indexStart < length; indexStart++)
            {
                for (int prevIndex = 0; prevIndex < indexStart; prevIndex++)
                {
                    long diff = (long)nums[indexStart] - nums[prevIndex];
                    if (diff >= -target && diff <= target)
                    {
                        if (dpCountJumps[prevIndex] != -1)
                        {
                            dpCountJumps[indexStart] = Math.Max(dpCountJumps[indexStart], dpCountJumps[prevIndex] + 1);
                        }
                    }
                }
            }

            return dpCountJumps[length - 1] < 0 ? -1 : dpCountJumps[length - 1];
        }
    }
}
