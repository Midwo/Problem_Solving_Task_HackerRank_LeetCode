using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_535
    {
        ////(535.) Encode and Decode TinyURL (MEDIUM)
        public class Codec
        {
            private Dictionary<string, string> _dictionaryShortTinyUrl;

            public Codec()
            {
                _dictionaryShortTinyUrl = new Dictionary<string, string>();
            }
            public string encode(string longUrl)
            {
                var newGuid = Guid.NewGuid();
                string shortGuid = Convert.ToBase64String(newGuid.ToByteArray());

                while (_dictionaryShortTinyUrl.ContainsKey(shortGuid))
                {
                    newGuid = Guid.NewGuid();
                    shortGuid = Convert.ToBase64String(newGuid.ToByteArray());
                }

                _dictionaryShortTinyUrl.Add(shortGuid, longUrl);

                return "http://tinyurl.com/" + shortGuid + "";
            }

            public string decode(string shortUrl)
            {
                string temp = shortUrl.Substring(19, shortUrl.Length-19);
                //return "";
                return _dictionaryShortTinyUrl[temp];
            }
        }

    }
}
