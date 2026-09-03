using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_654
    {
        ////(654.) Maximum Binary Tree (MEDIUM)
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructTree(nums, 0, nums.Length-1);

            TreeNode ConstructTree(int[] nums, int minIndex, int maxIndex)
            {
                if (minIndex > maxIndex)
                    return null;

                int maxValue = nums[minIndex];
                int maxValueIndex = minIndex;

                for (int currIndex = minIndex + 1; currIndex <= maxIndex; currIndex++)
                {
                    if (nums[currIndex] > maxValue)
                    {
                        maxValue = nums[currIndex];
                        maxValueIndex = currIndex;
                    }
                }

                TreeNode root = new TreeNode(maxValue);

                root.left = ConstructTree(nums, minIndex, maxValueIndex - 1);
                root.right = ConstructTree(nums, maxValueIndex + 1, maxIndex);

                return root;
            }
        }
    }
}
