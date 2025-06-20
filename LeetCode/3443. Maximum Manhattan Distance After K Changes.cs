using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3443
    {
        ////(3443.) Maximum Manhattan Distance After K Changes (MEDIUM)
        public int MaxDistance(string s, int k)
        {
            int result = 0;
            int upN = 0;
            int downS = 0;
            int leftW = 0;
            int rightE = 0;
            int howManyMaxAdd = 0;

            for (int i = 0; i < s.Length; i++)
            {
                howManyMaxAdd = 0;
                switch (s[i])
                {
                    case 'N':
                        upN++;
                        break;
                    case 'S':
                        downS++;
                        break;
                    case 'W':
                        leftW++;
                        break;
                    default:
                        rightE++;
                        break;
                }

                if(upN <= downS)
                {
                    howManyMaxAdd += upN;
                }
                else
                {
                    howManyMaxAdd += downS;
                }

                if(leftW <= rightE)
                {
                    howManyMaxAdd += leftW;
                }
                else
                {
                    howManyMaxAdd += rightE;
                }
   
                result = Math.Max(result, Math.Abs(downS - upN) + Math.Abs(leftW - rightE) + Math.Min(k, howManyMaxAdd)*2);

            }

            return result;
        }
    }
}
