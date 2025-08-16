using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1038
    {
        ////(1038.) Binary Search Tree to Greater Sum Tree (MEDIUM)
        private int _currValue;
        public TreeNode BstToGst(TreeNode root)
        {
            _currValue = 0;
            TreeNode dummyRoot = root;

            UpdateRoot(root);

            return dummyRoot;
        }
        public void UpdateRoot(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            UpdateRoot(root.right);
            //_listValue.Add(root.val);
            if (_currValue == 0)
            {
                _currValue += root.val;
            }
            else
            {
                _currValue += root.val;
                root.val = _currValue;
            }
            //Console.WriteLine(root.val);
            UpdateRoot(root.left);
        }
    }
}
