using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_783
    {
        ////(783.) Minimum Distance Between BST Nodes (EASY)

        private PriorityQueue<int, int> _priorityQueue;
        public int MinDiffInBST(TreeNode root)
        {
            _priorityQueue = new PriorityQueue<int, int>();

            if (root != null)
            {
                GiveMeValueFromTreeNode(root);
            }

            int result = _priorityQueue.Dequeue();
            int nextValue = _priorityQueue.Dequeue();

            if (result > nextValue) 
            {
                result = result - nextValue;
            }
            else
            {
                result = nextValue - result;
            }

            while (_priorityQueue.Count != 0)
            {
                int currTempValue = _priorityQueue.Dequeue();
                int currTempDiff = 0;
                if (nextValue > currTempValue)
                {
                    currTempDiff = nextValue - currTempValue;
                }
                else
                {
                    currTempDiff = currTempValue - nextValue;
                }
                result = Math.Min(result, currTempDiff);
                nextValue = currTempValue;
            }

            return result;
        }

        private void GiveMeValueFromTreeNode(TreeNode root)
        {
            if (root != null)
            {
                _priorityQueue.Enqueue(root.val, root.val);
            }
            if (root.left != null)
            {
                GiveMeValueFromTreeNode(root.left);
            }
            if (root.right != null)
            {
                GiveMeValueFromTreeNode(root.right);
            }
        }
    }
}
