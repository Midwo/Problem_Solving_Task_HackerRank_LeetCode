using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1305
    {
        ////(1305.) All Elements in Two Binary Search Trees (MEDIUM)
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            List<int> listAllValues = new List<int>();

            CheckRoot(root1, listAllValues);
            CheckRoot(root2, listAllValues);

            listAllValues.Sort();
            return listAllValues;
        }

        private void CheckRoot(TreeNode root, List<int> listAllValues)
        {
            if (root != null)
            {
                listAllValues.Add(root.val);
            }
            else
            {
                return;
            }

            CheckRoot(root.left, listAllValues);
            CheckRoot(root.right, listAllValues);
        }
    }
}
