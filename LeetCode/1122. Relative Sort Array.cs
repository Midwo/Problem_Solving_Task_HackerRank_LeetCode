using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1122
    {
        ////(1122.) Relative Sort Array (EASY)
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> arrToList = arr1.ToList();
            arrToList.Sort();

            List<int> result = new List<int>();

            for (int i = 0; i < arr2.Length; i++)
            {
                while(arrToList.Contains(arr2[i]))
                {
                    arrToList.Remove(arr2[i]);
                    result.Add(arr2[i]);
                }
            } 
            for (int i = 0; i < arrToList.Count; i++)
            {
                result.Add(arrToList[i]);
            }

            return result.ToArray();
        }
    }
}
