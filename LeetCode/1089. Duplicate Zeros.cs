using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1089
    {
        ////(1089.) Duplicate Zeros (EASY)
        public void DuplicateZeros(int[] arr)
        {
            int[] dudeArr = arr.ToArray();
            int currDudeArrLength = dudeArr.Length;
            int indexArr = 0;
            int arrLength = arr.Length;
            for (int i = 0; i < currDudeArrLength; i++) 
            {
                if (dudeArr[i] == 0)
                {
                    arr[indexArr] = 0;
                    if (arrLength > indexArr + 1)
                    {
                        arr[indexArr + 1] = 0;
                    }
                    indexArr += 2;
                    currDudeArrLength--;
                }
                else
                {
                    arr[indexArr] = dudeArr[i];
                    indexArr++;
                }
            }
            //Console.WriteLine(string.Join(",", arr));
        }
    }
}
