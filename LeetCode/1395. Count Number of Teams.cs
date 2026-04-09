using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1395
    {
        ////(1395.) Count Number of Teams (MEDIUM)
        public int NumTeams(int[] rating)
        {
            int countTeams = 0;
            int length = rating.Length;

            for (int indexFirstValue = 0; indexFirstValue < length-2; indexFirstValue++)
            {
                int currFirstValue = rating[indexFirstValue];
                for (int indexSecondValue = indexFirstValue+1; indexSecondValue < length-1; indexSecondValue++)
                {
                    int currSecondValue = rating[indexSecondValue];
                    if(currFirstValue > currSecondValue)
                    {
                        for(int indexThirdValue = indexSecondValue+1; indexThirdValue < length; indexThirdValue++)
                        {
                            if(currSecondValue > rating[indexThirdValue])
                            {
                                countTeams++;
                            }
                        }
                    }
                    else if (currFirstValue < currSecondValue)
                    {
                        for (int indexThirdValue = indexSecondValue + 1; indexThirdValue < length; indexThirdValue++)
                        {
                            if(currSecondValue < rating[indexThirdValue])
                            {
                                countTeams++;
                            }
                        }
                    }
                }
            } 

            return countTeams;
        }
    }
}
