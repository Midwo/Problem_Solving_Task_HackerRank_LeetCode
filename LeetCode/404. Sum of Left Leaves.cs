using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_404
    {
        ////(404.) Sum of Left Leaves (EASY)
        public int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;        
            if (root != null)
            {
                if (CheckingLeaf(root.left))
                {
                    result += root.left.val;
                }
                else
                {
                    result += SumOfLeftLeaves(root.left);
                }
                result += SumOfLeftLeaves(root.right);
            }
            return result;
        }

        private bool CheckingLeaf(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }
    }
}
