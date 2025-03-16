using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_15
    {
        ////(15.) 3Sum (MEDIUM)
        
        ////Two pointer method - best choice
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();

            int prevInt = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (prevInt == nums[i]) continue;
                prevInt = nums[i];
                ////OR
                //if (i > 0 && nums[i] == nums[i - 1]) continue;

                if (nums[i] > 0) break;
                int leftPointer = i + 1;
                int rightPointer = nums.Length - 1;

                while (leftPointer < rightPointer)
                {
                    int sum = nums[i] + nums[leftPointer] + nums[rightPointer];
                    if (sum < 0)
                    {
                        leftPointer++;
                    }
                    else if (sum > 0)
                    {
                        rightPointer--;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[leftPointer], nums[rightPointer] });
                        leftPointer++;
                        rightPointer--;
                        while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer - 1])
                        {
                            leftPointer++;
                        }
                    }
                }
            }

            return result;
           

            //// Ver. 1.1 - Very Slow.

            //HashSet<Tuple<int, int, int>> uniqueTriplets = new HashSet<Tuple<int, int, int>>();
            //IList<IList<int>> result = new List<IList<int>>();
            //Array.Sort(nums);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        for (int k = j + 1; k < nums.Length; k++)
            //        {
            //            if (nums[i] + nums[j] + nums[k] == 0)
            //            {
            //                var triplet = Tuple.Create(nums[i], nums[j], nums[k]);
            //                uniqueTriplets.Add(triplet);
            //            }
            //        }
            //    }
            //}

            //foreach (var triplet in uniqueTriplets)
            //{
            //    result.Add(new List<int> { triplet.Item1, triplet.Item2, triplet.Item3 });
            //}
            //return result;


            //foreach (var item in hashSet) {
            //    result.Add(new List<int> { item.Item1, item.Item2, item.Item3 });
            //}
            //return result;

            //// Ver. 1.0 - Brute Force - Very Slow.

            //for (int i = 0; i < length - 2; i++)
            //{
            //    firstValue = nums[i];
            //    for (int j = i + 1; j < length - 1; j++)
            //    {
            //        if (nums[j] != firstValue)
            //        {
            //            secondValue = nums[j];

            //            for (int k = j + 1; k < length; k++)
            //            {
            //                if (nums[k] != firstValue && nums[k] != secondValue)
            //                {

            //                    thirdValue = nums[k];
            //                    if (firstValue + secondValue + thirdValue == 0)
            //                    {
            //                        IList<int> list = new List<int>();
            //                        list.Add(firstValue);
            //                        list.Add(secondValue);
            //                        list.Add(thirdValue);
            //                        result.Add(list);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //return result;
        }
    }
}
