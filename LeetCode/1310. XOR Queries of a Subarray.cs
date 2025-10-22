using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1310
    {
        ////(1310.) XOR Queries of a Subarray (MEDIUM)
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            int[] result = new int[queries.Length];
            int lengthArr = arr.Length;
            int[] prefixArrSum = new int[lengthArr];
            prefixArrSum[0] = arr[0];

            for (int i = 1; i < lengthArr; i++)
            {
                prefixArrSum[i] = arr[i] ^ prefixArrSum[i - 1];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int sumXOR = 0;
                int l = queries[i][0]; 
                int r = queries[i][1];

                if (l == 0)
                {
                    sumXOR = prefixArrSum[r];
                }
                else
                {
                    sumXOR = prefixArrSum[l - 1] ^ prefixArrSum[r];
                }            

                result[i] = sumXOR;
            }

            return result;


            ////OR - very slow 
            
            //int[] result = new int[queries.Length];

            //for (int i = 0; i < queries.Length; i++)
            //{
            //    int sumXOR = 0;
            //    for (int j = queries[i][0]; j <= queries[i][1]; j++) 
            //    {
            //        sumXOR ^= arr[j];
            //    }

            //    result[i] = sumXOR;
            //}

            //return result;
        }
    }
}
