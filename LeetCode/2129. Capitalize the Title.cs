using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2129
    {
        ////(2129.) Capitalize the Title (EASY)
        public string CapitalizeTitle(string title)
        {
            List<string> splitList = title.Split(' ').ToList();

            for (int i = 0; i < splitList.Count; i++)
            {
                char[] currString = splitList[i].ToCharArray();

                if (currString.Length > 2)
                {
                    bool nextCharCapitalize = true;
                    for (int j = 0; j < currString.Length; j++)
                    {
                        char currchar = currString[j];
                        if (nextCharCapitalize)
                        {
                            if (currchar > 'Z')
                            {
                                currString[j] = ((char)((int)currchar - 32));
                            }
                            else
                            {
                                currString[j] = currchar;
                            }
                            nextCharCapitalize = false;
                        }
                        else if (currchar != ' ')
                        {
                            if (currchar > 'Z')
                            {
                                currString[j] = currchar;
                            }
                            else
                            {
                                currString[j] = (char)((int)currchar + 32);
                            }
                        }
                        else
                        {
                            currString[j] = currchar;
                            nextCharCapitalize = true;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < currString.Length; j++)
                    {
                        char currchar = currString[j];
                        if (currchar > 'Z')
                        {
                            currString[j] = currchar;
                        }
                        else
                        {
                            currString[j] = (char)((int)currchar + 32);
                        }
                    }
                }

                splitList[i] = new string (currString);
            }

            return string.Join(' ', splitList);
        }
    }
}
