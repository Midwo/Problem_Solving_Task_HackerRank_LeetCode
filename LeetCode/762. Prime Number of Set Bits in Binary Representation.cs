using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_762
    {
        ////(762.) Prime Number of Set Bits in Binary Representation (EASY)
        public int CountPrimeSetBits(int left, int right)
        {
            int result = 0;

            for (int i = left; i <= right; i++)
            {
                //Console.WriteLine(Convert.ToString(i, 2));
                //string tempBinary = Convert.ToString(i, 2);

                int howMany1Bits = BitOperations.PopCount((uint)i);
                //Console.WriteLine(bits);
                if (checkIsPrime(howMany1Bits))
                {
                    result++;
                }

            }
            return result;
        }
        private bool checkIsPrime(int target)
        {
            if (target < 2)
            {
                return false;
            }
            else if (target == 3 || target == 2 || target == 5)
            {
                return true;
            }
            else if (target % 2 == 0 || target % 3 == 0 || target % 5 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
