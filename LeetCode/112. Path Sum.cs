using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_112
    {
        ////(112.) Path Sum (EASY)
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return TreeHasPathSumTask112(root, targetSum);
        }

        public static bool TreeHasPathSumTask112(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            targetSum -= root.val;
            if (root.left == null && root.right == null && targetSum == 0)
            {
                return true;
            }
            return TreeHasPathSumTask112(root.left, targetSum) || TreeHasPathSumTask112(root.right, targetSum);
        }

    }
}
