using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_559
    {
        ////(559.) Maximum Depth of N-ary Tree (EASY)
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int resultDepth = 0;

            foreach (var item in root.children)
            {
                resultDepth = Math.Max(resultDepth, MaxDepth(item));
            }

            return resultDepth + 1;
        }
    }
}
