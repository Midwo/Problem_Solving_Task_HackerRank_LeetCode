using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0125
    {
        ////125. Equalize the Array (EASY)
        public int equalizeArray(List<int> arr)
        {
            ///Solution 1 (New)
            var freqNumber = new Dictionary<int, int>();
            int maxFreq = 1;

            foreach (var item in arr)
            {
                if(!freqNumber.TryAdd(item, 1))
                {
                    freqNumber[item]++;
                    int currFreq = freqNumber[item];
                    maxFreq = maxFreq < currFreq ? currFreq : maxFreq;
                }
            }

            return arr.Count - maxFreq;
            
            ////Solution 2 (Old)
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //int maxElement = 1;
            //foreach (int i in arr)
            //{
            //    if (!dictionary.ContainsKey(i))
            //    {
            //        dictionary.Add(i, 1);
            //    }
            //    else
            //    {
            //        int x = dictionary[i] + 1;
            //        dictionary[i] = x;
            //        if (maxElement < x)
            //        {
            //            maxElement = x;
            //        }
            //    }
            //}
            //Console.WriteLine(arr.Count - maxElement);
            //return arr.Count - maxElement;
        }
    }
}
