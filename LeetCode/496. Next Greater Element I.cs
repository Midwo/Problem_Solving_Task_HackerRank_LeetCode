using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_496
    {
        ////(496.) Next Greater Element I (EASY)
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            bool find = false;
            for (int i = 0; i < nums1.Length; i++)
            {
                find = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (find == true)
                    {
                        if (nums1[i] < nums2[j])
                        {
                            nums1[i] = nums2[j];
                            break;
                        }
                        else if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                        }
                    }
                    else if (nums1[i] == nums2[j])
                    {
                        find = true;
                        if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                        }
                    }
                    else
                    {
                        if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                            break;
                        }
                    }
                }
            }
            return nums1;
        }
    }
}
