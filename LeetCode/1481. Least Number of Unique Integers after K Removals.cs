using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1481
    {
        ////(1481.) Least Number of Unique Integers after K Removals (MEDIUM)
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> dictValueCount = new Dictionary<int, int>();

            foreach (int value in arr)
            {
                if (dictValueCount.ContainsKey(value))
                {
                    dictValueCount[value]++;
                }
                else
                {
                    dictValueCount.Add(value, 1);
                }
            }

            List<int> listCountFromDictValue = new List<int>();
            foreach (var item in dictValueCount)
            {
                listCountFromDictValue.Add(item.Value);
            }

            listCountFromDictValue.Sort();

            int indexCount = 0;
            while (indexCount < listCountFromDictValue.Count && k > 0)
            {
                int currCount = listCountFromDictValue[indexCount];
                if (currCount > k)
                {
                    break;
                }
                else
                {
                    k -= currCount;
                }
                indexCount++;
            }

            return listCountFromDictValue.Count - indexCount;
        }
    }
}
