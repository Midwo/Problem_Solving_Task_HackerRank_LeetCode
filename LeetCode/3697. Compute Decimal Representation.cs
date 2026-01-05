using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3697
    {
        ////(3697.) Compute Decimal Representation (EASY)
        public int[] DecimalRepresentation(int n)
        {
            List<int> listValue = new List<int>();
            int multiplier = 1;
            int currValue = 0;
            while (n > 0)
            {
                currValue = n % 10;
                if (currValue > 0)
                {
                    listValue.Add(currValue * multiplier);
                }
                multiplier *= 10;
                n /= 10;
            }
            listValue.Reverse();
            return listValue.ToArray();
        }
    }
}
