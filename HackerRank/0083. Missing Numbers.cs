using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0083
    {
        ////83. Missing Numbers (EASY)
        public List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            ////Solution 1 (New)

            var diffDictionary = new Dictionary<int, int>();

            foreach (var number in brr)
            {
                if (!diffDictionary.TryAdd(number, 1))
                {
                    diffDictionary[number]++;
                }
            }

            foreach (var number in arr)
            {
                diffDictionary[number]--;  
            }

            var missingNumbersList = new List<int>();

            foreach (var item in diffDictionary)
            {
                if(item.Value > 0)
                {
                    missingNumbersList.Add(item.Key);
                }
            }

            missingNumbersList.Sort();

            return missingNumbersList;

            ////Solution 2 (Old)

            //List<int> listDifference = new List<int>();

            //foreach (int item in brr)
            //{
            //    int index = arr.IndexOf(item);
            //    if (index > -1)
            //    {
            //        arr.RemoveAt(index);
            //    }
            //    else
            //    {
            //        if (!listDifference.Contains(item))
            //        {
            //            listDifference.Add(item);
            //        }
            //    }
            //}

            //listDifference.Sort();

            //return listDifference;
        }
    }
}
