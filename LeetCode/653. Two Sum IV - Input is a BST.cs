using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_653
    {
        ////(653.) Two Sum IV - Input is a BST (EASY)
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> valuesInRoot = new HashSet<int>();

            bool CheckedValues(TreeNode root)
            {
                if (root == null)
                    return false;
               
                int currValue = root.val;

                if (valuesInRoot.Contains(k - currValue))
                {
                    return true;
                }

                valuesInRoot.Add(currValue);

                if (CheckedValues(root.left))
                    return true;
                if (CheckedValues(root.right))
                    return true;

                return false;
            }

            return CheckedValues(root);


            ////Solution 2
            //bool found = false;
            //HashSet<int> valuesInRoot = new HashSet<int>();

            //CheckedValues(root);

            //void CheckedValues(TreeNode root)
            //{
            //    if (root == null || found)
            //        return;

            //    int currValue = root.val;

            //    if (valuesInRoot.Contains(k - currValue))
            //    {
            //        found = true;
            //        return;
            //    }

            //    valuesInRoot.Add(currValue);

            //    CheckedValues(root.left);
            //    CheckedValues(root.right);
            //}

            //return found;
        }
    }
}
