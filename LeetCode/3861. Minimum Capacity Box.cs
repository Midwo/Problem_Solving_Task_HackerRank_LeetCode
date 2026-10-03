using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3861
    {
        ////(3861.) Minimum Capacity Box (EASY)
        public int MinimumIndex(int[] capacity, int itemSize)
        {
            int minIndex = int.MaxValue;
            int minCorrectValue = int.MaxValue;

            for(int index = 0; index < capacity.Length; index++)
            {
                int currValue = capacity[index];
                if(currValue > itemSize)
                {
                    if(minCorrectValue > currValue)
                    {
                        minCorrectValue = currValue;
                        minIndex = index;
                    }
                }
                else if(currValue == itemSize)
                {
                    return index;
                }
            }

            return minIndex == int.MaxValue ? -1 : minIndex;
        }
    }
}
