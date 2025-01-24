using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_222
    {
        ////(222.) Count Complete Tree Nodes (EASY) 
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftCount = CountNodes(root.left);
            int rightCount = CountNodes(root.right);

            return leftCount + rightCount + 1;
        }
    }
}
