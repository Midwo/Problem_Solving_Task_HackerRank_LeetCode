using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2244
    {
        ////(2244.) Minimum Rounds to Complete All Tasks (MEDIUM)
        public int MinimumRounds(int[] tasks)
        {
            var freqDictionary = new Dictionary<int, int>();
            
            foreach(var task in tasks)
            {
                if (!freqDictionary.TryAdd(task, 1))
                    freqDictionary[task]++;
            }

            int sumRounds = 0;

            foreach (var currFreqAndValue in freqDictionary) 
            { 
                if (currFreqAndValue.Value < 2)
                {
                    return -1;
                }

                sumRounds += (currFreqAndValue.Value + 2) / 3;


                ////Alternative:

                //if(currFreqAndValue.Value % 3 == 0)
                //{
                //    sumRounds += currFreqAndValue.Value / 3;
                //}
                //else if ((currFreqAndValue.Value -2) % 3 == 0)
                //{
                //    sumRounds += 1 + (currFreqAndValue.Value) / 3;
                //}
                //else if((currFreqAndValue.Value -4) % 3 == 0)
                //{
                //    sumRounds += 2 + (currFreqAndValue.Value - 4) / 3;
                //}
            }

            return sumRounds;
        }
    }
}
