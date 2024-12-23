using System.Numerics;

namespace ProblemSolving
{
    internal class Basic_Task
    {
        public string catAndMouse(int x, int y, int z)
        {
            int CatA = Math.Abs(z - x);
            int CatB = Math.Abs(z - y);

            if (CatA == CatB)
            {
                return "Mouse C";
            }
            else if (CatA < CatB)
            {
                return "Cat A";
            }
            else
            {
                return "Cat B";
            }
        }

        public int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = ar[i] + ar[j];
                    if (sum % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int houseAplle = 0;
            int houseOranges = 0;

            foreach (var i in apples)
            {
                if ((a + i) >= s && (a + i) <= t)
                {
                    houseAplle++;
                }
            }
            foreach (var i in oranges)
            {
                if ((b + i) <= t && (b + i) >= s)
                {
                    houseOranges++;
                }
            }
            Console.WriteLine(houseAplle);
            Console.WriteLine(houseOranges);
        }

        public List<int> gradingStudents(List<int> grades)
        {
            List<int> ListGrading = new List<int>();

            foreach (int i in grades)
            {
                if (i < 38)
                {
                    ListGrading.Add(i);
                }
                else
                {
                    double x1;
                    x1 = i / 5;
                    int z1 = (int)x1;
                    int y1 = i % 5;
                    // ListGrading.Add(z1);
                    // ListGrading.Add(y1);
                    if (y1 >= 3)
                    {
                        ListGrading.Add((z1 + 1) * 5);
                    }
                    else
                    {
                        ListGrading.Add(i);
                    }
                }
            }
            return ListGrading;
        }

