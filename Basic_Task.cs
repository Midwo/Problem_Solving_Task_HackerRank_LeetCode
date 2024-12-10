namespace ProblemSolving
{
    internal class Basic_Task
    {
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

    }
}
