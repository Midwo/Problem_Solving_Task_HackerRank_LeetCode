using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2848
    {
        ////(2848.) Points That Intersect With Cars (EASY)
        public int NumberOfPoints(IList<IList<int>> nums)
        {
            IList<IList<int>> sortedList = nums.OrderBy(x => x[0]).ToList();

            int min = 0;
            int max = 0;
            int sum = 0;

            for (int i = 0; i < sortedList.Count; i++)
            {
                if (max >= sortedList[i][0])
                {
                    max = max < sortedList[i][1]? sortedList[i][1] : max;
                }
                else if (i == 0)
                {
                    min = sortedList[i][0];
                    max = sortedList[i][1];
                }
                else
                {
                    sum += max - min + 1;
                    min = sortedList[i][0];
                    max = sortedList[i][1];
                }
            }

            if (min <= max)
            {
                sum += max - min + 1;
            }

            return sum;
        }
    }
}
