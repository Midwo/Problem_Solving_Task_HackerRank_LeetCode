using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0010
    {
        public List<int> acmTeam(List<string> topic)
        {
            //topic = ["10101", "11100", "11010", "00101"];
            int countPermutationMaxTask = 0;
            int maxTaskDoneValueLoop = 0;
            int maxTaskDoneValue = 0;
            int howManyTask = topic[0].Length;
            int howManyTeams = topic.Count();
            for (int i = 0; i < howManyTeams - 1; i++)
            {
                for (int x = i + 1; x < howManyTeams; x++)
                {
                    maxTaskDoneValueLoop = 0;
                    for (int y = 0; y < howManyTask; y++)
                    {
                        if ((topic[i][y].ToString() == "1") || (topic[x][y].ToString() == "1"))
                        {
                            maxTaskDoneValueLoop++;
                        }
                    }
                    if (maxTaskDoneValueLoop > maxTaskDoneValue)
                    {
                        countPermutationMaxTask = 1;
                        maxTaskDoneValue = maxTaskDoneValueLoop;
                    }
                    else if (maxTaskDoneValueLoop == maxTaskDoneValue)
                    {
                        countPermutationMaxTask++;
                        maxTaskDoneValue = maxTaskDoneValueLoop;
                    }
                }
            }
            List<int> newPrintList = new List<int>();
            newPrintList.Add(maxTaskDoneValue);
            newPrintList.Add(countPermutationMaxTask);
            return newPrintList;
        }

    }
}
