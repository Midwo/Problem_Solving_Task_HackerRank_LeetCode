using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0073
    {
        ////73. Largest Permutation (EASY)
        public List<int> largestPermutation(int k, List<int> arr)
        {
            if (k <= 0 || arr == null || !arr.Any())
            {
                return new List<int>();
            }
            int length = arr.Count;
            int currMaxValue = length;
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; ++i)
            {
                dic.Add(arr[i], i);
            }

            var currentIndex = 0;
            var countMove = 0;

            while (currentIndex < length && countMove < k)
            {
                if (arr[currentIndex] != currMaxValue)
                {
                    int temp = arr[currentIndex];
                    arr[currentIndex] = currMaxValue;
                    arr[dic[currMaxValue]] = temp;
                    dic[temp] = dic[currMaxValue];
                    currMaxValue--;
                    countMove++;
                }
                else
                {
                    currMaxValue--;
                }
                currentIndex++;
            }

            return arr;
        }
    }
}
