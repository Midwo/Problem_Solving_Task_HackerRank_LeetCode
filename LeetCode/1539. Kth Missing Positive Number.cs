using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1539
    {
        ////(1539.) Kth Missing Positive Number (EASY)
        public int FindKthPositive(int[] arr, int k)
        {
            int lastNum = 0;
            int indexArr = 0;

            while (k > 0 && indexArr < arr.Length)
            {
                int currNum = arr[indexArr++];
                if (currNum - lastNum > 1)
                {
                    int diff = currNum - lastNum-1;
                    if (diff < k)
                    {
                        k -= diff;
                    }
                    else
                    {
                        return lastNum + k;
                    }
                }
                lastNum = currNum;
            }

            return lastNum + k;
        }
    }
}
