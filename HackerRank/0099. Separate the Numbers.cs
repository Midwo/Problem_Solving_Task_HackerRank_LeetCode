using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0099
    {
        ////99. Funny String (EASY)
        public void separateNumbers(string s)
        {
            string textOutput = "NO";
            if (s.Length > 1)
            {
                var sequenceStart = string.Empty;

                for (int i = 0; i < s.Length / 2; i++)
                {
                    sequenceStart += s[i];
                    var num = long.Parse(sequenceStart);
                    var sequence = string.Empty;

                    while (s.Length > sequence.Length)
                    {
                        if (!s.StartsWith(sequence)) break;

                        sequence += num;
                        ++num;
                    }

                    if (s.StartsWith(sequence))
                    {
                        textOutput = $"YES {sequenceStart}";
                    }

                    if (s.Length == sequence.Length) break;
                }
            }
            Console.WriteLine(textOutput);
        }
    }
}
