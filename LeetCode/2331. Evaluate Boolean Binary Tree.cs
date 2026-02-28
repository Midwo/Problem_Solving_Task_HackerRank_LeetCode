using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2331
    {
        ////(2331.) Evaluate Boolean Binary Tree (EASY)
        public bool EvaluateTree(TreeNode root)
        {
            bool status = CheckStatusEvaluateTree(root);

            return status;
        }

        private bool CheckStatusEvaluateTree(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return root.val != 0;
            }

            bool leftStatus = CheckStatusEvaluateTree(root.left);
            bool rightStatus = CheckStatusEvaluateTree(root.right);
            bool currStatus;

            if (root.val == 2)
            {
                currStatus = leftStatus | rightStatus;
            }
            else
            {
                currStatus = leftStatus & rightStatus;
            }

            return currStatus;
        }
            
    }
}
