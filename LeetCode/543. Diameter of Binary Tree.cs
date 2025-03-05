using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_543
    {
        ////(543.) Diameter of Binary Tree (EASY)
        private int maxLevelTree;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxLevelTree = 0;
            DepthLeveLTree(root);
            return maxLevelTree;
        }

        private int DepthLeveLTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DepthLeveLTree(root.left);
            int right = DepthLeveLTree(root.right);

            maxLevelTree = Math.Max(maxLevelTree, left + right);

            return 1 + Math.Max(left, right);
        }
    }
}
