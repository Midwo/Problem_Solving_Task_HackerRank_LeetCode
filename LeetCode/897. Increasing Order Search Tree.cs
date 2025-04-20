using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_897
    {
        ////(897.) Increasing Order Search Tree (EASY)

        private TreeNode currentRoot;

        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode newDummyRoot = new TreeNode(-1);
            currentRoot = newDummyRoot;

            IncreasingBSTIn(root);
            return newDummyRoot.right;
        }

        private void IncreasingBSTIn(TreeNode root)
        {
            if (root == null) 
            { 
                return; 
            }

            IncreasingBSTIn(root.left);

            root.left = null;
            currentRoot.right = root;
            currentRoot = root;

            IncreasingBSTIn(root.right);
        }
    }
}
