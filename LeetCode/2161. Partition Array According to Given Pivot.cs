using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2161
    {
        ////(2161.) Partition Array According to Given Pivot (MEDIUM)
        public int[] PivotArray(int[] nums, int pivot)
        {
            int[] result = new int[nums.Length];
            List<int> listGreater = new List<int>();
            int index = 0;
            int howManyPivotValue = 0;
            foreach (int x in nums) 
            { 
                if(x < pivot)
                {
                    result[index] = x;
                    index++;
                }
                else if ( x > pivot)
                {
                    listGreater.Add(x);
                }
                else 
                {
                    howManyPivotValue++;
                }
            }

            for (int i = 0; i < howManyPivotValue; i++)
            {
                result[index] = pivot;
                index++;
            }

            foreach (var item in listGreater)
            {
                result[index] = item;
                index++;
            }

            return result;

        }
    }
}
