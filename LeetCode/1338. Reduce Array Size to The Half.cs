using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1338
    {
        ////(1338.) Reduce Array Size to The Half (MEDIUM)
        public int MinSetSize(int[] arr)
        {
            Dictionary<int, int> dictNumberAndCount = new Dictionary<int, int>();
            
            foreach (int i in arr) 
            {
                if (dictNumberAndCount.ContainsKey(i))
                {
                    dictNumberAndCount[i]++;
                }
                else
                {
                    dictNumberAndCount.Add(i, 1);
                }
            }

            int[] CountList = dictNumberAndCount.Values.ToArray();

            CountList = CountList.OrderDescending().ToArray();

            int length = arr.Length;
            int currSumLenght = 0;
            int howManyNumbers = 0;

            for (int i = 0; i < CountList.Length; i++)
            {
                currSumLenght += CountList[i];
                howManyNumbers++;

                if (currSumLenght *2 >= arr.Length)
                {
                    return howManyNumbers;
                }
                
            }

            return howManyNumbers;
        }
    }
}
