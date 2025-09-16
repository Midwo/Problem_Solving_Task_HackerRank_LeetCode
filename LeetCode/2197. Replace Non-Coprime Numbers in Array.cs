using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2197
    {
        ////(2197.) Replace Non-Coprime Numbers in Array (HARD)
        public IList<int> ReplaceNonCoprimes(int[] nums)
        {
            IList<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[i]);

                while(result.Count > 1)
                {
                    int firstValue = result[result.Count - 2];
                    int secondValue = result[result.Count - 1];
                   
                    int gdcValue = GreatestCommonDivisor(firstValue, secondValue);
                    
                    if (gdcValue == 1)
                    {
                        break;
                    }

                    result.RemoveAt(result.Count - 1);

                    result[result.Count - 1] = (int)((long)firstValue * secondValue / gdcValue);
                }
            }

            return result;
        }

        private int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GreatestCommonDivisor (b, a % b);
        }
    }
}
