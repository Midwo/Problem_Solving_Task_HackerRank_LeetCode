using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0126
    {
        ////126. Jumping on the Clouds (EASY)
        public int jumpingOnClouds(List<int> c)
        {
            ////Solution 1 (New)
            int countJump = 0;
            int index = 0;
            int indexMeta = c.Count-1;

            while(index < indexMeta)
            {
                if (index + 2 <= indexMeta && c[index + 2] == 0)
                    index += 2;
                else
                    index++;

                countJump++;              
            }

            return countJump;
           


            ////Solution 2 (Old)
            //bool finish = false;
            //int jump = 0;
            //int index = 0;
            //do
            //{
            //    if (index + 1 <= c.Count - 1)
            //    {
            //        if (index + 2 <= c.Count - 1)
            //        {
            //            if (c[index + 2] == 0)
            //            {
            //                jump++;
            //                index += 2;
            //            }
            //            else if (c[index + 1] == 0)
            //            {
            //                jump++;
            //                index++;
            //            }
            //        }
            //        else
            //        {
            //            jump++;
            //            index++;
            //        }
            //    }


            //    if (index >= c.Count - 1)
            //    {
            //        finish = true;
            //    }

            //} while (!finish);
            //return jump;
        }
    }
}
