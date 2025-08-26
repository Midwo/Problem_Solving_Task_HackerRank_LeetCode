using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2610
    {
        ////(2610.) Convert an Array Into a 2D Array With Conditions (MEDIUM)
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();

            foreach (int num in nums) 
            {
                if (dictionaryNums.ContainsKey(num))
                {
                    dictionaryNums[num]++;
                }
                else
                {
                    dictionaryNums.Add(num, 1);
                }
            }

            int maxLength = 1;
            int currLength = 0;

            while (maxLength != currLength) 
            {
                IList<int> temp = new List<int>();
                if (maxLength == 1)
                {
                    foreach (var item in dictionaryNums)
                    {
                        maxLength = Math.Max(maxLength, item.Value);
                        temp.Add(item.Key);
                    }
                    currLength++;
                    result.Add(temp);
                }
                else
                {
                    foreach (var item in dictionaryNums)
                    {
                        if(item.Value > currLength)
                        {
                            temp.Add(item.Key);
                        }
                    }
                    result.Add(temp);
                    currLength++;
                }
            }

            return result;
        }
    }
}
