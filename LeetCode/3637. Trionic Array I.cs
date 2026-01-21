using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3637
    {
        ////(3637.) Trionic Array I (EASY)
        public bool IsTrionic(int[] nums)
        {
            int status = 1;
            int lastValue = nums[1];

            if (lastValue <= nums[0])
            {
                return false;
            }

            int currValue = 0;
            
            for (int indexNums = 2; indexNums < nums.Length; indexNums++)
            {
                currValue = nums[indexNums];
                
                if (currValue > lastValue)
                {
                   if(status == 2)
                   {
                       status = 3;
                   }
                }
                else if (currValue < lastValue && status < 3)
                {
                    status = 2;
                }
                else
                {
                    return false;
                }
                lastValue = currValue;
            }

            return status == 3? true: false;
        }
    }
}
