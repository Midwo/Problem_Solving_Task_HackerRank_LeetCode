using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1262
    {
        ////(1262. Greatest Sum Divisible by Three (MEDIUM)
        public int MaxSumDivThree(int[] nums)
        {
            int sumNums = 0;
            int minValueModuloRest1 = int.MaxValue;
            int secondMinValueModuloRest1 = int.MaxValue;
            int minValueModuloRest2 = int.MaxValue;
            int secondMinValueModuloRest2 = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                sumNums += currValue;

                if (currValue % 3 == 1)
                {
                    if(currValue < minValueModuloRest1)
                    {
                        if (minValueModuloRest1 < secondMinValueModuloRest1)
                        {
                            secondMinValueModuloRest1 = minValueModuloRest1;
                        }
                        minValueModuloRest1 = currValue;
                    }
                    else if ( currValue < secondMinValueModuloRest1)
                    {
                        secondMinValueModuloRest1 = currValue;
                    }
                }
                else if (currValue % 3 == 2)
                {
                    if (currValue < minValueModuloRest2)
                    {
                        if (minValueModuloRest2 < secondMinValueModuloRest2)
                        {
                            secondMinValueModuloRest2 = minValueModuloRest2;
                        }
                        minValueModuloRest2 = currValue;
                    }
                    else if (currValue < secondMinValueModuloRest2)
                    {
                        secondMinValueModuloRest2 = currValue;
                    }
                }
            }

            if (sumNums % 3 == 0)
            {
                return sumNums;
            }
            else if (sumNums % 3 == 1)
            {
                int temp1 = int.MaxValue;
                int temp2 = int.MaxValue;

                if(minValueModuloRest1 < int.MaxValue)
                {
                    temp1 = sumNums - minValueModuloRest1;
                }
                if (minValueModuloRest2 < int.MaxValue && secondMinValueModuloRest2 < int.MaxValue)
                {
                    temp2 = sumNums - minValueModuloRest2 - secondMinValueModuloRest2;
                }

                if(temp1 == int.MaxValue && temp2 == int.MaxValue)
                {
                    return 0;
                }
                else if (temp1 == int.MaxValue && temp2 < int.MaxValue)
                {
                    if(temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (temp2 == int.MaxValue && temp1 < int.MaxValue)
                {
                    if (temp1 > 0)
                    {
                        return temp1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (temp1 > 0 && temp2 > 0)
                    {
                        if(temp1 > temp2)
                        {
                            return temp1;
                        }
                        else
                        {
                            return temp2;
                        }
                    }
                    else if (temp1 == 0 && temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return temp1;
                    }
                }
            }
            else
            {
                int temp1 = int.MaxValue;
                int temp2 = int.MaxValue;

                if (minValueModuloRest2 < int.MaxValue)
                {
                    temp1 = sumNums - minValueModuloRest2;
                }
                if (minValueModuloRest1 < int.MaxValue && secondMinValueModuloRest1 < int.MaxValue)
                {
                    temp2 = sumNums - minValueModuloRest1 - secondMinValueModuloRest1;
                }

                if (temp1 == int.MaxValue && temp2 == int.MaxValue)
                {
                    return 0;
                }
                else if (temp1 == int.MaxValue && temp2 < int.MaxValue)
                {
                    if (temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (temp2 == int.MaxValue && temp1 < int.MaxValue)
                {
                    if (temp1 > 0)
                    {
                        return temp1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (temp1 > 0 && temp2 > 0)
                    {
                        if (temp1 > temp2)
                        {
                            return temp1;
                        }
                        else
                        {
                            return temp2;
                        }
                    }
                    else if (temp1 == 0 && temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return temp1;
                    }
                }
            }
        }
    }
}
