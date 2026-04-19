using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0101
    {
        ////101. Quicksort 1 - Partition (EASY)
        public List<int> quickSort(List<int> arr)
        {
            var left = new List<int>();
            var pivot = arr[0];
            var right = new List<int>();
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }
            left.Add(pivot);
            left.AddRange(right);
            return left;
        }
    }
}
