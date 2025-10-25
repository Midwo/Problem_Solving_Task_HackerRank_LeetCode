using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3483
    {
        ////(3483.) Unique 3-Digit Even Numbers (EASY)
        public int TotalNumbers(int[] digits)
        {
            HashSet<int> firstValue = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int indexFirst = 0; indexFirst < digits.Length; indexFirst++)
            {
                int tempFirstValue = digits[indexFirst];
                if (tempFirstValue != 0 && firstValue.Add(tempFirstValue))
                {
                    for (int indexSecond = 0; indexSecond < digits.Length; indexSecond++)
                    {
                        int tempSecondValue = digits[indexSecond];
                        if (indexFirst != indexSecond)
                        {
                            for (int indexLast = 0; indexLast < digits.Length; indexLast++)
                            {
                                if (indexLast != indexFirst && indexLast != indexSecond && digits[indexLast] % 2 == 0)
                                {
                                    result.Add(tempFirstValue * 100 + tempSecondValue * 10 + digits[indexLast]);
                                }
                            }
                        }
                    }
                }
            }
            return result.Count;
        }
    }
}
