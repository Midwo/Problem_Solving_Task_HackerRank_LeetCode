using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_898
    {
        ////(898.) Bitwise ORs of Subarrays (MEDIUM) 
        public int SubarrayBitwiseORs(int[] arr)
        {
            int length = arr.Length;
            HashSet<int> hashSet = new HashSet<int>();
            int currValue = 0;

            for (int i = 0; i < length; i++)
            {
                int SubValue = 0;
                currValue |= arr[i];

                for (int j = i; j >= 0; j--)
                {
                    SubValue |= arr[j];
                    hashSet.Add(SubValue);

                    if (SubValue == currValue)
                    {
                        break;
                    }
                }
            }

            return hashSet.Count();
        }
    }
}
