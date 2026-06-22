using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1291
    {
        ////(1291.) Sequential Digits (MEDIUM)
        public IList<int> SequentialDigits(int low, int high)
        {
            IList<int> resultList = new List<int>();
            int startLenght = low.ToString().Length;
            int maxLenght = high.ToString().Length;

            string pattern = "123456789";

            while(startLenght <= maxLenght)
            {
                for(int index = 0; index <= 9-startLenght; index++)
                {
                    int currValue = int.Parse(pattern[index..(index+startLenght)]);

                    if(currValue >= low && currValue <= high)
                        resultList.Add(currValue);
                }

                startLenght++;
            }

            return resultList;
        }
    }
}
