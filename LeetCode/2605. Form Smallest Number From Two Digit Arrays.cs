using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2605
    {
        ////(2605.) Form Smallest Number From Two Digit Arrays (EASY)
        public int MinNumber(int[] nums1, int[] nums2)
        {
            HashSet<int> nums1HashSet = new HashSet<int>() { nums1[0] };
            int minValueNums1 = nums1[0];
            int minValueNums2 = int.MaxValue;
            int minNumber = int.MaxValue;
            int firstOption = int.MaxValue;
            int secondOption = int.MaxValue;

            for (int i = 1; i < nums1.Length; i++) 
            { 
                nums1HashSet.Add(nums1[i]);
                minValueNums1 = minValueNums1 > nums1[i] ? nums1[i] : minValueNums1;    
            }

            for (int i = 0; i < nums2.Length; i++) 
            {
                int tempValue = nums2[i];
                if (nums1HashSet.Contains(tempValue))
                {
                    minNumber = minNumber > tempValue ? tempValue : minNumber;
                }
                minValueNums2 = minValueNums2 > tempValue ? tempValue : minValueNums2;
            }

            firstOption = minValueNums1 * 10 + minValueNums2;
            secondOption = minValueNums2 * 10 + minValueNums1;

            firstOption = firstOption < secondOption ? firstOption : secondOption;

            if (firstOption < minNumber)
            {
                return firstOption;
            }

            return minNumber;
        }
    }
}
