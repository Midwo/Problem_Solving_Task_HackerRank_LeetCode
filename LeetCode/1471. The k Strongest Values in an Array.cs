using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1471
    {
        ////(1471.) The k Strongest Values in an Array (MEDIUM)
        public int[] GetStrongest(int[] arr, int k)
        {
            //Array.Sort(arr, (a,b) => b.CompareTo(a));
            Array.Sort(arr);

            int center = arr[(arr.Length - 1) / 2];

            //LINQ Options:
            //arr = arr.OrderByDescending(x => Math.Abs(x - center)).ThenByDescending(x => x).ToArray();

            Array.Sort(arr, (a, b) =>
            {
                int strengthA = Math.Abs(a - center);
                int strengthB = Math.Abs(b - center);

                int cmp = strengthB.CompareTo(strengthA);
                if (cmp != 0)
                    return cmp;
                return b.CompareTo(a);
            });

            return arr[0..k];
        }
    }
}
