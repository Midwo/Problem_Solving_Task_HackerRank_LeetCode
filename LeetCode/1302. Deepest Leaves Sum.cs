using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1302
    {
        ////(1302.) Deepest Leaves Sum (MEDIUM)

        private int _maxLevel;
        private int _sumMaxLevel;
        public int DeepestLeavesSum(TreeNode root)
        {
            _maxLevel = 0;
            _sumMaxLevel = 0;

            SeachrDeepestLeaves(root, 0, 0);

            return _sumMaxLevel/2;
        }

        private void SeachrDeepestLeaves(TreeNode root, int level, int lastValue) 
        {
            if (root == null)
            {
                if (_maxLevel <= level)
                {
                    if(_maxLevel < level)
                    {
                        _maxLevel = level;
                        _sumMaxLevel = lastValue;
                    }
                    else
                    {
                        _sumMaxLevel += lastValue;
                    }
                }
                return;
            }

            SeachrDeepestLeaves(root.left, level + 1, root.val);
            SeachrDeepestLeaves(root.right, level + 1, root.val);

        }

    }
}
