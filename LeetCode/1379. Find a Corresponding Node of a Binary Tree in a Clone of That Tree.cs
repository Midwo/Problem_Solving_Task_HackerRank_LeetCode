using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1379
    {
        ////(1379.) Find a Corresponding Node of a Binary Tree in a Clone of That Tree (EASY)
        
        private TreeNode _ans, _target;
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            _target = target;
            inorder(original, cloned);
            return _ans;
        }

        public void inorder(TreeNode original, TreeNode cloned)
        {
            if (original != null)
            {
                inorder(original.left, cloned.left);
                if (original == _target)
                {
                   _ans = cloned;
                }
                inorder(original.right, cloned.right);
            }
        }
    }
}
