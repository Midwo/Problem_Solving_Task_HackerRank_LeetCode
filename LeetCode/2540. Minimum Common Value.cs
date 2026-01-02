using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2540
    {
        ////(2540.) Minimum Common Value (EASY)
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int lengthNums1 = nums1.Length-1;
            int lengthNums2 = nums2.Length-1;

            int indexNums1 = 0;
            int indexNums2 = 0;
            int currValueNums1 = nums1[0];
            int currValueNums2 = nums2[0];

            while(indexNums1 > -1)
            {
                if (currValueNums1 < currValueNums2)
                {
                    if(++indexNums1 > lengthNums1)
                    {
                        return -1;
                    }
                    currValueNums1 = nums1[indexNums1];
                }
                else if (currValueNums1 > currValueNums2)
                {
                    if(++indexNums2 > lengthNums2)
                    {
                        return -1;
                    }
                    currValueNums2 = nums2[indexNums2];
                }
                else
                {
                    return currValueNums1;
                }
            }

            return -1;
        }
    }
}
