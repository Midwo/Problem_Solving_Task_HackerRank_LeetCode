using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0034
    {
        ////34. Mini-Max Sum (EASY)
        public void miniMaxSum(List<int> arr)
        {
            arr = arr.OrderBy(p => p).ToList();
            long min = 0;
            long max = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                min += arr[i];
            }
            //  Console.WriteLine(min);
            for (int i = 1; i < arr.Count; i++)
            {
                max += arr[i];
            }
            Console.WriteLine("{0} {1}", min, max);
        }

    }
}
