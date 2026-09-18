using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2196
    {
        ////(2196.) Create Binary Tree From Descriptions (MEDIUM)

        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            Dictionary<int, int> leftRootParentAndChild = new Dictionary<int, int>();
            Dictionary<int, int> rightRootParentAndChild = new Dictionary<int, int>();
            HashSet<int> hashSetParents = new HashSet<int>();
            HashSet<int> hashSetChilden = new HashSet<int>();

            foreach (var currItem in descriptions)
            {
                hashSetParents.Add(currItem[0]);
                hashSetChilden.Add(currItem[1]);

                if (currItem[2] == 1)
                {
                    leftRootParentAndChild.Add(currItem[0], currItem[1]);
                }
                else
                {
                    rightRootParentAndChild.Add(currItem[0], currItem[1]);
                }
            }

            int rootValue = -1;

            foreach (var currParent in hashSetParents)
            {
                if (!hashSetChilden.Contains(currParent))
                {
                    rootValue = currParent;
                }
            }

            //Console.WriteLine(rootValue);

            TreeNode root = new TreeNode(rootValue);
            BuildTreeNode(rootValue, root);

            void BuildTreeNode(int parentValue, TreeNode root)
            {
                if (leftRootParentAndChild.ContainsKey(parentValue))
                {
                    root.left = new TreeNode(leftRootParentAndChild[parentValue]);
                    BuildTreeNode(leftRootParentAndChild[parentValue], root.left);
                }
                if (rightRootParentAndChild.ContainsKey(parentValue))
                {
                    root.right = new TreeNode(rightRootParentAndChild[parentValue]);
                    BuildTreeNode(rightRootParentAndChild[parentValue], root.right);
                }
            }

            return root;
        }
    }
}
