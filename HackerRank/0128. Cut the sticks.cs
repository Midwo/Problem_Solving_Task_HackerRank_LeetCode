using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0128
    {
        ////128. Cut the sticks (EASY)
        public List<int> cutTheSticks(List<int> arr)
        {
            ////Solution 1 (New)
            arr.Sort();
            int size = arr.Count;
            int lastValue = arr[0];

            var resultList = new List<int>() { size };

            for (int i = 1; i < size; i++)
            {
                int currValue = arr[i];
                if (lastValue == arr[i])
                    continue;
                lastValue = currValue;
                resultList.Add(size - i);
            }

            return resultList;


            ////Solution 2 (Old)
            //List<int> ret = new List<int>();
            //while (arr.Count > 0)
            //{
            //    ret.Add(arr.Count);
            //    int min = arr.Min();
            //    List<int> tmp = new List<int>();
            //    for (int i = 0; i < arr.Count; i++)
            //        if (arr[i] > min) tmp.Add(arr[i] - min);
            //    arr = tmp;
            //}
            //return ret;
        }
    }
}
