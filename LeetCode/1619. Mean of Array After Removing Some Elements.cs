using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1619
    {
        ////(1619.) Mean of Array After Removing Some Elements (EASY)
        public double TrimMean(int[] arr)
        {
            int lengthArr = arr.Length;
            int sumRemoving = 0;
            int howManyRemoveOneSide = lengthArr / 20;

            Array.Sort(arr);

            for (int i = howManyRemoveOneSide; i < lengthArr - howManyRemoveOneSide; i++)
            {
                sumRemoving += arr[i];
            }

            return (double)sumRemoving / (lengthArr-howManyRemoveOneSide-howManyRemoveOneSide); 
        }
    }
}
