using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2325
    {
        ////(2325.) Decode the Message (EASY) 
        public string DecodeMessage(string key, string message)
        {
            int indexAlphabet = 1;
            int[] intSwitch = new int[26];

            for (int i = 0; i < key.Length; i++) 
            {
                //Console.WriteLine(key[i] - 'a');
                if (key[i] != ' ' && intSwitch[key[i] - 'a'] == 0)
                {
                    intSwitch[key[i] - 'a'] = indexAlphabet;
                    indexAlphabet++;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {

                if (message[i] != ' ')
                {
                    //Console.WriteLine(message[i]);
                    //Console.WriteLine(message[i] - 'a');
                    //Console.WriteLine(intSwitch[message[i] - 'a']);
                    //char temp = (char)('a'+19);
                    //Console.WriteLine(temp);
                    //Console.WriteLine((char)('a' + intSwitch[message[i] - 'a']-1));
                    sb.Append((char)('a' + intSwitch[message[i] - 'a'] - 1));
                }
                else
                {
                    sb.Append(' ');
                }

            }


            return new string (sb.ToString());
        }
    }
}
