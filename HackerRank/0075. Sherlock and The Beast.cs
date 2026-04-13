using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0075
    {
        ////75. Sherlock and The Beast (EASY)
        public void decentNumber(int n)
        {
            if (n < 3)
            {
                Console.WriteLine("-1");
                return;
            }
            if (n % 3 == 0)
            {
                Console.WriteLine(new string('5', n));
                return;
            }
            int howMany5 = (n / 3) - 1;
            int howMany3 = n - (howMany5 * 3);
            if (howMany3 % 5 != 0)
            {
                howMany3 = 0;
                while (howMany5 > 0)
                {
                    howMany5--;
                    howMany3 = n - (howMany5 * 3);
                    if (howMany3 % 5 == 0)
                        break;
                    howMany3 = 0;
                }
            }
            if (howMany5 <= 0 && howMany3 <= 0)
            {
                Console.WriteLine("-1");
                return;
            }
            Console.Write(new string('5', howMany5 * 3));
            Console.WriteLine(new string('3', howMany3));
        }
    }
}

