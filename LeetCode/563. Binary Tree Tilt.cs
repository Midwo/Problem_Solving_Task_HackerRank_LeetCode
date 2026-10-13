using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_563
    {
        ////(563.) Binary Tree Tilt (EASY)
        public int FindTilt(TreeNode root)
        {
            int result = 0;
            SumTree(root);
            return result;

            int SumTree(TreeNode root)
            {
                if (root == null)
                    return 0;

                int leftSum = SumTree(root.left);
                int rightSum = SumTree(root.right);

                int abs = Math.Abs(leftSum - rightSum);
                result += abs;
                
                return root.val + leftSum + rightSum;
            }
        }
    }
}
