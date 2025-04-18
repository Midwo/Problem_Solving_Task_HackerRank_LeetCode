using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_872
    {
        ////(872.) Leaf-Similar Trees (EASY)

        private string _resultRoot1String;
        private string _resultRoot2String;
        
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            _resultRoot1String = string.Empty;
            _resultRoot2String = string.Empty;

            if (root1 != null)
            {
                DeepLeafSimilar(root1, 1);
            }
            if (root2 != null)
            {
                DeepLeafSimilar(root2, 2);
            }

            if (_resultRoot1String == _resultRoot2String)
            {
                return true;
            }
            return false;
        }
        private void DeepLeafSimilar(TreeNode root, int numberRoot)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                DeepLeafSimilar(root.left, numberRoot);
            }
            if (root.right != null)
            {
                DeepLeafSimilar(root.right, numberRoot);
            }
            if (root.right == null && root.left == null)
            {
                if (numberRoot == 1)
                {
                    _resultRoot1String += root.val + ',';
                }
                else
                {
                    _resultRoot2String += root.val + ',';
                }
            }
        }
    }
}
