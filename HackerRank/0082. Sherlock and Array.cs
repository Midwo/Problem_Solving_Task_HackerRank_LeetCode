using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0082
    {
        ////82. Sherlock and Array (EASY)
        public string balancedSums(List<int> arr)
        {
            ////Solution 1 (New):

            var leftSum = 0;
            var rightSum = arr.Sum();

            foreach (var item in arr)
            {
                rightSum -= item;
                if (leftSum == rightSum)
                {
                    return "YES";
                }
                leftSum += item;
            }
            return "NO";


            ////Solution 2 (Old)

            //long lenght = arr.Count;
            //long total = arr.Sum();
            //long leftSum = 0;
            //long rightSum = total;

            //for (int i = 0; i < lenght; i++)
            //{
            //    rightSum -= arr[i];
            //    int leftIndex = (i == 0) ? 0 : i - 1;

            //    if (i > 0)
            //    {
            //        leftSum += arr[leftIndex];
            //    }
            //    if (leftSum == rightSum)
            //    {
            //        return "YES";
            //    }
            //}
            //return "NO";
        }
    }
}
