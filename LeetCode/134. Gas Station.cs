using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_134
    {
        ////(134.) Gas Station (MEDIUM)
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            bool end = false;

            int index = 1;
            int total = gas[0] - cost[0];
            int currTotal = gas[0];
            int length = gas.Length;
            int counterStationX2 = length*2;
            int counterStation = length;
            int startIndex = 0;
            int prevIndex = 0;

            if (length == 1)
            {
                if (gas[0] >= cost[0])
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            while (!end) 
            {
                if (counterStationX2 == 0)
                {
                    return -1;
                }
                currTotal -= cost[prevIndex];
                if(currTotal < 0)
                {
                    startIndex = index;
                    currTotal = gas[index];
                    counterStation = length;
                }
                else
                {
                    currTotal += gas[index];
                }

                counterStation--;
                if (counterStation == 0) 
                {
                    if (startIndex - 1 < 0)
                    {
                        if (currTotal < 0)
                        {
                            startIndex = 1;
                            index = startIndex;
                            currTotal = gas[index];
                            counterStation = length;
                        }
                        else
                        {
                            return startIndex;
                        }
                    }
                    else
                    {
                        if (currTotal < cost[startIndex - 1])
                        {
                            if (startIndex + 1 == length)
                            {
                                startIndex = 0;
                            }
                            else
                            {
                                startIndex = startIndex + 1;
                            }

                            index = startIndex;
                            currTotal = gas[index];
                            counterStation = length;
                        }
                        else
                        {
                            return startIndex;
                        }
                    }
                }
                prevIndex = index;
                index++;
                if (index == length)
                {
                    index = 0;
                }
                counterStationX2--;
            }

            return startIndex;
        }
    }
}
