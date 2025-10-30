using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1287
    {
        ////(1287.) Element Appearing More Than 25% In Sorted Array (EASY)
        public int FindSpecialInteger(int[] arr)
        {
            int lenght = arr.Length;
            int size = lenght / 4;

            for (int i = 0; i < lenght - size; i++)
            {
                if (arr[i] == arr[i + size])
                {
                    return arr[i];
                }
            }

            return -1;
        }
    }
}
