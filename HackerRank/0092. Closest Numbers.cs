using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0092
    {
        ////92. Closest Numbers (EASY)
        public List<int> closestNumbers(List<int> arr)
        {
            ////Solution 1 (New)
            arr.Sort();
            var minDiff = int.MaxValue;
            var lastValue = arr[0];
            var listWithMinDiff = new List<int>();

            for (int i = 1; i < arr.Count; i++)
            {
                var currValue = arr[i];
                var currDiff = currValue - lastValue;
                if(minDiff > currDiff)
                {
                    listWithMinDiff.Clear();
                    listWithMinDiff.Add(lastValue);
                    listWithMinDiff.Add(currValue);
                    minDiff = currDiff;
                }
                else if(minDiff == currDiff)
                {
                    listWithMinDiff.Add(lastValue);
                    listWithMinDiff.Add(currValue);
                }

                lastValue = currValue;
            }

            return listWithMinDiff;

            ////Solution 2 (Old)
            //arr.Sort();
            //List<int> arr2 = new List<int>();          
            //int lowDifference = int.MaxValue;

            //for (int i = 1; i < arr.Count; i++)
            //{
            //    int x = Math.Abs((arr[i - 1]) - arr[i]);
            //    if (x < lowDifference)
            //    {
            //        lowDifference = x;
            //        arr2.Clear();
            //        arr2.Add(arr[i - 1]);
            //        arr2.Add(arr[i]);
            //    }
            //    else if (x == lowDifference)
            //    {
            //        arr2.Add(arr[i - 1]);
            //        arr2.Add(arr[i]);
            //    }
            //}
            //return arr2;
        }
    }
}
