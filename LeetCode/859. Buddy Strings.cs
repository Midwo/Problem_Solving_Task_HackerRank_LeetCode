using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_859
    {
        ////(859.) Buddy Strings (EASY)
        public bool BuddyStrings(string s, string goal)
        {
            int lengthS = s.Length;
            int lengthGoal = goal.Length;
            Dictionary<char, int> dictionaryS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryGoal = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryDiffS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryDiffGoal = new Dictionary<char, int>();

            if (lengthS != lengthGoal) 
            {
                return false;
            }

            for (int i = 0; i < lengthS; i++)
            {
                if (s[i] != goal[i])
                {
                    if (dictionaryDiffS.ContainsKey(s[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dictionaryDiffS.Add(s[i], 1);
                    }

                    if (dictionaryDiffGoal.ContainsKey(goal[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dictionaryDiffGoal.Add(goal[i], 1);
                    }
                    if (dictionaryDiffGoal.Count > 2 || dictionaryDiffS.Count > 2)
                    {
                        return false;
                    }
                }

                if (dictionaryS.ContainsKey(s[i]))
                {
                     dictionaryS[s[i]]++;
                }
                else
                {
                    dictionaryS.Add(s[i], 1);
                }

                if (dictionaryGoal.ContainsKey(goal[i]))
                {
                    dictionaryGoal[goal[i]]++;
                }
                else
                {
                    dictionaryGoal.Add(goal[i], 1);
                }
            }

            if (dictionaryDiffS.Count == 0)
            {
                foreach (var item in dictionaryS)
                {
                    if(item.Value > 1)
                    {
                        return true;
                    }
                }
                return false;
            }

            foreach (var item in dictionaryDiffS)
            {
                int value;
                dictionaryDiffGoal.TryGetValue(item.Key, out value);
                if (value != item.Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
