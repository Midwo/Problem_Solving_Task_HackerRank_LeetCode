using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0124
    {
        ////124. ACM ICPC Team (EASY)
        public List<int> acmTeam(List<string> topic)
        {
            ////Solution 1 (New)
            int maxKnow = 0;
            int countMaxKnow = 0;
            int m = topic[0].Length;
            for (int indexFirstTeam = 0; indexFirstTeam < topic.Count -1; indexFirstTeam++)
            {
                for (int indexSecondTeam = indexFirstTeam+1; indexSecondTeam < topic.Count; indexSecondTeam++)
                {
                    int currKnow = 0;
                    for (int index = 0; index < m; index++)
                    {
                        if (topic[indexFirstTeam][index] == '1' || topic[indexSecondTeam][index] == '1')
                            currKnow++;
                    }
                    if (maxKnow < currKnow)
                    {
                        maxKnow = currKnow;
                        countMaxKnow = 1;
                    }
                    else if (maxKnow == currKnow)
                        countMaxKnow++;
                }
            }
            return new List<int> { maxKnow, countMaxKnow };

            ////Solution 2 (Old)
            //int countPermutationMaxTask = 0;
            //int maxTaskDoneValueLoop = 0;
            //int maxTaskDoneValue = 0;
            //int howManyTask = topic[0].Length;
            //int howManyTeams = topic.Count();
            //for (int i = 0; i < howManyTeams - 1; i++)
            //{
            //    for (int x = i + 1; x < howManyTeams; x++)
            //    {
            //        maxTaskDoneValueLoop = 0;
            //        for (int y = 0; y < howManyTask; y++)
            //        {
            //            if ((topic[i][y].ToString() == "1") || (topic[x][y].ToString() == "1"))
            //            {
            //                maxTaskDoneValueLoop++;
            //            }
            //        }
            //        if (maxTaskDoneValueLoop > maxTaskDoneValue)
            //        {
            //            countPermutationMaxTask = 1;
            //            maxTaskDoneValue = maxTaskDoneValueLoop;
            //        }
            //        else if (maxTaskDoneValueLoop == maxTaskDoneValue)
            //        {
            //            countPermutationMaxTask++;
            //            maxTaskDoneValue = maxTaskDoneValueLoop;
            //        }
            //    }
            //}
            //List<int> newPrintList = new List<int>();
            //newPrintList.Add(maxTaskDoneValue);
            //newPrintList.Add(countPermutationMaxTask);
            //return newPrintList;
        }
    }
}
