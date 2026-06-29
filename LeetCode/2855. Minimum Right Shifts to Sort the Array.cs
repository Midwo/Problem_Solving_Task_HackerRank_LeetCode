using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2855
    {
        ////(2855.) Minimum Right Shifts to Sort the Array (EASY)
        public int MinimumRightShifts(IList<int> nums)
        {
            bool shiftDetect = false;
            int lenght = nums.Count;
            int lastValue = -1;
            int indexShift = -1;

            for (int index = 0; index < lenght; index++) 
            {
                int currValue = nums[index];
                if (lastValue > currValue)
                {
                    if (shiftDetect) return -1;
                    shiftDetect = true;
                    indexShift = index;
                }
                lastValue = currValue;
            }

            if (shiftDetect && nums[0] < nums[lenght-1])
            {
                return -1;
            }

            return shiftDetect == false ? 0 : lenght - indexShift;            
        }
    }
}
