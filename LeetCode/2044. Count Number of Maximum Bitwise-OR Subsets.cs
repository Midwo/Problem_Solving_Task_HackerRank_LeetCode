using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2044
    {
        //(2044.) Count Number of Maximum Bitwise-OR Subsets (MEDIUM)
        private int[] _nums;
        private int _countMaxValue;
        private int _allBitwiseOR;
        public int CountMaxOrSubsets(int[] nums)
        {
            _allBitwiseOR = 0;
            _nums = nums;
            _countMaxValue = 0;

            foreach (int item in nums)
            {
                _allBitwiseOR |= item;
            }

            generatePairs(0, 0);

            return _countMaxValue;
        }


        private void generatePairs(int index, int currentBitwiseOR)
        {
            if (index == _nums.Length)
            {
                if (currentBitwiseOR == _allBitwiseOR)
                {
                    _countMaxValue++;
                }
                return;                
            }

            generatePairs(index + 1, currentBitwiseOR);

            generatePairs(index + 1, currentBitwiseOR | _nums[index]);
        }
    }
}
