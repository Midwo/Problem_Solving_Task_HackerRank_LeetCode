using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2236
    {
        ////(2236.) Root Equals Sum of Children (EASY)
        public bool CheckTree(TreeNode root)
        {
            if (root.val == root.left.val + root.right.val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
