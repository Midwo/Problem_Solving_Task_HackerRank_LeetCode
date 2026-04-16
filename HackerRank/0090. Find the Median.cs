using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0090
    {
        ////90. Find the Median (EASY)
        public int findMedian(List<int> arr)
        {
            ////Solution 1 (New)
            arr.Sort();
            return arr[arr.Count/2];

            ////Solution 2 (Old)
            //arr.Sort();
            //double median = arr[(arr.Count + 1) / 2 - 1];
            //return (int)median;
        }
    }
}
