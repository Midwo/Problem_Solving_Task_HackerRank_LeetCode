using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0039
    {
        ////39. Breaking the Records (EASY)
        public List<int> breakingRecords(List<int> scores)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int minBrokeCount = 0;
            int maxBrokeCount = 0;
            bool firstRecord = true;
            List<int> lista = new List<int>();
            foreach (var i in scores)
            {
                if (firstRecord)
                {
                    minValue = i;
                    maxValue = i;
                    firstRecord = false;
                }
                if (minValue < i)
                {
                    minValue = i;
                    minBrokeCount++;
                }
                if (maxValue > i)
                {
                    maxValue = i;
                    maxBrokeCount++;
                }
            }
            lista.Add(minBrokeCount);
            lista.Add(maxBrokeCount);
            return lista;
        }
    }
}
