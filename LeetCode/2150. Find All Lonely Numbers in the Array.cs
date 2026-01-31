using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2150
    {
        ////(2150.) Find All Lonely Numbers in the Array (MEDIUM)
        public IList<int> FindLonely(int[] nums)
        {
            ////Solution 1
            ////Beats: 100.00%, Memory: 80.00%
            
            Dictionary<int, int> dictValueCount = new Dictionary<int, int>();
            IList<int> listLonelyNumbers = new List<int>();

            foreach (int num in nums) 
            {
                if (dictValueCount.ContainsKey(num))
                {
                    dictValueCount[num]++;
                }
                else
                {
                    dictValueCount.Add(num, 1);
                }
            }

            foreach (var recordDict in dictValueCount)
            {
                if (recordDict.Value == 1 && !dictValueCount.ContainsKey(recordDict.Key - 1) && !dictValueCount.ContainsKey(recordDict.Key+1))
                {
                    listLonelyNumbers.Add(recordDict.Key);
                }
            }
            
            return listLonelyNumbers;

            ////Solution 2
            ////Beats: 20.00%, Memory: 80.00%
            
            //HashSet<int> distinctListNums = new HashSet<int>();
            //HashSet<int> appearsTwiceOrMoreList = new HashSet<int>();

            //IList<int> listLonelyNumbers = new List<int>();

            //for (int i = 0; i < nums.Length; i++) 
            //{ 
            //    if (!distinctListNums.Add(nums[i]))
            //    {
            //        appearsTwiceOrMoreList.Add(nums[i]);
            //    }
            //}

            //foreach (int num in distinctListNums) 
            //{ 
            //    if (!distinctListNums.Contains(num-1) && !distinctListNums.Contains(num + 1) && !appearsTwiceOrMoreList.Contains(num))
            //    {
            //        listLonelyNumbers.Add(num);
            //    }
            
            //}

            //return listLonelyNumbers;
        }
    }
}
