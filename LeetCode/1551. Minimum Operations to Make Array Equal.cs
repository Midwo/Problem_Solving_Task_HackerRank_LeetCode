using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1551
    {
        ////(1551.) Minimum Operations to Make Array Equal (MEDIUM)
        public int MinOperations(int n)
        {
            int result = 0;

            int[] arrayN = new int[n];
            int length = arrayN.Length;
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = (2 * i) + 1;
            }

            int indexL = 0;
            int indexR = length - 1;
            int seachrNumber = 0;

            if (length % 2 == 0)
            {
                seachrNumber = (arrayN[length / 2]+arrayN[length / 2-1])/2;
                while (indexL < indexR)
                {
                    result += seachrNumber - arrayN[indexL++];
                    indexR--;
                }
            }
            else
            {
                seachrNumber = arrayN[length / 2];
                while (indexL < indexR)
                {
                    result += seachrNumber - arrayN[indexL++];
                    indexR--;
                }
            }

            return result;
        }
    }
}
