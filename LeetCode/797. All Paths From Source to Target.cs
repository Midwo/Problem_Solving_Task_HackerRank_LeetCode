using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_797
    {
        ////(797.) All Paths From Source to Target (MEDIUM)

        IList<IList<int>> _resultList;
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            _resultList = new List<IList<int>>();

            IList<int> currPath = new List<int>();
            currPath.Add(0);

            GeneratePath(currPath, 0, graph);

            return _resultList;
        }

        private void GeneratePath(IList<int> currPath, int value, int[][] graph)
        {
            if (value == graph.Length - 1)
            {
                _resultList.Add(new List<int>(currPath));
                //currPath.RemoveAt(currPath.Count() - 1);
                return;
            }

            foreach (int i in graph[value])
            {
                currPath.Add(i);
                GeneratePath(currPath, i, graph);
                currPath.RemoveAt(currPath.Count() - 1);
            }
        }
    }
}
