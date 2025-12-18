using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3591
    {
        ////(3591.) Check if Any Element Has Prime Frequency (EASY)
        public bool CheckPrimeFrequency(int[] nums)
        {
            int maxValue = 0;
            Dictionary<int, int> dictionaryKeyCount = new Dictionary<int, int>();

            foreach (int num in nums) 
            { 
                maxValue = maxValue < num? num : maxValue;
                if(!dictionaryKeyCount.TryAdd(num, 1))
                {
                    dictionaryKeyCount[num]++;
                }
            }

            bool[] primaryListValue = new bool[nums.Length+1];
            for (int i = 2; i <= nums.Length; i++)
            {
                int count = 1;
                for (int j = 2; j < i ; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count == 1)
                {
                    primaryListValue[i] = true;
                }
            }

            foreach (var item in dictionaryKeyCount) 
            { 
                if (primaryListValue[item.Value] == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
