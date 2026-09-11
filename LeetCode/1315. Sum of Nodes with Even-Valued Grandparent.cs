using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1315
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            int sumEvenGrandParent = 0;

            checkTree(root, 0, 0, 1);

            void checkTree(TreeNode root, int fatherValue, int grandFatherValue, int level)
            {
                if (root == null) 
                    return;

                int currValue = root.val;
                
                //Console.WriteLine(currValue);
                if (level < 3)
                {
                    level++;
                }
                else if (grandFatherValue % 2 == 0)
                {
                    sumEvenGrandParent += currValue;
                }

                grandFatherValue = fatherValue;
                fatherValue = currValue;

                checkTree(root.left, fatherValue, grandFatherValue, level);
                checkTree(root.right, fatherValue, grandFatherValue, level);

            }
            return sumEvenGrandParent;
        }
    }
}
