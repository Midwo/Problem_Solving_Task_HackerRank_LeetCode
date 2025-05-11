using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1207
    {
        ////(1207.) Unique Number of Occurrences (EASY)
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dictionaryArr = new Dictionary<int, int>();

            foreach (int item in arr)
            {
                if (dictionaryArr.ContainsKey(item))
                {
                    dictionaryArr[item]++;
                }
                else
                {
                    dictionaryArr.Add(item, 1);
                }
            }

            HashSet<int> uniqueCount = new HashSet<int>();

            foreach (var item in dictionaryArr) 
            {
                if (uniqueCount.Contains(item.Value))
                {
                    return false;
                }
                else
                {
                    uniqueCount.Add(item.Value);
                }
            }

            return true;
        }
    }
}
