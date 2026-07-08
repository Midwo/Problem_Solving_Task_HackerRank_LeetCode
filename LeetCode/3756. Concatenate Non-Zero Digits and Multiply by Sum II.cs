using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3756
    {
        ////(3756.) Concatenate Non-Zero Digits and Multiply by Sum II (MEDIUM)
        public int[] SumAndMultiply(string s, int[][] queries)
        {
            int lengthS = s.Length;
            int lengthQueries = queries.Length;
            int[] resultArray = new int[lengthQueries];
            int[] sumDigitTableS = new int[lengthS];
            long[] valueWithoutZeroAndModuloArray = new long[lengthS];
            int[] countNonZeroArray = new int[lengthS];
            int currSum = 0;
            long valueWithoutZeroAndModulo = 0;
            int currCountNonZero = 0;
            long[] pow10 = new long[lengthS + 1];
            long MOD = 1000000007;
            pow10[0] = 1;

            for (int index = 1; index <= lengthS; index++)
            {
                pow10[index] = (pow10[index - 1] * 10) % MOD;
            }

            for (int index = 0; index < lengthS; index++)
            {
                currSum += s[index] - '0';
                sumDigitTableS[index] = currSum;
                if (s[index] != '0')
                {
                    valueWithoutZeroAndModulo *= 10;
                    valueWithoutZeroAndModulo += s[index] - '0';
                    valueWithoutZeroAndModulo = valueWithoutZeroAndModulo % MOD;
                    currCountNonZero++;
                }
                countNonZeroArray[index] = currCountNonZero;
                valueWithoutZeroAndModuloArray[index] = valueWithoutZeroAndModulo;
            }

            for (int index = 0; index < lengthQueries; index++)
            {
                int firstIndex = queries[index][0];
                int lastIndex = queries[index][1];
                long valueWithoutZero = valueWithoutZeroAndModuloArray[lastIndex];
                int sumDigits = sumDigitTableS[lastIndex];
                int cnt = countNonZeroArray[lastIndex];
                if (firstIndex > 0)
                {
                    sumDigits -= sumDigitTableS[firstIndex - 1];
                    cnt -= countNonZeroArray[firstIndex - 1];
                    valueWithoutZero = (valueWithoutZero - (valueWithoutZeroAndModuloArray[firstIndex - 1] * pow10[cnt]) % MOD + MOD) % MOD;
                }

                valueWithoutZero *= sumDigits;

                resultArray[index] = (int)(valueWithoutZero % MOD); 
            }

            return resultArray;
        }
    }
}
