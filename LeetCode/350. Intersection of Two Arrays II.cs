using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_350
    {
        ////(350.) Intersection of Two Arrays II (EASY)
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int howLongNums1 = nums1.Length;
            int howLongNums2 = nums2.Length;
            List<int> result = new List<int>();
            int currIndex = 0;
            if (howLongNums1 > howLongNums2)
            {
                for (int i = 0; i < howLongNums1; i++)
                {
                    for (int j = currIndex; j < howLongNums2; j++)
                    {
                        if (nums1[i] == nums2[j])
                        {
                            currIndex++;
                            result.Add(nums1[i]);
                            break;
                        }
                        else if (nums1[i] < nums2[j])
                        {
                            break;
                        }
                        currIndex++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < howLongNums2; i++)
                {
                    for (int j = currIndex; j < howLongNums1; j++)
                    {
                        if (nums2[i] == nums1[j])
                        {
                            currIndex++;
                            result.Add(nums2[i]);
                            break;
                        }
                        else if (nums2[i] < nums1[j])
                        {
                            break;
                        }
                        currIndex++;
                    }
                }
            }
            return result.ToArray();
        }
    }
}
