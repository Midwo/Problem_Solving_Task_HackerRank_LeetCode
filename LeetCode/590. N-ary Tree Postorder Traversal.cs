using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_590
    {
        ////(590.) N-ary Tree Postorder Traversal (EASY)
        public IList<int> Postorder(Node root)
        {
            List<int> resultList = new List<int>();
            travelsal(root);

            void travelsal(Node root)
            {
                if (root == null) 
                {
                    return;
                }

                for (int i = 0; i < root.children.Count; i++)
                {
                    travelsal(root.children[i]);
                }

                resultList.Add(root.val);
            }

            return resultList;
        }
    }
}
