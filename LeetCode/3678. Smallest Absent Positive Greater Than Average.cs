using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3678
    {
        ////(3678.) Smallest Absent Positive Greater Than Average (EASY)
        public int SmallestAbsent(int[] nums)
        {
            int length = nums.Length;

            int sum = 0;

            for (int i = 0; i < length; i++) 
            { 
                sum += nums[i];
            }

            int seachrValue = sum / length+1;
            seachrValue = seachrValue < 1? 1 : seachrValue;

            while (seachrValue < 102)
            {
                bool status = true;
                for (int i = 0; i < length; i++)
                {
                    if (nums[i] == seachrValue)
                    {
                        status = false;
                        break;
                    }
                }

                if (status) { return seachrValue; }
                
                seachrValue++;
            }

            return seachrValue;
        }
    }
}
