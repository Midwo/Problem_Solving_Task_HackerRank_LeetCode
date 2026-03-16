using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2446
    {
        ////(2446.) Determine if Two Events Have Conflict (EASY)
        public bool HaveConflict(string[] event1, string[] event2)
        {
            int currHourEv1Start = int.Parse(event1[0][0..2]);
            int currHourEv2Start = int.Parse(event2[0][0..2]);
            int currMinEv1Start = int.Parse(event1[0][3..5]);
            int currMinEv2Start = int.Parse(event2[0][3..5]);

            int currHourEv1Stop = int.Parse(event1[1][0..2]);
            int currHourEv2Stop = int.Parse(event2[1][0..2]);
            int currMinEv1Stop = int.Parse(event1[1][3..5]);
            int currMinEv2Stop = int.Parse(event2[1][3..5]);

            if(currHourEv1Start < currHourEv2Start)
            {
                if(currHourEv1Stop < currHourEv2Start)
                {
                    return false;
                }
                else if (currHourEv1Stop == currHourEv2Start)
                {
                    if (currMinEv1Stop < currMinEv2Start)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else if (currHourEv1Start > currHourEv2Start)
            {
                if (currHourEv2Stop < currHourEv1Start)
                {
                    return false;
                }
                else if (currHourEv2Stop == currHourEv1Start)
                {
                    if (currMinEv2Stop < currMinEv1Start)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if(currMinEv1Start < currMinEv2Start)
                {
                    if(currHourEv1Stop == currHourEv2Start)
                    {
                        if(currMinEv1Stop < currMinEv2Start)
                        {
                            return false;
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }   
                }
                else if(currMinEv1Start > currMinEv2Start)
                {
                    if (currHourEv2Stop == currHourEv1Start)
                    {
                        if (currMinEv2Stop < currMinEv1Start)
                        {
                            return false;
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }                
            }
        }
    }
}
