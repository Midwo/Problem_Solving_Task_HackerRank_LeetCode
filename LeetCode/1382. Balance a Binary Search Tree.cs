using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1382
    {
        ////1382. Balance a Binary Search Tree (MEDIUM)     
        public TreeNode BalanceBST(TreeNode root)
        {
            List<int> allValues = new List<int>();

            CheckAllValues(root);

            void CheckAllValues(TreeNode root)
            {
                if(root == null)
                {
                    return;
                }

                CheckAllValues(root.left);
                allValues.Add(root.val);
                CheckAllValues(root.right);
            }

            TreeNode GenerateNewRoot(int min, int max)
            {
                if (min > max)
                {
                    return null;
                }

                int middle = min + (max - min) / 2;

                TreeNode resultRoot = new TreeNode(allValues[middle]);

                resultRoot.left = GenerateNewRoot(min, middle-1);
                resultRoot.right = GenerateNewRoot(middle+1, max);

                return resultRoot;
            }

            return GenerateNewRoot(0, allValues.Count - 1);
        }
    }
}
