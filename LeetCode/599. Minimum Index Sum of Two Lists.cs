using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_599
    {
        ////(599.) Minimum Index Sum of Two Lists(EASY)
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dictionaryList = new Dictionary<string, int>();
            
            int lengthList1 = list1.Length;
            int lengthList2 = list2.Length;
            int loopMaxLength = lengthList1>lengthList2? lengthList1: lengthList2;
            int minSumIndex = int.MaxValue;
            Dictionary<string, int> dictionaryListSUM = new Dictionary<string, int>();

            for (int i = 0; i < loopMaxLength; i++)
            {
                if (i < lengthList1)
                {
                    if (dictionaryList.ContainsKey(list1[i]))
                    {
                        dictionaryListSUM.Add(list1[i], dictionaryList[list1[i]] + i);
                        minSumIndex = minSumIndex < dictionaryList[list1[i]] + i ? minSumIndex: dictionaryList[list1[i]] + i;
                    }
                    else
                    {
                        dictionaryList.Add(list1[i], i);
                    }
                }
                if (i < lengthList2)
                {
                    if (dictionaryList.ContainsKey(list2[i]))
                    {
                        dictionaryListSUM.Add(list2[i], dictionaryList[list2[i]] + i);
                        minSumIndex = minSumIndex < dictionaryList[list2[i]] + i ? minSumIndex : dictionaryList[list2[i]] + i;
                    }
                    else
                    {
                        dictionaryList.Add(list2[i], i);
                    }
                }
            }
            List<string> resultList = new List<string>();

            foreach (var item in dictionaryListSUM)
            {
                if (item.Value == minSumIndex)
                {
                    resultList.Add(item.Key);
                }
            }         
            return resultList.ToArray();
        }
    }
}
