using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0046
    {
        ////46. Picking Numbers (EASY)
        public int pickingNumbers(List<int> a)
        {
            a.Sort();

            int maxCountFollowing = 0;
            int actualCountFollowing = 0;
            int actualValue = 0;
            bool reset = true;

            bool getNewValue = true;
            for (int i = 0; i < a.Count - 1; i++)
            {
                if (getNewValue)
                {
                    actualValue = i;
                    getNewValue = false;
                }
                if (Math.Abs(a[actualValue] - a[i + 1]) <= 1)
                {
                    //Console.WriteLine("yes");

                    if (reset)
                    {
                        actualCountFollowing = 2;
                        reset = false;
                    }
                    else
                    {
                        actualCountFollowing++;
                    }
                }
                else
                {
                    getNewValue = true;
                    reset = true;
                    if (actualCountFollowing > maxCountFollowing)
                    {
                        maxCountFollowing = actualCountFollowing;
                    }
                    actualCountFollowing = 0;
                }
                if (actualCountFollowing > maxCountFollowing)
                {
                    maxCountFollowing = actualCountFollowing;
                }
            }
            return maxCountFollowing;
        }
    }
}
