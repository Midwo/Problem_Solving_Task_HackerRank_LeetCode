using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3069
    {
        ////(3069.) Distribute Elements Into Two Arrays I (EASY)
        public int[] ResultArray(int[] nums)
        {
            int lastArr1Value = nums[0];
            int lastArr2Value = nums[1];
            List<int> arr1 = new List<int>() { lastArr1Value };
            List<int> arr2 = new List<int>() { lastArr2Value };

            for (int i = 2; i < nums.Length; i++) 
            { 
                int tempValue = nums[i];
                if (lastArr1Value > lastArr2Value)
                {
                    lastArr1Value = tempValue;
                    arr1.Add(tempValue);
                }
                else
                {
                    lastArr2Value = tempValue;
                    arr2.Add(tempValue);
                }
            }

            arr1.AddRange(arr2);
            return arr1.ToArray();
        }
    }
}
