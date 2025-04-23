using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_989
    {
        ////(989.) Add to Array-Form of Integer (EASY)
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            IList<int> result = new List<int>();

            int lengthNum = num.Length;

            int extraAdd = 0;
            int mod = 10;

            while (k > 0)
            {
                int tempValue = k % mod;
                if (tempValue > 0)
                {
                    result.Add(tempValue / (mod / 10));
                }
                else
                {
                    result.Add(tempValue);
                }
                k -= tempValue;
                mod *= 10;
            }

            int index = 0;
            for (int i = lengthNum - 1; i >= 0; i--)
            {
                if (index == result.Count)
                {
                    result.Add(0);
                }
                int temp = result[index] + num[i] + extraAdd;
                extraAdd = 0;
                if (temp > 9)
                {
                    temp -= 10;
                    extraAdd = 1;
                }
                result[index] = temp;
                index++;
            }

            while (extraAdd > 0)
            {
                if (index == result.Count)
                {
                    result.Add(extraAdd);
                    extraAdd = 0;
                    break;
                }
                int temp = extraAdd + result[index];
                extraAdd = 0;
                if (temp > 9)
                {
                    extraAdd = 1;
                    temp -= 10;
                }
                result[index] = temp;
                index++;
            }

            return result.Reverse().ToList();
        }
    }
}
