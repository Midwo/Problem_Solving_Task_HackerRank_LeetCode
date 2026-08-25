using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2265
    {
        ////(2265.) Count Nodes Equal to Average of Subtree (MEDIUM)
        public int AverageOfSubtree(TreeNode root)
        {
            int count = 0;

            dfs(root);

            (int sum, int size) dfs (TreeNode root)
            {
                if (root == null)
                {
                    return (0, 0);
                }

                (int leftSum, int leftSize) = dfs (root.left);
                (int rightSum, int rightSize) = dfs (root.right);

                int sum = leftSum + rightSum + root.val;
                int size = rightSize + leftSize + 1;

                if(root.val == sum / size)
                {
                    count++;
                }
                //Console.WriteLine(root.val);

                return (sum, size);
            }
            
            return count;
        }
    }
}
