using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1865
    {
        ////(1865.) Finding Pairs With a Certain Sum (MEDIUM)
        public class FindSumPairs
        {
            private int[] _nums1;
            private int[] _nums2;
            private int _lengthNums2;
            private Dictionary<int, int> _countForNums2;
            public FindSumPairs(int[] nums1, int[] nums2)
            {
                _nums1 = nums1;
                _nums2 = nums2;
                _lengthNums2 = nums2.Length;
                _countForNums2 = new Dictionary<int, int>();

                foreach (int i in _nums2)
                {
                    if (_countForNums2.ContainsKey(i))
                    {
                        _countForNums2[i]++;
                    }
                    else
                    {
                        _countForNums2.Add(i, 1);
                    }
                }
            }

            public void Add(int index, int val)
            {
                int tempValue = _nums2[index];

                if (_countForNums2.TryGetValue(tempValue, out int oldCount))
                {
                    if (oldCount == 1)
                    {
                        _countForNums2.Remove(tempValue);
                    }
                    else
                    {
                        _countForNums2[tempValue] = oldCount - 1;
                    }
                }
                _nums2[index] += val;
                tempValue += val;
                if (_countForNums2.TryGetValue(tempValue, out int countValue))
                {
                    _countForNums2[tempValue] = countValue +1;
                }
                else
                {
                    _countForNums2.Add(tempValue, 1);
                }
            }

            public int Count(int tot)
            {
                int count = 0;
                foreach (int i in _nums1) 
                {
                    int target = tot - i;
                    if (_countForNums2.TryGetValue(target, out int countValue))
                    {
                        count += countValue;
                    }    
                }

                return count; 
            }
        }
    }
}
