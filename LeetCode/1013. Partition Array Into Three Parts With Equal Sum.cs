using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1013
    {
        ////(1013.) Partition Array Into Three Parts With Equal Sum (EASY)
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = arr.Sum();
            if (sum % 3 != 0)
            {
                return false;
            }
            int groupSum = sum / 3;
            int length = arr.Length;
            int increaseIndex = 1;
            bool foundAGroup1 = false;
            bool foundAGroup2 = false;
            int sumGroup1 = arr[0];
            int sumGroup2 = arr[length-1];
            int indexStopGroup1 = int.MaxValue;
            int indexStopGroup2 = int.MaxValue;

            while (foundAGroup1 == false || foundAGroup2 == false)
            {
                if (increaseIndex == length - 1 || length -1 - increaseIndex == indexStopGroup1)
                {
                    return false;
                }
                if (foundAGroup1 == false) 
                {
                    if (sumGroup1 != groupSum)
                    {
                        sumGroup1 += arr[increaseIndex];
                    }
                    else
                    {
                        foundAGroup1 = true;
                        indexStopGroup1 = increaseIndex-1;
                    }
                }

                if (foundAGroup2 == false) 
                {
                    if (sumGroup2 != groupSum)
                    {
                        sumGroup2 += arr[length - 1 - increaseIndex];
                    }
                    else
                    {
                        indexStopGroup2 = length - 1 - (increaseIndex-1);
                        foundAGroup2 = true;
                    }
                }

                if (foundAGroup1 && !foundAGroup2)
                {
                    if (increaseIndex <= indexStopGroup1)
                    {
                        return false;
                    }
                }
                else if (!foundAGroup1 && foundAGroup2)
                {
                    if (increaseIndex >= indexStopGroup2)
                    {
                        return false;
                    }
                }
                else if (!foundAGroup1 && !foundAGroup2)
                {
                    if ((increaseIndex)*2 +1 >= length-1)
                    {
                        return false;
                    }
                }
                increaseIndex++;
            }
           
            if (foundAGroup1 && foundAGroup2)
            {
                return true;
            }

            return false;
        }
    }
}
