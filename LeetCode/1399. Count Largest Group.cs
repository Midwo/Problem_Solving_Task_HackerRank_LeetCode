using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1399
    {
        ////(1399.) Count Largest Group (EASY)
        public int CountLargestGroup(int n)
        {
            var dictionaryGroup = new Dictionary<int, int>();            

            for (int currNumber = 1; currNumber <= n; currNumber++) 
            {
                var tempValue = currNumber;
                var sumOfDigits = 0;
                while (tempValue > 0) 
                {
                    sumOfDigits += tempValue % 10;
                    tempValue /= 10;
                }

                if(!dictionaryGroup.TryAdd(sumOfDigits, 1))
                {
                    dictionaryGroup[sumOfDigits]++;
                }
            }

            var maxSizeGroup = 0;
            var countMaxSizeGroup = 0;

            foreach (var item in dictionaryGroup)
            {
                if(maxSizeGroup < item.Value)
                {
                    maxSizeGroup = item.Value;
                    countMaxSizeGroup = 1;
                }
                else if (maxSizeGroup == item.Value)
                {
                    countMaxSizeGroup++;
                }
            }

            return countMaxSizeGroup;
        }
    }
}
