using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0123
    {
        ////123. Taum and B'day (EASY)
        public long taumBday(int b, int w, int bc, int wc, int z)
        {
            ////Solution 1 (New)
            
            if(bc+z <= wc)
                return (long)b*bc + (long)w *(bc+z);
            
            if(wc +z <= bc)
                return (long)w * wc + (long)b * (wc + z);

            return (long)w * wc + (long)b * bc;


            ////Solution 2 (Old)

            //long howMany = 0;

            //if ((long)bc + (long)z <= (long)wc)
            //{
            //    howMany = (long)b * (long)bc + (long)w * ((long)bc + (long)z);
            //}
            //else if ((long)wc + (long)z <= (long)bc)
            //{
            //    howMany = (long)w * (long)wc + (long)b * ((long)wc + (long)z);
            //}
            //else
            //{
            //    howMany = (long)w * (long)wc + (long)b * (long)bc;
            //}
            //return howMany;
        }
    }
}
