using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1817
    {
        ////(1817.) Finding the Users Active Minutes (MEDIUM)
        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            int[] resultTable = new int[k];
            Dictionary<int, HashSet<int>> usersAndDistinctActives = new Dictionary<int, HashSet<int>>();
            int length = logs.Length;

            for (int i = 0; i < length; i++)
            {
                int currID = logs[i][0];
                int currTime = logs[i][1];

                if (usersAndDistinctActives.ContainsKey(currID)) //&& usersAndDistinctActives[currID].Count < k)
                {
                    if (usersAndDistinctActives[currID].Count < k)
                    {
                        usersAndDistinctActives[currID].Add(currTime);
                    }
                }
                else
                {
                    usersAndDistinctActives.Add(currID, new HashSet<int>() { currTime });
                }
            }

            foreach (var item in usersAndDistinctActives)
            {
                if (item.Value.Count < k)
                {
                    resultTable[item.Value.Count-1]++;
                }
            }

            return resultTable;
        }
    }
}
