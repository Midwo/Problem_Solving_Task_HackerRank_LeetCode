using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1855
    {
        ////(1855.) Maximum Distance Between a Pair of Values (MEDIUM)
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            int lengthNums1 = nums1.Length;
            int lengthNums2 = nums2.Length;
            var maxDistance = -1;
            var currCheckIndexNums2 = 0;

            for (int indexNums1 = 0; indexNums1 < lengthNums1; indexNums1++)
            {
                var currValue = nums1[indexNums1];

                currCheckIndexNums2 = currCheckIndexNums2 < indexNums1 ? indexNums1 : currCheckIndexNums2;
                
                while(currCheckIndexNums2 < lengthNums2)
                {
                    if (currValue <= nums2[currCheckIndexNums2])
                    {
                        maxDistance = maxDistance < currCheckIndexNums2 - indexNums1 ? currCheckIndexNums2 - indexNums1 : maxDistance;
                        currCheckIndexNums2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return maxDistance == -1 ? 0 : maxDistance;
        }
    }
}
