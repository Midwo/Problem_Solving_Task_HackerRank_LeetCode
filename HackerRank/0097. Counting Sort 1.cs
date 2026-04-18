using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0097
    {
        ////97. Counting Sort 1 (EASY)
        public List<int> countingSort(List<int> arr)
        {
            ////Solution 1 (New - Better)

            if(arr.Count == 0)
                return new List<int>();

            var freqNums = new int[100];

            for (int index = 0; index < arr.Count; index++)
            {
                freqNums[arr[index]]++;
            }

            return freqNums.ToList();

            ////Solution 2 (Old - Poor)
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();

            //int maxValue = arr.Max();

            //foreach (int i in arr)
            //{
            //    if (!dictionary.ContainsKey(i))
            //    {
            //        dictionary.Add(i, 1);
            //    }
            //    else
            //    {
            //        dictionary[i] = dictionary[i] + 1;
            //    }
            //}

            //arr.Clear();

            //for (int i = 0; i < 100; i++)
            //{
            //    if (dictionary.ContainsKey(i))
            //    {
            //        arr.Add(dictionary[i]);
            //    }
            //    else
            //    {
            //        arr.Add(0);
            //    }
            //}
            //return arr;
        }

    }
}
