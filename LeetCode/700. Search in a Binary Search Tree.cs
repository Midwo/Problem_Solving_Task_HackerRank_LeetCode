using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_700
    {
        ////(700.) Search in a Binary Search Tree (EASY)
        public TreeNode SearchBST(TreeNode root, int val)
        {
            ////0ms, Beats: 100.00%

            while (root != null) 
            { 
                if(root.val == val)
                {
                    return root;
                }
                if(root.val > val)
                {
                    root = root.right;
                }
                if (root.val < val)
                {
                    root = root.left;
                }
            }

            return null;
        }
    }
}
