using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4049
    {
        ////(4049.) Count Values With Equally Spaced Occurrences II (MEDIUM)
        public int CountSpecialIntegers(int[] nums)
        {
            int countSpecialIntegers = 0;

            HashSet<int> correctCount = new HashSet<int>();
            Dictionary<int, List<int>> disctionaryValueCountAndIndexes = new Dictionary<int, List<int>>();

            for (int index = 0; index < nums.Length; index++)
            {
                int currValue = nums[index];
                if (disctionaryValueCountAndIndexes.ContainsKey(currValue))
                {
                    int currCount = disctionaryValueCountAndIndexes[currValue][0];
                    if (currCount == 2)
                    {
                        correctCount.Add(currValue);
                        disctionaryValueCountAndIndexes[currValue][0] = currCount + 1;

                    }
                    else if (currCount < 2)
                    {
                        disctionaryValueCountAndIndexes[currValue][0] = currCount + 1;
                    }

                    disctionaryValueCountAndIndexes[currValue].Add(index);
                }
                else
                {
                    List<int> newList = new List<int>() { 1, index };
                    disctionaryValueCountAndIndexes.Add(currValue, newList);
                }
            }

            foreach (int value in correctCount)
            {
                int length = disctionaryValueCountAndIndexes[value].Count;
                bool status = true;
                for (int i = 1; i < length - 2; i++)
                {
                    if (disctionaryValueCountAndIndexes[value][i + 1] - disctionaryValueCountAndIndexes[value][i] != disctionaryValueCountAndIndexes[value][i + 2] - disctionaryValueCountAndIndexes[value][i + 1])
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                    countSpecialIntegers++;
            }

            return countSpecialIntegers;
        }
    }
}
