using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2438
    {
        ////(2438.) Range Product Queries of Powers (MEDIUM)
        public int[] ProductQueries(int n, int[][] queries)
        {
            int M = 1000000007;
            string binaryValueN = Convert.ToString(n, 2);
            int[] listPower2 = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384,
                                                        32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608,
                                                        16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
            List<int> listActivePowers = new List<int>();
            int lenght = binaryValueN.Length;
            int indexBinaryValueN = 0;

            for (int i = binaryValueN.Length-1; i >= 0; i--)
            {
                if (binaryValueN[i] == '1')
                {
                    listActivePowers.Add(listPower2[indexBinaryValueN]);
                }
                indexBinaryValueN++;
            }

            int[] result = new int[queries.Length];

            for(int i = 0; i < queries.Length; i++)
            {
                long temp = 1;

                for(int j = queries[i][0]; j <= queries[i][1]; j++)
                {
                    temp = (temp*listActivePowers[j]) % M;
                }
                result[i] = (int)temp;
            }


            return result;
        }
    }
}
