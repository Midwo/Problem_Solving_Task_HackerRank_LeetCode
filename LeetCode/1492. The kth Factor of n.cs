using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1492
    {
        ////(1492.) The kth Factor of n (MEDIUM)
        public int KthFactor(int n, int k)
        {
            List<int> resultList = new List<int>();
            
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    resultList.Add(i);
                }
            }     

            resultList.Sort();

            if (resultList.Count < k) 
            {
                return -1;
            }

            return resultList[k-1];
        }
    }
}
