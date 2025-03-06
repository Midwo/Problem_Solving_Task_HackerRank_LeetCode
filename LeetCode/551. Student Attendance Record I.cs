using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_551
    {
        ////(551.) Student Attendance Record I (EASY)
        public bool CheckRecord(string s)
        {
            int howManyTimesAbsent = 0;
            int howManyTimesConsecutiveLate = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == 'A')
                {
                    howManyTimesConsecutiveLate = 0;
                    howManyTimesAbsent++;
                    if (howManyTimesAbsent == 2)
                    {
                        return false;
                    }
                }
                else if (s[i] == 'L')
                {
                    howManyTimesConsecutiveLate++;
                    if (howManyTimesConsecutiveLate == 3)
                    {
                        return false;
                    }
                }
                else
                {
                    howManyTimesConsecutiveLate = 0;
                }
            }
            return true;
        }
    }
}
