using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_547
    {
        ////(547.) Number of Provinces (MEDIUM)
        public int FindCircleNum(int[][] isConnected)
        {
            Dictionary<int, HashSet<int>> groupCities = new Dictionary<int, HashSet<int>>();
            int length = isConnected.Length;
            int numberGroup = 0;
            foreach (var cities in isConnected)
            {
                HashSet<int> currGroup = new HashSet<int>();
                for (int indexCity = 0; indexCity < length; indexCity++)
                {
                    int isConnect = cities[indexCity];
                    if (isConnect == 1)
                    {
                        currGroup.Add(indexCity);
                    }
                }

                foreach (var groupListCities in groupCities)
                {
                    bool added = false;
                    foreach (var city in currGroup)
                    {
                        if (groupListCities.Value.Contains(city))
                        {
                            added = true;
                            foreach (var cityInList in groupListCities.Value)
                            {
                                currGroup.Add(cityInList);
                            }
                            break;
                        }
                    }
                    if (added)
                    {
                        groupCities.Remove(groupListCities.Key);
                    }
                }
                groupCities.Add(numberGroup++, currGroup);
            }
            
            return groupCities.Count;
        }
    }
}
