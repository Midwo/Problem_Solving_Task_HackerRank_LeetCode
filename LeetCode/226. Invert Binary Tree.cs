using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_226
    {
        ////(226.) Invert Binary Tree (EASY)
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode invertRoot = root.left;
            root.left = root.right;
            root.right = invertRoot;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
