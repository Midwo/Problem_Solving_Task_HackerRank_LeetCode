using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2578
    {
        ////(2578.) Split With Minimum Sum (EASY)
        public int SplitNum(int num)
        {
            List<int> numInList  = new List<int>();
            while (num != 0)
            {
                numInList.Add(num % 10);
                num /= 10;
            }

            int fistValue = 0;
            int secondValue = 0;

            numInList.Sort();

            for (int i = 0; i < numInList.Count; i++)
            {
                if(i % 2 == 0)
                {
                    fistValue *= 10;
                    fistValue += numInList[i];
                }
                else
                {
                    secondValue *= 10;
                    secondValue += numInList[i];
                }
            }

            return fistValue + secondValue;
        }
    }
}
