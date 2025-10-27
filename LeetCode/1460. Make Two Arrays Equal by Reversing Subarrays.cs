using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1460
    {
        ////(1460.) Make Two Arrays Equal by Reversing Subarrays (EASY)
        public bool CanBeEqual(int[] target, int[] arr)
        {
            ////Solution #1
            ////0ms, Beats: 100.00%

            int[] countValueTarget = new int[1001];

            for (int i = 0; i < target.Length; i++)
            {
                countValueTarget[target[i]]++;
            }

            for (int i = 0; i < arr.Length; i++) 
            { 
                if (countValueTarget[arr[i]] == 0)
                {
                    return false;
                }
                countValueTarget[arr[i]]--;
            }
            return true;

            ////Solution #2
            ////10ms, Beats: 35.48%
            
            //Array.Sort(target);
            //Array.Sort(arr);

            //for(int i = 0; i < target.Length; i++)
            //{
            //    if (target[i] != arr[i])
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }
    }
}
