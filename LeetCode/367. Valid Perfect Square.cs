using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_367
    {
        ////(367.) Valid Perfect Square (EASY)
        public bool IsPerfectSquare(int num)
        {
            bool result = true;
            int min = 0;
            int max = 0;
            switch (num)
            {
                case >= 1600000000:
                    min = 40000;
                    max = 46340;
                    break;
                case >= 900000000:
                    min = 30000;
                    max = 39999;
                    break;
                case >= 400000000:
                    min = 20000;
                    max = 29000;
                    break;
                case >= 100000000:
                    min = 10000;
                    max = 19999;
                    break;
                case <= 100000000:
                    min = 1;
                    max = 9999;
                    break;
            }

            if (result == false)
            {
                return false;
            }
            else
            {
                for (int i = min; i <= max; i++)
                {
                    if ((i * i) == num)
                    {
                        return true;
                    }
                    else if ((i * i) > num)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
