using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1502
    {
        ////(1502.) Can Make Arithmetic Progression From Sequence (EASY)
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            ////3ms, Beats: 91.43%

            Array.Sort(arr);

            int diff = arr[1] - arr[0];

            for (int i = 2; i < arr.Length; i++) 
            { 
                if (arr[i] - arr[i-1] != diff)
                {
                    return false;
                }  
            }
            return true;
        }
    }
}
