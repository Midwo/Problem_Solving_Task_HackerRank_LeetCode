using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2798
    {
        ////(2798.) Number of Employees Who Met the Target (EASY)
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int result = 0;

            for (int i = 0; i < hours.Length; i++) 
            {
                if (hours[i] >= target)
                {
                    result++;  
                }
            
            }

            return result;
        }
    }
}
