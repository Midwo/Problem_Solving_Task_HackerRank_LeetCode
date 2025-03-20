using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_22
    {
        ////(22.) Generate Parentheses (MEDIUM)
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();

            BacktrackingGenerateParenthesis(result, n, "", 0, 0);

            return result;
        }

        private void BacktrackingGenerateParenthesis(IList<string> result, int howManyPairs, string currStringToAddToTheResult, int numberOfOpenings, int numberOfClosed)
        {
            if (howManyPairs *2 == currStringToAddToTheResult.Length)
            {
                result.Add(currStringToAddToTheResult);
                return;
            }

            if(numberOfOpenings < howManyPairs)
            {
                BacktrackingGenerateParenthesis(result, howManyPairs, currStringToAddToTheResult + "(", numberOfOpenings +1, numberOfClosed);
            }

            if(numberOfOpenings > numberOfClosed)
            {
                BacktrackingGenerateParenthesis(result, howManyPairs, currStringToAddToTheResult + ")", numberOfOpenings, numberOfClosed +1);
            }
        }
    }
}
