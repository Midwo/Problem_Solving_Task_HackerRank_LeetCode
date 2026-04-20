using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0106
    {
        ////106. Correctness and the Loop Invariant (EASY)
        public void insertionSort(int[] A)
        {            
            for (int i = 1; i < A.Length; i++) 
            {
                int currValue = A[i];
                int j = i - 1;

                while (j >= 0 && A[j] > currValue)
                {
                    A[j + 1] = A[j];
                    j--;
                }

                A[j + 1] = currValue;
            }

            Console.WriteLine(string.Join(' ', A));
        }
    }
}
