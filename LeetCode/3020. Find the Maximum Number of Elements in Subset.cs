using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3020
    {
        ////(3020.) Find the Maximum Number of Elements in Subset (MEDIUM)
        public int MaximumLength(int[] nums)
        {
            HashSet<int> listDistictNumbers = new HashSet<int>();
            HashSet<int> listCountTwoOrMore = new HashSet<int>();
            int countOne = 0;

            foreach (int num in nums)
            {
                if (!listDistictNumbers.Add(num))
                {
                    listCountTwoOrMore.Add(num);
                }
                if (num == 1)
                {
                    countOne++;
                }
            }

            int maxLenght = 1;

            if (countOne % 2 == 0)
            {
                maxLenght = Math.Max(1, countOne-1);
            }
            else
            {
                maxLenght = Math.Max(1, countOne);
            }

            foreach (int num in listCountTwoOrMore)
            {
                if (num == 1)
                {
                    continue;
                }

                int currNum = num * num;
                
                if (currNum < 0)
                {
                    continue;
                }

                int currlenght = 1;

                while (currNum > 0 && currNum < 1000000001)
                {
                    if (listCountTwoOrMore.Contains(currNum))
                    {
                        currlenght += 2;
                    }
                    else if (listDistictNumbers.Contains(currNum))
                    {
                        currlenght += 2;
                        break;
                    }
                    else
                    {
                        break;
                    }

                    currNum *= currNum;
                }

                maxLenght = Math.Max(maxLenght, currlenght);
            }

            return maxLenght;
        }

    }
}
