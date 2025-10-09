using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2553
    {
        public int[] SeparateDigits(int[] nums)
        {
            List<int> listAllNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 9)
                {
                    listAllNums.Add(nums[i]);
                }
                else
                {
                    string tempValue = nums[i].ToString();

                    for (int j = 0; j < tempValue.Length; j++)
                    {
                        listAllNums.Add((int)char.GetNumericValue(tempValue[j]));
                    }
                }
            }

            return listAllNums.ToArray();
        }
    }
}
