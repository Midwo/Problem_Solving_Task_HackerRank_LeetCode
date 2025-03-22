using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static ProblemSolving.Program;

namespace ProblemSolving
{
    internal class LeetCodeAll
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] printOutput = [0];
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        printOutput = [i, j];
                        break;
                    }
                }
            }
            return printOutput;
        }
        public bool IsPalindrome(int x)
        {
            bool ToSame = false;
            if (x < 0)
            {
                ToSame = false;
            }
            else
            {
                long x1 = long.Parse(new string(x.ToString().Reverse().ToArray()));
                if (x1 == x)
                {
                    ToSame = true;
                }
            }
            return ToSame;
        }
        public int RomanToInt(string s)
        {
            int howMany = 0;

            Dictionary<char, int> dictionaryRoman = new Dictionary<char, int>()
            {
                {'I',1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000}
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (dictionaryRoman[s[i]] >= dictionaryRoman[s[i + 1]])
                    {
                        howMany += dictionaryRoman[s[i]];
                    }
                    else
                    {
                        howMany -= dictionaryRoman[s[i]];
                    }
                }
                else
                {
                    howMany += dictionaryRoman[s[i]];
                }
            }
            return howMany;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            int minChar = strs.Min(s => s.Length);
            string[] x = strs.OrderBy(s => s).ToArray();
            string firstString = x[0];
            string lastString = x[x.Length - 1];
            string outPutString = "";
            for (int i = 0; i < minChar; i++)
            {
                if (firstString[i] == lastString[i])
                {
                    outPutString += firstString[i];
                }
                else
                {
                    break;
                }
            }
            return outPutString;
        }
        public bool IsValid(string s)
        {
            var x = s.ToList();
            bool endloop = false;
            Dictionary<char, char> dictionaryChar = new Dictionary<char, char>()
            {
                { '(',')' }, {'[',']'}, {'{','}'}
            };

            do
            {
                endloop = true;
                for (int i = 0; i < x.Count() - 1; i++)
                {
                    if (dictionaryChar.ContainsKey(x[i]))
                    {
                        if (dictionaryChar[x[i]] == x[i + 1])
                        {
                            x.RemoveAt(i + 1);
                            x.RemoveAt(i);
                            endloop = false;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (!endloop);

            if (x.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }
            var newNodeList = new ListNode();
            var current = newNodeList;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null)
            {
                current.next = list1;
            }
            if (list2 != null)
            {
                current.next = list2;
            }

            return newNodeList.next;
        }
        public int RemoveDuplicates(int[] nums)
        {
            int current = int.MinValue;
            int total = 0;
            foreach (int num in nums)
            {
                if (current != num)
                {
                    total++;
                    nums[total - 1] = num;
                }
                current = num;
            }
            return total;
        }
        public int RemoveElement(int[] nums, int val)
        {
            int total = 0;
            foreach (int i in nums)
            {
                if (i != val)
                {
                    nums[total] = i;
                    total++;
                }
            }
            return total;
        }
        public int StrStr(string haystack, string needle)
        {
            int outputIint = -1;
            bool cancelLoop = false;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length <= haystack.Length)
                {
                    if (haystack[i] == needle[0])
                    {
                        for (int j = 1; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                break;
                            }
                            else
                            {
                                if (j == needle.Length - 1)
                                {
                                    outputIint = i;
                                    cancelLoop = true;
                                    break;
                                }
                            }
                        }
                        if (needle.Length == 1)
                        {
                            outputIint = i;
                            cancelLoop = true;
                            break;
                        }
                    }
                    if (cancelLoop) { break; }
                }
            }
            return outputIint;
        }
        public int SearchInsert(int[] nums, int target)
        {
            int where = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    where = i;
                    break;
                }
            }
            return where == -1 ? nums.Length : where;
        }
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int lenght = -1;
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] == ' ')
                {
                    lenght = s.Length - 1 - i;
                    break;
                }
            }
            return lenght == -1 ? s.Length : lenght;
        }
        public int[] PlusOne(int[] digits)
        {
            int tempPlusOne = 0;

            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            }
            else
            {
                digits[digits.Length - 1] = 0;
                tempPlusOne = 1;
                for (int i = digits.Length - 2; i >= 0; i--)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        tempPlusOne = 0;
                        break;
                    }
                }
            }
            if (tempPlusOne == 1)
            {
                int[] array1 = [1];
                digits = array1.Concat(digits).ToArray();
            }
            return digits;
        }
        public string AddBinary(string a, string b)
        {
            var aArray = a.ToCharArray().Select(c => c.ToString()).ToArray();
            var bArray = b.ToCharArray().Select(c => c.ToString()).ToArray();
            int a1 = a.Length;
            int b1 = b.Length;
            int howManyAdd = 0;
            if (a1 >= b1)
            {
                for (int i = 0; i < a1; i++)
                {
                    //Console.WriteLine("a1: " + a[a1-i-1] );
                    if (b1 - i - 1 >= 0)
                    {
                        //Console.WriteLine("b1: " + b[b1 - i - 1]);
                        if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) > 2)
                        {
                            howManyAdd = 1;
                            aArray[a1 - i - 1] = "1";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) == 2)
                        {
                            howManyAdd = 1;
                            aArray[a1 - i - 1] = "0";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) == 1)
                        {
                            howManyAdd = 0;
                            aArray[a1 - i - 1] = "1";
                        }
                        else
                        {
                            howManyAdd = 0;
                            aArray[a1 - i - 1] = "0";
                        }

                    }
                    else
                    {
                        //Console.WriteLine("b1: " + b[b1 - i - 1]);
                        if (howManyAdd + int.Parse((aArray[a1 - i - 1])) > 2)
                        {
                            howManyAdd = 1;
                            aArray[a1 - i - 1] = "1";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) == 2)
                        {
                            howManyAdd = 1;
                            aArray[a1 - i - 1] = "0";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) == 1)
                        {
                            howManyAdd = 0;
                            aArray[a1 - i - 1] = "1";
                        }
                        else
                        {
                            howManyAdd = 0;
                            aArray[a1 - i - 1] = "0";
                        }
                    }
                }
                if (howManyAdd > 0)
                {
                    aArray = new String[] { "1" }.Concat(aArray).ToArray();
                }
            }
            else
            {
                for (int i = 0; i < b1; i++)
                {
                    if (a1 - i - 1 >= 0)
                    {
                        if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) > 2)
                        {
                            howManyAdd = 1;
                            bArray[b1 - i - 1] = "1";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) == 2)
                        {
                            howManyAdd = 1;
                            bArray[b1 - i - 1] = "0";
                        }
                        else if (howManyAdd + int.Parse((aArray[a1 - i - 1])) + int.Parse((bArray[b1 - i - 1])) == 1)
                        {
                            howManyAdd = 0;
                            bArray[b1 - i - 1] = "1";
                        }
                        else
                        {
                            howManyAdd = 0;
                            bArray[b1 - i - 1] = "0";
                        }

                    }
                    else
                    {
                        if (howManyAdd + int.Parse((bArray[b1 - i - 1])) > 2)
                        {
                            howManyAdd = 1;
                            bArray[b1 - i - 1] = "1";
                        }
                        else if (howManyAdd + int.Parse((bArray[b1 - i - 1])) == 2)
                        {
                            howManyAdd = 1;
                            bArray[b1 - i - 1] = "0";
                        }
                        else if (howManyAdd + int.Parse((bArray[b1 - i - 1])) == 1)
                        {
                            howManyAdd = 0;
                            bArray[b1 - i - 1] = "1";
                        }
                        else
                        {
                            howManyAdd = 0;
                            bArray[b1 - i - 1] = "0";
                        }
                    }
                }
                if (howManyAdd > 0)
                {
                    bArray = new String[] { "1" }.Concat(bArray).ToArray();
                }
            }
            if (a1 >= b1)
            {
                return string.Join("", aArray);
            }
            else
            {
                return string.Join("", bArray);
            }
        }
        public int MySqrt(int x)
        {
            return (int)Math.Sqrt(x);
        }
        public int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            List<int> howManyList = new List<int>();
            howManyList.Add(1);
            howManyList.Add(1);

            for (int i = 2; i <= n; i++)
            {
                howManyList.Add(howManyList[i - 1] + howManyList[i - 2]);
            }

            return howManyList[n];
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode cur = head;
            while (cur != null && cur.next != null)
            {
                if (cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }
            return head;
        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int indexNums1 = m + n - 1;
            while (n > 0)
            {
                if (m > 0 && nums1[m - 1] > nums2[n - 1])
                {
                    nums1[indexNums1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[indexNums1] = nums2[n - 1];
                    n--;
                }
                indexNums1--;
            }
            Console.WriteLine(string.Join("", nums1));
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> resultList = new List<int>();
            if (root == null)
            {
                return resultList;
            }
            return TreeNode.InTree(resultList, root);
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }
            if (q.val == p.val)
            {
                return TreeNode.TreeNodeIsSameTree(true, p, q);
            }
            else
            {
                return false;
            }
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }
            if (root.left == null || root.right == null)
            {
                return false;
            }
            if (root.left.val != root.right.val)
            {
                return false;
            }
            if (root.left.val == root.right.val)
            {
                return TreeNode.TreeNodeRootIsSymmetric(true, root.left, root.right);
            }
            else
            {
                return false;
            }
        }
        public int MaxDepth(TreeNode root)
        {
            if (root != null)
            {
                return (TreeNode.TreeMaxDepth(root));
            }
            return 0;
        }
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            int centerValue = nums.Length / 2;
            TreeNode root = new TreeNode(nums[centerValue]);

            root.left = SortedArrayToBST(nums[..centerValue]);
            root.right = SortedArrayToBST(nums[(centerValue + 1)..]);

            return root;
        }
        public int MinDepth(TreeNode root)
        {
            return TreeNode.TreeMinDepth(root);
        }
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return TreeNode.TreeHasPathSum(root, targetSum);
        }
        public IList<IList<int>> PascalsTriangleGenerate(int numRows)
        {
            IList<IList<int>> fullList = new List<IList<int>>();
            fullList.Add(new List<int>([1]));
            if (numRows == 0)
            {
                return null;
            }
            else if (numRows == 1)
            {
                return fullList;
            }
            else
            {
                for (int i = 0; i < numRows - 1; i++)
                {
                    List<int> currentList = new List<int>();
                    currentList.Add(1);
                    for (int j = 1; j < fullList[i].Count; j++)
                    {
                        currentList.Add(fullList[i][j - 1] + fullList[i][j]);
                    }
                    currentList.Add(1);
                    fullList.Add(currentList);
                }
                return fullList;
            }
        }
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> fullList = new List<IList<int>>();
            fullList.Add(new List<int>([1]));
            if (rowIndex == 0)
            {
                return fullList[0];
            }
            else
            {
                for (int i = 0; i < rowIndex; i++)
                {
                    List<int> currentList = new List<int>();
                    currentList.Add(1);
                    for (int j = 1; j < fullList[i].Count; j++)
                    {
                        currentList.Add(fullList[i][j - 1] + fullList[i][j]);
                    }
                    currentList.Add(1);
                    fullList.Add(currentList);
                }
                return fullList[fullList.Count - 1];
            }
        }
        public int MaxProfit(int[] prices)
        {
            int buyOrCheapPrice = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buyOrCheapPrice > prices[i])
                {
                    buyOrCheapPrice = prices[i];
                }
                maxProfit = Math.Max(maxProfit, prices[i] - buyOrCheapPrice);
            }
            return maxProfit;
        }
        public bool IsPalindrome(string s)
        {
            StringBuilder stringBuilderInputString = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    stringBuilderInputString.Append(s[i]);
                }
            }
            String newS = stringBuilderInputString.ToString().ToLower();
            for (int i = 0; i < newS.Length / 2; i++)
            {
                if (newS[newS.Length - 1 - i] != newS[i])
                {
                    return false;
                }
            }
            return true;
        }
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();
            foreach (int item in nums)
            {
                if (dictionaryNums.ContainsKey(item))
                {
                    dictionaryNums[item]++;
                }
                else
                {
                    dictionaryNums.Add(item, 1);
                }
            }
            return dictionaryNums.FirstOrDefault(x => x.Value == 1).Key;
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode slow = head;
            do
            {
                if (head.next == null || head.next.next == null) return false;
                slow = slow.next;
                head = head.next.next;
            } while (slow != head);
            return true;
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> listRoot = new List<int>();
            return TreeNode.TreePreorderTraversal(root, listRoot);
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> listRoot = new List<int>();
            return TreeNode.TreePostorderTraversal(root, listRoot);
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            //while (headB != null)
            //{
            //    ListNode temp = headA;
            //    while (temp != null)
            //    {

            //        // If both Nodes are same
            //        if (temp == headB)
            //            return headB;
            //        temp = temp.next;
            //    }
            //    headB = headB.next;
            //}
            //return null;

            HashSet<ListNode> visitedPointsFromHeadA = new HashSet<ListNode>();

            ListNode listA = headA;
            while (listA != null)
            {
                visitedPointsFromHeadA.Add(listA);
                listA = listA.next;
            }

            ListNode listB = headB;
            while (listB != null)
            {
                if (visitedPointsFromHeadA.Contains(listB))
                    return listB;
                listB = listB.next;
            }

            return null;
        }
        public string ConvertToTitle(int columnNumber)
        {
            string resultString = string.Empty;
            while (columnNumber != 0)
            {
                --columnNumber;
                resultString = ((char)('A' + columnNumber % 26)).ToString() + resultString;
                columnNumber /= 26;
            }
            return resultString;

            ////Alternative:
            //StringBuilder res = new StringBuilder();
            //    while (columnNumber != 0)
            //    {
            //        --columnNumber;
            //        res.Append((char)('A' + columnNumber % 26));
            //        columnNumber /= 26;
            //    }
            //    return new string (res.ToString().Reverse().ToArray());
        }
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dictionaryCountNumbers = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (dictionaryCountNumbers.ContainsKey(num))
                {
                    dictionaryCountNumbers[num]++;
                }
                else
                {
                    dictionaryCountNumbers.Add(num, 1);
                }
            }
            return dictionaryCountNumbers.FirstOrDefault(x => x.Value == dictionaryCountNumbers.Values.Max()).Key;
        }
        public int TitleToNumber(string columnTitle)
        {
            int tempResult = 0;
            int howLength = columnTitle.Length;
            for (int i = howLength - 1; i >= 0; i--)
            {
                tempResult += ((int)columnTitle[i] - 64) * (int)Math.Pow(26, howLength - i - 1);
            }
            return tempResult;
        }
        public uint reverseBits(uint n)
        {
            string tempString = Convert.ToString(n, 2).PadLeft(32, '0');
            string newReverseString = string.Empty;
            for (int i = tempString.Length - 1; i >= 0; i--)
            {
                newReverseString += tempString[i];
            }
            return Convert.ToUInt32(newReverseString, 2);

            //OR

            //uint result = 0;
            //for (int i = 0; i < 32; i++)
            //{
            //    result <<= 1;
            //    result |= (n & 1);
            //    n >>= 1;
            //}
            //return result;
        }
        public int HammingWeight(int n)
        {
            string tempStringBinary = Convert.ToString(n, 2);
            int howManyOne = 0;
            foreach (char item in tempStringBinary)
            {
                if (item == '1')
                {
                    howManyOne++;
                }
            }
            return howManyOne;
        }
        public bool IsHappy(int n)
        {
            string nString = n.ToString();
            double curr = 0;
            int howLong = nString.Length;
            List<int> list = new List<int>();
            while (n != 1)
            {
                for (int i = 0; i < howLong; i++)
                {
                    curr += Math.Pow((nString[i] - 48), 2);
                }
                n = (int)curr;
                if (n == 1)
                {
                    return true;
                }
                else if (n == 0)
                {
                    return false;
                }
                if (n > 2147483647)
                {
                    return false;
                }
                if (list.Contains(n))
                {
                    return false;
                }
                curr = 0;
                nString = n.ToString();
                howLong = nString.Length;
                list.Add(n);
            }
            return true;
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode copyHeadWithAddFirstRecord = new ListNode(0);
            copyHeadWithAddFirstRecord.next = head;
            ListNode correctedList = copyHeadWithAddFirstRecord;

            while (correctedList.next != null)
            {
                if (correctedList.next.val == val)
                {
                    correctedList.next = correctedList.next.next;
                }
                else
                {
                    correctedList = correctedList.next;
                }
            }
            return copyHeadWithAddFirstRecord.next;
        }
        public bool IsIsomorphic(string s, string t)
        {
            bool result = true;
            int lenghtStringS = s.Length;
            if (lenghtStringS != t.Length)
            {
                return false;
            }
            Dictionary<char, char> dictionaryMapping = new Dictionary<char, char>();
            for (int i = 0; i < lenghtStringS; i++)
            {
                if (dictionaryMapping.ContainsKey(s[i]))
                {
                    if (dictionaryMapping[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dictionaryMapping.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    dictionaryMapping.Add(s[i], t[i]);

                }
            }
            return result;
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode next;

            while (head != null)
            {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
        public bool ContainsDuplicate(int[] nums)
        {
            int howManyNums = nums.Count();
            if (howManyNums == 0)
            {
                return false;
            }
            Dictionary<int, int> dictionaryCountingReps = new Dictionary<int, int>();

            for (int i = 0; i < howManyNums; i++)
            {
                if (dictionaryCountingReps.ContainsKey(nums[i]))
                {
                    dictionaryCountingReps[nums[i]] += 1;
                    if (dictionaryCountingReps[nums[i]] >= 2)
                    {
                        return true;
                    }
                }
                else
                {
                    dictionaryCountingReps.Add(nums[i], 1);
                }
            }
            return false;
            ////Alternative, low memory consumption:
            //int howManyNums = nums.Count();
            //if (howManyNums == 0)
            //{
            //    return false;
            //}
            //Array.Sort(nums);
            //for (int i = 0; i < howManyNums - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1])
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int howManyNums = nums.Count();
            Dictionary<int, int> dictionaryIndexNumbers = new Dictionary<int, int>();
            for (int i = 0; i < howManyNums; i++)
            {
                if (dictionaryIndexNumbers.ContainsKey(nums[i]))
                {
                    if (i - dictionaryIndexNumbers[nums[i]] <= k)
                    {
                        return true;
                    }
                }
                dictionaryIndexNumbers[nums[i]] = i;
            }
            return false;
            ////Alternative, low memory consumption:
            //int howManyNums = nums.Count();
            //int howLongTwoLoop = 0;
            //int currI = 0;
            //if (howManyNums <= 1 || k == 0)
            //{
            //    return false;
            //}
            //for (int i = 0; i < howManyNums - 1; i++)
            //{
            //    currI = nums[i];
            //    howLongTwoLoop = i + k >= howManyNums ? howManyNums - 1 : i + k;
            //    for (int j = i + 1; j <= howLongTwoLoop; j++)
            //    {
            //        if (currI == nums[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
        }
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftCount = CountNodes(root.left);
            int rightCount = CountNodes(root.right);

            return leftCount + rightCount + 1;
        }
        public class LeetCodeAll_225_MyStack
        {

            //void push(int x) Pushes element x to the top of the stack.
            //int pop() Removes the element on the top of the stack and returns it.
            //int top() Returns the element on the top of the stack.
            //boolean empty() Returns true if the stack is empty, false otherwise.

            Queue<int> stackUsingQueues;

            public LeetCodeAll_225_MyStack()
            {
                stackUsingQueues = new Queue<int>();
            }

            public void Push(int x)
            {
                stackUsingQueues.Enqueue(x);
                int sizeStackUsingQueues = stackUsingQueues.Count;
                while (sizeStackUsingQueues-- > 1)
                {
                    //sizeStackUsingQueues--;
                    int returnValueOnStack = stackUsingQueues.Dequeue();
                    stackUsingQueues.Enqueue(returnValueOnStack);
                }
            }

            public int Pop()
            {
                return stackUsingQueues.Dequeue();
            }

            public int Top()
            {
                return stackUsingQueues.Peek();
            }

            public bool Empty()
            {
                return stackUsingQueues.Count == 0;
            }
        }
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode invertRoot = root.left;
            root.left = root.right;
            root.right = invertRoot;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> resultList = new List<string>();
            int numsLenght = nums.Length;
            bool firstValue = true;
            int startValue = 0;
            int endValue = 0;
            for (int i = 0; i < numsLenght; i++)
            {
                if (i == numsLenght - 1)
                {
                    resultList.Add("" + nums[i] + "");
                    break;
                }
                if (nums[i] + 1 == nums[i + 1])
                {
                    if (firstValue == true)
                    {
                        firstValue = false;
                        startValue = nums[i];
                    }
                    endValue = nums[i + 1];
                    if (i == numsLenght - 2)
                    {
                        resultList.Add("" + startValue + "->" + endValue + "");
                        break;
                    }
                }
                else
                {
                    if (firstValue == false)
                    {
                        firstValue = true;
                        resultList.Add("" + startValue + "->" + endValue + "");
                        if (i == numsLenght - 1)
                        {
                            resultList.Add("" + startValue + "->" + endValue + "");
                            break;
                        }
                    }
                    else
                    {
                        resultList.Add("" + nums[i] + "");
                    }
                }
            }
            return resultList;
        }
        public bool IsPowerOfTwo(int n)
        {
            //Solution only for net 6 and newer.
            return BitOperations.IsPow2(n);

            ////OR
            ////Standard way to solve without using BitOperations.IsPow2(n) from NET

            //return (n > 0) && ((n & (n - 1)) == 0);
        }
        public class LeetCodeAll_232_MyQueue
        {
            Queue<int> queueStacks;
            public LeetCodeAll_232_MyQueue()
            {
                queueStacks = new Queue<int>();
            }

            public void Push(int x)
            {
                queueStacks.Enqueue(x);
            }

            public int Pop()
            {
                var x = queueStacks.Dequeue();
                return x;
            }

            public int Peek()
            {
                var x = queueStacks.Peek();
                return x;
            }

            public bool Empty()
            {
                if (queueStacks.Count == 0)
                {
                    return true;
                };
                return false;
            }
        }
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            List<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int countList = list.Count;
            for (int i = 0; i < countList; i++)
            {
                if (list[i] != list[countList - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsAnagram(string s, string t)
        {
            int howLongStringS = s.Length;
            if (howLongStringS != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dictionaryCharsForStringS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryCharsForStringT = new Dictionary<char, int>();

            for (int i = 0; i < howLongStringS; i++)
            {
                if (dictionaryCharsForStringS.ContainsKey(s[i]))
                {
                    dictionaryCharsForStringS[s[i]]++;
                }
                else
                {
                    dictionaryCharsForStringS.Add(s[i], 1);
                }
                if (dictionaryCharsForStringT.ContainsKey(t[i]))
                {
                    dictionaryCharsForStringT[t[i]]++;
                }
                else
                {
                    dictionaryCharsForStringT.Add(t[i], 1);
                }
            }
            return dictionaryCharsForStringS.All(s => dictionaryCharsForStringT.ContainsKey(s.Key) && dictionaryCharsForStringT[s.Key] == s.Value);
        }
        public bool IsUgly(int n)
        {
            if (n <= 0) return false;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else if (n % 3 == 0)
                {
                    n = n / 3;
                }
                else if (n % 5 == 0)
                {
                    n = n / 5;
                }
                else { break; }
            }
            return n == 1;
        }
        public int MissingNumber(int[] nums)
        {
            int howManyNums = nums.Length;
            int sumIndex = 0;
            int sumNums = 0;

            for (int i = 0; i < howManyNums; i++)
            {
                sumNums += nums[i];
            }
            for (int i = 0; i <= howManyNums; i++)
            {
                sumIndex += i;
            }

            return sumIndex - sumNums;
        }
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> result = new List<string>();
            StringBuilder stringToList = new StringBuilder();

            if (root == null)
            {
                return result;
            }

            if (root.left == null && root.right == null)
            {
                result.Add(root.val.ToString());
                return result;
            }
            BacktrackingBinaryTreePaths(root, stringToList, result);

            return result;
        }
        private void BacktrackingBinaryTreePaths(TreeNode root, StringBuilder stringToList, IList<string> result)
        {
            if (root.left == null && root.right == null)
            {
                stringToList.Append("->" + root.val.ToString());
                result.Add(stringToList.ToString());
                return;
            }
            if (stringToList.Length == 0)
            {
                stringToList.Append(root.val.ToString());
            }
            else
            {
                stringToList.Append("->" + root.val.ToString());
            }
            String copyStringToList = stringToList.ToString();
            if (root.left != null)
            {
                BacktrackingBinaryTreePaths(root.left, stringToList, result);
            }
            stringToList = new StringBuilder(copyStringToList);
            if (root.right != null)
            {
                BacktrackingBinaryTreePaths(root.right, stringToList, result);
            }
        }
        public int AddDigits(int num)
        {
            int currNum = 0;
            string numString = num.ToString();
            if (num < 10)
            {
                return num;
            }
            while (num > 9)
            {
                for (int i = 0; i < numString.Length; i++)
                {
                    currNum += Convert.ToInt32(numString[i].ToString());
                }
                num = currNum;
                numString = num.ToString();
                currNum = 0;
            }
            return num;
        }
        public int FirstBadVersion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int end = n;
            int begin = 1;
            while (begin < end)
            {
                int mid = begin + (end - begin) / 2;
                if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else if (IsBadVersion(mid) == false && IsBadVersion(mid + 1) == true)
                {
                    return mid + 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }
            if (begin != n && IsBadVersion(begin)) return begin;
            return -1;
        }
        private bool IsBadVersion(int n)
        {
            bool result = false;
            Dictionary<int, bool> dictionaryBadVersion = new Dictionary<int, bool>()
            {
                {1, true}, {2, true}, {3, true}, {4, true}, {5, true}, {6, true}, {7, true}, {8, true}, {9, true}, {10, true}, {11, true}
            };
            if (dictionaryBadVersion.ContainsKey(n))
            {
                return dictionaryBadVersion[n];
            }
            return true;
        }
        public void MoveZeroes(int[] nums)
        {
            int howLong = nums.Length - 1;
            int currentNumbersOfWithoutZero = 0;
            for (int i = 0; i <= howLong; i++)
            {
                if (nums[i] != 0)
                {
                    if (currentNumbersOfWithoutZero != i)
                    {
                        nums[currentNumbersOfWithoutZero] = nums[i];
                        nums[i] = 0;
                    }
                    currentNumbersOfWithoutZero++;
                }
            }
            ////checking the output data
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dictionaryForPatternAndStringS = new Dictionary<char, string>();
            int currIndexS = 0;
            string currWorld = string.Empty;
            int howLongS = s.Length;
            bool result = true;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (currIndexS >= howLongS)
                {
                    return false;
                }
                if (dictionaryForPatternAndStringS.ContainsKey(pattern[i]))
                {
                    currWorld = string.Empty;
                    for (int j = currIndexS; j < howLongS; j++)
                    {
                        if (s[j] != (char)32)
                        {
                            currWorld += s[j];
                        }
                        else
                        {
                            currIndexS = j + 1;
                            break;
                        }
                        currIndexS = j + 1;
                    }
                    if (dictionaryForPatternAndStringS[pattern[i]] != currWorld)
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    currWorld = string.Empty;
                    for (int j = currIndexS; j < howLongS; j++)
                    {
                        if (s[j] != (char)32)
                        {
                            currWorld += s[j];
                        }
                        else
                        {
                            currIndexS = j + 1;
                            break;
                        }
                        currIndexS = j + 1;
                    }
                    if (dictionaryForPatternAndStringS.ContainsValue(currWorld))
                    {
                        result = false;
                        break;
                    }
                    dictionaryForPatternAndStringS.Add(pattern[i], currWorld);
                }
            }
            if (currIndexS < howLongS)
            {
                return false;
            }
            return result;
        }
        public bool CanWinNim(int n)
        {
            if (n % 4 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public class NumArrayLeetCodeAll
        {
            List<int> numsValues;
            public NumArrayLeetCodeAll(int[] nums)
            {
                numsValues = new List<int>();
                int lastValue = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    lastValue = nums[i] + lastValue;
                    numsValues.Add(lastValue);
                }
            }
            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return numsValues[right];
                }
                return numsValues[right] - numsValues[left - 1];
            }
        }
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            bool endLoop = false;
            while (!endLoop)
            {
                if (n == 1)
                {
                    return true;
                }
                if (n % 3 != 0)
                {
                    return false;
                }
                n = n / 3;
            }
            return true;
        }
        public int[] CountBits(int n)
        {
            List<int> result = new List<int>();
            int howManyOne = 0;
            for (int i = 0; i <= n; i++)
            {
                howManyOne = 0;
                foreach (var item in Convert.ToString(i, 2))
                {
                    if (item == (char)49)
                    {
                        howManyOne++;
                    }
                }
                result.Add(howManyOne);
            }
            return result.ToArray();
        }
        public bool IsPowerOfFour(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n == 0)
            {
                return false;
            }
            while (n != 1)
            {
                if (n % 4 != 0)
                {
                    return false;
                }
                else
                {
                    n = n / 4;
                    if (n == 1)
                    {
                        return true;
                    }
                }
            }
            return true;
        }
        public void ReverseString(char[] s)
        {
            int howLong = s.Length;
            if (howLong >= 2)
            {
                if (howLong % 2 == 0)
                {
                    for (int i = 0; i < howLong / 2; i++)
                    {
                        char tempChar = s[i];
                        s[i] = s[howLong - i - 1];
                        s[howLong - i - 1] = tempChar;
                    }
                }
                else
                {
                    for (int i = 0; i < howLong / 2; i++)
                    {
                        char tempChar = s[i];
                        s[i] = s[howLong - i - 1];
                        s[howLong - i - 1] = tempChar;
                    }
                }
            }
            ////optional output
            Console.WriteLine(string.Join(",", s));
        }
        public string ReverseVowels(string s)
        {
            List<char> listVowels = new List<char>() { 'a', 'A', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            int howLongS = s.Length;

            char[] charsStringS = s.ToCharArray();

            for (int i = 0; i < howLongS; i++)
            {
                if (listVowels.Contains(charsStringS[i]))
                {
                    for (int j = howLongS - 1; j > i; j--)
                    {
                        howLongS--;
                        if (listVowels.Contains(charsStringS[j]))
                        {
                            char tempChar = charsStringS[i];
                            charsStringS[i] = charsStringS[j];
                            charsStringS[j] = tempChar;
                            break;
                        }
                    }
                }
            }

            return string.Join("", charsStringS);
        }
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int howLongNums1 = nums1.Length;
            int howLongNums2 = nums2.Length;
            List<int> result = new List<int>();
            int currIndex = 0;
            if (howLongNums1 > howLongNums2)
            {
                for (int i = 0; i < howLongNums1; i++)
                {
                    for (int j = currIndex; j < howLongNums2; j++)
                    {
                        if (nums1[i] == nums2[j])
                        {
                            currIndex++;
                            result.Add(nums1[i]);
                            break;
                        }
                        else if (nums1[i] < nums2[j])
                        {
                            break;
                        }
                        currIndex++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < howLongNums2; i++)
                {
                    for (int j = currIndex; j < howLongNums1; j++)
                    {
                        if (nums2[i] == nums1[j])
                        {
                            currIndex++;
                            result.Add(nums2[i]);
                            break;
                        }
                        else if (nums2[i] < nums1[j])
                        {
                            break;
                        }
                        currIndex++;
                    }
                }
            }
            return result.ToArray();
        }
        public bool IsPerfectSquare(int num)
        {
            bool result = true;
            int min = 0;
            int max = 0;
            switch (num)
            {
                case >= 1600000000:
                    min = 40000;
                    max = 46340;
                    break;
                case >= 900000000:
                    min = 30000;
                    max = 39999;
                    break;
                case >= 400000000:
                    min = 20000;
                    max = 29000;
                    break;
                case >= 100000000:
                    min = 10000;
                    max = 19999;
                    break;
                case <= 100000000:
                    min = 1;
                    max = 9999;
                    break;
            }

            if (result == false)
            {
                return false;
            }
            else
            {
                for (int i = min; i <= max; i++)
                {
                    if ((i * i) == num)
                    {
                        return true;
                    }
                    else if ((i * i) > num)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public int GuessNumber(int n)
        {
            int pick = -1;
            int maxValue = int.MaxValue;
            int minValue = 1;
            int midValue = 1;
            pick = guess(maxValue);
            if (pick == 0) { return maxValue; }
            else
            {
                while (pick != 0)
                {
                    if (maxValue % 2 == 0)
                    {
                        midValue = Convert.ToInt32(((long)maxValue + (long)minValue) / 2);
                        pick = guess(midValue);
                        if (pick == 0)
                        {
                            return midValue;
                        }
                        else if (pick == -1)
                        {
                            maxValue = midValue;
                        }
                        else
                        {
                            minValue = midValue;
                        }
                    }
                    else
                    {
                        midValue = Convert.ToInt32(((long)maxValue + (long)minValue) / 2);
                        pick = guess(midValue);
                        if (pick == 0)
                        {
                            return midValue;
                        }
                        else if (pick == -1)
                        {
                            maxValue = midValue;
                        }
                        else
                        {
                            minValue = midValue;
                        }
                    }
                }
            }
            return n;
        }
        private int guess(int num)
        {
            int pick = 1702766719;
            if (num > pick) pick = -1;
            else if (num < pick) pick = 1;
            else pick = 0;
            return pick;
        }
        public bool CanConstruct(string ransomNote, string magazine)
        {
            char[] ransomNoteChar = ransomNote.ToCharArray();
            char[] magazineChar = magazine.ToCharArray();
            bool result = false;
            Array.Sort(ransomNoteChar);
            Array.Sort(magazineChar);
            int currMagazineIndex = 0;
            int magazineCharCount = magazineChar.Count();
            for (int i = 0; i < ransomNoteChar.Count(); i++)
            {
                if (currMagazineIndex == magazineCharCount)
                {
                    return false;
                }
                for (int j = currMagazineIndex; j < magazineCharCount; j++)
                {
                    if ((int)ransomNoteChar[i] == (int)magazineChar[j])
                    {
                        result = true;
                        currMagazineIndex++;
                        break;
                    }
                    else if ((int)ransomNoteChar[i] < (int)magazineChar[j])
                    {
                        result = false;
                        goto EndOfLoop;
                    }
                    currMagazineIndex++;
                    result = false;
                }
                if (result == false)
                {
                    return false;
                }
            }
        EndOfLoop:
            return result;
        }
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dictionaryForStringS = new Dictionary<char, int>();
            int sLenght = s.Length;
            for (int i = 0; i < sLenght; i++)
            {
                if (dictionaryForStringS.ContainsKey(s[i]))
                {
                    dictionaryForStringS[s[i]]++;
                }
                else
                {
                    dictionaryForStringS.Add(s[i], 1);
                }
            }
            for (int i = 0; i < sLenght; i++)
            {
                if (dictionaryForStringS[s[i]] == 1)
                {
                    return i;
                }
            };
            return -1;
        }
        public char FindTheDifference(string s, string t)
        {
            //char[] charsStringS = s.ToCharArray();
            //char[] charsStringT = t.ToCharArray();

            //Array.Sort(charsStringS);
            //Array.Sort(charsStringT);
            //int sLenght = s.Length;

            //if (sLenght == 0) 
            //{
            //    return charsStringT[0];
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (charsStringS[i] != charsStringT[i])
            //    {
            //        return charsStringT[i];
            //    }
            //}
            //return charsStringT[sLenght];

            ////OR SUM ASCI (Better Runtime, Worse Memory)
            int sumASCIforStringS = 0;
            int sumASCIforStringT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sumASCIforStringS += s[i];
            }
            for (int i = 0; i < t.Length; i++)
            {
                sumASCIforStringT += t[i];
            }
            return (char)(sumASCIforStringT - sumASCIforStringS);
        }
        public bool IsSubsequence(string s, string t)
        {
            int indexStringT = 0;
            char currChar = '1';
            bool result = false;
            for (int i = 0; i < s.Length; i++)
            {
                result = false;
                currChar = s[i];
                for (int j = indexStringT; j < t.Length; j++)
                {
                    if (currChar == t[j])
                    {
                        indexStringT++;
                        result = true;
                        break;
                    }
                    indexStringT++;
                }
                if (result == false)
                {
                    return false;
                }
            }
            if (s.Length == 0)
            {
                return true;
            }
            return result;
        }
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            IList<String> result = new List<string>();
            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    if (BitCount(h) + BitCount(m) == turnedOn)
                    {
                        result.Add($"{h}:{m:00}");
                    }
                }
            }
            return result;

        }
        private static int BitCount(int num)
        {
            var result = 0;
            while (num > 0)
            {
                result++;
                num &= num - 1;
            }
            return result;
        }
        public int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;
            if (root != null)
            {
                if (CheckingLeaf(root.left))
                {
                    result += root.left.val;
                }
                else
                {
                    result += SumOfLeftLeaves(root.left);
                }
                result += SumOfLeftLeaves(root.right);
            }
            return result;
        }
        private bool CheckingLeaf(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }
        public string ToHex(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            char[] hexValues = {'0', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
            StringBuilder resultStringBuilder = new StringBuilder();

            while (num != 0)
            {
                resultStringBuilder.Append(hexValues[num & 0xf]);
                num >>>= 4;
            }
            return new string(resultStringBuilder.ToString().Reverse().ToArray());
        }
        public int LongestPalindrome(string s)
        {
            int result = 0;
            int stringSlenght = s.Length;
            if (stringSlenght < 1)
            {
                return 0;
            }
            else if (stringSlenght == 1)
            {
                return 1;
            }
            else
            {

                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                bool firstCount = true;
                int currCount = 0;
                for (int i = 1; i < stringSlenght; i++)
                {
                    if (chars[i] == chars[i - 1])
                    {
                        if (firstCount)
                        {
                            result += 2;
                            firstCount = false;
                        }
                        else
                        {
                            currCount++;
                            if (currCount % 2 == 0)
                            {
                                currCount = 0;
                                result += 2;
                            }
                        }
                    }
                    else
                    {
                        firstCount = true;
                        currCount = 0;
                    }
                }
                if (result != stringSlenght)
                {
                    return result + 1;
                }
                else
                {
                    return result;
                }
            }
        }
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        result.Add("FizzBuzz");
                    }
                    else
                    {
                        result.Add("Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int howLong = nums.Length;
            int place;
            int currValue;
            place = 1;
            currValue = nums[howLong - 1];
            for (int i = howLong - 2; i >= 0; i--)
            {
                if (nums[i] != currValue)
                {
                    place++;
                    if (place == 3)
                    {
                        return nums[i];
                    }
                    else
                    {
                        currValue = nums[i];
                    }
                }
            }
            if (place <= 3)
            {
                return nums[howLong - 1];
            }
            return 1;
        }
        public string AddStrings(string num1, string num2)
        {
            int howLongNum1 = num1.Length;
            int howLongNum2 = num2.Length;
            char[] num1Chars = num1.ToCharArray();
            char[] num2Chars = num2.ToCharArray();
            int addValue = 0;
            int currIndex = -1;
            if (howLongNum1 >= howLongNum2)
            {
                for (int i = howLongNum1 - 1; i >= 0; i--)
                {
                    currIndex++;
                    if (currIndex <= howLongNum2 - 1)
                    {
                        int tempValue = ((int)(num2[howLongNum2 - currIndex - 1] + addValue) + (int)num1[i] - 48);
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num1Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num1Chars[i] = (char)(tempValue);
                        }
                    }
                    else
                    {
                        int tempValue = (int)num1[i] + addValue;
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num1Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num1Chars[i] = (char)(tempValue);
                        }
                    }
                }
                if (addValue == 1)
                {
                    num1 = "1" + string.Join("", num1Chars);
                }
                else
                {
                    num1 = string.Join("", num1Chars);
                }
                return num1;
            }
            else
            {
                for (int i = howLongNum2 - 1; i >= 0; i--)
                {
                    currIndex++;
                    if (currIndex <= howLongNum1 - 1)
                    {
                        int tempValue = ((int)(num1[howLongNum1 - currIndex - 1] + addValue) + (int)num2[i] - 48);
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num2Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num2Chars[i] = (char)(tempValue);
                        }
                    }
                    else
                    {
                        int tempValue = (int)num2[i] + addValue;
                        if (tempValue > 57)
                        {
                            addValue = 1;
                            num2Chars[i] = (char)(tempValue - 10);
                        }
                        else
                        {
                            addValue = 0;
                            num2Chars[i] = (char)(tempValue);
                        }
                    }
                }
                if (addValue == 1)
                {
                    num2 = "1" + string.Join("", num2Chars);
                }
                else
                {
                    num2 = string.Join("", num2Chars);
                }
                return num2;
            }
        }
        public int CountSegments(string s)
        {
            int result = 0;
            int lenghtS = s.Length;
            if (lenghtS < 1)
            {
                return 0;
            }
            char lastchar = s[0];
            if (lastchar != ' ' && lastchar != ' ')
            {
                result++;
            }
            for (int i = 1; i < lenghtS; i++)
            {
                if (lastchar == ' ' && s[i] != ' ')
                {
                    result++;
                }
                lastchar = s[i];
            }
            if (result == 0)
            {
                s = s.Trim();
                if (s.Length > 0)
                {
                    return 1;
                }
                else return 0;
            }
            return result;
        }
        public int ArrangeCoins(int n)
        {
            int result = 0;
            int currValue = 1;
            while (n > 0)
            {
                n = n - currValue++;
                if (n > 0) { result++; }
            }
            return result;
        }
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();

            Array.Sort(nums);
            int howManyDubels = 0;
            int howManyAddValues = 0;
            int numsLenght = nums.Length;
            if (nums[0] != 1)
            {
                for (int i = 1; i < nums[0]; i++)
                {
                    howManyAddValues++;
                    result.Add(i);
                }
            }
            for (int i = 1; i < numsLenght; i++)
            {
                int numsCurr = nums[i];
                int numsMinusOne = nums[i - 1];
                if (numsCurr == nums[i - 1])
                {
                    howManyDubels++;
                }
                else if (numsMinusOne != numsCurr - 1)
                {
                    for (int j = numsMinusOne + 1; j < numsCurr; j++)
                    {
                        result.Add(j);
                        howManyAddValues++;
                    }
                }
            }
            int tempLastValue = nums[numsLenght - 1];
            while (howManyDubels > howManyAddValues)
            {
                result.Add(tempLastValue++ + 1);
                howManyAddValues++;
            }
            return result;
        }
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int lengthS = s.Length;
            int currIndexS = 0;
            int currGValue;
            int result = 0;
            for (int i = 0; i < g.Length; i++)
            {
                currGValue = g[i];
                for (int j = currIndexS; j < lengthS; j++)
                {
                    if (s[j] >= currGValue)
                    {
                        ++result;
                        ++currIndexS;
                        break;
                    }
                    else
                    {
                        ++currIndexS;
                    }
                }
            }
            return result;
        }
        public bool RepeatedSubstringPattern(string s)
        {
            var str = s + s;
            return str.IndexOf(s, 1) != s.Length;
        }
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
        public int IslandPerimeter(int[][] grid)
        {
            int result = 0;
            int prevLevelCountNumber = 0;
            bool clearBox = true;
            int numberOfLevels = grid.Count();
            for (int i = 0; i < numberOfLevels; i++)
            {
                clearBox = true;
                if (i == 0)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            result += 4;
                            if (clearBox == false)
                            {
                                result -= 2;
                            }
                            clearBox = false;
                        }
                        else
                        {
                            clearBox = true;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            if (prevLevelCountNumber >= j)
                            {
                                if (grid[i - 1][j] == 1)
                                {
                                    result -= 2;
                                }
                            }
                            result += 4;
                            if (clearBox == false)
                            {
                                result -= 2;
                            }
                            clearBox = false;
                        }
                        else
                        {
                            clearBox = true;
                        }
                    }
                }
                prevLevelCountNumber = grid[i].Length;
            }
            return result;
        }
        public int FindComplement(int num)
        {
            string stringByteNum = Convert.ToString(num, 2);
            int result = 0;
            for (int i = stringByteNum.Length - 1; i >= 0; i--)
            {
                if (stringByteNum[i] == '0')
                {
                    result += (int)Math.Pow(2, stringByteNum.Length - 1 - i);
                }
            }
            return result;
        }
        public string LicenseKeyFormatting(string s, int k)
        {
            List<string> list = new List<string>();
            string currString = string.Empty;
            int counter = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '-')
                {
                    counter++;
                    currString = s[i] + currString;
                    if (counter == k)
                    {
                        list.Add(currString.ToUpper());
                        currString = string.Empty;
                        counter = 0;
                    }
                }
            }
            if (counter != 0)
            {
                list.Add(currString.ToUpper());
            }
            list.Reverse();
            return string.Join("-", list);
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int currConsecutiveOnes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currConsecutiveOnes++;
                    result = result < currConsecutiveOnes ? currConsecutiveOnes : result;
                }
                else
                {
                    currConsecutiveOnes = 0;
                }
            }

            return result;
        }
        public int[] ConstructRectangle(int area)
        {
            int l = 1;
            int w = 1;
            for (int i = 1; i <= Math.Sqrt(area); i++)
            {
                if (area % i == 0)
                {
                    l = area / i;
                    w = i;
                }
            }
            return new int[] { l, w };
        }
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int result = 0;
            int currLastTime = 0;
            for (int i = 0; i < timeSeries.Length; i++)
            {
                if (result == 0)
                {
                    currLastTime = timeSeries[i] + duration - 1;
                    result += duration;
                }
                else
                {
                    if (currLastTime >= timeSeries[i])
                    {
                        result += timeSeries[i] + duration - currLastTime - 1;
                        currLastTime = timeSeries[i] + duration - 1;
                    }
                    else
                    {
                        currLastTime = timeSeries[i] + duration - 1;
                        result += duration;
                    }
                }
            }
            return result;
        }
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            bool find = false;
            for (int i = 0; i < nums1.Length; i++)
            {
                find = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (find == true)
                    {
                        if (nums1[i] < nums2[j])
                        {
                            nums1[i] = nums2[j];
                            break;
                        }
                        else if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                        }
                    }
                    else if (nums1[i] == nums2[j])
                    {
                        find = true;
                        if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                        }
                    }
                    else
                    {
                        if (j + 1 >= nums2.Length)
                        {
                            nums1[i] = -1;
                            break;
                        }
                    }
                }
            }
            return nums1;
        }
        public string[] FindWords(string[] words)
        {
            char[] rowConsitsChar1 = ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'];
            char[] rowConsitsChar2 = ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'];
            char[] rowConsitsChar3 = ['z', 'x', 'c', 'c', 'v', 'b', 'n', 'm'];
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string tempString = words[i].ToLower();
                if (ValidationChars(tempString, rowConsitsChar1))
                {
                    result.Add(words[i]);
                }
                else if (ValidationChars(tempString, rowConsitsChar2))
                {
                    result.Add(words[i]);
                }
                else if (ValidationChars(tempString, rowConsitsChar3))
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }
        private static bool ValidationChars(string words, char[] chars)
        {
            bool result = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (!chars.Contains(words[i]))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public string ConvertToBase7(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            List<char> resultList = new List<char>();
            bool minusValue = num < 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                resultList.Insert(0, (char)(num % 7 + '0'));
                num /= 7;
            }

            if (minusValue)
            {
                resultList.Insert(0, '-');
            }

            return new string(resultList.ToArray());
        }
        public int[] FindMode(TreeNode root)
        {
            ////(501.) Find Mode in Binary Search Tree (EASY)

            List<int> ans = new List<int>();
            int[] count = new int[2];

            inorder(root, count, ans);
            return ans.ToArray();
        }
        private TreeNode pred = null;
        private void inorder(TreeNode root, int[] count, List<int> ans)
        {
            if (root == null)
                return;

            inorder(root.left, count, ans);
            updateCount(root, count, ans);
            inorder(root.right, count, ans);
        }
        private void updateCount(TreeNode root, int[] count, List<int> ans)
        {
            if (pred != null && pred.val == root.val)
                ++count[0];
            else
                count[0] = 1;

            if (count[0] > count[1])
            {
                count[1] = count[0];
                ans.Clear();
                ans.Add(root.val);
            }
            else if (count[0] == count[1])
            {
                ans.Add(root.val);
            }

            pred = root;
        }
        public string[] FindRelativeRanks(int[] score)
        {
            int[] sortScore = score.ToArray();
            Array.Sort(sortScore);
            int scoreLength = score.Length;
            string[] result = new string[scoreLength];
            int index = 0;
            for (int i = 0; i < scoreLength; i++)
            {
                for (int j = 0; j < scoreLength; j++)
                {
                    if (score[i] == sortScore[j])
                    {
                        index = scoreLength - j; break;
                    }
                }

                if (index <= 3)
                {
                    if (index == 1)
                    {
                        result[i] = "Gold Medal";
                    }
                    else if (index == 2)
                    {
                        result[i] = "Silver Medal";
                    }
                    else
                    {
                        result[i] = "Bronze Medal";
                    }
                    continue;
                }
                result[i] = index.ToString();
            }
            return result;
        }
        public bool CheckPerfectNumber(int num)
        {
            int result = 0;
            if (num % 2 == 0)
            {
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        result += i;
                        if (result > num)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            if (result == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Fib(int n)
        {
            ////HARDCODE VERSION - NOT RECOMMENDATION
            //int[] result = [0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711,28657,46368,75025,121393,196418,317811,514229];
            //return result[n];

            ////Alternative:
            int result = 0;
            if (n == 0) { return 0; }
            else if (n == 1) { return 1; }
            int prev = 1;
            int prevprev = 0;
            for (int i = 2; i <= n; i++)
            {
                result = prev + prevprev;
                prevprev = prev;
                prev = result;
            }

            return result;
        }
        public void LeetCode511()
        {
            ////(511.) Game Play Analysis I (EASY)

            ////T-SQL query CODE - MS SQL */
            //Select
            //[player_id],
            //MIN(event_date) as [first_login]
            //From Activity
            //GROUP BY[player_id]
        }
        public bool DetectCapitalUse(string word)
        {
            int lengthWord = word.Length - 1;
            bool lastWordUpper = false;
            if (word[lengthWord] < 97) { lastWordUpper = true; }
            if (word[0] >= 97)
            {
                for (int i = 1; i <= lengthWord; i++)
                {
                    if ((word[i] < 97))
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (lastWordUpper)
                {
                    for (int i = 1; i <= lengthWord; i++)
                    {
                        if ((word[i] <= 97) != lastWordUpper)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= lengthWord; i++)
                    {
                        if ((word[i] >= 97) == lastWordUpper)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public int FindLUSlength(string a, string b)
        {
            if (b.Length > a.Length) { return b.Length; }
            else if (a.Length > b.Length) { return a.Length; }
            bool theSame = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    theSame = false;
                    break;
                }
            }
            if (theSame)
            {
                return -1;
            }
            else
            {
                return a.Length;
            }
        }
        public int GetMinimumDifference(TreeNode root)
        {
            List<int> listValueRoot = new List<int>();
            InTree(listValueRoot, root);
            int minDifference = int.MaxValue;
            for (int i = 0; i < listValueRoot.Count - 1; i++)
            {
                minDifference = Math.Min(minDifference, listValueRoot[i + 1] - listValueRoot[i]);
            }
            return minDifference;
        }
        public void InTree(List<int> listValueRoot, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InTree(listValueRoot, root.left);
            listValueRoot.Add(root.val);
            InTree(listValueRoot, root.right);
        }
        public string ReverseStr(string s, int k)
        {
            char[] arrayCharS = s.ToCharArray();
            int sLength = s.Length;
            for (int i = 0; i < arrayCharS.Length; i += 2 * k)
            {
                int curLeftIndex = i;
                int curRightIndex = i + k - 1;

                if (curRightIndex >= sLength)
                {
                    curRightIndex = sLength - 1;
                }

                while (curLeftIndex < curRightIndex)
                {
                    char temp = arrayCharS[curLeftIndex];
                    arrayCharS[curLeftIndex] = arrayCharS[curRightIndex];
                    arrayCharS[curRightIndex] = temp;

                    curLeftIndex++;
                    curRightIndex--;
                }
            }

            return new String(arrayCharS);
        }
        private int maxLevelTree;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxLevelTree = 0;
            DepthLeveLTree(root);
            return maxLevelTree;
        }
        private int DepthLeveLTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DepthLeveLTree(root.left);
            int right = DepthLeveLTree(root.right);

            maxLevelTree = Math.Max(maxLevelTree, left + right);

            return 1 + Math.Max(left, right);
        }
        public bool CheckRecord(string s)
        {
            int howManyTimesAbsent = 0;
            int howManyTimesConsecutiveLate = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A')
                {
                    howManyTimesConsecutiveLate = 0;
                    howManyTimesAbsent++;
                    if (howManyTimesAbsent == 2)
                    {
                        return false;
                    }
                }
                else if (s[i] == 'L')
                {
                    howManyTimesConsecutiveLate++;
                    if (howManyTimesConsecutiveLate == 3)
                    {
                        return false;
                    }
                }
                else
                {
                    howManyTimesConsecutiveLate = 0;
                }
            }
            return true;
        }
        public string ReverseWords(string s)
        {
            int start = 0;
            char[] resultChars = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    if (i == s.Length - 1)
                    {
                        for (int j = start; j < start + (s.Length - start) / 2; j++)
                        {
                            char tempChar = resultChars[j];
                            resultChars[j] = resultChars[start - j + s.Length - 1];
                            resultChars[start - j + s.Length - 1] = tempChar;
                        }
                    }
                    else
                    {
                        for (int j = start; j < start + (i - start) / 2; j++)
                        {
                            char tempChar = resultChars[j];
                            resultChars[j] = resultChars[i - (j - start) - 1];
                            resultChars[i - (j - start) - 1] = tempChar;
                        }
                    }
                    start = i + 1;
                }
            }
            return new string(resultChars);
        }
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int resultDepth = 0;

            foreach (var item in root.children)
            {
                resultDepth = Math.Max(resultDepth, MaxDepth(item));
            }

            return resultDepth + 1;

        }
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int result = 0;
            while (i < nums.Length)
            {
                result += nums[i];
                i += 2;
            }
            return result;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sumVal = 0;
            int restDivinity = 0;
            ListNode result = new ListNode(0);
            ListNode current = result;
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    sumVal += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sumVal += l2.val;
                    l2 = l2.next;
                }
                if (current != null)
                {
                    sumVal = sumVal + restDivinity;
                    restDivinity = 0;
                    if (sumVal < 10)
                    {
                        current.next = new ListNode(sumVal);
                    }
                    else
                    {
                        restDivinity = 1;
                        sumVal -= 10;
                        current.next = new ListNode(sumVal);
                    }
                    current = current.next;
                }
                else
                {
                    sumVal = sumVal + restDivinity;
                    restDivinity = 0;
                    if (sumVal < 10)
                    {
                        current = new ListNode(sumVal);
                    }
                    else
                    {
                        restDivinity = 1;
                        sumVal -= 10;
                        current = new ListNode(sumVal);
                    }
                }
                sumVal = 0;
            }
            if (restDivinity != 0)
            {
                current.next = new ListNode(1);
            }
            return result.next;
        }
        public int LengthOfLongestSubstring(string s)
        {
            int lengthOfLongestSubstring = 0;
            int currlengthOfLongestSubstring = 0;
            int lengthS = s.Length;
            var currHashSet = new HashSet<char>();
            for (int i = 0; i < lengthS; i++)
            {
                currlengthOfLongestSubstring = 0;
                if (lengthOfLongestSubstring < lengthS - i || lengthOfLongestSubstring == lengthS)
                {

                    for (int j = i; j < lengthS; j++)
                    {
                        if (!currHashSet.Add(s[j]))
                        {
                            lengthOfLongestSubstring = lengthOfLongestSubstring < j - i ? j - i : lengthOfLongestSubstring;
                            break;
                        }
                        currlengthOfLongestSubstring++;
                        lengthOfLongestSubstring = lengthOfLongestSubstring < currlengthOfLongestSubstring ? currlengthOfLongestSubstring : lengthOfLongestSubstring;
                    }
                    currHashSet.Clear();
                }
                else
                {
                    break;
                }
            }

            return lengthOfLongestSubstring;
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);
            int lengthCombined = combined.Length;

            if (lengthCombined % 2 == 0)
            {
                //Console.WriteLine(combined[(lengthCombined-1) / 2]);
                //Console.WriteLine(combined[(lengthCombined-1) / 2 + 1]);
                return (double)(combined[(lengthCombined - 1) / 2] + combined[(lengthCombined - 1) / 2 + 1]) / 2;
            }
            else
            {
                return combined[lengthCombined / 2];
            }
        }
        public string LongestPalindromeMedium(string s)
        {
            int slength = s.Length;
            if (slength < 2)
            {
                if (slength < 1)
                {
                    return "";
                }
                else
                {
                    return s[0].ToString();
                }
            }

            int maxLongestPalindrome = 0;
            int currMaxLongestPalindrome = 0;
            int currStartPalindromeIndex = 0;
            int startPalindromeIndex = 0;
            int backToCurrLength = 0;

            bool palindromeStart = false;
            StringBuilder stringBuilder = new StringBuilder();

            int currlength = slength - 1;
            for (int i = 0; i < slength; i++)
            {
                palindromeStart = false;
                int tempI = i;
                currMaxLongestPalindrome = 0;
                // Console.WriteLine(s[i]);
                currlength = slength - 1;
                while (tempI <= currlength)
                {
                    if (s[tempI] == s[currlength])
                    {
                        if (!palindromeStart)
                        {
                            backToCurrLength = currlength;
                            palindromeStart = true;
                            currStartPalindromeIndex = tempI;
                        }
                        if (tempI == currlength)
                        {
                            currMaxLongestPalindrome++;
                        }
                        else
                        {
                            currMaxLongestPalindrome += 2;
                        };
                        tempI++;
                    }
                    else
                    {
                        currMaxLongestPalindrome = 0;
                        if (palindromeStart)
                        {
                            currlength = backToCurrLength;
                        }
                        palindromeStart = false;
                        tempI = i;
                    }
                    currlength--;
                }
                if (maxLongestPalindrome < currMaxLongestPalindrome)
                {
                    maxLongestPalindrome = currMaxLongestPalindrome;
                    startPalindromeIndex = currStartPalindromeIndex;
                }
            }

            return s[startPalindromeIndex..(startPalindromeIndex + maxLongestPalindrome)];
        }
        public string ConvertZigZag(string s, int numRows)
        {
            int currIndex = numRows;
            int endIndex = s.Length;
            List<string> resultList = new List<string>(numRows - 1);
            bool grow = true;
            int row = numRows - 1;
            if (endIndex < numRows)
            {
                numRows = endIndex;
                currIndex = endIndex;
            }
            if (numRows == 1)
            {
                return s;
            }
            for (int i = 0; i < numRows; i++)
            {
                resultList.Add(s[i].ToString());
            }

            while (currIndex != endIndex)
            {
                if (grow)
                {
                    row--;
                    resultList[row] += s[currIndex];
                    if (row == 0)
                    {
                        grow = false;
                    }
                }
                else
                {
                    row++;
                    resultList[row] += s[currIndex];
                    if (row == numRows - 1)
                    {
                        grow = true;
                    }
                }


                currIndex++;
            }

            return string.Join("", resultList);
        }
        public int Reverse(int x)
        {
            string stringX = x.ToString();
            char[] charX = stringX.ToCharArray();
            string resultString = string.Empty;
            int lengthX = stringX.Length;
            if (x < 0)
            {
                resultString += "-";
                for (int i = lengthX - 1; i > 0; i--)
                {
                    //char tempChar = charX[i];
                    //charX[i] = charX[lengthX - i];
                    //charX[lengthX - i] = tempChar;
                    resultString += charX[i];
                }
            }
            else
            {
                for (int i = lengthX - 1; i >= 0; i--)
                {
                    //char tempChar = charX[i];
                    //charX[i] = charX[lengthX - i - 1];
                    //charX[lengthX - i - 1] = tempChar;
                    resultString += charX[i];
                }
            }
            long resultLong = Convert.ToInt64(resultString);
            if (Int32.MaxValue <= resultLong || int.MinValue >= resultLong)
            {
                return 0;
            }
            return Convert.ToInt32(resultLong);
        }
        public int MyAtoi(string s)
        {
            int quantityToSkip = 0;
            int sLength = s.Length;
            StringBuilder sb = new StringBuilder();
            bool zeroBeforeValue = true;
            bool signBeforeValue = false;
            bool returnZero = false;
            for (int i = 0; i < sLength; i++)
            {
                if (s[i] == ' ')
                {
                    quantityToSkip++;
                }
                else
                {
                    break;
                }
            }
            if (quantityToSkip < sLength - 1)
            {
                if (s[quantityToSkip] == '-')
                {
                    sb.Append('-');
                    signBeforeValue = true;
                    quantityToSkip++;
                }
                else if (s[quantityToSkip] == '+')
                {
                    signBeforeValue = true;
                    quantityToSkip++;
                }
            }
            for (int i = quantityToSkip; i < sLength; i++)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    if (zeroBeforeValue)
                    {
                        if ((int)s[i] > 48)
                        {
                            sb.Append(s[i]);
                            zeroBeforeValue = false;
                        }
                    }
                    else
                    {
                        sb.Append(s[i]);
                    }
                }
                else
                {
                    break;
                }
            }
            if (sb.Length < 2)
            {
                if (sb.Length == 0)
                {
                    return 0;
                }
                else if ((int)sb[0] < 48 || (int)sb[0] > 57)
                {
                    return 0;
                }
                return (int)Char.GetNumericValue(sb[0]);
            }
            if (sb.Length > 11)
            {
                if (sb[0] == '-')
                {
                    return Int32.MinValue;
                }
                else
                {
                    return Int32.MaxValue;
                }
            }
            long resultLong = Convert.ToInt64(sb.ToString());
            if (resultLong > Int32.MaxValue)
            {
                resultLong = Int32.MaxValue;
            }
            else if (resultLong < Int32.MinValue)
            {
                resultLong = Int32.MinValue;
            }
            return (int)resultLong;
        }
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int howManyValues = height.Length;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int currArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
        public string IntToRoman(int num)
        {
            string[] thousands = ["", "M", "MM", "MMM"];
            string[] hundreds = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
            string[] tens = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
            string[] units = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];

            return thousands[num / 1000] + hundreds[num % 1000 / 100] + tens[num % 100 / 10] + units[num % 10];

            ///SLOW Version 

            //char[] chars = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];
            //int x = 5;
            //int transitionIndex = 0;
            //StringBuilder sb = new StringBuilder();

            //while (num != 0)
            //{
            //    int rest = num % 10;
            //    num = (num - rest) / 10;

            //    switch (rest)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 2:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 3:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 4:
            //            sb.Append(chars[1 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //        case 5:
            //            sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 6:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 7:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 8:
            //            sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[0 + transitionIndex]); sb.Append(chars[1 + transitionIndex]);
            //            break;
            //        case 9:
            //            sb.Append(chars[2 + transitionIndex]); sb.Append(chars[0 + transitionIndex]);
            //            break;
            //    }
            //    transitionIndex += 2;
            //}
            //return new string(sb.ToString().Reverse().ToArray());
        }
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            int prevInt = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (prevInt == nums[i]) continue;
                prevInt = nums[i];
                ////OR
                //if (i > 0 && nums[i] == nums[i - 1]) continue;

                if (nums[i] > 0) break;
                int leftPointer = i + 1;
                int rightPointer = nums.Length - 1;

                while (leftPointer < rightPointer)
                {
                    int sum = nums[i] + nums[leftPointer] + nums[rightPointer];
                    if (sum < 0)
                    {
                        leftPointer++;
                    }
                    else if (sum > 0)
                    {
                        rightPointer--;
                    }
                    else
                    {
                        result.Add(new List<int> { nums[i], nums[leftPointer], nums[rightPointer] });
                        leftPointer++;
                        rightPointer--;
                        while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer - 1])
                        {
                            leftPointer++;
                        }
                    }
                }
            }
            return result;
        }
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int resultSumCloset = int.MaxValue;
            int lengthNums = nums.Length;

            for (int i = 0; i < lengthNums; i++)
            {
                int leftPointerIndex = i + 1;
                int rightPointerIndex = nums.Length - 1;

                while (leftPointerIndex < rightPointerIndex)
                {
                    int currTempSum = nums[i] + nums[leftPointerIndex] + nums[rightPointerIndex];

                    if (target == currTempSum)
                    {
                        return currTempSum;
                    }
                    else if (Math.Abs(currTempSum - target) < Math.Abs(resultSumCloset - target))
                    {
                        resultSumCloset = currTempSum;
                    }

                    if (currTempSum > target)
                    {
                        rightPointerIndex--;
                    }
                    else
                    {
                        leftPointerIndex++;
                    }
                }
            }

            return resultSumCloset;
        }

        private List<string> result = new List<string>();
        private string buttonNumbers;
        private string[] lettersFromButton = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        private StringBuilder stringBuilderForResult = new StringBuilder();
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return result;
            }
            buttonNumbers = digits;

            GenerateResultDFS(0);

            return result;
        }
        public void GenerateResultDFS(int index)
        {
            if (index >= buttonNumbers.Length)
            {
                result.Add(stringBuilderForResult.ToString());
                return;
            }
            string tempCurrLettersFromButton = lettersFromButton[buttonNumbers[index] - '2'];

            foreach (char currChar in tempCurrLettersFromButton)
            {
                stringBuilderForResult.Append(currChar);
                GenerateResultDFS(index + 1);
                stringBuilderForResult.Remove(stringBuilderForResult.Length - 1, 1);
            }
        }
        ////// Traversal and other options 
        //public IList<string> LetterCombinations(string digits)
        //{
        ////// Traversal 
        //List<string> result = new List<string>();
        //if (digits.Length == 0)
        //{
        //    return result;
        //}

        //result.Add("");
        //string[] lettersFromButton = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        //foreach (char i in digits)
        //{
        //    string currLettersFromButtonChars = lettersFromButton[i - '2'];
        //    var tempList = new List<string>();
        //    foreach (string a in result)
        //    {
        //        foreach (char b in currLettersFromButtonChars)
        //        {
        //            tempList.Add(a + b);
        //        }
        //    }
        //    result = tempList;
        //}
        //return result;



        ////correct operation and solution of the task but non-responsive version - depending on the length of the input.

        //IList<string> result = new List<string>();

        //Dictionary<char, string> dictionaryNumber = new Dictionary<char, string>()
        //{ 
        //    {'2', "abc"}, {'3', "def"}, {'4', "ghi" }, {'5', "jkl"}, {'6', "mno"}, 
        //    {'7', "pqrs"}, {'8', "tuv"}, {'9',"wxyz"} 
        //};

        //int lengthDigits = digits.Length;
        //int startIndex = 0;
        //if (lengthDigits == 0) return result;
        //for (int i = 0; i < dictionaryNumber[digits[startIndex]].Length; i++)
        //{
        //    if (lengthDigits - 1 == 0)
        //    {
        //        result.Add(dictionaryNumber[digits[startIndex]][i].ToString());
        //    }
        //    else
        //    {
        //        for (int j = 0; j < dictionaryNumber[digits[startIndex + 1]].Length; j++)
        //        {
        //            if (lengthDigits - 2 == 0)
        //            {
        //                result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j]);
        //            }
        //            else
        //            {
        //                for (int k = 0; k < dictionaryNumber[digits[startIndex + 2]].Length; k++)
        //                {
        //                    if (lengthDigits - 3 == 0)
        //                    {
        //                        result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j] + dictionaryNumber[digits[startIndex + 2]][k]);
        //                    }
        //                    else
        //                    {
        //                        for (int l = 0; l < dictionaryNumber[digits[startIndex + 3]].Length; l++)
        //                        {
        //                            result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j] + dictionaryNumber[digits[startIndex + 2]][k] + dictionaryNumber[digits[startIndex + 3]][l]);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //return result;
        //}
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode result = new ListNode(0, head);
            ListNode beforePoint = result;
            ListNode afterPoint = result;

            while (0 < n--)
            {
                afterPoint = afterPoint.next;
            }

            while (afterPoint.next != null)
            {
                afterPoint = afterPoint.next;
                beforePoint = beforePoint.next;
            }

            beforePoint.next = beforePoint.next.next;
            return result.next;
        }
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();

            BacktrackingGenerateParenthesis(result, n, "", 0, 0);

            return result;
        }
        private void BacktrackingGenerateParenthesis(IList<string> result, int howManyPairs, string currStringToAddToTheResult, int numberOfOpenings, int numberOfClosed)
        {
            if (howManyPairs * 2 == currStringToAddToTheResult.Length)
            {
                result.Add(currStringToAddToTheResult);
                return;
            }

            if (numberOfOpenings < howManyPairs)
            {
                BacktrackingGenerateParenthesis(result, howManyPairs, currStringToAddToTheResult + "(", numberOfOpenings + 1, numberOfClosed);
            }

            if (numberOfOpenings > numberOfClosed)
            {
                BacktrackingGenerateParenthesis(result, howManyPairs, currStringToAddToTheResult + ")", numberOfOpenings, numberOfClosed + 1);
            }
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode mergeList = new ListNode();
            ListNode result = new ListNode(0, mergeList);

            List<int> allValue = new List<int>();

            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    allValue.Add(lists[i].val);
                    lists[i] = lists[i].next;
                }
            }

            allValue.Sort();

            foreach (int i in allValue)
            {
                mergeList.next = new ListNode(i);
                mergeList = mergeList.next;
            }

            return result.next.next;
        }
        public ListNode SwapPairs(ListNode head)
        {
            ListNode result = new ListNode(0, head);
            ListNode currResult = result;

            int firstValueToSecondPlace = 0;
            int secondValueToFirstPlace = 0;

            while (head != null)
            {
                firstValueToSecondPlace = head.val;
                head = head.next;
                if (head == null)
                {
                    result.next = new ListNode(firstValueToSecondPlace);
                    break;
                }
                secondValueToFirstPlace = head.val;
                head = head.next;
                result.next = new ListNode(secondValueToFirstPlace);
                result = result.next;
                result.next = new ListNode(firstValueToSecondPlace);
                result = result.next;
            }

            return currResult.next;
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode result = new ListNode(0, head);
            ListNode currResult = result;
            int counter = 0;
            List<int> listValueHead = new List<int>();

            while (head != null)
            {
                counter++;
                listValueHead.Add(head.val);
                head = head.next;

                if (counter == k)
                {
                    counter = 0;
                    for (int i = 0; i < k; i++)
                    {
                        result.next = new ListNode(listValueHead[k - 1 - i]);
                        result = result.next;
                    }
                    listValueHead.Clear();
                }
            }
            if (listValueHead.Count > 0)
            {
                for (int i = 0; i < listValueHead.Count; i++)
                {
                    result.next = new ListNode(listValueHead[i]);
                    result = result.next;
                }
            }

            return currResult.next;
        }


























    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Node
    {
        public int val;
        public IList <Node> children;

        //public Node() { }

        public Node(int _val)
        {
            val = _val;
            children = new List<Node>();
        }

        //public Node(int _val, IList<Node> _children)
        //{
        //    val = _val;
        //    children = _children;
        //}
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public static IList<int> TreePostorderTraversal(TreeNode root, IList<int> listRoot)
        {
            if (root == null)
            {
                return listRoot;
            }
            var leftRoot = TreePostorderTraversal(root.left, listRoot);
            var righRoot = TreePostorderTraversal(root.right, listRoot);
            listRoot.Add(root.val);
            return listRoot;
        }
        public static IList<int> TreePreorderTraversal(TreeNode root, IList<int> listRoot)
        {
            if (root == null)
            {
                return listRoot;
            }
            else
            {
                listRoot.Add(root.val);
            }
            var leftRoot = TreePreorderTraversal(root.left, listRoot);
            var righRoot = TreePreorderTraversal(root.right, listRoot);


            return listRoot;
        }
        public static bool TreeHasPathSum(TreeNode root,int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            targetSum -= root.val;
            if (root.left == null && root.right == null && targetSum == 0) 
            {
                return true;
            }
            return TreeHasPathSum(root.left, targetSum) || TreeHasPathSum(root.right, targetSum);
        }
        public static int TreeMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var leftDepth = TreeMaxDepth(root.left);
            var rightDepth = TreeMaxDepth(root.right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
        public static int TreeMinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            if (root.left == null)
            {
                return TreeMinDepth(root.right) + 1;
            }
            if (root.right == null)
            {
                return TreeMinDepth(root.left) + 1;
            }
            return Math.Min(TreeMinDepth(root.left), TreeMinDepth(root.right))+1;
        }

        public static bool TreeNodeRootIsSymmetric(bool boolValue, TreeNode leftRoot, TreeNode rightRoot)
        { 
            if (leftRoot.left != null || rightRoot.right != null)
            {
                if (leftRoot.left != null && rightRoot.right != null)
                {
                    if (leftRoot.left.val == rightRoot.right.val)
                    {
                        boolValue = TreeNodeRootIsSymmetric(boolValue, leftRoot.left, rightRoot.right);
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
            if (leftRoot.right != null || rightRoot.left != null)
            {
                if (leftRoot.right != null && rightRoot.left != null)
                {
                    if (leftRoot.right.val == rightRoot.left.val)
                    {
                        boolValue = TreeNodeRootIsSymmetric(boolValue, leftRoot.right, rightRoot.left);
                    }
                    else
                    {
                        return false;
                    }
                }
                else { return false; }
            }
            return boolValue;
        }
        public static bool TreeNodeIsSameTree(bool boolValue, TreeNode q, TreeNode p)
        {
            if (q.left != null && p.left != null)
            {
                if (q.left.val == p.right.val)
                {
                    boolValue = TreeNodeIsSameTree(boolValue, q.left, p.left);
                }
                else 
                {
                    return false; 
                }
            }
            else
            {
                if (q.left == null && p.left == null)
                { }
                else
                {
                    return false;
                }
            }
            if (q.right != null && p.right != null)
            {
                if (q.right.val == p.right.val) 
                {
                    boolValue = TreeNodeIsSameTree(boolValue, q.right, p.right);
                }
                else 
                { 
                    return false; 
                }
            }
            else
            {
                if (q.right == null && p.right == null)
                { }
                else
                {
                    return false;
                }
            }
            return boolValue;

        }
        public static IList<int> InTree(IList<int> resultList, TreeNode root)
        {
            if (root.left != null)
            {
                resultList = InTree(resultList, root.left);
            }
            resultList.Add(root.val);
            if (root.right != null)
            {
                resultList = InTree(resultList, root.right);
            }
            return resultList;
        }
    }
}


