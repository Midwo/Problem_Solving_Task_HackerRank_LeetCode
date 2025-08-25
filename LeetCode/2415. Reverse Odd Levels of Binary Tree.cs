using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2415
    {
        ////(2415.) Reverse Odd Levels of Binary Tree (MEDIUM)
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            ReverseOddTreeNode(root.left, root.right, 0);
            return root;
        }

        private void ReverseOddTreeNode(TreeNode leftRoot, TreeNode rightRoot, int level)
        {
            if (leftRoot == null || rightRoot == null)
            {
                return;
            }

            if (level % 2 == 0) 
            {
                int tempValue = rightRoot.val;
                rightRoot.val = leftRoot.val;
                leftRoot.val = tempValue;
            }

            ReverseOddTreeNode(leftRoot.left, rightRoot.right, level + 1);
            ReverseOddTreeNode(leftRoot.right, rightRoot.left, level + 1);
        }
         
    }
}
