namespace ProblemSolving
{
    internal class LeetCodeAll
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] printOutput = [0];
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        printOutput = [i, j];
                        break;
                    }
                }
            }
            return printOutput;
        }
        public bool IsPalindrome(int x)
        {
            bool ToSame = false;
            if (x < 0)
            {
                ToSame = false;
            }
            else
            {
                long x1 = long.Parse(new string(x.ToString().Reverse().ToArray()));
                if (x1 == x)
                {
                    ToSame = true;
                }
            }
            return ToSame;
        }
        public int RomanToInt(string s)
        {
            int howMany = 0;

            Dictionary<char, int> dictionaryRoman = new Dictionary<char, int>()
            {
                {'I',1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000}
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (dictionaryRoman[s[i]] >= dictionaryRoman[s[i + 1]])
                    {
                        howMany += dictionaryRoman[s[i]];
                    }
                    else
                    {
                        howMany -= dictionaryRoman[s[i]];
                    }
                }
                else
                {
                    howMany += dictionaryRoman[s[i]];
                }
            }
            return howMany;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            int minChar = strs.Min(s => s.Length);
            string[] x = strs.OrderBy(s => s).ToArray();
            string firstString = x[0];
            string lastString = x[x.Length - 1];
            string outPutString = "";
            for (int i = 0; i < minChar; i++)
            {
                if (firstString[i] == lastString[i])
                {
                    outPutString += firstString[i];
                }
                else
                {
                    break;
                }
            }
            return outPutString;
        }
    }
}
