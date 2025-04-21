using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_941
    {
        public bool ValidMountainArray(int[] arr)
        {
            int prevValue = arr[0];
            bool changeTrend = false;
            bool trendGrow = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (prevValue == arr[i])
                {
                    return false;
                }
                if (!changeTrend)
                {
                    if (prevValue > arr[i])
                    {
                        changeTrend = true;
                    }
                    else
                    {
                        trendGrow = true;
                    }
                }
                else
                {
                    if(prevValue < arr[i])
                    {
                        return false;
                    }
                }
                prevValue = arr[i];
            }
            if (changeTrend && trendGrow) { return true; }
            return false;
        }
    }
}
