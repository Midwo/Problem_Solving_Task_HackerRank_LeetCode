using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1733
    {
        ////(1733.) Minimum Number of People to Teach (MEDIUM);
        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {
            HashSet<int> whoCannotSpeak = new HashSet<int>();

            foreach (var recordFromFriendShips in friendships)
            {
                HashSet<int> availableLanguages = new HashSet<int>();
                bool boolCanCommunicate = false;

                foreach (var item in languages[recordFromFriendShips[0]-1])
                {
                    availableLanguages.Add(item);
                }

                foreach(var item in languages[recordFromFriendShips[1] - 1])
                {
                    if (availableLanguages.Contains(item))
                    {
                        boolCanCommunicate |= true;
                        break;
                    }
                }

                if (!boolCanCommunicate)
                {
                    whoCannotSpeak.Add(recordFromFriendShips[0] - 1);
                    whoCannotSpeak.Add(recordFromFriendShips[1] - 1);
                }
            }

            int[] languagePopularityTable = new int[n+1];
            int howManyKnowMostPopularityLanguage = 0;

            foreach (var numberPerson in whoCannotSpeak) 
            {
                foreach (var language in languages[numberPerson])
                {
                    languagePopularityTable[language]++;
                    howManyKnowMostPopularityLanguage = Math.Max(howManyKnowMostPopularityLanguage, languagePopularityTable[language]);
                }
            }

            return whoCannotSpeak.Count - howManyKnowMostPopularityLanguage; 
        }
    }
}
