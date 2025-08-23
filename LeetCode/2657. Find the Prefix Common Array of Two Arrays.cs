using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2657
    {
        ////(2657.) Find the Prefix Common Array of Two Arrays (MEDIUM)
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            Dictionary<int, int> dictionaryArray = new Dictionary<int, int>();
            int count = 0;

            for (int i = 0; i < A.Length; i++) 
            {
                if (dictionaryArray.ContainsKey(A[i]))
                {
                    count++;
                }
                else
                {
                    dictionaryArray.Add(A[i], 1);
                }
                if (dictionaryArray.ContainsKey(B[i]))
                {
                    count++;
                }
                else
                {
                    dictionaryArray.Add(B[i], 1);
                }

                A[i] = count;
            }

            return A;
        }
    }
}
