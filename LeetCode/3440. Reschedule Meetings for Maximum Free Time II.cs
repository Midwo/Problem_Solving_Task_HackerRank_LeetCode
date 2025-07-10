using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3440
    {
        ////(3440.) Reschedule Meetings for Maximum Free Time II (MEDIUM)
        public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
        {
            int result = 0;

            List<int> breaksTimesList = new List<int>();
            List<int> noBreaksTimesList = new List<int>();

            for (int i = 0; i < startTime.Length; i++)
            {
                if (i == 0)
                {
                    if (startTime[i] > 0)
                    {
                        breaksTimesList.Add(startTime[i]);
                        noBreaksTimesList.Add(endTime[i] - startTime[i]);
                    }
                    else
                    {
                        noBreaksTimesList.Add(endTime[i] - startTime[i]);
                    }
                }
                else if (endTime[i - 1] == startTime[i])
                {
                    noBreaksTimesList.Add(endTime[i] - startTime[i]);
                }
                else if (endTime[i - 1] < startTime[i])
                {
                    breaksTimesList.Add(startTime[i] - endTime[i - 1]);
                    noBreaksTimesList.Add(endTime[i] - startTime[i]);
                }
                else
                {
                    noBreaksTimesList.Add(startTime[i] - endTime[i]);
                }
                breaksTimesList.Add(0);

            }

            if (endTime[(endTime.Length - 1)] < eventTime)
            {
                breaksTimesList.Add(eventTime - endTime[(endTime.Length - 1)]);
            }

            int indexNoBreaksTimes = 0;
            int leftMaxWithoutAdjacent = 0;
            int left = 0;
            int currLength = 0;

            int maxBreaks = 0;

            int[] intRightBreaksTimes = new int[breaksTimesList.Count];

            for (int i = breaksTimesList.Count-1; i >= 0; i--)
            {
                if(i == breaksTimesList.Count-1)
                {
                    intRightBreaksTimes[i] = breaksTimesList[i];
                    maxBreaks = breaksTimesList[i];
                }
                else
                {
                    if(maxBreaks < breaksTimesList[i])
                    {
                        maxBreaks = breaksTimesList[i];
                        intRightBreaksTimes[i] = maxBreaks;
                    }
                    else
                    {
                        intRightBreaksTimes[i] = maxBreaks;
                    }
                }
            }

            for (int i = 0; i < breaksTimesList.Count; i++)
            {
                if (breaksTimesList[i] == 0)
                {
                    currLength = noBreaksTimesList[indexNoBreaksTimes];
                    if (i == breaksTimesList.Count - 1)
                    {
                        if (leftMaxWithoutAdjacent >= currLength)
                        {
                            result = Math.Max(result, left + currLength);
                        }
                        else
                        {
                            result = Math.Max(result, left);    
                        }
                    }
                    else
                    {
                        if (leftMaxWithoutAdjacent >= currLength)
                        {
                            result = Math.Max(result, left + currLength + breaksTimesList[i+1]);
                        }
                        else
                        {
                            //for (int j = i + 2; j < breaksTimesList.Count; j++)
                            //{
                            //    if (breaksTimesList[j] >= currLength)
                            //    {
                            //        result = Math.Max(result, left + currLength + breaksTimesList[i + 1]);
                            //        break;
                            //    }
                            //}
                            //result = Math.Max(result, left + breaksTimesList[i + 1]);

                            if (i < breaksTimesList.Count - 2 && currLength <= intRightBreaksTimes[i+2])
                            {
                                result = Math.Max(result, left + currLength + breaksTimesList[i + 1]);
                            }
                            result = Math.Max(result, left + breaksTimesList[i + 1]);

                        }
                        leftMaxWithoutAdjacent = Math.Max(left, leftMaxWithoutAdjacent);
                        left = 0;
                        indexNoBreaksTimes++;
                    }
                }
                else
                {
                    leftMaxWithoutAdjacent = Math.Max(left, leftMaxWithoutAdjacent);
                    left = breaksTimesList[i];
                }
            }

            return result;
        }
    }
}
