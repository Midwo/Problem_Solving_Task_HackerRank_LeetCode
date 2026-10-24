using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2409
    {
        ////(2409.) Count Days Spent Together (EASY)
        public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            int[] daysInMonths = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
            int countDaysTogether = 0;

            int lateArriveMonth = 0;
            int lateArriveDay = 0;
            int earlyLeaveMonth = 0;
            int earlyLeaveDay = 0;

            int convertAliceMonth = int.Parse(arriveAlice[0..2]);
            int convertAliceDay = int.Parse(arriveAlice[3..5]);
            int convertBobMonth = int.Parse(arriveBob[0..2]);
            int convertBobDay = int.Parse(arriveBob[3..5]);

            if(convertAliceMonth > convertBobMonth)
            {
                lateArriveMonth = convertAliceMonth;
                lateArriveDay = convertAliceDay;
            }
            else if (convertAliceMonth < convertBobMonth)
            {
                lateArriveMonth = convertBobMonth;
                lateArriveDay = convertBobDay;            
            }
            else
            {
                lateArriveMonth = convertAliceMonth;
                if (convertAliceDay > convertBobDay)
                    lateArriveDay = convertAliceDay;
                else
                    lateArriveDay = convertBobDay;
            }

            convertAliceMonth = int.Parse(leaveAlice[0..2]);
            convertAliceDay = int.Parse(leaveAlice[3..5]);
            convertBobMonth = int.Parse(leaveBob[0..2]);
            convertBobDay = int.Parse(leaveBob[3..5]);

            if(convertAliceMonth < convertBobMonth)
            {
                earlyLeaveMonth = convertAliceMonth;
                earlyLeaveDay = convertAliceDay;
            }
            else if(convertAliceMonth > convertBobMonth)
            {
                earlyLeaveMonth = convertBobMonth;
                earlyLeaveDay = convertBobDay;
            }
            else
            {
                earlyLeaveMonth = convertAliceMonth;
                if(convertAliceDay < convertBobDay)
                    earlyLeaveDay = convertAliceDay;
                else
                    earlyLeaveDay = convertBobDay;
            }

            if (lateArriveMonth > earlyLeaveMonth || lateArriveMonth == earlyLeaveMonth && lateArriveDay > earlyLeaveDay)
                return 0;
            else if (lateArriveMonth == earlyLeaveMonth)
                return earlyLeaveDay - lateArriveDay+1;

            countDaysTogether += earlyLeaveDay + daysInMonths[lateArriveMonth-1] - lateArriveDay+1;
            countDaysTogether += daysInMonths[(lateArriveMonth)..(earlyLeaveMonth-1)].Sum();

            return countDaysTogether;
        }
    }
}
