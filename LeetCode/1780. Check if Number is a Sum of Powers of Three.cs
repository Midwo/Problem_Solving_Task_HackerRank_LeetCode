using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1780
    {
        ////(1780.) Check if Number is a Sum of Powers of Three (MEDIUM)
        public bool CheckPowersOfThree(int n)
        {
            if(n % 3 == 2)
            {
                return false;
            }

            int sum = n;

            List<int> powNumberTable = new List<int>() { 1 };
            int currValue = 1;
 
            while(currValue < n)
            {
               currValue *= 3;
               powNumberTable.Add(currValue);
            }

            for (int index = powNumberTable.Count-1; index >= 0; index--)
            {
                if (sum - powNumberTable[index] >= 0)
                {
                    sum -= powNumberTable[index];
                    if (sum == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
