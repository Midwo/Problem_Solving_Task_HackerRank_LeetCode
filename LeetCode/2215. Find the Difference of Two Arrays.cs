using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2215
    {
        ////(2215.) Find the Difference of Two Arrays (EASY)
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            ////20ms, Beats: 87.33%
            
            IList<IList<int>> result = new List<IList<int>>();
            IList<int> listNum1 = nums1.ToList();
            IList<int> listNum2 = nums2.ToList();
            IList<int> listNum1Unique = new List<int>();
            IList<int> listNum2Unique = new List<int>();

            for (int i = 0; i < nums1.Length; i++) 
            { 
                if (!listNum2.Contains(nums1[i]) && !listNum1Unique.Contains(nums1[i]))
                {
                    listNum1Unique.Add(nums1[i]);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (!listNum1.Contains(nums2[i]) && !listNum2Unique.Contains(nums2[i]))
                {
                    listNum2Unique.Add(nums2[i]);
                }
            }

            result.Add(listNum1Unique);
            result.Add(listNum2Unique);

            return result;

            //OR - bad method
            //IList<IList<int>> result = new List<IList<int>>();
            //int lengthNums1 = nums1.Length;
            //int lengthNums2 = nums2.Length;

            //for (int i = 0; i < 2; i++)
            //{
            //    IList<int> currList = new List<int>();
            //    result.Add(currList);

            //    if (i == 0)
            //    {
            //        for (int j = 0; j < lengthNums1; j++)
            //        {
            //            int tempValue = nums1[j];
            //            bool addStatus = true;

            //            for (int k = 0; k < lengthNums2; k++)
            //            {
            //                if (tempValue == nums2[k])
            //                {
            //                    addStatus = false;
            //                    break;
            //                }
            //            }
            //            if (addStatus)
            //            {
            //                if (!currList.Contains(nums1[j]))
            //                {
            //                    currList.Add(nums1[j]);
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < lengthNums2; j++)
            //        {
            //            int tempValue = nums2[j];
            //            bool addStatus = true;

            //            for (int k = 0; k < lengthNums1; k++)
            //            {
            //                if (tempValue == nums1[k])
            //                {
            //                    addStatus = false;
            //                    break;
            //                }
            //            }
            //            if (addStatus)
            //            {
            //                if (!currList.Contains(nums2[j]))
            //                {
            //                    currList.Add(nums2[j]);
            //                }
            //            }
            //        }
            //    }
            //}

            //return result;
        }
    }
}
