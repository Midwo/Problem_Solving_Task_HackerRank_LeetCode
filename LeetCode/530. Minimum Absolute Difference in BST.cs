using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_530
    {
        ////(530.) Minimum Absolute Difference in BST (EASY)
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> listValueRoot = new List<int>();
            InTree(listValueRoot, root);
            int minDifference = int.MaxValue;
            for (int i = 0; i < listValueRoot.Count-1; i++) 
            {
                minDifference = Math.Min(minDifference, listValueRoot[i + 1] - listValueRoot[i]);
            }
            return minDifference;
        }

        public void InTree(List<int> listValueRoot, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InTree(listValueRoot, root.left);
            listValueRoot.Add(root.val);
            InTree(listValueRoot, root.right);
        }
    }
}
