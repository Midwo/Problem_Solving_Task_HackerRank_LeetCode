using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3386
    {
        ////(3386.) Button with Longest Push Time (EASY)
        public int ButtonWithLongestTime(int[][] events)
        {
            int buttonIndex = events[0][0];
            int maxPushTime = events[0][1];

            int lastTime = maxPushTime;

            for (int indexEvents = 1; indexEvents < events.Length; indexEvents++) 
            { 
                int currTime = events[indexEvents][1];
                int currIndex = events[indexEvents][0];
                
                int currUnitsOfTime = currTime - lastTime;

                if (currUnitsOfTime > maxPushTime || currUnitsOfTime == maxPushTime && buttonIndex > currIndex)
                {
                    maxPushTime = currUnitsOfTime;
                    buttonIndex = currIndex;
                }

                lastTime = currTime;            
            }

            return buttonIndex;
        }
    }
}
