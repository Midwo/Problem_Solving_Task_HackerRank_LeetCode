using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1552
    {
        ////(1552.) Magnetic Force Between Two Balls (MEDIUM) 
        public int MaxDistance(int[] position, int m)
        {
            int maxDistance = 0;
            int length = position.Length;
            Array.Sort(position);

            int low = 1;
            int high = (int)Math.Ceiling(position[length - 1] / (m - 1.0));

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (IsPossiblePlaceBalls(mid))
                {
                    maxDistance = mid;
                    low = mid +1; 
                }
                else
                {
                    high = mid - 1;
                }


            }

            bool IsPossiblePlaceBalls(int mid)
            {
                int lastBallPosition = position[0];
                int countBalls = 1;
                
                for (int i = 1; i < length && countBalls < m; i++)
                {
                    int currPos = position[i];

                    if (currPos - lastBallPosition >= mid)
                    {
                        countBalls++;
                        lastBallPosition = currPos;
                    }
                }
                return countBalls == m;
            }
            
            return maxDistance;
        }
    }
}
