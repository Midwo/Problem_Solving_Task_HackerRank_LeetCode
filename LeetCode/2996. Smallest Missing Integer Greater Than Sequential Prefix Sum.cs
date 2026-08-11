using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2996
    {
        ////(2996.) Smallest Missing Integer Greater Than Sequential Prefix Sum (EASY)
        public int MissingInteger(int[] nums)
        {
            HashSet<int> uniqeValues = new HashSet<int>();

            foreach (int num in nums)
            {
                uniqeValues.Add(num);
            }

            int lastVallue = nums[0];
            int sumSequential = lastVallue;
            int lengthSequential = 1;
            for (int index = 1; index < nums.Length; index++)
            {
                int currValue = nums[index];
                if (currValue == lastVallue + 1)
                {
                    lengthSequential++;
                    sumSequential += currValue;
                }
                else
                {
                    break;
                }
                lastVallue = currValue;
            }

            while (true)
            {
                if (!uniqeValues.Contains(sumSequential))
                {
                    return sumSequential;                    
                }
                sumSequential++;
            }

        }
    }
}