using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2570
    {
        ////(2570.) Merge Two 2D Arrays by Summing Values (EASY)
        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            List<int[]> mergeList = new List<int[]>();
            int[] indexValueNums1 = nums1[0];
            int[] indexValueNums2 = nums2[0];

            int lengthNums1 = nums1.Length;
            int lengthNums2 = nums2.Length;
            int left = 0;
            int right = 0;

            while (left < lengthNums1 || right < lengthNums2) 
            {
                if (left == lengthNums1)
                {
                    mergeList.Add(new int[] { indexValueNums2[0], (indexValueNums2[1]) });
                    right++;
                    if (right < lengthNums2)
                    {
                        indexValueNums2 = nums2[right];
                    }
                }
                else if (right == lengthNums2)
                {
                    mergeList.Add(new int[] { indexValueNums1[0], (indexValueNums1[1]) });
                    left++;
                    if (left < lengthNums1)
                    {
                        indexValueNums1 = nums1[left];
                    }
                }
                else
                {
                    if (indexValueNums1[0] > indexValueNums2[0])
                    {
                        mergeList.Add(new int[] { indexValueNums2[0], indexValueNums2[1] });
                        right++;
                        if (right < lengthNums2)
                        {
                            indexValueNums2 = nums2[right];
                        }
                    }
                    else if (indexValueNums1[0] < indexValueNums2[0])
                    {
                        mergeList.Add(new int[] { indexValueNums1[0], indexValueNums1[1] });
                        left++;
                        if (left < lengthNums1)
                        {
                            indexValueNums1 = nums1[left];
                        }
                    }
                    else
                    {
                        mergeList.Add(new int[] { indexValueNums1[0], (indexValueNums1[1] + indexValueNums2[1]) });
                        left++;
                        right++;
                        if(left < lengthNums1)
                        {
                            indexValueNums1 = nums1[left];
                        }
                        if (right < lengthNums2)
                        {
                            indexValueNums2 = nums2[right];
                        }
                    }
                }
            }
            return mergeList.ToArray();
        }
    }
}
