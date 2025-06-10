using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_97
    {
        ////(97.) Interleaving String (MEDIUM)
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int lengthS1 = s1.Length;
            int lengthS2 = s2.Length;

            if (lengthS1 + lengthS2 != s3.Length)
            {
                return false;
            }

            bool[] dp = new bool[lengthS2 + 1];

            for (int i = 0; i <= lengthS1; i++)
            {
                for (int j = 0; j <= lengthS2; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[j] = true;
                    }
                    else if (i == 0)
                    {
                        //Console.WriteLine("dp[j-1]: " + dp[j-1] +"");
                        //Console.WriteLine("s3[j - 1] == s2[j - 1]: " + s3[j - 1] + " and : " +s2[j - 1] +" ");
                        //if (s3[j - 1] == s2[j - 1])
                        //{
                        //    Console.WriteLine("s3[j - 1] == s2[j - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[j - 1] == s2[j - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j - 1] && s3[j - 1] == s2[j - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                    else if (j == 0)
                    {
                        //Console.WriteLine("dp[j]: " + dp[j] + "");
                        //Console.WriteLine("s3[i - 1] == s1[i - 1]: " + s3[i - 1] + " and : " + s1[i - 1] + " ");
                        //if (s3[i - 1] == s1[i - 1])
                        //{
                        //    Console.WriteLine("s3[i - 1] == s1[i - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[i - 1] == s1[i - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j] && s3[i - 1] == s1[i - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                    else
                    {
                        //Console.WriteLine("");
                        //Console.WriteLine("dp[j]: " + dp[j] + "");
                        //Console.WriteLine("s3[i + j - 1] == s1[i - 1]: " + s3[j + i - 1] + " and : " + s1[i - 1] + " ");
                        //if (s3[j + i - 1] == s1[i - 1])
                        //{
                        //    Console.WriteLine("s3[i + j - 1] == s1[i - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3i + j - 1] == s1[i - 1]: False");
                        //}
                        //Console.WriteLine("and");
                        //Console.WriteLine("dp[j-1]: " + dp[j - 1] + "");
                        //Console.WriteLine("s3[j + i - 1] == s2[j - 1]: " + s3[j + i - 1] + " and : " + s2[j - 1] + " ");
                        //if (s3[j + i - 1] == s2[j - 1])
                        //{
                        //    Console.WriteLine("s3[j + i - 1] == s2[j - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[j + i - 1] == s2[j - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j] && s3[i + j - 1] == s1[i - 1] || dp[j - 1] && s3[j + i - 1] == s2[j - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                }
            }

            return dp[lengthS2];
        }

        //// Option 2 - recursive, too slow.
        #region Option 2 - code 
        //private bool statusOk;
        //private int lengthS1;
        //private int lengthS2;
        //private int lengthS3;
        //private string _s3;
        //private string _s2;
        //private string _s1;
        //public bool IsInterleave(string s1, string s2, string s3)
        //{
        //    statusOk = false;
        //    lengthS3 = s3.Length;
        //    lengthS2 = s2.Length;
        //    lengthS1 = s1.Length;
        //    _s3 = s3;
        //    _s2 = s2;
        //    _s1 = s1;

        //    if (lengthS2+lengthS1 != lengthS3)
        //    {
        //        return false;
        //    }

        //    int indexS1 = 0;
        //    int indexS2 = 0;

        //    for (int i = 0; i < lengthS3; i++)
        //    {
        //        //Console.WriteLine(s1[indexS1]);
        //        //Console.WriteLine(s2[indexS2]);
        //        //Console.WriteLine(s3[i]);
        //        if (indexS1 < lengthS1 && s3[i] == s1[indexS1])
        //        {
        //            if (indexS2 < lengthS2)
        //            {
        //                if (s3[i] == s2[indexS2])
        //                {
        //                    CheckRecursiveInDP(indexS1+1, indexS2, i+1);
        //                    if (statusOk)
        //                    {
        //                        return true;
        //                    }
        //                    CheckRecursiveInDP(indexS1, indexS2+1, i+1);
        //                    if (statusOk)
        //                    {
        //                        return true;
        //                    }
        //                    break;
        //                }
        //                else
        //                {
        //                    if (_s3[i] == s1[indexS1])
        //                    {
        //                        indexS1++;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (_s3[i] == s1[indexS1])
        //                {
        //                    indexS1++;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        else if (indexS2 < lengthS2)
        //        {
        //            if (s3[i] == s2[indexS2])
        //            {
        //                indexS2++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        else if (statusOk)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //        if (i == lengthS3 - 1)
        //        {
        //            statusOk = true;
        //        }
        //    }

        //    if (statusOk)
        //    {
        //        return true;
        //    }
        //    else if (lengthS1 == 0 && lengthS2 == 0 && lengthS3 == 0) 
        //    {
        //        return true;
        //    }

        //    return false;
        //}


        //private void CheckRecursiveInDP(int indexS1, int indexS2, int indexS3)
        //{
        //    for (int i = indexS3; i < lengthS3; i++)
        //    {
        //        //Console.WriteLine("new");
        //        // Console.WriteLine(_s1[indexS1]);
        //        //Console.WriteLine(_s2[indexS2]);
        //        //Console.WriteLine(_s3[i]);
        //        if (indexS1 < lengthS1 && _s3[i] == _s1[indexS1])
        //        {
        //            if (indexS2 < lengthS2)
        //            {
        //                if (_s3[i] == _s2[indexS2])
        //                {
        //                    CheckRecursiveInDP(indexS1+1, indexS2, i + 1);
        //                    if (statusOk)
        //                    {
        //                        return;
        //                    }
        //                    CheckRecursiveInDP(indexS1, indexS2+1, i + 1);
        //                    if (statusOk) 
        //                    {
        //                        return;
        //                    }
        //                }
        //                else
        //                {
        //                    if (_s3[i] == _s1[indexS1])
        //                    {
        //                        indexS1++;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (_s3[i] == _s1[indexS1])
        //                {
        //                    indexS1++;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        else if (indexS2 < lengthS2)
        //        {
        //            if (_s3[i] == _s2[indexS2])
        //            {
        //                indexS2++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //        if (statusOk)
        //        {
        //            return;
        //        }
        //        if (i == lengthS3 - 1)
        //        {
        //            statusOk = true;
        //            return;
        //        }
        //    }
        //}
        #endregion
    }
}
