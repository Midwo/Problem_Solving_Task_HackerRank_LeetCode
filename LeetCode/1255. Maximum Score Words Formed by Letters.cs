using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1255
    {
        ////(1255.) Maximum Score Words Formed by Letters (HARD)
        private int _maxScore;
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            _maxScore = 0;
            int[] freqletters = new int[26];
            int wordsLenght = words.Length;
            foreach (char letter in letters)
            {
                freqletters[letter - 'a']++;
            }

            BTMaxScoreSearch(words, score, 0, 0, freqletters, wordsLenght);

            return _maxScore;
        }

        private void BTMaxScoreSearch(string[] words, int[] score, int currScore, int indexWord, int[] countFreqWords, int wordsLength)
        {
            if(_maxScore < currScore)
                _maxScore = currScore;

            if(indexWord == wordsLength)
            {
                return;
            }

            BTMaxScoreSearch(words, score, currScore, indexWord + 1, countFreqWords, wordsLength);

            for (int index = indexWord; index < wordsLength; index++)
            {
                int addScore = 0;
                int[] tempFreq = new int[26];
                int tempScore = currScore;

                Array.Copy(countFreqWords, tempFreq, 26);
                bool status = true;
                int[] currFreq = new int[26];

                foreach (char currChar in words[index])
                {
                    tempFreq[currChar - 'a']--;
                    addScore += score[currChar - 'a'];
                    if (tempFreq[currChar - 'a'] < 0)
                    {
                        status = false;
                        break;
                    }
                }

                if (status)
                {
                    BTMaxScoreSearch(words, score, tempScore+addScore, indexWord + 1, tempFreq, wordsLength);
                }
            }
        }

    }
}
