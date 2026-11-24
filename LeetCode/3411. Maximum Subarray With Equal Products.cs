using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3411
    {
        ////(3411.) Maximum Subarray With Equal Products (EASY)
        public int MaxLength(int[] nums)
        {
            int maxLength = 0;
            int length = nums.Length;

            for (int startIndex = 0; startIndex < length-1; startIndex++)
            {
                int currMaxLenght = 2;
                int currLCM = 1;

                int temp1 = nums[startIndex +1];
                int temp2 = nums[startIndex];

                int prod = temp1 * temp2;
                int currGCD = prod;
                
                while(temp1 != 1 || temp2 != 1)
                {
                    for (int i = 2; i < 11; i++)
                    {
                        if(temp1 != 1)
                        {
                            if(temp1 == (temp1 / i) * i)
                            {
                                currLCM *= i;
                                temp1 /= i;

                                if (temp2 != 1 && temp2 == (temp2 / i) * i)
                                {
                                    temp2 /= i;
                                }
                                break;
                            }
                        }
                        if(temp2 != 1)
                        {
                            if (temp2 != 1 && temp2 == (temp2 / i) * i)
                            {
                                currLCM *= i;
                                temp2 /= i;
                                break;
                            }
                        }
                    }
                }

                currGCD /= currLCM;

                for(int index = startIndex+2; index < length; index++)
                {
                    int newLCM = 1;
                    int nextVal = nums[index];
                    prod *= nextVal;

                    temp1 = currLCM;
                    temp2 = nextVal;

                    while (temp1 != 1 || temp2 != 1)
                    {
                        for (int i = 2; i < 11; i++)
                        {
                            if (temp1 != 1)
                            {
                                if (temp1 == (temp1 / i) * i)
                                {
                                    newLCM *= i;
                                    temp1 /= i;

                                    if (temp2 != 1 && temp2 == (temp2 / i) * i)
                                    {
                                        temp2 /= i;
                                    }
                                    break;
                                }
                            }
                            if (temp2 != 1)
                            {
                                if (temp2 != 1 && temp2 == (temp2 / i) * i)
                                {
                                    newLCM *= i;
                                    temp2 /= i;
                                    break;
                                }
                            }
                        }
                    }

                    currLCM = newLCM;

                    int newGCD = 1;
                    
                    for (int i = 2; i <= Math.Min(currGCD, nextVal); i++)
                    {
                        if (currGCD % i == 0 && nextVal % i == 0)
                        {
                            newGCD = i;
                        }
                    }
                    currGCD = newGCD;

                    if (prod == currLCM * currGCD)
                    {
                        currMaxLenght = index - startIndex+1;
                    }
                }

                maxLength = Math.Max(maxLength, currMaxLenght);
            }

            return maxLength;
        }
    }
}