        public string Happy_ladybugs(string b)
        {
            //b = "RBY_YBR";
            Dictionary<int, int> dictionaryString = new Dictionary<int, int>();
            int howManyChar95 = 0;
            int howManyOtherChar = 0;
            int howLongString = b.Length;
            char firstChar = b[0];
            char nextChar = b[0];
            int twoWrongValues = 0;

            foreach (char s in b)
            {
                if (s != 95)
                {
                    howManyOtherChar++;
                    if (dictionaryString.ContainsKey(s))
                    {
                        dictionaryString[s]++;
                    }
                    else
                    {
                        dictionaryString.Add(s, 1);
                    }
                }
                else
                {
                    howManyChar95++;
                }
            }

            if (dictionaryString.ContainsValue(1))
            {
                return "NO";
            }
            else
            {
                if (howManyChar95 > 0)
                {
                    return "YES";
                }
                else
                {
                    for (int i = 1; i < b.Length; i++)
                    {
                        nextChar = b[i];
                        if (firstChar == nextChar)
                        {
                            firstChar = b[i];
                            twoWrongValues = 0;
                        }
                        else
                        {
                            firstChar = b[i];
                            twoWrongValues++;
                            if (twoWrongValues >= 2)
                            {
                                return "NO";
                            }
                        }
                    }
                    if (twoWrongValues < 2)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
        }

        public List<string> Cavity_Map(List<string> grid)
        {
            //grid = ["1112", "1912", "1892", "1234"];
            int lenghtStringInGrid = grid[0].Length;
            int countGridMinusOne = grid.Count - 1;
            List<string> newGrid = new List<string>();
            newGrid = grid.ToList();

            for (int i = 1; i < lenghtStringInGrid - 1; i++)
            {
                for (int x = 1; x < countGridMinusOne; x++)
                {
                    int actualRecordValue = Int32.Parse(grid[x][i].ToString());
                    if (actualRecordValue > Int32.Parse(grid[x - 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x + 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i - 1].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i + 1].ToString()))
                    {
                        newGrid[x] = newGrid[x].Substring(0, i) + "X" + newGrid[x].Substring(i + 1);
                    }
                }
            }
            return newGrid;
        }

        public string kaprekarNumbers(int p, int q)
        {
            //p = 1;
            //q = 100;
            string outPrint = string.Empty;

            for (int i = p; i <= q; i++)
            {
                var square = Math.Pow(i, 2);
                var howLongSquareNumber = square.ToString().Length;
                var howLongLoopNumber = i.ToString().Length;
                int leftValue = 0;
                int rightValue = 0;

                if (howLongSquareNumber > 1)
                {
                    int digitsForLeft = howLongSquareNumber - howLongLoopNumber;
                    leftValue = Convert.ToInt32(square.ToString().Substring(0, digitsForLeft));
                    rightValue = Convert.ToInt32(square.ToString().Substring(digitsForLeft));
                }
                else
                {
                    rightValue = (int)square;
                }
                if (leftValue + rightValue == i)
                {
                    outPrint += i + " ";
                }
            }
            return outPrint.Length > 0 ? outPrint.TrimEnd() : "INVALID RANGE";
        }

        public List<int> acmTeam(List<string> topic)
        {
            //topic = ["10101", "11100", "11010", "00101"];
            int countPermutationMaxTask = 0;
            int maxTaskDoneValueLoop = 0;
            int maxTaskDoneValue = 0;
            int howManyTask = topic[0].Length;
            int howManyTeams = topic.Count();
            for (int i = 0; i < howManyTeams - 1; i++)
            {
                for (int x = i + 1; x < howManyTeams; x++)
                {
                    maxTaskDoneValueLoop = 0;
                    for (int y = 0; y < howManyTask; y++)
                    {
                        if ((topic[i][y].ToString() == "1") || (topic[x][y].ToString() == "1"))
                        {
                            maxTaskDoneValueLoop++;
                        }
                    }
                    if (maxTaskDoneValueLoop > maxTaskDoneValue)
                    {
                        countPermutationMaxTask = 1;
                        maxTaskDoneValue = maxTaskDoneValueLoop;
                    }
                    else if (maxTaskDoneValueLoop == maxTaskDoneValue)
                    {
                        countPermutationMaxTask++;
                        maxTaskDoneValue = maxTaskDoneValueLoop;
                    }
                }
            }
            List<int> newPrintList = new List<int>();
            newPrintList.Add(maxTaskDoneValue);
            newPrintList.Add(countPermutationMaxTask);
            return newPrintList;
        }

        public string fairRations(List<int> B)
        {
            int howManyRations = 0;
            bool failRations = false;
            for (int i = 0; i < B.Count; i++)
            {
                // Console.WriteLine(B[i]);
                if ((B[B.Count - 1] % 2 != 0) && (i == B.Count - 1))
                {
                    failRations = true;
                    break;
                }
                else if (B[i] % 2 != 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    howManyRations += 2;
                }
            }
            return failRations == true ? "NO" : howManyRations.ToString();
        }

        public string encryption(string s)
        {
            int howLong = s.Length;
            double doubleSqrtValue = Math.Sqrt(howLong);
            int ceilingSqrtValue = (int)Math.Ceiling(doubleSqrtValue);
            int floorSqrtValue = (int)Math.Floor(doubleSqrtValue);
            if (ceilingSqrtValue * floorSqrtValue < howLong)
            {
                floorSqrtValue = ceilingSqrtValue;
            }
            List<string> listEncryption = new List<string>();
            for (int i = 0; i < floorSqrtValue; i++)
            {
                if (i == floorSqrtValue - 1)
                {
                    listEncryption.Add(s.Substring(i * ceilingSqrtValue));
                }
                else
                {
                    listEncryption.Add(s.Substring(i * ceilingSqrtValue, ceilingSqrtValue));
                }
            }
            int howManyLenghtLastRow = listEncryption[floorSqrtValue - 1].Length;
            string newOutput = string.Empty;
            for (int i = 0; i < ceilingSqrtValue; i++)
            {
                for (int x = 0; x < floorSqrtValue; x++)
                {
                    if (i < howManyLenghtLastRow)
                    {
                        newOutput += listEncryption[x][i];
                    }
                    else if (x < floorSqrtValue - 1)
                    {
                        newOutput += listEncryption[x][i];
                    }
                }
                newOutput += " ";
            }
            return newOutput.Trim();
        }

        public int alternate(string s)
        {
            int lenghtString = s.Length;
            List<string> allCharsFromString = new List<string>();
            List<string> listStringFromChar = new List<string>();
            int howLongMax = 0;
            foreach (char item in s)
            {
                if (!allCharsFromString.Contains(item.ToString()))
                {
                    allCharsFromString.Add(item.ToString());
                }
            }
            allCharsFromString.Sort();
            for (int i = 0; i < allCharsFromString.Count; i++)
            {
                for (int j = i + 1; j < allCharsFromString.Count; j++)
                {
                    listStringFromChar.Add(allCharsFromString[i].ToString() + allCharsFromString[j].ToString());
                }
            }
            foreach (var item in listStringFromChar)
            {
                string x = string.Empty;
                foreach (var charS in s)
                {
                    if (charS == item[0] || charS == item[1])
                    {
                        x += charS;
                    }
                }
                char lastChar = x[0];
                for (int k = 1; k < x.Length; k++)
                {
                    if (lastChar == x[k])
                    {
                        x = "";
                        break;
                    }
                    else
                    {
                        lastChar = x[k];
                    }
                }
                if (x.Length > 0 && x.Length > howLongMax)
                {
                    howLongMax = x.Length;
                }
            }
            return howLongMax;
        }

        public int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int maxDistanceFromStation = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                maxDistanceFromStation = Math.Max(maxDistanceFromStation, distance);
            }
            return Math.Max(maxDistanceFromStation, n - 1 - c[c.Length - 1]);
        }

