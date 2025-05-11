using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1200
    {
        ////(1200.) Minimum Absolute Difference (EASY)
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(arr);

            int minAbs = int.MaxValue;

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = 0;
                if (arr[i-1] < 0 && arr[i] > 0)
                {
                    temp = arr[i] + Math.Abs(arr[i - 1]);
                }
                else
                {
                    temp = Math.Abs(Math.Abs(arr[i-1])-Math.Abs(arr[i]));
                }
                minAbs = minAbs < temp ? minAbs : temp;
            }

            //Console.WriteLine(minAbs);

            for (int i = 1; i<arr.Length; i++)
            {
                int temp = 0;
                if (arr[i - 1] < 0 && arr[i] > 0)
                {
                    temp = arr[i] + Math.Abs(arr[i - 1]);
                }
                else
                {
                    temp = Math.Abs(Math.Abs(arr[i - 1]) - Math.Abs(arr[i]));
                }
                if (temp == minAbs)
                {
                    result.Add(new List<int>() { arr[i-1], arr[i] });
                }
            }

            return result;
        }
    }
}
