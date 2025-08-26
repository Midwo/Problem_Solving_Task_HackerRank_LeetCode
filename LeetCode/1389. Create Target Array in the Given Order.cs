using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1389
    {
        ////(1389.) Create Target Array in the Given Order (EASY)
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> arrayList = new List<int>();

            for (int i = 0; i < index.Length; i++)
            {
                arrayList.Insert(index[i], nums[i]);
            }

            return arrayList.ToArray();
        }
    }
}