        public List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> outputList = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] + arr[j] == m)
                    {
                        outputList.Add(i + 1);
                        outputList.Add(j + 1);
                        break;
                    }
                }
            }
            return outputList;
        }

        public List<string> weightedUniformStrings(string s, List<int> queries)
        {
            Dictionary<char, int> dataCharTable = new Dictionary<char, int>(){
                { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 },
                { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 }, { 'p', 16}, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 },
                { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 }};
            List<int> listValueFromString = new();
            int setWeight = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    //setWeight += s[i] - 96;
                    setWeight += dataCharTable[s[i]];
                    listValueFromString.Add(setWeight);
                }
                else
                {
                    listValueFromString.Add(setWeight + dataCharTable[s[i]]);
                    setWeight = 0;
                }
            }
            List<string> outputPrintList = new();
            for (int i = 0; i < queries.Count; i++)
            {
                if (listValueFromString.Contains(queries[i]))
                {
                    outputPrintList.Add("Yes");
                }
                else
                {
                    outputPrintList.Add("No");
                }
            }
            return outputPrintList;
        }

        public string pokerNim(int k, List<int> c)
        {
            var xor = c[0];
            for (var i = 1; i < c.Count; ++i)
            {
                xor ^= c[i];
            }
            return xor != 0 ? "First" : "Second";
        }

        public string nimGame(List<int> pile)
        {
            var xor = pile[0];
            for (var i = 1; i < pile.Count; ++i)
            {
                xor ^= pile[i];
            }
            return xor != 0 ? "First" : "Second";
        }

        public string superReducedString(string s)
        {
            bool endLoop = false;
            do
            {
                endLoop = true;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        if (i == 0)
                        {
                            s = s.Substring(i + 2);
                        }
                        else
                        {
                            s = s.Substring(0, i) + s.Substring(i + 2);
                        }
                        endLoop = false;
                        break;
                    }

                }

            } while (!endLoop);
            return s.Length == 0 ? "Empty String" : s;
        }

        public string superReducedString1(string s)
        {
            Stack<char> myStack = new Stack<char>();

            foreach (char c in s)
            {
                if (myStack.Count == 0)
                    myStack.Push(c);
                else
                {
                    if (c == myStack.Peek())
                        myStack.Pop();
                    else
                        myStack.Push(c);
                }
            }

            string myString = String.Join("", myStack.Reverse());

            return String.IsNullOrEmpty(myString) ? "Empty String" : myString;
        }

        public int beautifulPairs(List<int> A, List<int> B)
        {
            int pairs = 0;
            int countA = A.Count;
            for (int i = 0; i < A.Count; i++)
            {
                for (int y = 0; y < B.Count; y++)
                {
                    if (A[i] == B[y])
                    {
                        pairs++;
                        A.RemoveAt(i);
                        B.RemoveAt(y);
                        i = -1;
                        break;
                    }
                }
            }
            if (pairs != countA)
            {
                pairs++;
            }
            else
            {
                pairs--;
            }
            return pairs;
        }

        public string timeInWords(int h, int m)
        {
            string outputPrint = string.Empty;
            Dictionary<int, string> numbersTime = new Dictionary<int, string>
        {
            { 0, "o' clock" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"},
            { 5, "five"}, { 6, "six"}, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
            {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"},
            {15, "quarter"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"},
            {19, "nineteen"}, {20, "twenty"}, {21, "twenty one"}, {22, "twenty two"},
            {23, "twenty three"}, {24, "twenty four"}, {25, "twenty five"}, {26, "twenty six"},
            {27, "twenty seven"}, {28, "twenty eight"}, {29, "twenty nine"}, {30, "half"}
        };
            switch (m)
            {
                case 0:
                    outputPrint = numbersTime[h] + " " + numbersTime[0];
                    break;
                case 15:
                    outputPrint = numbersTime[m] + " past " + numbersTime[h];
                    break;
                case 30:
                    outputPrint = numbersTime[m] + " past " + numbersTime[h];
                    break;
                case 45:
                    outputPrint = numbersTime[60 - m] + " to " + numbersTime[h + 1];
                    break;
                case <= 10:
                    outputPrint = numbersTime[m] + " minute past " + numbersTime[h];
                    break;
                case <= 30:
                    outputPrint = numbersTime[m] + " minutes past " + numbersTime[h];
                    break;
                case > 30:
                    outputPrint = numbersTime[60 - m] + " minutes to " + numbersTime[h + 1];
                    break;
            }
            return outputPrint;
        }

        public int getMinimumCost(int k, int[] c)
        {

            int howManyFlowers = c.Count();
            Array.Sort(c);
            int cost = 0;
            int multipleCost = 1;
            int couterForMultipleCost = 0;
            if (howManyFlowers <= k)
            {
                //cost = c.Sum();
                return c.Sum();
            }
            else
            {
                do
                {
                    couterForMultipleCost++;
                    if (couterForMultipleCost > k)
                    {
                        couterForMultipleCost = 1;
                        multipleCost++;
                    }
                    cost += multipleCost * c[howManyFlowers - 1];
                    howManyFlowers -= 1;
                } while (howManyFlowers != 0);
            }
            return cost;
        }
      
        public void extraLongFactorials(int n)
        {
            BigInteger x = 1;
            for (int i = n; i > 1; i--)
            {
                x = x * (BigInteger)i;
            }
            Console.WriteLine(x);
        }

        public int powerSum(int X, int N)
        {
            return recursive(X, N, 1);
        }

        private int recursive(int total, int power, int num)
        {
            int val = Convert.ToInt32(total - Math.Pow(num, power));

            if (val == 0) return 1;
            if (val < 0) return 0;

            return recursive(val, power, num + 1) + recursive(total, power, num + 1);
        }

        public int maxMin(int k, List<int> arr)
        {
            k--;
            arr.Sort();
            int minValue = int.MaxValue;
            int actualValue = 0;
            for (int i = 0; i < arr.Count - k; i++)
            {
                actualValue = arr[i + k] - arr[i];
                if (actualValue < minValue)
                {
                    minValue = actualValue;
                }
            }
            return minValue;
        }

        public string biggerIsGreater(string w)
        {
            int lenghtString = w.Length;
            int index = -1;

            for (int i = lenghtString - 2; i >= 0; i--)
            {
                if (w[i] < w[i + 1])
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                // Console.WriteLine("no answer");
                return "no answer";
            }

            string rightCutString = w.Substring(index + 1);
            for (int i = rightCutString.Length - 1; i >= 0; i--)
            {
                if (rightCutString[i] > w[index])
                {
                    string leftCutString = w.Substring(0, index + 1);
                    char[] left = leftCutString.ToCharArray();
                    char[] right = rightCutString.ToCharArray();

                    char temporaryChar = right[i];
                    right[i] = left[index];
                    left[index] = temporaryChar;
                    Array.Reverse(right);

                    //Console.WriteLine(new String(left) + new string(right).ToString());
                    return new String(left) + new string(right).ToString();
                }
            }
            return "no answer";
        }

    }
}
