using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2248
    {
        ////(2248.) Intersection of Multiple Arrays (EASY)
        public IList<int> Intersection(int[][] nums)
        {
            int[] countNums = new int[1001];
            int length = nums.Length;
            List<int> listNumsMaxFreq = new List<int>();

            for (int i = 0; i < length; i++) 
            {
                for (int j = 0; j < nums[i].Length; j++) 
                {
                    countNums[nums[i][j]]++;
                }
            }

            for (int i = 1; i < 1001; i++)
            {
                if (countNums[i] == length)
                {
                    listNumsMaxFreq.Add(i);
                }
            }

            return listNumsMaxFreq.ToArray();
        }
    }
}
