using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0015
    {
        public List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> outputList = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] + arr[j] == m)
                    {
                        outputList.Add(i + 1);
                        outputList.Add(j + 1);
                        break;
                    }
                }
            }
            return outputList;
        }

    }
}
