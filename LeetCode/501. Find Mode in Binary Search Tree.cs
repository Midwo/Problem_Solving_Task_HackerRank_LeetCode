using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_501
    {
        public int[] FindMode(TreeNode root)
        {
            ////(501.) Find Mode in Binary Search Tree (EASY)
            
            List<int> ans = new List<int>();
            int[] count = new int[2];

            inorder(root, count, ans);
            return ans.ToArray();
        }

        private TreeNode pred = null;

        private void inorder(TreeNode root, int[] count, List<int> ans)
        {
            if (root == null)
                return;

            inorder(root.left, count, ans);
            updateCount(root, count, ans);
            inorder(root.right, count, ans);
        }

        private void updateCount(TreeNode root, int[] count, List<int> ans)
        {
            if (pred != null && pred.val == root.val)
                ++count[0];
            else
                count[0] = 1;

            if (count[0] > count[1])
            {
                count[1] = count[0];
                ans.Clear();
                ans.Add(root.val);
            }
            else if (count[0] == count[1])
            {
                ans.Add(root.val);
            }

            pred = root;
        }
    }
}
