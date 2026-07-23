using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1276
    {
        ////(1276.) Number of Burgers with No Waste of Ingredients (MEDIUM)
        public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices)
        {
            IList<int> result = new List<int>();

            if (tomatoSlices % 2 == 1)
                return result;

            int sumTomatoSlicesWhenOnlySmallBurger = cheeseSlices * 2;

            if(sumTomatoSlicesWhenOnlySmallBurger > tomatoSlices)
                return result;

            if (sumTomatoSlicesWhenOnlySmallBurger < tomatoSlices && (sumTomatoSlicesWhenOnlySmallBurger + sumTomatoSlicesWhenOnlySmallBurger) < tomatoSlices)
                return result;

            int diffTomatoSlices = tomatoSlices - sumTomatoSlicesWhenOnlySmallBurger;
            int howManyJumbo = diffTomatoSlices / 2;

            result.Add(howManyJumbo);
            result.Add(cheeseSlices - howManyJumbo);

            return result;
        }
    }
}
