using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4070
    {
        ////(4070.) Minimum Rotations to Dial a Number I (EASY)
        public int MinRotations(string s)
        {
            int totalMinRotate = 0;
            int lastPosition = 0;

            foreach (char currChar in s) 
            {
                int currPosition = currChar - '0';
                int currMinRotate = Math.Abs(lastPosition - currPosition);

                totalMinRotate += Math.Min(currMinRotate, 10-currMinRotate);
    
                lastPosition = currPosition;
            }

            return totalMinRotate;
        }
    }
}
