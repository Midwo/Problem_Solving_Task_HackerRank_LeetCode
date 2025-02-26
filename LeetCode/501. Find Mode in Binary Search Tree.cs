using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_501
    {
        ////(501.) Find Mode in Binary Search Tree (EASY)
        public int[] FindMode(TreeNode root)
        {
            
            List<int> result = new List<int>();
            int[] count = new int[2];

            inorder(root, count, result);
            return result.ToArray();
        }

        private TreeNode pred = null;

        private void inorder(TreeNode root, int[] count, List<int> result)
        {
            if (root == null) return;
            if (root == null) return;
            inorder(root.left, count, result);
            updateCount(root, count, result);
            inorder(root.right, count, result);
        }

        private void updateCount(TreeNode root, int[] count, List<int> result)
        {
            if (pred != null && pred.val == root.val)
            {
                ++count[0];
            }
            else 
            { 
                count[0] = 1;
            }
            if (count[0] > count[1])
            {
                count[1] = count[0];
                result.Clear();
                result.Add(root.val);
            }
            else if (count[0] == count[1])
            {
                result.Add(root.val);
            }
            pred = root;
        }
    }
}
