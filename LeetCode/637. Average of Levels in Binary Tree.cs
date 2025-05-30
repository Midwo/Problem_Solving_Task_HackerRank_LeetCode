using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_637
    {
        ////(637.) Average of Levels in Binary Tree (EASY)
        Dictionary<int, long[]> dictSumCount;
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> result = new List<double>();
            dictSumCount = new Dictionary<int, long[]>();
            int level = 0;
            if (root != null) 
            {
                AverageOfLevelsDeep(root, 0);
            }

            foreach (var item in dictSumCount)
            {
                //double temp = (double)(Convert.ToDouble(item.Value[0]) / Convert.ToDouble(item.Value[1]));
                result.Add(Convert.ToDouble(item.Value[0]) / Convert.ToDouble(item.Value[1]));
            }

            return result;
        }

        private void AverageOfLevelsDeep(TreeNode root, int level)
        {
            if (root == null) 
            {
                return;
            }
            if (dictSumCount.ContainsKey(level))
            {
                long[] temp = dictSumCount[level];
                temp[0] += root.val;
                temp[1]++;
                dictSumCount[level] = temp;
            }
            else
            {
                dictSumCount.Add(level, [root.val, 1]);
            }
            level++;
            AverageOfLevelsDeep(root.left, level);
            AverageOfLevelsDeep(root.right, level);
        }

    }
}
