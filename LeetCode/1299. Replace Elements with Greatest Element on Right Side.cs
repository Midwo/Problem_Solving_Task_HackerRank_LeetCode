using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1299
    {
        ////(1299.) Replace Elements with Greatest Element on Right Side (EASY)
        public int[] ReplaceElements(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            int currMAx = arr[arr.Length-1];
            newArr[arr.Length - 1] = -1;

            for (int i = arr.Length-2; i >= 0; i--)
            {
                newArr[i] = currMAx;
                currMAx = currMAx < arr[i] ? arr[i] : currMAx;
            }

            return newArr;
        }
    }
}
