using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_728
    {
        ////(728.) Self Dividing Numbers (EASY)

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                bool notDividing = false;
                int currLeft = i;
                int currI = i;
                while (currLeft > 0)
                {
                    currI = currLeft % 10;
                    currLeft = (currLeft - currI) / 10;
                    if (currI == 0)
                    {
                        notDividing = true;
                        break;
                    }
                    if (i % currI != 0)
                    {   
                        notDividing = true;
                        break;
                    }
                    
                }
                if (!notDividing)
                {
                    result.Add(i);
                }
            }

            return result;
        }



    }
}
