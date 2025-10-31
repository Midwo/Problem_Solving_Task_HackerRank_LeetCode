using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_852
    {
        ////(852.) Peak Index in a Mountain Array (MEDIUM)
        public int PeakIndexInMountainArray(int[] arr)
        {
            ////Solution 1#
            
            int indexL = 0;
            int indexR = arr.Length - 1;
            while (indexL < indexR)
            {
                int mid = (indexL + indexR) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    indexL = mid + 1;
                }
                else
                {
                    indexR = mid;
                }
            }

            return indexL;

            ////Solution 2#
            
            //int lastValue = arr[0];
            //bool grow = false;
            //int length = arr.Length;
            //int maxPeakValue = int.MinValue;
            //int indexMaxPeak = -1;

            //for (int i = 1; i < length - 1; i++) 
            //{
            //    if (arr[i] > lastValue)
            //    {
            //        grow = true;
            //    }
            //    else if (arr[i] < lastValue)
            //    {
            //        if (grow)
            //        {
            //            if (arr[i-1] > maxPeakValue)
            //            {
            //                maxPeakValue = arr[i-1];
            //                indexMaxPeak = i-1;
            //            }
            //            grow = false;
            //        }
            //    }
            //    else
            //    {
            //        grow = false;
            //    }
            //    lastValue = arr[i];
            //}

            //if (arr[length-1] < lastValue & grow)
            //{
            //    if (arr[length - 2] > maxPeakValue)
            //    {
            //        maxPeakValue = arr[length - 2];
            //        indexMaxPeak = length - 2;
            //    }
            //}

            //return indexMaxPeak;
        }
    }
}
