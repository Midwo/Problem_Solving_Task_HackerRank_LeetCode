using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1390
    {
        ////(1390.) Four Divisors (MEDIUM)
        public int SumFourDivisors(int[] nums)
        {
            int sumFourDivisors = 0;
            int currSumFourDivisors;
            int countDivisors = 0;
            int divider;
            int multiplier;
            int currValue;
            bool wrongStatusRight;
            for (int indexNums = 0; indexNums < nums.Length; indexNums++)
            {
                currSumFourDivisors = 0;
                countDivisors = 0;
                currValue = nums[indexNums];
                divider = 1;
                multiplier = currValue;
                wrongStatusRight = false;
                while (divider <= multiplier)
                {
                    if (!wrongStatusRight)
                    {
                        if (divider * multiplier == currValue)
                        {
                            if (divider == multiplier)
                            {
                                countDivisors += 1;
                                currSumFourDivisors += divider;
                            }
                            else
                            {
                                countDivisors += 2;
                                currSumFourDivisors += divider + multiplier;
                            }
                            if(countDivisors > 4)
                            {
                                break;
                            }
                        }
                    }
                    divider++;
                    multiplier = currValue / divider;
                    if (multiplier * divider == currValue)
                    {
                        wrongStatusRight = false;
                    }
                    else
                    {
                        wrongStatusRight = true;
                    }
                }


                if (countDivisors == 4)
                {
                    sumFourDivisors += currSumFourDivisors;
                }
            }

            return sumFourDivisors;
        }
    }
}
