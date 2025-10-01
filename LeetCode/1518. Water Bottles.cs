using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1518
    {
        ////(1518.) Water Bottles (EASY)
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            ////0ms, 100.00%
            int result = numBottles;

            while(numBottles >= numExchange)
            {
                int temp = numBottles / numExchange;
                result += temp;
                numBottles = numBottles % numExchange + temp;
            }

            return result;
        }
    }
}
