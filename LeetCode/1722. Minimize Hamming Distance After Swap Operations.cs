using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1722
    {
        ////(1722.) Minimize Hamming Distance After Swap Operations (MEDIUM)
        public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps)
        {
            int lengthSource = source.Length;

            var dictionaryGraph = new Dictionary<int, List<int>>();

            for (int i = 0; i < lengthSource; i++)
            {
                dictionaryGraph[i] = new List<int>();
            }

            foreach (var item in allowedSwaps)
            {
                int a = item[0];
                int b = item[1];

                dictionaryGraph[a].Add(b);
                dictionaryGraph[b].Add(a);
            }

            bool[] visited = new bool[lengthSource];
            int minHammingDistance = 0;

            for (int i = 0; i < lengthSource; i++)
            {
                if (visited[i])
                    continue;

                var listIndex = new List<int>();
                
                DFS(i, dictionaryGraph, visited, listIndex);

                Dictionary<int, int> freq = new();

                foreach (int index in listIndex)
                {
                    if (!freq.ContainsKey(source[index]))
                        freq[source[index]] = 0;

                    freq[source[index]]++;
                }

                foreach (int index in listIndex)
                {
                    int val = target[index];

                    if (freq.ContainsKey(val) && freq[val] > 0)
                    {
                        freq[val]--;
                    }
                    else
                    {
                        minHammingDistance++;
                    }
                }
            }

            return minHammingDistance;
        }

        private void DFS(int index, Dictionary<int, List<int>> dictionaryGraph, bool[] visited, List<int> component)
        {
            visited[index] = true;
            component.Add(index);

            foreach (int currIndexFromList in dictionaryGraph[index])
            {
                if (!visited[currIndexFromList])
                {
                    DFS(currIndexFromList, dictionaryGraph, visited, component);
                }
            }
        }

    }
}
