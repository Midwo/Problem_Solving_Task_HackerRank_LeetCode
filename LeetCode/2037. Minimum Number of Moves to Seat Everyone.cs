using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2037
    {
        ////(2037.) Minimum Number of Moves to Seat Everyone (EASY)
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            int result = 0;

            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }

            return result;
        }
    }
}
