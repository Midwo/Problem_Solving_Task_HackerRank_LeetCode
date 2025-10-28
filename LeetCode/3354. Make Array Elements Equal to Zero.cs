using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3354
    {
        ////(3354.) Make Array Elements Equal to Zero (EASY)
        public int CountValidSelections(int[] nums)
        {
            ////62ms, Beats: 100.00% 
            
            int result = 0;
            int length = nums.Length;
            List<int> listIndexZero = new List<int>();
            int[] sumInts = new int[nums.Length];
            int currSum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                sumInts[i] = currSum;
                if (nums[i] == 0)
                {
                    listIndexZero.Add(i);
                }
            }

            foreach (var item in listIndexZero)
            {
                if (item > 0 & item < length - 1)
                {
                    //Console.WriteLine(Math.Abs(sumInts[item - 1] - Math.Abs(sumInts[item -1] - sumInts[length - 1])) == 1);
                    int temp = Math.Abs(sumInts[item - 1] - Math.Abs(sumInts[item - 1] - sumInts[length - 1]));
                    if (temp == 0)
                    {
                        result += 2;
                    }
                    else if (temp == 1)
                    {
                        result++;
                    }
                }
                else if (sumInts[length - 1] == 0)
                {
                    return sumInts.Length * 2;
                }
                else if (item == 0 || item == length - 1)
                {
                    if (item == 0)
                    {
                        int temp = Math.Abs(sumInts[item] - Math.Abs(sumInts[item] - sumInts[length - 1]));
                        if (temp == 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        int temp = Math.Abs(sumInts[length - 2] - Math.Abs(sumInts[length - 2] - sumInts[length - 1]));
                        if (temp == 1)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
