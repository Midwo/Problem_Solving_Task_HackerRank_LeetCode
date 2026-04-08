using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3653
    {
        ////(3653.) XOR After Range Multiplication Queries I (MEDIUM)
        //[MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int XorAfterQueries(int[] nums, int[][] queries)
        {
            //int modulo = (int)(Math.Pow(10, 9) + 7);
            int modulo = 1000000007;
            int numsLenght = nums.Length;

            for (int indexQueries = 0; indexQueries < queries.Length; indexQueries++)
            {
                int idx = queries[indexQueries][0];
                int r1 = queries[indexQueries][1];
                int k1 = queries[indexQueries][2];
                long v1 = queries[indexQueries][3];

                while(idx <= r1)
                {

                    nums[idx] = (int)((nums[idx] * v1) % modulo);
                    
                    idx += k1; 
                }
            }

            int bitwiseXor = 0;

            for (int i = 0; i < numsLenght; i++)
            {
                bitwiseXor ^= nums[i];
            }

            return bitwiseXor;
        }
    }
}
