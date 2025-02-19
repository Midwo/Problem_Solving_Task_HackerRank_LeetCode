using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_461
    {
        ////(461.) Hamming Distance (EASY)
        public int HammingDistance(int x, int y)
        {
            string stringX = Convert.ToString(x, 2);
            string stringY = Convert.ToString(y, 2);

            int lengthX = stringX.Length;
            int lengthY = stringY.Length;
            int HammingDistance = 0;
            int indexIfValue = 0;

            if (x > y)
            {
                for (int i = 0; i < lengthX; i++)
                {
                    if (lengthX - i <= lengthY)
                    {
                        if (stringX[i] != stringY[indexIfValue])
                        {
                            HammingDistance++;
                        }
                        indexIfValue++;
                    }
                    else
                    {
                        if (stringX[i] == '1')
                        {
                            HammingDistance++;
                        }
                    }
                }
            }
            else if (y > x)
            {
                for (int i = 0; i < lengthY; i++)
                {
                    if (lengthY - i <= lengthX)
                    {
                        if (stringY[i] != stringX[indexIfValue])
                        {
                            HammingDistance++;
                        }
                        indexIfValue++;
                    }
                    else
                    {
                        if (stringY[i] == '1')
                        {
                            HammingDistance++;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
            return HammingDistance;
        }
    }
}
