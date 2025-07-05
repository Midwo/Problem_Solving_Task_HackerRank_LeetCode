using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1394
    {
        ////(1394.) Find Lucky Integer in an Array (EASY)
        public int FindLucky(int[] arr)
        {
            //// Option 1 - better, dictionary

            Dictionary<int, int> countNumber = new Dictionary<int, int>();
            int maxLuckyNumber = -1;

            for (int i = 0; i < arr.Length; i++) 
            { 
                if (countNumber.ContainsKey(arr[i]))
                {
                    countNumber[arr[i]]++;
                }
                else
                {
                    countNumber.Add(arr[i], 1);
                }
            }

            foreach (var item in countNumber) 
            {
                if(item.Key == item.Value && item.Value > maxLuckyNumber)
                {
                    maxLuckyNumber = item.Value;
                }
            }

            return maxLuckyNumber;

            //// Option 2, check i and i-1 and Sort(Arr)
            
            //int maxLuckyNumber = -1;
            //int count = 1;
            //int length = arr.Length;
            //Array.Sort(arr);

            //for (int i = 1; i < length; i++)
            //{
            //    if (arr[i] == arr[i - 1])
            //    {
            //        count++;
            //        if (i == length - 1)
            //        {
            //            if (count > maxLuckyNumber && count == arr[i - 1])
            //            {
            //                maxLuckyNumber = count;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (count > maxLuckyNumber && count == arr[i - 1])
            //        {
            //            maxLuckyNumber = count;
            //        }
            //        count = 1;
            //    }
            //}

            //return maxLuckyNumber;
        }
    }
}
