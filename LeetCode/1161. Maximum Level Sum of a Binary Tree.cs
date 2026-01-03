using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1161
    {
        ////(1161.) Maximum Level Sum of a Binary Tree (MEDIUM)
        public int MaxLevelSum(TreeNode root)
        {
            Dictionary<int, int> levelAndSum = new Dictionary<int, int>();
            AddingToTheSumLevel(root, 1, levelAndSum); 
            int levelSumMax = 1; 
            int sumMax = levelAndSum[1];

            foreach (var item in levelAndSum)
            {
                if (sumMax < item.Value || sumMax == item.Value && levelSumMax > item.Key)
                {
                    sumMax = item.Value;
                    levelSumMax = item.Key;
                }
            }

            return levelSumMax;
        }
        private void AddingToTheSumLevel(TreeNode root, int level, Dictionary<int, int> levelAndSum)
        {
            if (root == null)
            {
                return;
            }
            
            int currValue = root.val;
            if (levelAndSum.ContainsKey(level))
            {
                levelAndSum[level] += currValue;
            }
            else
            {
                levelAndSum.Add(level, currValue);
            }

            AddingToTheSumLevel(root.left, level + 1, levelAndSum);
            AddingToTheSumLevel(root.right, level + 1, levelAndSum);
        }

    }
}
