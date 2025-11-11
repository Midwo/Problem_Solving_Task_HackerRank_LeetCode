using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1436
    {
        ////(1436.) Destination City (EASY)
        public string DestCity(IList<IList<string>> paths)
        {
            ////Solution #1
            ////1ms, Beats: 94.85%
            
            HashSet<string> locationFirst = new HashSet<string>();

            foreach (var path in paths) 
            {
                locationFirst.Add(path[0]);         
            }

            foreach (var path in paths) 
            {
                if (!locationFirst.Contains(path[1]))
                {
                    return path[1];
                }
            }

            return "";

            ////Solution #2
            ////8ms, Beats: 5.15%

            //string result = string.Empty;
            //int countList = paths.Count;

            //for (int i = 0; i < countList; i++)
            //{
            //    bool status = false;
            //    string temp = paths[i][1];

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (paths[j][0] == temp)
            //        {
            //            status = true;
            //            break;
            //        }
            //    }
            //    if (status == false)
            //    {
            //        for (int k = i + 1; k < countList; k++)
            //        {
            //            if (paths[k][0] == temp)
            //            {
            //                status = true;
            //                break;
            //            }
            //        }
            //    }
            //    if (!status)
            //    {
            //        return temp;
            //    }
            //}

            //return result;
        }
    }
}
