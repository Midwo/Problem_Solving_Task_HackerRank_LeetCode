using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2058
    {
        ////(2058.) Find the Minimum and Maximum Number of Nodes Between Critical Points (MEDIUM)
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            int minDistance = int.MaxValue;
            int maxDistance = -1;
            //List<int> indexCriticalPoints = new List<int>();
            int penultimateValue = 0;
            int lastValue = 0;
            int currValue = 0;
            int startChecking = 2;
            int position = 0;
            int lastPosition = -1;
            int firstPosition = -1;

            while (head != null)
            {
                penultimateValue = lastValue;
                lastValue = currValue;
                currValue = head.val;

                if (startChecking == 0)
                {
                    if (penultimateValue > lastValue && lastValue < currValue)
                    {
                        if(lastPosition == -1)
                        {
                            lastPosition = position;
                            firstPosition = position;
                        }
                        else
                        {
                            minDistance = Math.Min(minDistance, position - lastPosition);
                            lastPosition = position;
                        }
                        //indexCriticalPoints.Add(position);
                        maxDistance = Math.Max(maxDistance, position - firstPosition);
                    }
                    else if (penultimateValue < lastValue && lastValue > currValue)
                    {
                        if (lastPosition == -1)
                        {
                            lastPosition = position;
                            firstPosition = position;
                        }
                        else
                        {
                            minDistance = Math.Min(minDistance, position - lastPosition);
                            lastPosition = position;
                        }
                        //indexCriticalPoints.Add(position);
                        maxDistance = Math.Max(maxDistance, position - firstPosition);
                    }
                }
                else
                {
                    startChecking--;
                }
                position++;
                head = head.next;
            }

            if (firstPosition == lastPosition)
            {
                return new int[] { -1, -1 };
            }

            return new int[] { minDistance, maxDistance };

            //if(indexCriticalPoints.Count < 2) 
            //{ 
            //    return new int[] { -1, -1 };
            //}
            //else
            //{
            //    //maxDistance = indexCriticalPoints[indexCriticalPoints.Count-1]-indexCriticalPoints[0];
            //    return new int[] { minDistance, maxDistance };
            //}
        }
    }
}
