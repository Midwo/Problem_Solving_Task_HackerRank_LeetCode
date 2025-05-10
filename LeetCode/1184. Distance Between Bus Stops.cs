using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1184
    {
        ////(1184.) Distance Between Bus Stops (EASY)
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int length = distance.Length;
            int reverseRouteDistance = 0;
            int routeDistance = 0;
            int indexReverseRoute = start;
            int indexRoute = start;
            bool endRoute = false;
            bool endReverseRoute = false;
          
            while (!endRoute || !endReverseRoute)
            {
                if (!endRoute)
                {
                    if (indexRoute == destination)
                    {
                        endRoute = true;
                    }
                    else
                    {
                        if (indexRoute >= length)
                        {
                            indexRoute = 0;
                            if (indexRoute == destination)
                            {
                                endRoute = true;
                            }
                            else
                            {
                                routeDistance += distance[0];
                            }
                        }
                        else
                        {
                            if (indexRoute < 1)
                            {
                                routeDistance += distance[0];
                            }
                            else
                            {
                                routeDistance += distance[indexRoute];
                            }
                        }
                    }
                    indexRoute++;
                }
                else
                {
                    if ( routeDistance < reverseRouteDistance)
                    {
                        return routeDistance;
                    }
                }

                if (!endReverseRoute)
                {
                    if (indexReverseRoute == destination)
                    {
                        endReverseRoute = true;
                    }
                    else
                    {
                        if (indexReverseRoute < 0)
                        {
                            indexReverseRoute = length;
                            if (indexReverseRoute == destination)
                            {
                                endReverseRoute = true;
                            }
                        }
                        else
                        {
                            if (indexReverseRoute < 1)
                            {
                                reverseRouteDistance += distance[length-1];
                            }
                            else
                            {
                                reverseRouteDistance += distance[indexReverseRoute-1];
                            }
                        }
                    }
                    indexReverseRoute--;
                }
                else
                {
                    if (reverseRouteDistance < routeDistance)
                    {
                        return reverseRouteDistance;
                    }
                }
            }

            return Math.Min(reverseRouteDistance, routeDistance);
        }
    }
}
