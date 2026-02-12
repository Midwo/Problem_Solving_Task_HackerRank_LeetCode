using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_993
    {
        ////(993.) Cousins in Binary Tree (EASY)
        public bool IsCousins(TreeNode root, int x, int y)
        {
            List<string[]> depthAndUniqueCodeParrents = new List<string[]>();
            

            CheckRootForXY(x, y, root, depthAndUniqueCodeParrents, "S", 0);

            if (depthAndUniqueCodeParrents[0][0] == depthAndUniqueCodeParrents[1][0] && depthAndUniqueCodeParrents[0][1] != depthAndUniqueCodeParrents[1][1]) 
            {
                return true;
            }
            return false;
        }

        private void CheckRootForXY(int x, int y, TreeNode root, List<string[]> depthAndUniqueCodeParrents, String uniqueCode, int level)
        {
            if (root == null)
            {
                return;
            }
            if (root.val == x || root.val == y)
            {
                depthAndUniqueCodeParrents.Add(new string[] { level.ToString(), uniqueCode[0..(uniqueCode.Length-1)].ToString() });
            }

            string currUniqueCode = uniqueCode;
            string stringForY = uniqueCode;
            CheckRootForXY(x, y, root.left, depthAndUniqueCodeParrents, stringForY + "L", level + 1);
            
            CheckRootForXY(x, y, root.right, depthAndUniqueCodeParrents, currUniqueCode += "R", level + 1);
        }
    }
}
