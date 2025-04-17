using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_860
    {
        ////(860.) Lemonade Change (EASY)
        public bool LemonadeChange(int[] bills)
        {
            int[] cash = new int[3] { 0, 0, 0 };
            int countBills = bills.Length;

            for (int i = 0; i < countBills; i++)
            {
                if (bills[i] == 5)
                {
                    cash[0]++;
                }
                else if (bills[i] == 10)
                {
                    cash[1]++;
                    if (cash[0] > 0)
                    {
                        cash[0]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (cash[1] > 0 && cash[0] > 0)
                    {
                        cash[0] -= 1;
                        cash[1] -= 1;
                    }
                    else if (cash[0] > 2)
                    {
                        cash[0] -= 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
