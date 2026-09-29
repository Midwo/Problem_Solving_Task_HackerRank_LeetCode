using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_589
    {
        ////(589.) N-ary Tree Preorder Traversal (EASY)
        public IList<int> Preorder(Node root)
        {
            IList<int> result = new List<int>();
            GetValuesRoot(root);

            void GetValuesRoot(Node root)
            {
                if(root == null)
                    return;
                result.Add(root.val);

                foreach (Node child in root.children) 
                {
                    GetValuesRoot(child);
                }
            }

            return result;
        }
    }
}
