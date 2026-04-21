using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0114
    {
        ////0114. Strange Counter (EASY)
        public long strangeCounter(long t)
        {
            ////Solution 1 (New - Better)
            long lastElementTime = 3;
            long countElements = 3;
            
            while(t > lastElementTime)
            {
                countElements += countElements;
                lastElementTime += countElements;
            }

            return lastElementTime - t+1;


            ////Solution 2 (Old - Poor)
            //bool endLoopSearch = false;
            //long timeMaxLoop = 3;
            //long lastValue = 3;
            //do
            //{
            //    if (timeMaxLoop >= t)
            //    {
            //        break;
            //    }
            //    lastValue = 2 * lastValue;
            //    timeMaxLoop = timeMaxLoop + lastValue;
            //} while (!endLoopSearch);
            //return timeMaxLoop - t + 1;
        }
    }
}
