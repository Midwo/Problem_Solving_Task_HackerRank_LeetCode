using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_119
    {
        ////(119.) Pascal's Triangle II (EASY)
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> fullList = new List<IList<int>>();
            fullList.Add(new List<int>([1]));
            if (rowIndex == 0)
            {
                return fullList[0];
            }
            else
            {
                for (int i = 0; i < rowIndex; i++)
                {
                    List<int> currentList = new List<int>();
                    currentList.Add(1);
                    for (int j = 1; j < fullList[i].Count; j++)
                    {
                        currentList.Add(fullList[i][j - 1] + fullList[i][j]);
                    }
                    currentList.Add(1);
                    fullList.Add(currentList);
                }
                return fullList[fullList.Count - 1];
            }
        }
    }
}
