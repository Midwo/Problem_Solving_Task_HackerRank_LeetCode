using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1448
    {
        ////(1448.) Count Good Nodes in Binary Tree (MEDIUM)
        private int _countGoodNodes;
        public int GoodNodes(TreeNode root)
        {
            _countGoodNodes = 0;

            CountGoodNodes(root.val, root);

            return _countGoodNodes;
        }

        private void CountGoodNodes(int currValueMax, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            int currValueRoot = root.val;

            if (currValueMax <= currValueRoot)
            {
                _countGoodNodes++;
                currValueMax = currValueRoot;
            }

            CountGoodNodes(currValueMax, root.left);
            CountGoodNodes(currValueMax, root.right); 
        }
    }
}
