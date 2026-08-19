using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4020
    {
        ////(4020.) Elevator Requests I (EASY)
        public int ElevatorRequests(int n, int[] requests)
        {
            int sumElevatorRequests = 0;
            int lastValue = 0;

            foreach (int request in requests) 
            {
                sumElevatorRequests += Math.Abs(request - lastValue);
                lastValue = request;
            }

            return sumElevatorRequests;
        }
    }
}
