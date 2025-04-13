using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_796
    {
        ////796. Rotate String (EASY)
        private int _goalLength;
        private string _s;
        private string _goal;
        public bool RotateString(string s, string goal)
        {
            int sLength = s.Length;
            _goalLength = goal.Length;
            _s = s;
            _goal = goal;

            if (sLength != _goalLength)
            {
                return false;
            }

            char firstCharS = s[0];

            for (int i = 0; i < _goalLength; i++)
            {
                //Console.WriteLine(goal[i]);
                //Console.WriteLine(s[0]);
                if (s[0] == goal[i])
                {
                    if (isRotateString(1, i+1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isRotateString(int indexS, int indexGoal)
        {
            while (indexS < _goalLength)
            {
                if (indexGoal == _goalLength)
                {
                    indexGoal = 0;
                    //Console.WriteLine(_goal[indexGoal]);
                }
                //Console.WriteLine(_goal[indexGoal]);
                //Console.WriteLine(_s[indexS]);
                if (_s[indexS] != _goal[indexGoal])
                {
                    return false;
                }
                indexS++;
                indexGoal++;
            }

            return true;
        }
    }
}
