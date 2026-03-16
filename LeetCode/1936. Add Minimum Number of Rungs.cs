using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class Leetcode_1936
    {
        ////(1936.) Add Minimum Number of Rungs (MEDIUM)
        public int AddRungs(int[] rungs, int dist)
        {
            int howManyAdd = 0;
            int length = rungs.Length;
            int index = 0;
            int currLevel = 0;

            while (index < length) 
            { 
                if(currLevel + dist < rungs[index])
                {
                    int nextLevel = rungs[index];
                    int temp = (nextLevel - currLevel)-1;
                    
                    int howMany = temp / dist;

                    howManyAdd += howMany;

                    if (index < length - 1)
                    {
                        currLevel = rungs[index];
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    currLevel = rungs[index];
                    index++;
                }
            }

            return howManyAdd;
        }
    }
}
