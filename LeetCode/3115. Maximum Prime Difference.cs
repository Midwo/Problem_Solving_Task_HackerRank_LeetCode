using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3115
    {
        ////(3115.) Maximum Prime Difference (MEDIUM)
        public int MaximumPrimeDifference(int[] nums)
        {
            //Generate Prime Number <= 100.
            int maxCheckValue = 100;
            HashSet<int> primeNumber = new HashSet<int>();

            for (int currValue = 2; currValue < maxCheckValue; currValue++)
            {
                int divider = 2;
                for (divider = 2; divider <= currValue; divider++)
                {
                    if (currValue % divider == 0)
                    {
                        break;
                    }
                }
                if (divider == currValue)
                {
                    primeNumber.Add(currValue);
                }
            }

            //HashSet<int> primeNumber = new HashSet<int>() { 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97 };
            int firstPrimeIndex = -1;
            int lastPrimeIndex = -1;


            for (int indexNums = 0; indexNums < nums.Length; indexNums++)
            {
                if (primeNumber.Contains(nums[indexNums]))
                {
                    firstPrimeIndex = indexNums;
                    break;
                }
            }

            if (firstPrimeIndex == -1)
            {
                return -1;
            }

            for (int indexNums = nums.Length-1; indexNums >= 0; indexNums--)
            {
                if (primeNumber.Contains(nums[indexNums]))
                {
                    lastPrimeIndex = indexNums;
                    break;
                }
            }

            return lastPrimeIndex - firstPrimeIndex;
        }
    }
}
