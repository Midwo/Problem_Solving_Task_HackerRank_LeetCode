using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_904
    {
        ////(904.) Fruit Into Baskets (MEDIUM)
        public int TotalFruit(int[] fruits)
        {
            int maxCount = 0;
            int firstFruit = int.MinValue;
            int firstFruitCount = 0;
            int firstFruitHowMuchWithoutABreak = 0;
            int secondFruit = int.MinValue;
            int secondFruitCount = 0;
            int secondFruitHowMuchWithoutABreak = 0;
            int lastValue = 0;

            bool firstValue = false;
            bool secondValue = false;


            for (int i = 0; i < fruits.Length; i++)
            {
                //Console.WriteLine(fruits[i]);
                if(firstValue && secondValue)
                {
                    if (fruits[i] == firstFruit || fruits[i] == secondFruit)
                    {
                        if(fruits[i] == firstFruit)
                        {
                            if(lastValue != firstFruit)
                            {
                                secondFruitHowMuchWithoutABreak = 0;
                                firstFruitHowMuchWithoutABreak = 1;
                                firstFruitCount++;
                                lastValue = fruits[i];
                            }
                            else
                            {
                                firstFruitHowMuchWithoutABreak++;
                                firstFruitCount++;
                            }
                        }
                        else
                        {
                            if (lastValue != secondFruit)
                            {
                                firstFruitHowMuchWithoutABreak = 0;
                                secondFruitHowMuchWithoutABreak = 1;
                                secondFruitCount++;
                                lastValue = fruits[i];
                            }
                            else
                            {
                                secondFruitHowMuchWithoutABreak++;
                                secondFruitCount++;
                            }
                        }
                    }
                    else
                    {
                        if(lastValue == firstFruit)
                        {
                            firstFruitCount = firstFruitHowMuchWithoutABreak;
                            firstFruitHowMuchWithoutABreak = 0;
                            lastValue = fruits[i];
                            secondFruit = lastValue;
                            secondFruitCount = 1;
                            secondFruitHowMuchWithoutABreak = 1;
                        }
                        else
                        {
                            firstFruit = secondFruit;
                            firstFruitCount = secondFruitHowMuchWithoutABreak;
                            firstFruitHowMuchWithoutABreak = 0;
                            lastValue = fruits[i];
                            secondFruit = lastValue;
                            secondFruitCount = 1;
                            secondFruitHowMuchWithoutABreak = 1;
                        }
                    }
                    maxCount = Math.Max(maxCount, firstFruitCount + secondFruitCount);
                }
                else
                {
                    if (!firstValue)
                    {
                        lastValue = fruits[i];
                        firstValue = true;
                        firstFruitCount = 1;
                        firstFruitHowMuchWithoutABreak++;
                        firstFruit = lastValue;
                    }
                    else
                    {
                        if (firstFruit == fruits[i])
                        {
                            firstFruitCount++;
                            firstFruitHowMuchWithoutABreak++;
                        }
                        else
                        {
                            lastValue = fruits[i];
                            secondFruit = lastValue;
                            secondFruitCount = 1;
                            secondFruitHowMuchWithoutABreak = 1;
                            firstFruitHowMuchWithoutABreak = 0;
                            secondValue = true;
                        }
                    }
                    maxCount = Math.Max(maxCount, firstFruitCount + secondFruitCount);
                }
            }

            return maxCount;
        }
    }
}
