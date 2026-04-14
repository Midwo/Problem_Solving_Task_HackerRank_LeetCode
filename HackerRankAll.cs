using System.Numerics;

namespace ProblemSolving
{
    internal class HackerRankAll
    {
        //Hackerrank
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
        public int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (int i in ar)
            {
                if (!dictionary.ContainsKey(i))
                {
                    dictionary.Add(i, 1);
                }
                else
                {
                    int x = dictionary[i] + 1;
                    dictionary[i] = x;
                }
            }
            int howManyPairs = 0;
            double y1 = 0;
            foreach (var x in dictionary.Values)
            {
                if (x >= 2)
                {
                    y1 = x / 2;
                    howManyPairs += (int)y1;
                }
            }
            return howManyPairs;
        }
        public int birthday(List<int> s, int d, int m)
        {
            int sumChocolate = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int y = 0;
                // Console.WriteLine(s[i]);
                if (i + m <= s.Count)
                {
                    for (int x = i; x < i + m; x++)
                    {
                        y += s[x];
                        if (y == d && x == i + m - 1)
                        {
                            sumChocolate++;
                        }
                    }
                }
            }
            return sumChocolate;
        }
        public int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        public int simpleArraySum(List<int> ar)
        {
            int y = ar.Sum();
            return y;
        }
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            int Alice = 0;
            int Bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    Alice++;
                }
                else if (a[i] < b[i])
                {
                    Bob++;
                }
            }
            List<int> results = [Alice, Bob];
            return results;
        }
        public long aVeryBigSum(List<long> ar)
        {
            long y = ar.Sum();
            return y;
        }
        public int diagonalDifference(List<List<int>> arr)
        {
            int z1 = 0;
            int y1 = 0;
            int x1 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                y1 += arr[i][arr.Count - 1 - i];
                x1 += arr[i][i];
            }
            z1 = x1 - y1;
            return Math.Abs(z1);
        }
        public void plusMinus(List<int> arr)
        {
            decimal plus = 0;
            decimal minus = 0;
            decimal zero = 0;
            decimal howmany = arr.Count();
            foreach (int item in arr)
            {
                if (item == 0)
                {
                    zero++;
                }
                else if (item > 0)
                {
                    plus++;
                }
                else
                {
                    minus++;
                }
            }
            decimal pluscount = plus / howmany;
            decimal minuscount = minus / howmany;
            decimal zerocount = zero / howmany;

            Console.WriteLine(pluscount);
            Console.WriteLine(minuscount);
            Console.WriteLine(zerocount);
        }
        public void staircase(int n)
        {
            string space = "";
            string hash = "";
            string all = "";
            for (int i = 0; i < n; i++)
            {
                space = "";
                int hashspace = n - i;
                if (hashspace > 1)
                {
                    for (int z = 1; z < hashspace; z++)
                    {
                        space += " ";
                    }
                }

                hash += "#";
                all = space + hash;
                Console.WriteLine(all);

            }
        }
        public void miniMaxSum(List<int> arr)
        {
            arr = arr.OrderBy(p => p).ToList();
            long min = 0;
            long max = 0;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                min += arr[i];
            }
            //  Console.WriteLine(min);
            for (int i = 1; i < arr.Count; i++)
            {
                max += arr[i];
            }
            Console.WriteLine("{0} {1}", min, max);
        }
        public int birthdayCakeCandles(List<int> candles)
        {
            int x1 = int.MinValue;
            int y1 = int.MinValue;
            foreach (var i in candles)
            {
                if (x1 == i)
                {
                    y1 += 1;
                }
                else if (x1 < i)
                {
                    x1 = i;
                    y1 = 1;
                }

            }
            return y1;
        }
        public string timeConversion(string s)
        {
            DateTime timeValue = Convert.ToDateTime(s);
            return timeValue.ToString("HH:mm:ss");
        }
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            string message = "NO";
            if (x1 > x2 && v1 > v2)
            {
                message = "NO";
            }
            else if (x2 > x1 && v2 > v1)
            {
                message = "NO";
            }
            if (x1 + v1 > x2 + v2)
            {
                do
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                    {
                        message = "YES";
                    }
                }
                while (x1 > x2);
            }
            else if (x2 + v2 > x1 + v1)
            {
                do
                {
                    x1 += v1;
                    x2 += v2;
                    if (x2 == x1)
                    {
                        message = "YES";
                    }
                }
                while (x2 > x1);
            }
            else
            {
                message = "YES";
            }

            return message;
        }
        public int getTotalX(List<int> a, List<int> b)
        {
            int maxA = a.Max();
            int minB = b.Min();
            int count = 0;

            for (int num = maxA; num <= minB; num++)
            {
                bool isFactorA = true;
                bool isFactorB = true;
                foreach (var i in a)
                {
                    if (num % i != 0)
                    {
                        isFactorA = false;
                    }
                }
                foreach (var i in b)
                {
                    if (i % num != 0)
                    {
                        isFactorB = false;
                    }
                }
                if (isFactorA && isFactorB)
                {
                    count++;
                }
            }
            return count;
        }
        public List<int> breakingRecords(List<int> scores)
        {
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int minBrokeCount = 0;
            int maxBrokeCount = 0;
            bool firstRecord = true;
            List<int> lista = new List<int>();
            foreach (var i in scores)
            {
                if (firstRecord)
                {
                    minValue = i;
                    maxValue = i;
                    firstRecord = false;
                }
                if (minValue < i)
                {
                    minValue = i;
                    minBrokeCount++;
                }
                if (maxValue > i)
                {
                    maxValue = i;
                    maxBrokeCount++;
                }
            }
            lista.Add(minBrokeCount);
            lista.Add(maxBrokeCount);
            return lista;
        }
        public int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int y = arr[i];
                if (!dictionary.ContainsKey(y))
                {
                    dictionary.Add(y, 1);
                }
                else
                {
                    int x = dictionary[y] + 1;
                    dictionary[y] = x;
                }
            }
            int howManyMax = 0;
            int howManyNow = 0;
            int keyDictionaryMinValueKey = int.MaxValue;
            int keyDictionaryNow = int.MaxValue;
            for (int xy = 0; xy < dictionary.Count; xy++)
            {
                int key = dictionary.ElementAt(xy).Key;
                howManyNow = dictionary[key];
                if (howManyMax == howManyNow)
                {
                    if (key < keyDictionaryMinValueKey)
                    {
                        keyDictionaryMinValueKey = key;
                    }
                }
                else if (howManyMax < howManyNow)
                {
                    howManyMax = howManyNow;
                    keyDictionaryMinValueKey = key;
                }
            }
            return keyDictionaryMinValueKey;
        }
        public string dayOfProgrammer(int year)
        {
            string whenDate = string.Empty;

            if (year < 1918)
            {
                if (year % 4 == 0)
                {
                    whenDate = "12";
                }
                else
                {
                    whenDate = "13";

                }
            }
            else if (year > 1918)
            {
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    whenDate = "12";
                }
                else
                {
                    whenDate = "13";
                }
            }
            else
            {
                whenDate = "26";
            }
            return whenDate + ".09." + year;
        }
        public void bonAppetit(List<int> bill, int k, int b)
        {
            int sum1 = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    sum1 += bill[i];
                }
            }
            sum1 = b - (sum1 / 2);

            if (sum1 == 0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(sum1);
            }
        }
        public int pageCount(int n, int p)
        {
            int howMany = 0;
            int howManyMax = 0;
            if (p == 1 || p == n)
            {
                howMany = 0;
            }
            else
            {
                double x = p / 2;
                howMany = (int)x;
                x = n / 2;
                howManyMax = (int)x - howMany;
                if (howMany > howManyMax)
                {
                    howMany = howManyMax;
                }
            }
            return howMany;
        }
        public int countingValleys(int steps, string path)
        {
            int countValley = 0;
            int height = 0;
            bool activeValley = false;
            foreach (char item in path)
            {
                if (item == (char)68)
                {
                    height--;
                }
                else if (item == (char)85)
                {
                    height++;
                }
                if (height < 0 && activeValley == false)
                {
                    activeValley = true;
                    countValley++;
                }
                else if (height >= 0)
                {
                    activeValley = false;
                }
            }

            return countValley;
        }
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            if (keyboards.Min() + drives.Min() > b)
            {
                return -1;
            }
            else
            {
                int maxBuyValue = int.MinValue;
                foreach (int i in keyboards)
                {
                    foreach (int x in drives)
                    {
                        if (i + x <= b)
                        {
                            maxBuyValue = maxBuyValue < i + x ? i + x : maxBuyValue;
                        }

                    }
                }
                return maxBuyValue;
            }
        }
        public int pickingNumbers(List<int> a)
        {
            a.Sort();

            int maxCountFollowing = 0;
            int actualCountFollowing = 0;
            int actualValue = 0;
            bool reset = true;

            bool getNewValue = true;
            for (int i = 0; i < a.Count - 1; i++)
            {
                if (getNewValue)
                {
                    actualValue = i;
                    getNewValue = false;
                }
                if (Math.Abs(a[actualValue] - a[i + 1]) <= 1)
                {
                    //Console.WriteLine("yes");

                    if (reset)
                    {
                        actualCountFollowing = 2;
                        reset = false;
                    }
                    else
                    {
                        actualCountFollowing++;
                    }
                }
                else
                {
                    getNewValue = true;
                    reset = true;
                    if (actualCountFollowing > maxCountFollowing)
                    {
                        maxCountFollowing = actualCountFollowing;
                    }
                    actualCountFollowing = 0;
                }
                if (actualCountFollowing > maxCountFollowing)
                {
                    maxCountFollowing = actualCountFollowing;
                }
            }
            return maxCountFollowing;
        }
        public int hurdleRace(int k, List<int> height)
        {
            int howManyPotions = 0;
            int heightWithPotion = k;
            for (int i = 0; i < height.Count; i++)
            {
                if (heightWithPotion < height[i])
                {
                    for (int x = heightWithPotion; x < height[i]; x++)
                    {
                        howManyPotions++;
                        heightWithPotion++;
                    }
                }

            }
            return howManyPotions;
        }
        public int designerPdfViewer(List<int> h, string word)
        {
            int maxValue = 0;
            int currentValue = 0;
            foreach (char letter in word)
            {
                currentValue = h[(letter) - 97];
                if (currentValue > maxValue)
                    maxValue = currentValue;
            }
            return maxValue * word.Length;
        }
        public int utopianTree(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    x++;
                }
                else
                {
                    x = x *= 2;
                }
            }
            return x;
        }
        public string angryProfessor(int k, List<int> a)
        {
            int notToolate = 0;
            foreach (int item in a)
            {
                if (item <= 0)
                {
                    notToolate++;
                }
            }
            if (notToolate >= k)
            {
                return "NO";
            }
            else
            {
                return "YES";
            }
        }
        public int beautifulDays(int i, int j, int k)
        {
            int countBeatifulDay = 0;
            for (int x = i; x <= j; x++)
            {
                int reverseint = int.Parse(x.ToString().Reverse().ToArray());
                if ((x - reverseint) % k == 0)
                {
                    countBeatifulDay++;
                }
            }
            return countBeatifulDay;
        }
        public int viralAdvertising(int n)
        {
            int liked = 2;
            int shared = 5;
            int cumulative = 2;

            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked = shared / 2;
                cumulative += liked;
            }
            return cumulative;
        }
        public int saveThePrisoner(int n, int m, int s)
        {
            var pos = s + (m % n) - 1;
            return (pos == 0 || pos > n) ? Math.Abs(pos - n) : pos;
        }
        public List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> queries1 = new List<int>();
            int length = a.Count;
            int remainder = k % length;

            for (int i = 0; i < queries.Count; i++)
            {
                int indexSeachr = (length - (remainder - queries[i])) % length;
                // Console.WriteLine(x);
                queries1.Add(a[indexSeachr]);
            }
            return queries1;
        }
        public List<int> permutationEquation(List<int> p)
        {
            List<int> newList = new List<int>();
            int length = p.Count;

            for (int i = 1; i <= length; i++)
            {
                bool statusBreak = false;
                for (int j = 0; j < length; j++)
                {
                    if (p[j] == i)
                    {
                        for (int k = 0; k < length; k++)
                        {
                            if (p[k] == j + 1)
                            {
                                newList.Add(k + 1);
                                statusBreak = true;
                                break;
                            }
                        }
                        if (statusBreak)
                        {
                            break;
                        }
                    }
                }
            }
            return newList;
        }
        public int jumpingOnClouds(int[] c, int k)
        {
            int index = 0;
            int points = 100;

            while (true)
            {
                index += k;
                if (index > c.Length - 1)
                {
                    index = index % c.Length;
                }

                if (c[index] == 1)
                    points -= 2;

                points--;
                if (index == 0) break;
            }
            return points;
        }
        public int findDigits(int n)
        {
            int count = 0;
            int copyN = n;

            while (copyN > 0)
            {
                int temp = copyN % 10;
                copyN /= 10;
                if (temp > 0 && n % temp == 0)
                {
                    count++;
                }
            }

            return count;
        }
        public string appendAndDelete(string s, string t, int k)
        {
            int countCorrectDigit = 0;

            int lengthS = s.Length;
            int lengthT = t.Length;

            if (k >= lengthS + lengthT)
            {
                return "Yes";
            }

            int minLenght = Math.Min(lengthS, lengthT);

            for (int i = 0; i < minLenght; i++)
            {
                if (s[i] == t[i])
                {
                    countCorrectDigit++;
                }
                else
                {
                    break;
                }
            }
            int howManyOperations = lengthS - countCorrectDigit + lengthT - countCorrectDigit;
            if (howManyOperations > k)
            {
                return "No";
            }
            else if (howManyOperations != k && (k - howManyOperations) % 2 == 1)
            {
                return "No";
            }
            return "Yes";
        }
        public int squares(int a, int b)
        {
            return (int)Math.Floor(Math.Sqrt(b)) - (int)Math.Ceiling(Math.Sqrt(a)) + 1;
        }
        public int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime date1 = new DateTime(y1, m1, d1);
            DateTime date2 = new DateTime(y2, m2, d2);

            if (date1 <= date2)
            {
                return 0;
            }
            else if (date1.Year > date2.Year)
            {
                return 10000;
            }
            else if (date1.Month > date2.Month)
            {
                return (500 * (date1.Month - date2.Month));
            }
            else
            {
                return 15 * (int)(date1 - date2).Days;
            }
        }
        public bool is_smart_number(int num)
        {
            int val = (int)Math.Sqrt(num);
            if (val * val == num)
                return true;
            return false;
        }
        public string strings_xor(string s, string t)
        {

            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    res += '0';
                else
                    res += '1';
            }

            return res;
        }
        public string misereNim(List<int> s)
        {
            int n = s.Count();
            int xr = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                xr ^= s[i];
                sum += s[i];
            }

            if (n % 2 == 0)
            {
                return n != sum && xr == 0 ? "Second" : "First";
            }
            else
            {
                return n == sum || xr == 0 ? "Second" : "First";
            }

        }
        public int towerBreakers(int n, int m)
        {
            if (m == 1)
            {
                return 2;
            }
            else
            {
                return 2 - (n % 2);
            }
        }
        public string gameOfStones(int n)
        {
            return n % 7 <= 1 ? "Second" : "First";
        }
        public long flippingBits(long n)
        {
            uint binaryValue = Convert.ToUInt32(n);
            binaryValue = ~binaryValue;
            n = Convert.ToInt64(binaryValue);
            return n;
        }
        public long sumXor(long n)
        {
            long howMany = 0;
            for (long i = 0; i < n; i++)
            {
                if ((n ^ i) == n + i)
                {
                    howMany++;
                }
            }
            return howMany;
        }
        public int maximizingXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i + 1; j <= r; j++)
                {
                    int xor = (i ^ j);
                    if (xor > max)
                    {
                        max = xor;
                    }
                }
            }
            return max;
        }
        public int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> howManyNumber = new Dictionary<int, int>();
            int minimumValueReplay = int.MaxValue;
            int minimumKeyReplay = 0;

            foreach (int i in a)
            {
                if (howManyNumber.ContainsKey(i))
                {
                    howManyNumber[i]++;
                }
                else
                {
                    howManyNumber.Add(i, 1);
                }
            }

            foreach (var i in howManyNumber)
            {
                if (i.Value < minimumValueReplay)
                {
                    minimumValueReplay = i.Value;
                    minimumKeyReplay = i.Key;
                }
            }

            return minimumKeyReplay;
        }
        public string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B = B.OrderBy(x => x).Reverse().ToList();
            bool trueOrFalse = false;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                {
                    return "NO";
                }
            }
            return "YES";
        }
        public List<int> jimOrders(List<List<int>> orders)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < orders.Count; i++)
            {
                dictionary.Add(i + 1, (orders[i][0] + orders[i][1]));
            }

            List<int> jimOrdersList = dictionary.OrderBy(x => x.Value).Select(x => x.Key).ToList();

            return jimOrdersList;
        }
        public int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int sumCost = 0;
            int sumCount = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                if (sumCost + prices[i] <= k)
                {
                    sumCount++;
                    sumCost += prices[i];
                }
                else
                {
                    break; ;
                }
            }
            return sumCount;
        }
        public List<int> largestPermutation(int k, List<int> arr)
        {
            if (k <= 0 || arr == null || !arr.Any())
            {
                return new List<int>();
            }
            int length = arr.Count;
            int currMaxValue = length;
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; ++i)
            {
                dic.Add(arr[i], i);
            }

            var currentIndex = 0;
            var countMove = 0;

            while (currentIndex < length && countMove < k)
            {
                if (arr[currentIndex] != currMaxValue)
                {
                    int temp = arr[currentIndex];
                    arr[currentIndex] = currMaxValue;
                    arr[dic[currMaxValue]] = temp;
                    dic[temp] = dic[currMaxValue];
                    currMaxValue--;
                    countMove++;
                }
                else
                {
                    currMaxValue--;
                }
                currentIndex++;
            }

            return arr;
        }
        public int toys(List<int> w)
        {
            w.Sort();
            int startWeight = w[0];
            int howManyConteiner = 1;

            foreach (int i in w)
            {
                if (startWeight + 4 < i)
                {
                    howManyConteiner++;
                    startWeight = i;
                }
            }
            return howManyConteiner;
        }
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
        public int beautifulPairs(List<int> A, List<int> B)
        {
            Dictionary<int, int> dictB = new Dictionary<int, int>();
            int countBeautifulPairs = 0;
            bool addOne = false;
            foreach (int i in B)
            {
                if (dictB.ContainsKey(i))
                {
                    dictB[i]++;
                }
                else
                {
                    dictB.Add(i, 1);
                }
            }

            for (int index = 0; index < A.Count; index++)
            {
                int currValue = A[index];

                if (dictB.ContainsKey(currValue) && dictB[currValue] > 0)
                {
                    countBeautifulPairs++;
                    dictB[currValue]--;
                }
                else
                {
                    addOne = true;
                }

            }

            if (addOne)
            {
                return countBeautifulPairs + 1;
            }
            else
            {
                return countBeautifulPairs - 1;
            }

        }
        public List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            int length = sticks.Count;
            sticks.Sort();
            int longLengthStick = sticks[length - 1];
            int medLengthStick = sticks[length - 2];
            int shortLengthStick = sticks[length - 3];

            if (longLengthStick < medLengthStick + shortLengthStick)
            {
                return [shortLengthStick, medLengthStick, longLengthStick];
            }

            for (int index = length - 4; index >= 0; index--)
            {
                longLengthStick = medLengthStick;
                medLengthStick = shortLengthStick;
                shortLengthStick = sticks[index];

                if (longLengthStick < medLengthStick + shortLengthStick)
                {
                    return [shortLengthStick, medLengthStick, longLengthStick];
                }
            }

            return [-1];
        }
        public int luckBalance(int k, List<List<int>> contests)
        {
            List<int> important = new List<int>();
            int luck = 0;

            foreach (var item in contests)
            {
                if (item[1] == 1)
                {
                    important.Add(item[0]);
                }
                else
                {
                    luck += item[0];
                }
            }

            important = important.OrderByDescending(x => x).ToList();

            luck += important.Take(k).Sum();
            luck -= important.Skip(k).Sum();

            return luck;

        }
        public string gridChallenge(List<string> grid)
        {
            int rows = grid.Count;
            int cols = grid[0].Length;
            char[][] charGrid = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                //charGrid[i] = grid[i].ToArray().OrderBy(x => x).ToArray();

                //Better this:
                char[] temp = grid[i].ToCharArray();
                Array.Sort(temp);
                charGrid[i] = temp;
            }

            for (int indexCol = 0; indexCol < cols; indexCol++)
            {
                int lastChar = charGrid[0][indexCol];

                for (int indexRow = 1; indexRow < rows; indexRow++)
                {
                    int currChar = charGrid[indexRow][indexCol];

                    if (lastChar > currChar)
                    {
                        return "NO";
                    }
                    lastChar = currChar;
                }
            }

            return "YES";

            ////Old version -> Much worse. Less efficient.

            //bool endLoop = false;
            //string outprint = string.Empty;
            //if (grid.Count > 1)
            //{
            //    for (int i = 0; i < grid.Count; i++)
            //    {
            //        grid[i] = String.Concat(grid[i].OrderBy(c => c));
            //    }

            //    int howLengh = grid[0].Length;

            //    for (int i = 0; i < howLengh; i++)
            //    {
            //        if (endLoop == false)
            //        {
            //            for (int x = 1; x < grid.Count; x++)
            //            {
            //                if ((int)Convert.ToChar(grid[x - 1][i]) <= (int)Convert.ToChar(grid[x][i]))
            //                {
            //                    outprint = "YES";
            //                }
            //                else
            //                {
            //                    outprint = "NO";
            //                    endLoop = true;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    outprint = "YES";
            //}
            //return outprint;
        }
        public long marcsCakewalk(List<int> calorie)
        {
            calorie.Sort();
            long multiplier = 1;
            long sumValue = 0;

            for (int i = calorie.Count - 1; 0 <= i; i--)
            {
                sumValue += calorie[i] * multiplier;
                multiplier *= 2;
                //OR better:
                //multiplier <<= 1;
            }

            return sumValue;


            ////Old version
            //calorie.Sort();

            //double SumValue = 0;
            //for (int i = calorie.Count - 1; 0 <= i; i--)
            //{
            //    SumValue = SumValue + (calorie[calorie.Count - i - 1] * Math.Pow(2, i));
            //    // Console.WriteLine(SumValue);
            //}
            //return (long)SumValue;
        }





















































    }
}

