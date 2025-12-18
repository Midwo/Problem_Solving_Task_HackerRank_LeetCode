using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1385
    {
        ////(1385.) Find the Distance Value Between Two Arrays (EASY)
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int countDistanceBetweenTwoArrays = 0;
            int arr2Length = arr2.Length;
            for (int i = 0; i < arr1.Length; i++) 
            {
                int currValueArr1 = arr1[i];
                bool status = true;
                for (int j = 0; j < arr2Length; j++)
                {
                    if (Math.Abs(currValueArr1 - arr2[j]) <= d)
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                {
                    countDistanceBetweenTwoArrays++;
                }
            }
            return countDistanceBetweenTwoArrays;
        }
    }
}
