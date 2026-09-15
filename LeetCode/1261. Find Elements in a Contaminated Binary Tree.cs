using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1261
    {
        ////(1261.) Find Elements in a Contaminated Binary Tree (MEDIUM)
        public class FindElements
        {
            private HashSet<int> _findedElements;
            public FindElements(TreeNode root)
            {
                _findedElements = new HashSet<int>();

                AddAllElements(root, 0);

                void AddAllElements (TreeNode root, int lastValue)
                {
                    if (root == null)
                    {
                        return;
                    }
                    _findedElements.Add(lastValue);

                    AddAllElements(root.left, 2 * lastValue + 1);
                    AddAllElements(root.right, 2 * lastValue + 2);
                } 
            }

            public bool Find(int target)
            {
                if (_findedElements.Contains(target))
                    return true;
                return false;
            }
        }
    }
}
