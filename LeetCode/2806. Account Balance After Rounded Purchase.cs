using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2806
    {
        ////(2806.) Account Balance After Rounded Purchase (EASY)
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            int moduloResult = purchaseAmount % 10;
            if (moduloResult > 4) 
            {
                return 90 - purchaseAmount + moduloResult;
            }
            return 100 - purchaseAmount + moduloResult;
        }
    }
}
