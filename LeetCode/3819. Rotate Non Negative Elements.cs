using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3819
    {
        ////(3819.) Rotate Non Negative Elements (MEDIUM)
        public int[] RotateElements(int[] nums, int k)
        {
            int length = nums.Length;
            if (k == 0 || length == 1)
                return nums;

            List<int[]> listNumberIndex = new List<int[]>();

            for (int index = 0; index < nums.Length; index++) 
            {
                int currValue = nums[index];
                if (currValue >= 0)
                    listNumberIndex.Add(new int[2] { currValue, index });
            }
            int countPositiveNumber = listNumberIndex.Count;
            if (countPositiveNumber < 2)
                return nums;
            
            int reductionRotate = k % countPositiveNumber;
            if(reductionRotate == 0)
                return nums;

            int indexWhereList = 0;
            int countOperations = 0;

            while(countOperations < countPositiveNumber)
            {
                int[] currValueAndIndex = listNumberIndex[reductionRotate++];
                nums[listNumberIndex[indexWhereList][1]] = currValueAndIndex[0];
                indexWhereList++;

                if(reductionRotate == countPositiveNumber)
                {
                    reductionRotate = 0;
                }

                countOperations++;
            }     
           
            return nums;
        }
    }
}
