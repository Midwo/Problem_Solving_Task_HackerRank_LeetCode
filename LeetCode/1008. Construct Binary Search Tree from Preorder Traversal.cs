using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1008
    {
        ////(1008.) Construct Binary Search Tree from Preorder Traversal (MEDIUM)
        public TreeNode BstFromPreorder(int[] preorder)
        {
            int index = 0;
            int maxIndex = preorder.Length -1;
            return BuildTreeNode(int.MaxValue);

            TreeNode BuildTreeNode(int maxValue)
            {
                if(index > maxIndex || preorder[index] > maxValue)
                    return null;

                TreeNode root = new TreeNode(preorder[index++]);
                root.left = BuildTreeNode(root.val);
                root.right = BuildTreeNode(maxValue);

                return root;
            }
        }
    }
}
