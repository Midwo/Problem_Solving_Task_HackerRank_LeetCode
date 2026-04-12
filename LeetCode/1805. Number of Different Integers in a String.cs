using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1805
    {
        ////(1805.) Number of Different Integers in a String (EASY)
        public int NumDifferentIntegers(string word)
        {
            HashSet<string> countDistinctNumbers = new HashSet<string>();
            int startIndexNumber = -1;
            int index = 0;
            int lengthWord = word.Length;

            for (; index < lengthWord; index++)
            {
                char currChar = word[index];
                if (currChar >= '0' && currChar <= '9')
                {
                    if(startIndexNumber == -1)
                    {
                        startIndexNumber = index;
                    }
                }
                else if (startIndexNumber > -1)
                {
                    for (; startIndexNumber < index; startIndexNumber++)
                    {
                        if (word[startIndexNumber] > '0')
                        {
                            break;
                        }
                    }
                    countDistinctNumbers.Add(word[startIndexNumber..index]);
                    startIndexNumber = -1;
                }
            }

            if (startIndexNumber > -1)
            {
                for (; startIndexNumber < index; startIndexNumber++)
                {
                    if (word[startIndexNumber] > '0')
                    {
                        break;
                    }
                }
                countDistinctNumbers.Add(word[startIndexNumber..(lengthWord)]);
            }

            return countDistinctNumbers.Count;
        }
    }
}
