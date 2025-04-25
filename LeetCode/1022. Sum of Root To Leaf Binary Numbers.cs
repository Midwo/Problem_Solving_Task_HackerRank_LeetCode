using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    ////(1022.) Sum of Root To Leaf Binary Numbers (EASY)
    internal class LeetCode_1022
    {
        private int _sum;
        public int SumRootToLeaf(TreeNode root)
        {
            _sum = 0;
            if (root != null)
            {
                DeepSumSumRootToLeaf(root, 0);
            }
            return _sum;
        }
        private void DeepSumSumRootToLeaf(TreeNode root, int target)
        {
            if (root == null)
            {
                return;
            }

            target = target * 2 + root.val;
            
            if (root.left == null && root.right == null)
            {
                _sum += target;
            }

            DeepSumSumRootToLeaf(root.left, target);
            DeepSumSumRootToLeaf(root.right, target);
        }
    }
}
