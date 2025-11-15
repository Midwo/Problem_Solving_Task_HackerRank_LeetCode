using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3074
    {
        ////(3074.) Apple Redistribution into Boxes (EASY)
        public int MinimumBoxes(int[] apple, int[] capacity)
        {
            int sumApple = 0;
            int minBoxes = 0;
            foreach (int item in apple)
            {
                sumApple += item;
            }

            Array.Sort(capacity);
            int index = capacity.Length - 1;

            while (sumApple > 0 && index > -1)
            {
                sumApple -= capacity[index--];
                minBoxes++;
            }

            if(sumApple > 0)
            {
                return -1;
            }

            return minBoxes;
        }
    }
}
