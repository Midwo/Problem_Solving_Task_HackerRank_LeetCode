using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1233
    {
        ////(1233.) Remove Sub-Folders from the Filesystem (MEDIUM)
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);
            IList<string> result = new List<string>();
            string currText = string.Empty;
            bool add = true;

            foreach (string item in folder)
            {
                var temp = item.Split('/');
                add = true;
                currText = string.Empty;
                for (int i = 1; i < temp.Length; i++)
                {
                    currText += "/" + temp[i];
                    if (result.Contains(currText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
