using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2899
    {
        ////(2899.) Last Visited Integers (EASY)
        public IList<int> LastVisitedIntegers(int[] nums)
        {
            List<int> ansList = new List<int>();
            List<int> seenList = new List<int>();
            int k = 0;

            foreach (int num in nums) 
            {
                if (num > -1)
                {
                    k = 0;
                    seenList.Insert(0, num);
                }
                else
                {
                    k++;
                    if (k <= seenList.Count)
                    {
                        ansList.Add(seenList[k-1]);
                    }
                    else
                    {
                        ansList.Add(-1);
                    }
                }
            }

            return ansList;
        }
    }
}
