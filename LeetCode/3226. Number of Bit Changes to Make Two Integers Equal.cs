using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3226
    {
        ////(3226.) Number of Bit Changes to Make Two Integers Equal (EASY)
        public int MinChanges(int n, int k)
        {
            string binaryN = Convert.ToString(n, 2);
            string binaryK = Convert.ToString(k, 2);
            int countChanges = 0;
            int lastIndexN = binaryN.Length - 1;
            int lastIndexK = binaryK.Length - 1;

            if (lastIndexN >= lastIndexK)
            {
                while (lastIndexN > -1)
                {
                    bool isValueOnBitN = binaryN[lastIndexN] == '1' ? true : false;

                    if (lastIndexK > -1)
                    {
                        bool isValueOnBitK = binaryK[lastIndexK] == '1' ? true : false;

                        if (isValueOnBitK && !isValueOnBitN)
                        {
                            return -1;
                        }
                        else if (!isValueOnBitK && isValueOnBitN)
                        {
                            countChanges++;
                        }
                        lastIndexK--;
                    }
                    else if (isValueOnBitN)
                    {
                        countChanges++;
                    }
                    lastIndexN--;
                }
            }
            else
            {
                return -1;
            }

            return countChanges;
        }

    }
}
