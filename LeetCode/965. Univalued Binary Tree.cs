using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_965
    {
        ////(965.) Univalued Binary Tree (EASY)
        private bool _result;
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return false;
            _result = true;
            DeepIsUnivalTree(root, root.val);

            return _result;
        }

        private void DeepIsUnivalTree(TreeNode root, int rootValue)
        {
            if (root == null)
            {
                return;
            }
            if (root.val != rootValue)
            {
                _result = false;
                return;
            }
            else
            {
                DeepIsUnivalTree(root.left, rootValue);
                DeepIsUnivalTree(root.right, rootValue);
            }
        }
    }
}
