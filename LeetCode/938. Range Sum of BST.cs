using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_938
    {
        ////(938.) Range Sum of BST (EASY)
        private int _sum;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.val >= low && root.val <= high)
            {
                _sum += root.val;
            }

            RangeSumBST(root.left, low, high);

            RangeSumBST(root.right, low, high);

            return _sum;
        }

    }
}
