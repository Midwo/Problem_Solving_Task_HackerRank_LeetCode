using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3959
    {
        ////(3959.) Check Good Integer (EASY)
        public bool CheckGoodInteger(int n)
        {
            int squareSum = 0;
            int digitSum = 0;

            while(n != 0)
            {
                int currModulo = n % 10;
                digitSum += currModulo;
                squareSum += currModulo*currModulo;
                n /= 10;
            }

            return squareSum - digitSum >= 50 ? true : false;
        }
    }
}
