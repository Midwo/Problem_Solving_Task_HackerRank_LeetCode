using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_111
    {
        ////(111.) Minimum Depth of Binary Tree(EASY) 
        public int MinDepth(TreeNode root)
        {
            return TreeMinDepth(root);
        }
        public static int TreeMinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            if (root.left == null)
            {
                return TreeMinDepth(root.right) + 1;
            }
            if (root.right == null)
            {
                return TreeMinDepth(root.left) + 1;
            }
            return Math.Min(TreeMinDepth(root.left), TreeMinDepth(root.right)) + 1;
        }
    }
}
