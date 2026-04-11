using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_784
    {
        ////(784.) Letter Case Permutation (MEDIUM)
        public IList<string> LetterCasePermutation(string s)
        {
            IList<string> listAllPermutation = new List<string>();
            int length = s.Length;
            List<int> listIndexToChange = new List<int>(); 
            
            for (int indexS = 0; indexS < length; indexS++)
            {
                if (s[indexS] < '0' || s[indexS] > '9')
                {
                    listIndexToChange.Add(indexS);
                }
            }

            int howManyChangeDigit = listIndexToChange.Count;

            StringBuilder sb = new StringBuilder(s);

            backTrackingMethodTask784(listAllPermutation, listIndexToChange, sb, howManyChangeDigit, 0);

            return listAllPermutation;
        }

        private void backTrackingMethodTask784(IList<string> listAllPermutation, List<int> listIndexToChange, StringBuilder sb, int howManyChangeDigit, int currIndexChange)
        {
            if(currIndexChange < howManyChangeDigit)
            {
                int currIndex = listIndexToChange[currIndexChange];

                char original = sb[currIndex];

                if (char.IsLower(original))
                {
                    backTrackingMethodTask784(listAllPermutation, listIndexToChange, sb, howManyChangeDigit, currIndexChange + 1);

                    sb[currIndex] = char.ToUpper(original);
                    backTrackingMethodTask784(listAllPermutation, listIndexToChange, sb, howManyChangeDigit, currIndexChange + 1);
                }
                else
                {
                    backTrackingMethodTask784(listAllPermutation, listIndexToChange, sb, howManyChangeDigit, currIndexChange + 1);

                    sb[currIndex] = char.ToLower(original);
                    backTrackingMethodTask784(listAllPermutation, listIndexToChange, sb, howManyChangeDigit, currIndexChange + 1);
                }

                sb[currIndex] = original;
            }
            else
            {
                listAllPermutation.Add(sb.ToString());
            }
        } 
    }
}
