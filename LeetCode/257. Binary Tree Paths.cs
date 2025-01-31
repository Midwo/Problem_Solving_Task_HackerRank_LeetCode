using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_257
    {
        ////(257.) Binary Tree Paths (EASY)
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> result = new List<string>();
            StringBuilder stringToList = new StringBuilder();

            if (root == null)
            {
                return result;
            }

            if (root.left == null && root.right == null)
            {
                result.Add(root.val.ToString());
                return result;
            }
            BacktrackingBinaryTreePaths(root, stringToList, result);

            return result;
        }
        private void BacktrackingBinaryTreePaths(TreeNode root, StringBuilder stringToList, IList<string> result)
        {
            if (root.left == null && root.right == null)
            {
                stringToList.Append("->"+root.val.ToString());
                result.Add(stringToList.ToString());
                return;
            }
            if (stringToList.Length == 0)
            {
                stringToList.Append(root.val.ToString());
            }
            else
            {
                stringToList.Append("->" + root.val.ToString());
            }
            String copyStringToList = stringToList.ToString();
            if (root.left != null)
            {
                BacktrackingBinaryTreePaths(root.left, stringToList, result);
            }
            stringToList = new StringBuilder(copyStringToList);
            if (root.right != null)
            {
                BacktrackingBinaryTreePaths(root.right, stringToList, result);
            }
        }
    }
}
