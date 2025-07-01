using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
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
        public int Divide(long dividend, long divisor)
        {
            int quotient = 0;
            bool divisiorOne = false;
            bool isPositive = dividend > 0 && divisor > 0 || dividend < 0 && divisor < 0;
            divisor = Math.Abs(divisor);
            dividend = Math.Abs(dividend);
            long copydiVidend = dividend;
            if (divisor != 1 && divisor != -1)
            {
                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    quotient++;
                }
            }
            else
            {
                divisiorOne = true;
            }
            if (isPositive)
            {
                if (divisiorOne)
                {
                    if (copydiVidend >= 2147483648)
                    {
                        return int.MaxValue;
                    }
                    else if (copydiVidend <= -2147483648)
                    {
                        return 2147483647;
                    }
                    return (int)copydiVidend;
                }
                if (quotient >= 2147483648)
                {
                    return int.MaxValue;
                }
                else if (quotient <= -2147483648)
                {
                    return 2147483647;
                }
                return (int)quotient;
            }
            else
            {
                if (divisiorOne)
                {
                    if (copydiVidend <= -2147483648)
                    {
                        return -2147483648;
                    }
                    return (int)copydiVidend - (int)copydiVidend - (int)copydiVidend;
                }
                quotient = quotient - quotient - quotient;
                if (quotient <= -2147483648)
                {
                    return -2147483648;
                }
                return (int)quotient;
            }
        }
        public IList<int> FindSubstring(string s, string[] words)
        {
            int howLongWord = words[0].Length;
            int howManyWords = words.Length;
            int totalLengthCombineWords = howLongWord * howManyWords;

            int slength = s.Length;

            List<int> result = new List<int>();

            if (totalLengthCombineWords > slength)
            {
                return result;
            }

            Dictionary<string, int> dictionaryWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                dictionaryWords[word] = dictionaryWords.GetValueOrDefault(word, 0) + 1;
            }

            if (dictionaryWords.Count == 1 && slength > 100)
            {
                Dictionary<char, int> tempDictionaryS = new Dictionary<char, int>();
                foreach (char item in s)
                {
                    tempDictionaryS[item] = tempDictionaryS.GetValueOrDefault(item, 0) + 1;
                }

                if (tempDictionaryS.Count == 1)
                {
                    if (s[0] == words[0][0])
                    {
                        int tempDictionaryDiff = tempDictionaryS[s[0]] - dictionaryWords[words[0]];
                        int x = -1;
                        while (x++ < tempDictionaryDiff)
                        {
                            result.Add(x);
                        }
                    }
                    return result;
                }
            }



            for (int i = 0; i <= slength - totalLengthCombineWords; i++)
            {
                Dictionary<string, int> tempDictionaryWords = new Dictionary<string, int>(dictionaryWords);

                int tempHowManyWords = howManyWords;

                int currIndexWithWords = i;

                while (currIndexWithWords < i + totalLengthCombineWords)
                {
                    string currWordFromS = s.Substring(currIndexWithWords, howLongWord);

                    if (!tempDictionaryWords.ContainsKey(currWordFromS) || tempDictionaryWords[currWordFromS] == 0)
                    {
                        break;
                    }
                    else
                    {
                        tempDictionaryWords[currWordFromS] -= 1;
                        tempHowManyWords--;
                    }
                    currIndexWithWords += howLongWord;
                    if (tempHowManyWords == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
        public void NextPermutation(int[] nums)
        {
            int countNums = nums.Length;
            bool noChanges = true;
            if (countNums > 1)
            {
                int lastIndexValue = nums.Length - 1;

                int maxValue = nums[lastIndexValue];
                int indexMaxValue = lastIndexValue;

                int minValue = nums[lastIndexValue];
                int indexMinValue = lastIndexValue;
                int howManyNoChanges = 0;
                bool newMinValue = false;
                bool none = false;

                for (int i = lastIndexValue - 1; i >= 0; i--)
                {
                    if (nums[i + 1] > nums[i])
                    {
                        if (nums[i + 1] >= maxValue)
                        {
                            maxValue = nums[i + 1];
                            indexMaxValue = i + 1;
                            for (int j = lastIndexValue; j >= i; j--)
                            {
                                if (nums[i] < nums[j])
                                {
                                    if (nums[j] <= maxValue)
                                    {
                                        minValue = nums[j];
                                        indexMaxValue = j;
                                        none = true;
                                    }
                                }
                            }
                        }
                        noChanges = false;
                        if (howManyNoChanges > 0 && none)
                        {
                            for (int j = lastIndexValue; j >= i; j--)
                            {
                                if (nums[i] < nums[j])
                                {
                                    if (nums[j] <= minValue)
                                    {
                                        minValue = nums[j];
                                        indexMinValue = j;
                                        newMinValue = true;
                                    }
                                }
                            }
                            if (newMinValue)
                            {
                                nums[indexMinValue] = nums[i];
                                nums[i] = minValue;
                                Array.Sort(nums, i + 1, lastIndexValue - i);
                                break;
                            }
                        }
                        nums[indexMaxValue] = nums[i];
                        nums[i] = maxValue;
                        Array.Sort(nums, i + 1, countNums - (i + 1));
                        break;
                    }
                    else
                    {
                        howManyNoChanges++;
                    }
                }
                if (noChanges)
                {
                    Array.Sort(nums);
                }
                Console.WriteLine(string.Join(',', nums));
            }
        }
        public int LongestValidParentheses(string s)
        {
            ////"(()"
            //// string s = ")()())"; 
            int maxValue = 0;
            int maxValueFromBehind = 0;
            int leftBracket = 0;
            int leftBracketFromBehind = 0;
            int rightBracket = 0;
            int rightBracketFromBehind = 0;
            int lastIndexS = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    leftBracket++;
                }
                else
                {
                    rightBracket++;
                }
                if (leftBracket == rightBracket)
                {
                    maxValue = Math.Max(maxValue, rightBracket * 2);
                }
                else if (rightBracket > leftBracket)
                {
                    leftBracket = rightBracket = 0;
                }

                if (s[lastIndexS - i] == '(')
                {
                    leftBracketFromBehind++;
                }
                else
                {
                    rightBracketFromBehind++;
                }
                if (leftBracketFromBehind == rightBracketFromBehind)
                {
                    maxValueFromBehind = Math.Max(maxValueFromBehind, leftBracketFromBehind * 2);
                }
                else if (leftBracketFromBehind > rightBracketFromBehind)
                {
                    leftBracketFromBehind = rightBracketFromBehind = 0;
                }
            }
            return Math.Max(maxValue, maxValueFromBehind);
        }
        public int Search(int[] nums, int target)
        {
            int length = nums.Length;
            int start = 0;
            int stop = length - 1;

            while (start < stop)
            {
                int middle = (start + stop) / 2;

                if (nums[start] <= nums[middle])
                {
                    if (nums[start] <= target && nums[middle] >= target)
                    {
                        stop = middle;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
                else
                {
                    if (nums[middle] < target && target <= nums[length - 1])
                    {
                        start = middle + 1;
                    }
                    else
                    {
                        stop = middle;
                    }
                }
            }
            if (nums[start] == target)
            {
                return start;
            }
            else
            {
                return -1;
            }
        }
        public int[] SearchRange(int[] nums, int target)
        {
            int leftBracketIndex = BracketSearchIndex(nums, target);
            int rightBracketIndex = BracketSearchIndex(nums, target + 1);

            if (leftBracketIndex == rightBracketIndex)
            {
                return new int[] { -1, -1 };
            }
            else
            {
                return new int[] { leftBracketIndex, rightBracketIndex - 1 };
            }

            ////Alternative -- function available via list: indexOf/LastIndexOf
            //List<int> listNums = nums.ToList();

            //return new int[] { listNums.IndexOf(target), listNums.LastIndexOf(target) };

        }
        private int BracketSearchIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length;

            while (left < right)
            {
                int middle = (left + right) / 2;

                if (nums[middle] >= target)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }

            }

            return left;
        }
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int countMat = mat.Length;
            //Console.WriteLine(countMat);
            int lengthMat = mat[0].Length;

            if (countMat * lengthMat != r * c)
            {
                return mat;
            }
            int[][] resultTable = new int[r][];

            int currR = 0;
            int currC = 0;

            for (int i = 0; i < r; i++)
            {
                int[] currTable = new int[c];
                for (int j = 0; j < c; j++)
                {
                    currTable[j] = mat[currR][currC];
                    currC++;
                    if (currC == lengthMat)
                    {
                        currR++;
                        currC = 0;
                    }
                }
                resultTable[i] = currTable;
            }
            return resultTable;
        }
        public int DistributeCandies(int[] candyType)
        {
            int length = candyType.Length;
            int maxEat = length / 2;

            HashSet<int> hashSetValues = candyType.ToHashSet();

            int numberOfDifferent = hashSetValues.Count;

            if (numberOfDifferent > maxEat)
            {
                return maxEat;
            }

            return numberOfDifferent;
        }
        public void LeetCode_577()
        {
            ////(577.) Employee Bonus (EASY)

            ////T-SQL query CODE - MS SQL */

            //SELECT
            //    b.name,
            //    a.bonus
            //From Bonus as a
            //right Join Employee as b
            //On a.empId = b.empId
            //where a.bonus< 1000 or a.bonus is null
        }
        public void LeetCode_584()
        {
            ////(584.) Find Customer Referee (EASY)

            ////T-SQL query CODE - MS SQL */

            //Select
            //    name
            //From Customer
            //Where referee_id != 2 or referee_id is null
        }
        public void LeetCode_586()
        {
            ////(586.) Customer Placing the Largest Number of Orders (EASY)

            ////T-SQL query CODE - MS SQL */

            //SELECT
            //customer_number
            //FROM
            //    (
            //        Select
            //        customer_number,
            //        (customer_number) as countCustomer
            //        From Orders
            //        Group BY customer_number
            //    ) as a
            //WHERE countCustomer = (
            //                        Select
            //                        max(countCustomer)
            //                        FROM
            //                        (Select
            //                        customer_number,
            //                        COUNT(customer_number) as countCustomer
            //                        From Orders
            //                        Group BY customer_number
            //                      ) as b)
        }
        public int FindLHS(int[] nums)
        {
            ////Dictionary method
            var dictionaryNums = new Dictionary<int, int>();
            var result = 0;

            foreach (int num in nums)
            {
                //if (!dictionaryNums.TryAdd(num, 1))
                //{
                //    dictionaryNums[num]++;
                //}
                if (dictionaryNums.ContainsKey(num))
                {
                    dictionaryNums[num]++;
                }
                else
                {
                    dictionaryNums.Add(num, 1);
                }
            }

            foreach (int key in dictionaryNums.Keys)
            {
                if (dictionaryNums.ContainsKey(key + 1))
                {
                    result = Math.Max(result, dictionaryNums[key] + dictionaryNums[key + 1]);
                }
            }

            return result;

            //////SORT Method:
            //Array.Sort(nums);
            //int length = nums.Length;
            //bool saveToResult = false;
            //int currValueFirst = nums[0];
            //int countSecondValue = 0;
            //int currValueTwo = int.MinValue;
            //int result = 0;
            //int currMax = 1;
            //bool inLoop = false;

            //for (int i = 1; i < length; i++)
            //{
            //    //Console.WriteLine(nums[i]);
            //    if (currValueFirst == nums[i] || currValueFirst + 1 == nums[i])
            //    {
            //        inLoop = true;
            //        currMax++;
            //        if (currValueFirst + 1 == nums[i])
            //        {
            //            saveToResult = true;
            //            currValueTwo = nums[i];
            //            countSecondValue++;
            //        }
            //        if (saveToResult)
            //        {
            //            result = result < currMax ? currMax : result;   
            //        }
            //    }
            //    else 
            //    {
            //        if (nums[i]-1 == nums[i-1])
            //        {
            //            if (countSecondValue > 0)
            //            {
            //                currMax = countSecondValue + 1;
            //            }
            //            else
            //            {
            //                currMax = 1;
            //            }
            //            if (inLoop == false)
            //            {
            //                currValueFirst = nums[i];
            //                countSecondValue = 0;
            //            }
            //            else
            //            {
            //                if (!saveToResult)
            //                {
            //                    currValueFirst = nums[i-1];
            //                }
            //                else
            //                {
            //                    currValueFirst = currValueTwo;
            //                }
            //                countSecondValue = 1;
            //            }
            //            if (nums[i] == nums[i] - 1)
            //            {
            //                saveToResult = true;
            //            }
            //            else
            //            {
            //                saveToResult = false;
            //            }
            //        }
            //        else
            //        {
            //            saveToResult = false;
            //            currValueFirst = nums[i];
            //            countSecondValue = 0;
            //            inLoop = false;
            //            currMax = 1;
            //        }
            //    }     
            //}

            //if (length == 1)
            //{
            //    return 0;
            //}
            //return result;
        }
        public void LeetCode_595()
        {
            ////(595.) Big Countries (EASY)

            ////T-SQL query CODE - MS SQL */

            //Select
            //    [name],
            //    [population],
            //    [area]
            //From World
            //Where[population] >= 25000000 or[area] >= 3000000
        }
        public void LeetCode_596()
        {
            ////(596.) Classes More Than 5 Students (EASY)

            ////T-SQL query CODE - MS SQL */

            //Select
            //    [class]
            //FROM(
            //     Select
            //        [class],
            //        COUNT([class]) as [howMany]
            //     From Courses
            //     Group by[class] ) as a
            //Where[howMany] >= 5


            ////OR 

            //Select
            //    [class]
            //FROM Courses
            //GROUP BY class
            //HAVING COUNT(DISTINCT student) >= 5

        }
        public int MaxCount(int m, int n, int[][] ops)
        {
            int opsLength = ops.Length;

            if (opsLength == 0)
            {
                return m * n;
            }

            int minM = int.MaxValue;
            int minN = int.MaxValue;

            for (int i = 0; i < opsLength; i++)
            {
                if (ops[i][0] < minM)
                {
                    minM = ops[i][0];
                }
                if (ops[i][1] < minN)
                {
                    minN = ops[i][1];
                }
                ////Console.WriteLine(string.Join(',', ops[i]));
            }
            return minN * minM;
        }
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dictionaryList = new Dictionary<string, int>();

            int lengthList1 = list1.Length;
            int lengthList2 = list2.Length;
            int loopMaxLength = lengthList1 > lengthList2 ? lengthList1 : lengthList2;
            int minSumIndex = int.MaxValue;
            Dictionary<string, int> dictionaryListSUM = new Dictionary<string, int>();

            for (int i = 0; i < loopMaxLength; i++)
            {
                if (i < lengthList1)
                {
                    if (dictionaryList.ContainsKey(list1[i]))
                    {
                        dictionaryListSUM.Add(list1[i], dictionaryList[list1[i]] + i);
                        minSumIndex = minSumIndex < dictionaryList[list1[i]] + i ? minSumIndex : dictionaryList[list1[i]] + i;
                    }
                    else
                    {
                        dictionaryList.Add(list1[i], i);
                    }
                }
                if (i < lengthList2)
                {
                    if (dictionaryList.ContainsKey(list2[i]))
                    {
                        dictionaryListSUM.Add(list2[i], dictionaryList[list2[i]] + i);
                        minSumIndex = minSumIndex < dictionaryList[list2[i]] + i ? minSumIndex : dictionaryList[list2[i]] + i;
                    }
                    else
                    {
                        dictionaryList.Add(list2[i], i);
                    }
                }
            }
            List<string> resultList = new List<string>();

            foreach (var item in dictionaryListSUM)
            {
                if (item.Value == minSumIndex)
                {
                    resultList.Add(item.Key);
                }
            }
            return resultList.ToArray();
        }
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            bool firstEmpty = flowerbed[0] == 0 ? true : false;
            int emptyDistance = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1)
                {
                    if (firstEmpty)
                    {
                        n -= emptyDistance / 2;
                        emptyDistance = 0;
                        firstEmpty = false;
                    }
                    else
                    {
                        if (emptyDistance >= 3)
                        {
                            while (emptyDistance >= 3)
                            {
                                --n;
                                emptyDistance -= 2;
                            }
                            //n -= emptyDistance / 3;                       
                        }
                        emptyDistance = 0;
                    }
                }
                else
                {
                    emptyDistance++;
                    if (i >= 1 && firstEmpty)
                    {
                        emptyDistance = 1;
                        --n;
                        firstEmpty = false;
                    }
                }
                if (n <= 0)
                {
                    return true;
                }
            }
            if (emptyDistance > 0 && firstEmpty)
            {
                if (flowerbed.Length == 1)
                {
                    return true;
                }
            }
            if (emptyDistance >= 2)
            {
                n -= emptyDistance / 2;
                if (n <= 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void LeetCode_607()
        {
            ////(607.) Sales Person (EASY)

            ////T-SQL query CODE - MS SQL */

            //Select
            //    a.name
            //    FROM SalesPerson as a
            //    Where sales_id NOT IN
            //                       (Select
            //                            a.sales_id
            //                        FROM Orders as a
            //                        INNER JOIN Company as b
            //                        ON b.com_id = a.com_id
            //                        Where b.name = 'RED')
        }
        public void LeetCode_610()
        {
            ////(610.) Triangle Judgement (EASY)

            ////T-SQL query CODE - MS SQL */

            //SELECT
            //    x,
            //    y,
            //    z,
            //    iif(x+y>z and x+z > y and y+z>x, 'Yes', 'No') as triangle
            //FROM Triangl

        }
        public void LeetCode_619()
        {
            ////(619.) Biggest Single Number (EASY)

            ////T-SQL query CODE - MS SQL */

            //SELECT
            //    max(num) as num
            //FROM(
            //    SELECT
            //        num
            //    FROM MyNumbers
            //    GROUP BY num
            //    HAVING count(num) = 1
            //    ) as a

        }
        public void LeetCode_620()
        {
            ////(620.) Not Boring Movies (EASY)

            ////T-SQL query CODE - MS SQL */

            //SELECT
            //    id,
            //    movie,
            //    description,
            //    rating
            //FROM Cinema
            //Where description != 'boring' and id%2=1
            //order by rating desc

        }
        public void LeetCode_627()
        {
            ////(627.) Swap Salary (EASY)

            ////T-SQL query CODE - MS SQL */

            //UPDATE Salary
            //SET
            //sex = IIf(sex = 'm', 'f', 'm')

        }
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int legth = nums.Length;

            int value1 = nums[0];
            int value2 = nums[1];
            int value3 = nums[legth - 1];
            if (legth > 3)
            {
                if (value3 >= 0)
                {
                    if (Math.Abs(value2) + Math.Abs(value1) > nums[legth - 3] + nums[legth - 2])
                    {
                        return Math.Abs(value2) * Math.Abs(value1) * value3;
                    }
                    else
                    {
                        return nums[legth - 1] * nums[legth - 2] * nums[legth - 3];
                    }
                }
                else
                {
                    return nums[legth - 1] * nums[legth - 2] * nums[legth - 3];
                }
            }
            else
            {
                return value1 * value2 * value3;
            }
        }
        public double FindMaxAverage(int[] nums, int k)
        {
            int length = nums.Length;
            double result = 0;

            for (int i = 0; i < k; i++)
            {
                result += nums[i];
            }

            double maxAverage = result;

            for (int i = k; i < length; i++)
            {
                result += nums[i];
                result -= nums[i - k];

                maxAverage = maxAverage < result ? result : maxAverage;
            }

            return maxAverage / k;
        }
        public int[] FindErrorNums(int[] nums)
        {

            int resultDuplicate = 0;

            foreach (int num in nums)
            {
                if (nums[Math.Abs(num) - 1] < 0)
                {
                    resultDuplicate = Math.Abs(num);
                }
                else
                {
                    nums[Math.Abs(num) - 1] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return new int[] { resultDuplicate, i + 1 };
                }
            }
            return new int[] { };

        }
        public bool JudgeCircle(string moves)
        {
            int leftRight = 0;
            int topBottom = 0;
            foreach (char currChar in moves)
            {
                switch (currChar)
                {
                    case 'U':
                        topBottom++;
                        break;
                    case 'D':
                        topBottom--;
                        break;
                    case 'R':
                        leftRight++;
                        break;
                    case 'L':
                        topBottom--;
                        break;
                }
            }
            if (leftRight == 0 && topBottom == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int[][] ImageSmoother(int[][] img)
        {
            int count = img.Length;
            int length = img[0].Length;
            int[][] result = new int[count][];
            if (count == 0)
            {
                return img;
            }
            int currIndexCount = 0;
            int currIndexLength = 0;
            result[currIndexCount] = new int[length];
            while (currIndexLength < length)
            {
                if (currIndexLength == 0)
                {
                    if (count > 1)
                    {
                        if (currIndexLength + 1 < length)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength] + img[currIndexCount][currIndexLength + 1] + img[currIndexCount + 1][currIndexLength + 1]) / 4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength]) / 2;
                        }
                    }
                    else
                    {
                        if (currIndexLength < length - 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount][currIndexLength + 1]) / 2;
                        }
                        else
                        {
                            if (length == 1 && count == 1)
                            {
                                return img;
                            }
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]);
                        }
                    }
                }
                else if (currIndexLength == length - 1)
                {
                    if (count > 1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength] + img[currIndexCount][currIndexLength - 1] + img[currIndexCount + 1][currIndexLength - 1]) / 4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength]) / 2;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount][currIndexLength - 1]) / 2;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = img[currIndexCount][currIndexLength];
                        }
                    }
                }
                else
                {
                    if (count > 1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength] + img[currIndexCount][currIndexLength + 1] + img[currIndexCount + 1][currIndexLength + 1] + img[currIndexCount + 1][currIndexLength - 1] + img[currIndexCount][currIndexLength - 1]) / 6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength]) / 2;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount][currIndexLength - 1] + img[currIndexCount][currIndexLength + 1]) / 3;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength]);
                        }
                    }
                }
                currIndexLength++;
            }
            currIndexCount++;
            while (currIndexCount < count - 1)
            {
                result[currIndexCount] = new int[length];
                currIndexLength = 0;
                while (currIndexLength < length)
                {
                    if (currIndexLength == 0)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount + 1][currIndexLength] + img[currIndexCount - 1][currIndexLength] +
                                img[currIndexCount - 1][currIndexLength + 1] + img[currIndexCount][currIndexLength + 1] + img[currIndexCount + 1][currIndexLength + 1]) / 6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] + img[currIndexCount + 1][currIndexLength]) / 3;
                        }
                    }
                    else if (currIndexLength == length - 1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] + img[currIndexCount + 1][currIndexLength]
                                + img[currIndexCount - 1][currIndexLength - 1] + img[currIndexCount][currIndexLength - 1] + img[currIndexCount + 1][currIndexLength - 1]) / 6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] + img[currIndexCount + 1][currIndexLength]) / 3;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] + img[currIndexCount + 1][currIndexLength] +
                                img[currIndexCount - 1][currIndexLength - 1] + img[currIndexCount][currIndexLength - 1] + img[currIndexCount + 1][currIndexLength - 1] +
                                img[currIndexCount - 1][currIndexLength + 1] + img[currIndexCount + 1][currIndexLength + 1] + img[currIndexCount][currIndexLength + 1]) / 9;
                        }
                    }
                    currIndexLength++;
                }

                currIndexCount++;
            }
            while (currIndexCount == count - 1 && currIndexCount > 0)
            {
                result[currIndexCount] = new int[length];
                currIndexLength = 0;
                while (currIndexLength < length)
                {
                    if (currIndexLength == 0)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] +
                                img[currIndexCount][currIndexLength + 1] + img[currIndexCount - 1][currIndexLength + 1]) / 4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength]) / 2;
                        }
                    }
                    else if (currIndexLength == length - 1)
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength] +
                                img[currIndexCount][currIndexLength - 1] + img[currIndexCount - 1][currIndexLength - 1]) / 4;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength]) / 2;
                        }
                    }
                    else
                    {
                        if (length > 1)
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount][currIndexLength + 1] +
                                img[currIndexCount][currIndexLength - 1] + img[currIndexCount - 1][currIndexLength - 1] + img[currIndexCount - 1][currIndexLength] +
                                img[currIndexCount - 1][currIndexLength + 1]) / 6;
                        }
                        else
                        {
                            result[currIndexCount][currIndexLength] = (img[currIndexCount][currIndexLength] + img[currIndexCount - 1][currIndexLength]) / 2;
                        }
                    }
                    currIndexLength++;
                }
                currIndexCount++;
            }

            return result;
        }
        public int FindLengthOfLCIS(int[] nums)
        {
            int maxContinuousIncreasingSubsequence = 1;
            int currValue = nums[0];
            int currContinuousIncreasingSubsequence = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (currValue < nums[i])
                {
                    currContinuousIncreasingSubsequence++;
                    currValue = nums[i];
                }
                else
                {
                    maxContinuousIncreasingSubsequence = maxContinuousIncreasingSubsequence < currContinuousIncreasingSubsequence ? currContinuousIncreasingSubsequence : maxContinuousIncreasingSubsequence;
                    currContinuousIncreasingSubsequence = 1;
                    currValue = nums[i];
                }
            }

            maxContinuousIncreasingSubsequence = maxContinuousIncreasingSubsequence < currContinuousIncreasingSubsequence ? currContinuousIncreasingSubsequence : maxContinuousIncreasingSubsequence;
            return maxContinuousIncreasingSubsequence;
        }
        public bool ValidPalindrome(string s)
        {
            int leftIndex = 0;
            int rightIndex = s.Length - 1;
            bool boolDeleting = false;

            while (leftIndex < rightIndex)
            {
                if (s[leftIndex] == s[rightIndex])
                {
                    leftIndex++;
                    rightIndex--;
                }
                else
                {
                    if (boolDeleting)
                    {
                        return false;
                    }
                    if (s[leftIndex + 1] == s[rightIndex])
                    {
                        int currLeft = leftIndex + 1;
                        int currRigt = rightIndex;
                        bool currFalse = false;
                        while (currLeft < currRigt)
                        {
                            if (s[currLeft] == s[currRigt])
                            {
                                currLeft++;
                                currRigt--;
                            }
                            else
                            {
                                currFalse = true;
                                break;
                            }
                        }
                        if (currFalse)
                        {
                            if ((s[leftIndex] == s[rightIndex - 1]))
                            {

                                boolDeleting = true;
                                rightIndex--;
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        //boolDeleting = true;
                        //leftIndex++;
                    }
                    else if ((s[leftIndex] == s[rightIndex - 1]))
                    {
                        boolDeleting = true;
                        rightIndex--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public int CalPoints(string[] operations)
        {
            List<int> listRecords = new List<int>();
            foreach (string item in operations)
            {
                switch (item)
                {
                    case "D":
                        listRecords.Add(listRecords[listRecords.Count - 1] * 2);
                        break;

                    case "C":
                        listRecords.RemoveAt(listRecords.Count - 1);
                        break;
                    case "+":
                        listRecords.Add(listRecords[listRecords.Count - 1] + listRecords[listRecords.Count - 2]);
                        break;
                    default:
                        listRecords.Add(Int32.Parse(item));
                        break;
                }
            }
            int result = 0;
            foreach (int record in listRecords)
            {
                result += record;
            }
            return result;
            //// for a slow solution
            // result listRecords.SUM()
        }
        public bool HasAlternatingBits(int n)
        {
            string x = Convert.ToString(n, 2);
            char target = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] == target)
                {
                    return false;
                }
                else
                {
                    target = x[i];
                }
            }

            return true;
        }
        public int CountBinarySubstrings(string s)
        {
            int result = 0;
            int howManyZeroCont = 0;
            int howManyOneCont = 0;
            char lastChar = s[0];

            if (s[0] == '1')
            {
                lastChar = '1';
                howManyZeroCont++;
            }
            else
            {
                lastChar = '0';
                howManyOneCont++;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (lastChar == s[i])
                {
                    if (lastChar == '1')
                    {
                        if (howManyOneCont == 0)
                        {
                            howManyOneCont += 2;
                        }
                        else
                        {
                            howManyOneCont++;
                        }
                        if (howManyOneCont <= howManyZeroCont && howManyOneCont > 1 && howManyZeroCont > 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        if (howManyZeroCont == 0)
                        {
                            howManyZeroCont += 2;
                        }
                        else
                        {
                            howManyZeroCont++;
                        }
                        if (howManyZeroCont <= howManyOneCont && howManyOneCont > 1 && howManyZeroCont > 1)
                        {
                            result++;
                        }
                    }
                }
                else
                {
                    result++;
                    if (lastChar == '1')
                    {
                        howManyZeroCont = 1;
                    }
                    else
                    {
                        howManyOneCont = 1;
                    }
                    lastChar = s[i];
                }
            }

            return result;
        }
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int> dictNumsCount = new Dictionary<int, int>();
            Dictionary<int, int> dictNumsFirstIndex = new Dictionary<int, int>();
            Dictionary<int, int> dictNumsLastIndex = new Dictionary<int, int>();

            int result = int.MaxValue;
            int maxCount = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictNumsCount.ContainsKey(nums[i]))
                {
                    dictNumsCount[nums[i]]++;
                    dictNumsLastIndex[nums[i]] = i;
                    maxCount = Math.Max(maxCount, dictNumsCount[nums[i]]);
                    //maxCount = maxCount < dictNumsCount[nums[i]] ? dictNumsCount[nums[i]] : maxCount;
                }
                else
                {
                    dictNumsFirstIndex.Add(nums[i], i);
                    dictNumsCount.Add(nums[i], 1);
                    dictNumsLastIndex.Add(nums[i], i);
                }
            }

            foreach (var item in dictNumsCount)
            {
                if (item.Value == maxCount)
                {
                    result = Math.Min(result, dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1);
                    //result = result > dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1? dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1 : result;
                }
            }

            return result;
        }
        public class KthLargest1
        {
            private int k { get; set; }
            private PriorityQueue<int, int> priorityQueue { get; set; }

            public KthLargest1(int k, int[] nums)
            {
                this.k = k;
                priorityQueue = new PriorityQueue<int, int>();

                foreach (var num in nums)
                {
                    Add(num);
                }
            }

            public int Add(int val)
            {
                priorityQueue.Enqueue(val, val);

                while (priorityQueue.Count > this.k)
                {
                    priorityQueue.Dequeue();
                }

                return priorityQueue.Peek();
            }
        }
        public int Search704(int[] nums, int target)
        {
            int length = nums.Length;
            int left = 0;
            int right = length - 1;

            while (left < right)
            {
                int targetIndex = left + (right - left) / 2;
                if (target > nums[targetIndex])
                {
                    left = targetIndex + 1;
                }
                else
                {
                    right = targetIndex;
                }
            }
            if (nums[left] == target)
            {
                return left;
            }
            return -1;

        }
        public class MyHashSet1
        {
            private HashSet<int> _hashset;
            public MyHashSet1()
            {
                _hashset = new HashSet<int>();
            }

            public void Add(int key)
            {
                _hashset.Add(key);
            }

            public void Remove(int key)
            {
                _hashset.Remove(key);
            }

            public bool Contains(int key)
            {
                if (_hashset.Contains(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class MyHashMap1
        {
            private Dictionary<int, int> _dictionaryKeyValue;
            public MyHashMap1()
            {
                _dictionaryKeyValue = new Dictionary<int, int>();
            }

            public void Put(int key, int value)
            {
                if (_dictionaryKeyValue.ContainsKey(key))
                {
                    _dictionaryKeyValue[key] = value;
                }
                else
                {
                    _dictionaryKeyValue.Add(key, value);
                }
            }

            public int Get(int key)
            {
                if (_dictionaryKeyValue.ContainsKey(key))
                {
                    return _dictionaryKeyValue[key];
                }
                else
                {
                    return -1;
                }
            }

            public void Remove(int key)
            {
                if (_dictionaryKeyValue.ContainsKey(key))
                {
                    _dictionaryKeyValue.Remove(key);
                }
            }
        }
        public string ToLowerCase(string s)
        {
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char temp = s[i];
                if ('A' <= temp && 'Z' >= temp)
                {
                    result[i] = (char)(temp + 32);
                }
                else
                {
                    result[i] = temp;
                }
            }
            return new string(result);

            //slow option
            //return s.ToLower();
        }
        public bool IsOneBitCharacter(int[] bits)
        {
            int lenght = bits.Length - 1;

            if (bits[lenght] == 1)
            {
                return false;
            }
            int howManyRest = lenght;

            for (int i = 0; i < lenght; i++)
            {
                if (bits[i] == 1)
                {
                    i++;
                    if (i == lenght)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public int PivotIndex(int[] nums)
        {
            int sumNums = 0;
            foreach (int num in nums)
            {
                sumNums += num;
            }
            int sumLeft = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumNums -= nums[i];
                if (sumLeft == sumNums)
                {
                    return i;
                }
                sumLeft += nums[i];
            }

            return -1;
        }
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> result = new List<int>();

            for (int i = left; i <= right; i++)
            {
                bool notDividing = false;
                int currLeft = i;
                int currI = i;
                while (currLeft > 0)
                {
                    currI = currLeft % 10;
                    currLeft = (currLeft - currI) / 10;
                    if (currI == 0)
                    {
                        notDividing = true;
                        break;
                    }
                    if (i % currI != 0)
                    {
                        notDividing = true;
                        break;
                    }

                }
                if (!notDividing)
                {
                    result.Add(i);
                }
            }

            return result;
        }
       
        private int _height733;
        private int _width733;
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            _height733 = image.Length;
            _width733 = image[0].Length;

            if (image[sr][sc] != color)
            {
                Fill733(image, sr, sc, image[sr][sc], color);
            }

            return image;
        }
        private void Fill733(int[][] image, int sr, int sc, int previousColor, int newColor)
        {
            if (sr >= 0 && sc >= 0 && sr < _height733 && sc < _width733)
            {
                if (image[sr][sc] == previousColor)
                {
                    image[sr][sc] = newColor;
                    Fill733(image, sr + 1, sc, previousColor, newColor);
                    Fill733(image, sr - 1, sc, previousColor, newColor);
                    Fill733(image, sr, sc + 1, previousColor, newColor);
                    Fill733(image, sr, sc - 1, previousColor, newColor);
                }
            }
        }
        public char NextGreatestLetter(char[] letters, char target)
        {
            int length = letters.Length;
            int left = 0;
            int right = length;

            if (letters[length - 1] < target)
            {
                return letters[0];
            }

            while (left < right)
            {
                int temp = left + (right - left) / 2;
                if (letters[temp] > target)
                {
                    right = temp;
                }
                else
                {
                    left = temp + 1;
                }
            }

            return letters[right];
        }
        public int MinCostClimbingStairs(int[] cost)
        {
            int startIndex0 = cost[0];
            int startIndex1 = cost[1];
            int minStepCost = 0;

            for (int i = 2; i < cost.Length; i++)
            {
                minStepCost = cost[i] + Math.Min(startIndex0, startIndex1);

                startIndex0 = startIndex1;
                startIndex1 = minStepCost;

            }

            return Math.Min(startIndex0, startIndex1);
        }
        public int DominantIndex(int[] nums)
        {
            int indexHighestNumber = int.MinValue;
            int highestNumber = int.MinValue;
            int secondHighestNumber = int.MinValue;
            bool newFoundMax = false;

            for (int i = 0; i < nums.Length; i++)
            {
                newFoundMax = false;
                if (highestNumber < nums[i])
                {
                    if (secondHighestNumber < highestNumber)
                    {
                        secondHighestNumber = highestNumber;
                    }
                    highestNumber = nums[i];
                    indexHighestNumber = i;
                    newFoundMax = true;
                }
                if (secondHighestNumber < nums[i] && newFoundMax == false)
                {
                    secondHighestNumber = nums[i];
                }
            }
            if (secondHighestNumber >= int.MinValue && highestNumber >= int.MinValue && secondHighestNumber * 2 <= highestNumber)
            {
                return indexHighestNumber;
            }
            else
            {
                return -1;
            }
        }
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            Dictionary<char, int> charsLicensePlate = CreateDictionaryCharsLicensePlate(licensePlate);

            int maxTooSameChars = 0;
            int indexMaxShort = int.MinValue;
            int lengthMaxShort = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                int currCharsMax = 0;
                Dictionary<char, int> tempDictionaryChars = CreateDictionaryCharsLicensePlate(words[i]);

                foreach (var item in charsLicensePlate)
                {
                    if (tempDictionaryChars.ContainsKey(item.Key))
                    {
                        if (item.Value >= tempDictionaryChars[item.Key])
                        {
                            currCharsMax += tempDictionaryChars[item.Key];
                        }
                        else
                        {
                            currCharsMax += item.Value;
                        }
                    }
                    if (currCharsMax > maxTooSameChars)
                    {
                        maxTooSameChars = currCharsMax;
                        indexMaxShort = i;
                        lengthMaxShort = words[i].Length;
                    }
                    else if (currCharsMax == maxTooSameChars)
                    {
                        if (lengthMaxShort > words[i].Length)
                        {
                            lengthMaxShort = words[i].Length;
                            indexMaxShort = i;
                        }
                    }
                }
            }

            return words[indexMaxShort];
        }
        private Dictionary<char, int> CreateDictionaryCharsLicensePlate(string textString)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < textString.Length; i++)
            {
                char temp = textString[i];
                if (temp > 64 && temp < 91)
                {
                    temp = (char)((int)temp + 32);
                }
                if (temp > 96 && temp < 123)
                {
                    if (result.ContainsKey(temp))
                    {
                        result[temp]++;
                    }
                    else
                    {
                        result.Add(temp, 1);
                    }
                }

            }
            return result;
        }
        public int CountPrimeSetBits(int left, int right)
        {
            int result = 0;

            for (int i = left; i <= right; i++)
            {
                //Console.WriteLine(Convert.ToString(i, 2));
                //string tempBinary = Convert.ToString(i, 2);

                int howMany1Bits = BitOperations.PopCount((uint)i);
                //Console.WriteLine(bits);
                if (checkIsPrime(howMany1Bits))
                {
                    result++;
                }

            }
            return result;
        }
        private bool checkIsPrime(int target)
        {
            if (target < 2)
            {
                return false;
            }
            else if (target == 3 || target == 2 || target == 5)
            {
                return true;
            }
            else if (target % 2 == 0 || target % 3 == 0 || target % 5 == 0)
            {
                return false;
            }
            return true;
        }

        private int _height766;
        private int _width766;
        private int[][] _matrix766;
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            _matrix766 = matrix;
            _height766 = matrix.Length;
            if (_height766 == 0)
            {
                return false;
            }
            _width766 = matrix[0].Length;

            for (int i = 1; i < _height766 - 1; i++)
            {
                if (!IsCorrectLine766(i, 0))
                {
                    return false;
                }
            }

            for (int i = 0; i < _width766; i++)
            {
                if (!IsCorrectLine766(0, i))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsCorrectLine766(int row, int column)
        {
            int currValue = _matrix766[row++][column++];
            for (int i = row; i < _height766; i++)
            {
                if (column > _width766 - 1)
                {
                    continue;
                }
                if (currValue != _matrix766[row][column])
                {
                    return false;
                }
                row++;
                column++;
            }

            return true;
        }
        public int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                {
                    result++;
                }
            }
            return result;
        }
        private PriorityQueue<int, int> _priorityQueue783;
        public int MinDiffInBST(TreeNode root)
        {
            _priorityQueue783 = new PriorityQueue<int, int>();

            if (root != null)
            {
                GiveMeValueFromTreeNode783(root);
            }

            int result = _priorityQueue783.Dequeue();
            int nextValue = _priorityQueue783.Dequeue();

            if (result > nextValue)
            {
                result = result - nextValue;
            }
            else
            {
                result = nextValue - result;
            }

            while (_priorityQueue783.Count != 0)
            {
                int currTempValue = _priorityQueue783.Dequeue();
                int currTempDiff = 0;
                if (nextValue > currTempValue)
                {
                    currTempDiff = nextValue - currTempValue;
                }
                else
                {
                    currTempDiff = currTempValue - nextValue;
                }
                result = Math.Min(result, currTempDiff);
                nextValue = currTempValue;
            }

            return result;
        }
        private void GiveMeValueFromTreeNode783(TreeNode root)
        {
            if (root != null)
            {
                _priorityQueue783.Enqueue(root.val, root.val);
            }
            if (root.left != null)
            {
                GiveMeValueFromTreeNode783(root.left);
            }
            if (root.right != null)
            {
                GiveMeValueFromTreeNode783(root.right);
            }
        }
        
        private int _goalLength796;
        private string _s796;
        private string _goal796;
        public bool RotateString(string s, string goal)
        {
            int sLength = s.Length;
            _goalLength796 = goal.Length;
            _s796 = s;
            _goal796 = goal;

            if (sLength != _goalLength796)
            {
                return false;
            }

            char firstCharS = s[0];

            for (int i = 0; i < _goalLength796; i++)
            {
                //Console.WriteLine(goal[i]);
                //Console.WriteLine(s[0]);
                if (s[0] == goal[i])
                {
                    if (isRotateString796(1, i + 1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool isRotateString796(int indexS, int indexGoal)
        {
            while (indexS < _goalLength796)
            {
                if (indexGoal == _goalLength796)
                {
                    indexGoal = 0;
                    //Console.WriteLine(_goal[indexGoal]);
                }
                //Console.WriteLine(_goal[indexGoal]);
                //Console.WriteLine(_s[indexS]);
                if (_s796[indexS] != _goal796[indexGoal])
                {
                    return false;
                }
                indexS++;
                indexGoal++;
            }

            return true;
        }
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> dictionaryMorse = new Dictionary<char, string>()
            {
                { 'a', ".-" }, { 'b', "-..." }, {'c', "-.-." }, {'d',"-.." }, {'e',"." }, {'f',"..-." }, {'g',"--." }, {'h',"...." },
                { 'i',".." }, {'j',".---" }, {'k',"-.-" }, {'l',".-.." }, {'m',"--" }, {'n',"-." }, {'o',"---" }, {'p',".--." }, {'q',"--.-" },
                { 'r',".-." }, {'s',"..." }, {'t',"-" }, {'u',"..-" }, {'v',"...-" }, {'w',".--" }, {'x',"-..-" }, {'y',"-.--" }, {'z',"--.." }
            };

            HashSet<string> resultString = new HashSet<string>();

            foreach (string word in words)
            {
                string currString = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    currString += dictionaryMorse[word[i]];
                }
                resultString.Add(currString);
            }

            return resultString.Count;
        }
        public int[] NumberOfLines(int[] widths, string s)
        {
            int rows = 1;
            int pixels = 0;

            foreach (char item in s)
            {
                //Console.WriteLine(s[i] - 97);
                //Console.WriteLine(widths[s[i] - 97]);
                int currpixel = widths[item - 97];
                pixels += widths[item - 97];
                if (pixels > 100)
                {
                    rows++;
                    pixels = currpixel;
                }
            }

            return new int[] { rows, pixels };
        }
        public double LargestTriangleArea(int[][] points)
        {
            // Area = 0.5∗(∣)x1​⋅(y2​−y3​)+x2​⋅(y3​−y1​)+x3​⋅(y1​−y2​))   
            double maxArea = 0;
            int length = points.Length;
            for (int i = 0; i < length - 2; i++)
            {
                int[] a = points[i];
                for (int j = i + 1; j < length - 1; j++)
                {
                    int[] b = points[j];
                    for (int k = j + 1; k < length; k++)
                    {
                        int[] c = points[k];
                        double currMaxArea = Math.Abs(((0.5) * (a[1] * (b[0] - c[0]) + b[1] * (c[0] - a[0]) + c[1] * (a[0] - b[0]))));
                        maxArea = maxArea < currMaxArea ? currMaxArea : maxArea;
                    }
                }
            }

            return maxArea;
        }
        public string MostCommonWord(string paragraph, string[] banned)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            ////!?',;.
            string word = string.Empty;
            for (int i = 0; i < paragraph.Length; i++)
            {
                char currChar = paragraph[i];
                if (currChar > 96 && currChar < 123 || currChar == 96 || currChar > 64 && currChar < 91)
                {
                    if (currChar < 91)
                    {
                        currChar += (char)(32);
                    }
                    word += currChar;
                }
                else
                {
                    //Console.WriteLine(word);
                    if (word.Length != 0)
                    {
                        if (!banned.Contains(word))
                        {
                            if (countWords.ContainsKey(word))
                            {
                                countWords[word]++;
                            }
                            else
                            {
                                countWords.Add(word, 1);
                            }
                        }
                        word = string.Empty;
                    }
                }
            }
            int maxCount = 0;
            foreach (var item in countWords)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    word = item.Key;
                }
            }

            return word;
        }
        public int[] ShortestToChar(string s, char c)
        {
            int howManyWithout = 0;

            List<int> listIndexCharC = new List<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    listIndexCharC.Add(i);
                }
            }
            int start = 0;
            int stop = listIndexCharC.Count - 1;
            for (int i = 0; i < s.Length; i++)
            {
                int currResult = Math.Abs(i - listIndexCharC[start]);
                if (start < stop)
                {
                    int currResultNext = Math.Abs(i - listIndexCharC[start + 1]);
                    if (currResult < currResultNext)
                    {
                        result.Add(currResult);
                    }
                    else
                    {
                        result.Add(currResultNext);
                        start++;
                    }
                }
                else
                {
                    result.Add(currResult);
                }
            }

            return result.ToArray();
        }
        public string ToGoatLatin(string sentence)
        {
            string result = string.Empty;
            int length = sentence.Length;

            int stop = 0;
            bool wordBegin = true;
            int howManyAddCharA = 1;
            string currWord = string.Empty;
            bool isVowel = false;
            while (stop < length)
            {
                char currChar = sentence[stop];
                if (sentence[stop] == ' ')
                {
                    if (isVowel)
                    {
                        result += currWord + "ma";

                        for (int i = 0; i < howManyAddCharA; i++)
                        {
                            result += 'a';
                        }
                    }
                    else
                    {
                        result += currWord[1..currWord.Length].ToString() + currWord[0] + "ma";

                        for (int i = 0; i < howManyAddCharA; i++)
                        {
                            result += 'a';
                        }
                    }
                    currWord = string.Empty;
                    howManyAddCharA++;
                    wordBegin = true;
                    result += ' ';
                }
                else if (wordBegin)
                {
                    if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u' ||
                        currChar == 'A' || currChar == 'E' || currChar == 'I' || currChar == 'O' || currChar == 'U')
                    {
                        isVowel = true;
                    }
                    else
                    {
                        isVowel = false;
                    }
                    currWord += currChar;
                    wordBegin = false;
                }
                else
                {
                    currWord += currChar;
                }
                stop++;
            }
            if (isVowel)
            {
                result += currWord + "ma";

                for (int i = 0; i < howManyAddCharA; i++)
                {
                    result += 'a';
                }
            }
            else
            {
                result += currWord[1..currWord.Length].ToString() + currWord[0] + "ma";

                for (int i = 0; i < howManyAddCharA; i++)
                {
                    result += 'a';
                }
            }
            return result;
        }
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> result = new List<IList<int>>();

            int start = 0;
            char lastChar = s[0];
            int count = 1;
            int length = s.Length;

            for (int i = 1; i < length; i++)
            {
                char currChar = s[i];
                if (currChar == lastChar)
                {
                    count++;
                }
                else
                {
                    if (count >= 3)
                    {
                        result.Add(new List<int>() { start, i - 1 });
                    }
                    count = 1;
                    lastChar = currChar;
                    start = i;
                }
            }
            if (start + 2 <= length)
            {
                result.Add(new List<int>() { start, length - 1 });
            }

            return result;
        }
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int countRows = image.Length;
            int lenght = image[0].Length;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght / 2; j++)
                {
                    int temp = image[i][j];
                    image[i][j] = image[i][lenght - 1 - j];
                    image[i][lenght - 1 - j] = temp;
                }
                for (int j = 0; j < lenght; j++)
                {
                    if (image[i][j] == 0)
                    {
                        image[i][j] = 1;
                    }
                    else
                    {
                        image[i][j] = 0;
                    }
                }


            }
            return image;
        }
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            ////rec1 = [0,0,2,2], rec2 = [1,1,3,3]

            int minX1 = rec1[0];
            int maxX1 = rec1[2];
            int minY1 = rec1[1];
            int maxY1 = rec1[3];

            //Console.WriteLine(minX1);
            //Console.WriteLine(maxX1);
            //Console.WriteLine(minY1);
            //Console.WriteLine(maxY2);

            int minX2 = rec2[0];
            int maxX2 = rec2[2];
            int minY2 = rec2[1];
            int maxY2 = rec2[3];

            if (maxX2 > minX1 && maxY2 > minY1 && minX2 < maxX1 && minY2 < maxY1)
            {
                return true;
            }
            return false;
        }
        public bool BackspaceCompare(string s, string t)
        {
            string newString = string.Empty;
            int lenghtS = s.Length;
            int lengthT = t.Length;
            bool result = false;

            if (lenghtS >= lengthT)
            {
                result = BackspaceCompareChangeSOnT(s, t, lenghtS, lengthT);
            }
            else
            {
                result = BackspaceCompareChangeSOnT(t, s, lengthT, lenghtS);
            }

            return result;
        }
        private bool BackspaceCompareChangeSOnT(string s, string t, int lengthS, int lengthT)
        {
            string newString = string.Empty;
            bool result = false;

            string sbS = string.Empty;
            string sbT = string.Empty;
            int indexS = 0;
            int indexT = 0;
            for (int i = 0; i < lengthS; i++)
            {
                if (i < lengthT)
                {
                    if (t[i] == '#')
                    {
                        if (indexT < 2)
                        {
                            indexT = 0;
                            sbT = string.Empty;
                        }
                        else
                        {
                            sbT = sbT.Remove(indexT - 1, 1);
                            indexT -= 1;
                        }
                    }
                    else
                    {
                        sbT += t[i];
                        indexT++;
                    }
                }
                if (s[i] == '#')
                {
                    if (indexS < 2)
                    {
                        indexS = 0;
                        sbS = string.Empty;
                    }
                    else
                    {
                        sbS = sbS.Remove(indexS - 1, 1);
                        indexS -= 1;
                    }
                }
                else
                {
                    sbS += s[i];
                    indexS++;
                }
            }
            if (sbS == sbT)
            {
                return true;
            }

            return result;
        }
        public bool BuddyStrings(string s, string goal)
        {
            int lengthS = s.Length;
            int lengthGoal = goal.Length;
            Dictionary<char, int> dictionaryS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryGoal = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryDiffS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryDiffGoal = new Dictionary<char, int>();

            if (lengthS != lengthGoal)
            {
                return false;
            }

            for (int i = 0; i < lengthS; i++)
            {
                if (s[i] != goal[i])
                {
                    if (dictionaryDiffS.ContainsKey(s[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dictionaryDiffS.Add(s[i], 1);
                    }

                    if (dictionaryDiffGoal.ContainsKey(goal[i]))
                    {
                        return false;
                    }
                    else
                    {
                        dictionaryDiffGoal.Add(goal[i], 1);
                    }
                    if (dictionaryDiffGoal.Count > 2 || dictionaryDiffS.Count > 2)
                    {
                        return false;
                    }
                }

                if (dictionaryS.ContainsKey(s[i]))
                {
                    dictionaryS[s[i]]++;
                }
                else
                {
                    dictionaryS.Add(s[i], 1);
                }

                if (dictionaryGoal.ContainsKey(goal[i]))
                {
                    dictionaryGoal[goal[i]]++;
                }
                else
                {
                    dictionaryGoal.Add(goal[i], 1);
                }
            }

            if (dictionaryDiffS.Count == 0)
            {
                foreach (var item in dictionaryS)
                {
                    if (item.Value > 1)
                    {
                        return true;
                    }
                }
                return false;
            }

            foreach (var item in dictionaryDiffS)
            {
                int value;
                dictionaryDiffGoal.TryGetValue(item.Key, out value);
                if (value != item.Value)
                {
                    return false;
                }
            }

            return true;
        }
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
        public int[][] Transpose(int[][] matrix)
        {
            int countColumn = matrix[0].Length;
            int countRows = matrix.Length;

            int[][] result = new int[countColumn][];

            for (int i = 0; i < countColumn; i++)
            {
                int[] currRow = new int[countRows];

                for (int j = 0; j < countRows; j++)
                {
                    currRow[j] = matrix[j][i];
                }
                result[i] = currRow;
            }

            return result;
        }
        public int BinaryGap(int n)
        {
            string binaryString = Convert.ToString(n, 2);
            int result = 0;
            int indexFor1 = -1;
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    if (indexFor1 >= 0)
                    {
                        result = Math.Max(result, i - indexFor1);
                        indexFor1 = i;
                    }
                    else
                    {
                        indexFor1 = i;
                    }
                }
            }

            return result;
        }
        private string _resultRoot1String872;
        private string _resultRoot2String872;
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            _resultRoot1String872 = string.Empty;
            _resultRoot2String872 = string.Empty;

            if (root1 != null)
            {
                DeepLeafSimilar(root1, 1);
            }
            if (root2 != null)
            {
                DeepLeafSimilar(root2, 2);
            }

            if (_resultRoot1String872 == _resultRoot2String872)
            {
                return true;
            }
            return false;
        }
        private void DeepLeafSimilar(TreeNode root, int numberRoot)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                DeepLeafSimilar(root.left, numberRoot);
            }
            if (root.right != null)
            {
                DeepLeafSimilar(root.right, numberRoot);
            }
            if (root.right == null && root.left == null)
            {
                if (numberRoot == 1)
                {
                    _resultRoot1String872 += root.val + ',';
                }
                else
                {
                    _resultRoot2String872 += root.val + ',';
                }
            }
        }
        public ListNode MiddleNode(ListNode head)
        {
            ListNode ordinaryCopyHead = head;
            int countValue = 0;

            while (head != null)
            {
                countValue++;
                head = head.next;
            }
            int middle = countValue / 2;

            while (middle != 0)
            {
                ordinaryCopyHead = ordinaryCopyHead.next;
                middle--;
            }

            return ordinaryCopyHead;
        }
        public int ProjectionArea(int[][] grid)
        {
            int countYX = 0;
            int countZX = 0;
            int countZY = 0;

            int countGrid = grid.Length;
            int lengthInGrid = grid[0].Length;

            for (int i = 0; i < countGrid; i++)
            {
                int tempCurrMaxZX = 0;
                for (int j = 0; j < lengthInGrid; j++)
                {
                    int tempCurrGrid = grid[i][j];
                    if (tempCurrGrid > 0)
                    {
                        countYX++;
                    }
                    tempCurrMaxZX = Math.Max(tempCurrMaxZX, tempCurrGrid);
                }
                countZX += tempCurrMaxZX;
            }

            for (int i = 0; i < lengthInGrid; i++)
            {
                int tempCurrMaxZY = 0;
                for (int j = 0; j < countGrid; j++)
                {
                    int tempCurrGrid = grid[j][i];
                    tempCurrMaxZY = Math.Max(tempCurrMaxZY, tempCurrGrid);
                }
                countZY += tempCurrMaxZY;
            }

            return countYX + countZX + countZY;
        }
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dictionaryS1 = new Dictionary<string, int>();
            Dictionary<string, int> dictionaryS2 = new Dictionary<string, int>();
            List<string> resultList = new List<string>();

            string tempString = string.Empty;
            for (int i = 0; i < s1.Length; i++)
            {
                char currChar = s1[i];
                if (currChar != ' ')
                {
                    tempString += currChar;
                }
                else
                {
                    if (dictionaryS1.ContainsKey(tempString))
                    {
                        dictionaryS1[tempString]++;
                    }
                    else
                    {
                        dictionaryS1.Add(tempString, 1);
                    }
                    tempString = string.Empty;
                }
            }
            if (tempString != string.Empty)
            {
                if (dictionaryS1.ContainsKey(tempString))
                {
                    dictionaryS1[tempString]++;
                }
                else
                {
                    dictionaryS1.Add(tempString, 1);
                }
                tempString = string.Empty;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                char currChar = s2[i];
                if (currChar != ' ')
                {
                    tempString += currChar;
                }
                else
                {
                    if (dictionaryS2.ContainsKey(tempString))
                    {
                        dictionaryS2[tempString]++;
                    }
                    else
                    {
                        dictionaryS2.Add(tempString, 1);
                    }
                    tempString = string.Empty;
                }
            }
            if (tempString != string.Empty)
            {
                if (dictionaryS2.ContainsKey(tempString))
                {
                    dictionaryS2[tempString]++;
                }
                else
                {
                    dictionaryS2.Add(tempString, 1);
                }
                tempString = string.Empty;
            }
            foreach (var item in dictionaryS1)
            {
                if (item.Value == 1)
                {
                    if (!dictionaryS2.ContainsKey(item.Key))
                    {
                        resultList.Add(item.Key);
                        dictionaryS1.Remove(item.Key);
                    }
                    else
                    {
                        dictionaryS2.Remove(item.Key);
                        dictionaryS1.Remove(item.Key);
                    }
                }
            }

            foreach (var item in dictionaryS2)
            {
                if (item.Value == 1)
                {
                    if (!dictionaryS1.ContainsKey(item.Key))
                    {
                        resultList.Add(item.Key);
                    }
                    else
                    {
                        dictionaryS1.Remove(item.Key);
                    }
                }
            }
            return resultList.ToArray();
        }
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            int aliceSum = 0;
            int bobSum = 0;
            int aliceLength = aliceSizes.Length;
            int bobLength = bobSizes.Length;

            for (int i = 0; i < aliceLength; i++)
            {
                aliceSum += aliceSizes[i];
            }

            for (int i = 0; i < bobLength; i++)
            {
                bobSum += bobSizes[i];
            }

            if (bobSum == aliceSum)
            {
                return new int[] { };
            }

            for (int i = bobLength - 1; i >= 0; i--)
            {
                int tempCurrBobValue = bobSizes[i];
                for (int j = 0; j < aliceLength; j++)
                {
                    int tempCurrAliceValue = aliceSizes[j];
                    int currBobSum = bobSum - tempCurrBobValue + tempCurrAliceValue;
                    int currAliceSum = aliceSum - tempCurrAliceValue + tempCurrBobValue;
                    if (currBobSum == currAliceSum)
                    {
                        return new int[] { tempCurrAliceValue, tempCurrBobValue };
                    }
                }
            }

            return new int[] { };
        }
        public int SurfaceArea(int[][] grid)
        {
            int widthX = grid[0].Length;
            int widthY = grid.Length;

            int areaSurfaceCount = 0;

            for (int i = 0; i < widthY; i++)
            {
                for (int j = 0; j < widthX; j++)
                {
                    int currHigth = grid[i][j];
                    if (currHigth > 0)
                    {
                        areaSurfaceCount += 2 + currHigth * 4;
                    }
                    if (j < widthX - 1)
                    {
                        areaSurfaceCount -= Math.Min(currHigth, grid[i][j + 1]) * 2;
                    }
                }
            }
            for (int i = 0; i < widthX; i++)
            {
                for (int j = 0; j < widthY; j++)
                {
                    int currHigth = grid[j][i];
                    if (j < widthY - 1)
                    {
                        areaSurfaceCount -= Math.Min(currHigth, grid[j + 1][i]) * 2;
                    }
                }
            }
            return areaSurfaceCount;
        }
        public bool IsMonotonic(int[] nums)
        {
            bool decreasing = false;
            bool trendSetting = false;
            int previousValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int currNums = nums[i];
                if (!trendSetting)
                {
                    if (previousValue > currNums)
                    {
                        trendSetting = true;
                        decreasing = false;
                    }
                    else if (previousValue < currNums)
                    {
                        trendSetting = true;
                        decreasing = true;
                    }
                }
                else
                {
                    if (previousValue > currNums)
                    {
                        if (decreasing == true)
                        {
                            return false;
                        }
                    }
                    else if (previousValue < currNums)
                    {
                        if (decreasing == false)
                        {
                            return false;
                        }
                    }
                }
                previousValue = nums[i];
            }

            return true;
        }
        public int[] SortArrayByParity(int[] nums)
        {
            int length = nums.Length;
            int howManyEvenNumbers = 0;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int tempValue = nums[howManyEvenNumbers];
                    nums[howManyEvenNumbers] = nums[i];
                    nums[i] = tempValue;
                    howManyEvenNumbers++;
                }
            }


            return nums;
        }       

        private TreeNode currentRoot897;
        public TreeNode IncreasingBST(TreeNode root)
        {
            TreeNode newDummyRoot = new TreeNode(-1);
            currentRoot897 = newDummyRoot;

            IncreasingBSTIn(root);
            return newDummyRoot.right;
        }
        private void IncreasingBSTIn(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            IncreasingBSTIn(root.left);

            root.left = null;
            currentRoot897.right = root;
            currentRoot897 = root;

            IncreasingBSTIn(root.right);
        }
        public int SmallestRangeI(int[] nums, int k)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                if (currValue > max)
                {
                    max = currValue;
                }
                if (currValue < min)
                {
                    min = currValue;
                }
            }
            int currMin = min + k;
            int currMax = max - k;
            int diff = currMax - currMin;

            if (diff <= 0)
            {
                return 0;
            }
            else
            {
                return diff;
            }
        }
        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> dictionaryDeck = new Dictionary<int, int>();

            if (deck.Length < 2)
            {
                return true;
            }

            for (int i = 0; i < deck.Length; i++)
            {
                if (!dictionaryDeck.ContainsKey(deck[i]))
                {
                    dictionaryDeck.Add(deck[i], 1);
                }
                else
                {
                    dictionaryDeck[deck[i]]++;
                }
            }

            int minDeck = int.MaxValue;

            foreach (var item in dictionaryDeck)
            {
                if (item.Value < minDeck)
                {
                    minDeck = item.Value;
                }
            }

            for (int i = 2; i <= minDeck; i++)
            {
                bool tempBool = true;
                foreach (var item in dictionaryDeck)
                {
                    if (item.Value % i != 0)
                    {
                        tempBool = false;
                        break;
                    }
                }
                if (tempBool == true)
                {
                    return true;
                }
            }

            return false;
        }
        public string ReverseOnlyLetters(string s)
        {
            char[] charS = s.ToCharArray();

            int lenght = s.Length;

            for (int i = 0; i < lenght; i++)
            {
                char currChar = s[i];
                if (currChar > 64 && currChar < 91 || currChar > 96 && currChar < 123)
                {
                    for (int j = lenght - 1; j >= i; j--)
                    {
                        char currNewChar = s[j];
                        if (currNewChar > 64 && currNewChar < 91 || currNewChar > 96 && currNewChar < 123)
                        {
                            charS[i] = currNewChar;
                            charS[j] = currChar;
                            lenght = j;
                            break;
                        }

                    }

                }
            }
            return new string(charS);
        }
        public int[] SortArrayByParityII(int[] nums)
        {
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine(i);

                int currNum = nums[i];
                if (i % 2 == 0)
                {
                    if (currNum % 2 != 0)
                    {
                        for (int j = length - 1; j >= 0; j--)
                        {
                            int currNewNum = nums[j];
                            if (currNewNum % 2 == 0)
                            {
                                nums[i] = currNewNum;
                                nums[j] = currNum;
                                break;
                            }
                            //Console.WriteLine(nums[j]);
                            //Console.WriteLine(j);
                        }
                    }
                }
                else
                {
                    if (currNum % 2 == 0)
                    {
                        for (int j = length - 1; j >= 0; j--)
                        {
                            int currNewNum = nums[j];
                            //Console.WriteLine(nums[j]);
                            //Console.WriteLine(j);
                            if (currNewNum % 2 != 0)
                            {
                                nums[i] = currNewNum;
                                nums[j] = currNum;
                                break;
                            }
                        }
                    }
                }
            }
            return nums;
        }
        public bool IsLongPressedName(string name, string typed)
        {
            int lengthName = name.Length;
            int lengthTyped = typed.Length;
            char prevChar = name[0];
            char currChar = name[0];
            int indexNumber = 0;
            bool result = false;

            if (currChar != typed[0])
            {
                return false;
            }

            for (int i = 0; i < lengthTyped; i++)
            {
                char tempChar = typed[i];
                if (currChar == typed[i])
                {
                    prevChar = currChar;
                    indexNumber++;
                    if (indexNumber == lengthName)
                    {
                        indexNumber--;
                        result = true;
                    }
                    currChar = name[indexNumber];
                }
                else if (tempChar == prevChar)
                {

                }
                else
                {
                    prevChar = name[0];
                    currChar = name[0];
                    indexNumber = 0;
                    result = false;
                }
            }

            return result;
        }
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> result = new HashSet<string>();

            for (int i = 0; i < emails.Length; i++)
            {
                string stringBeforeMonkey = string.Empty;

                string[] stringSplitEmailAfterBeforeMonkey = emails[i].Split('@');
                int firstPLusIndex = stringSplitEmailAfterBeforeMonkey[0].IndexOf('+');
                if (firstPLusIndex > 0)
                {
                    stringBeforeMonkey = stringSplitEmailAfterBeforeMonkey[0][..firstPLusIndex].Replace(".", "");
                }
                else
                {
                    stringBeforeMonkey = stringSplitEmailAfterBeforeMonkey[0].Replace(".", "");
                }
                result.Add(stringBeforeMonkey + '@' + stringSplitEmailAfterBeforeMonkey[1]);
            }

            return result.Count;
        }
        public class RecentCounter933
        {
            private List<int> _list;
            private int _startIndex;
            public RecentCounter933()
            {
                _list = new List<int>();
                _startIndex = 0;
            }

            public int Ping(int t)
            {
                _list.Add(t);

                while (_list[_startIndex] < t - 3000)
                {
                    _startIndex++;
                }
                //Console.WriteLine(_list.Count - _startIndex);
                return _list.Count - _startIndex;
            }
        }
        public bool ValidMountainArray(int[] arr)
        {
            int prevValue = arr[0];
            bool changeTrend = false;
            bool trendGrow = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (prevValue == arr[i])
                {
                    return false;
                }
                if (!changeTrend)
                {
                    if (prevValue > arr[i])
                    {
                        changeTrend = true;
                    }
                    else
                    {
                        trendGrow = true;
                    }
                }
                else
                {
                    if (prevValue < arr[i])
                    {
                        return false;
                    }
                }
                prevValue = arr[i];
            }
            if (changeTrend && trendGrow) { return true; }
            return false;
        }
        public int[] DiStringMatch(string s)
        {
            int length = s.Length;
            int minValue = 0;
            int maxValue = length;
            List<int> resultList = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (s[i] == 'I')
                {
                    resultList.Add(minValue);
                    minValue++;
                }
                else
                {
                    resultList.Add(maxValue);
                    maxValue--;
                }
            }
            resultList.Add(minValue);

            return resultList.ToArray();
        }
        public int MinDeletionSize(string[] strs)
        {
            int result = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j - 1][i] > strs[j][i])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }
        public bool IsAlienSorted(string[] words, string order)
        {
            ////["word", "world", "row"];

            int countWords = words.Length;

            for (int i = 0; i < countWords - 1; i++)
            {
                int tempLength0 = words[i].Length;
                int tempLength1 = words[i + 1].Length;
                int maxLengthWord = Math.Max(tempLength0, tempLength1);

                for (int j = 0; j < maxLengthWord; j++)
                {
                    if (tempLength0 - 1 < j)
                    {
                        break;
                    }
                    else if (tempLength1 - 1 < j && tempLength1 < tempLength0)
                    {
                        return false;
                    }

                    if (order.IndexOf(words[i][j]) > order.IndexOf(words[i + 1][j]))
                    {
                        return false;
                    }
                    else if (order.IndexOf(words[i][j]) < order.IndexOf(words[i + 1][j]))
                    {
                        break;
                    }
                }
            }

            return true;
        }
        public int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionaryNums.ContainsKey(nums[i]))
                {
                    return nums[i];
                }
                else
                {
                    dictionaryNums.Add(nums[i], 1);
                }
            }

            return 0;
        }

        private bool _result965;
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return false;
            _result965 = true;
            DeepIsUnivalTree(root, root.val);

            return _result965;
        }
        private void DeepIsUnivalTree(TreeNode root, int rootValue)
        {
            if (root == null)
            {
                return;
            }
            if (root.val != rootValue)
            {
                _result965 = false;
                return;
            }
            else
            {
                DeepIsUnivalTree(root.left, rootValue);
                DeepIsUnivalTree(root.right, rootValue);
            }
        }
        public int LargestPerimeter(int[] nums)
        {
            int maxArea = 0;
            int length = nums.Length;

            Array.Sort(nums);
            for (int i = length - 1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                {
                    return nums[i] + nums[i - 1] + nums[i - 2];
                }
            }
            return maxArea;
        }
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);


            return nums;
        }
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            IList<int> result = new List<int>();

            int lengthNum = num.Length;

            int extraAdd = 0;
            int mod = 10;

            while (k > 0)
            {
                int tempValue = k % mod;
                if (tempValue > 0)
                {
                    result.Add(tempValue / (mod / 10));
                }
                else
                {
                    result.Add(tempValue);
                }
                k -= tempValue;
                mod *= 10;
            }

            int index = 0;
            for (int i = lengthNum - 1; i >= 0; i--)
            {
                if (index == result.Count)
                {
                    result.Add(0);
                }
                int temp = result[index] + num[i] + extraAdd;
                extraAdd = 0;
                if (temp > 9)
                {
                    temp -= 10;
                    extraAdd = 1;
                }
                result[index] = temp;
                index++;
            }

            while (extraAdd > 0)
            {
                if (index == result.Count)
                {
                    result.Add(extraAdd);
                    extraAdd = 0;
                    break;
                }
                int temp = extraAdd + result[index];
                extraAdd = 0;
                if (temp > 9)
                {
                    extraAdd = 1;
                    temp -= 10;
                }
                result[index] = temp;
                index++;
            }

            return result.Reverse().ToList();
        }
        public int FindJudge(int n, int[][] trust)
        {
            Dictionary<int, int> dictionaryTrustWho = new Dictionary<int, int>();
            Dictionary<int, int> dictionaryTrustWhom = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                dictionaryTrustWho.Add(i, 0);
                dictionaryTrustWhom.Add(i, 0);
            }

            for (int i = 0; i < trust.Length; i++)
            {
                dictionaryTrustWho[trust[i][0]] += 1;
                dictionaryTrustWhom[trust[i][1]] += 1;

            }

            int result = dictionaryTrustWho.FirstOrDefault(x => x.Value == 0).Key;
            if (result == 0)
            {
                return -1;
            }
            else
            {
                if (dictionaryTrustWhom[result] == n - 1)
                {
                    return result;
                }
                else
                {
                    return -1;
                }
            }
        }

        private char[][] _board999;
        public int NumRookCaptures(char[][] board)
        {
            int indexHeightTarget = 0;
            int indexWidthTarget = 0;
            _board999 = board;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bool currPositionIsATarget1 = CheckIfThereIsAR(i, j);
                    if (currPositionIsATarget1)
                    {
                        indexHeightTarget = i;
                        indexWidthTarget = j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget2 = CheckIfThereIsAR(i, 7 - j);
                    if (currPositionIsATarget2)
                    {
                        indexHeightTarget = i;
                        indexWidthTarget = 7 - j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget3 = CheckIfThereIsAR(7 - i, j);
                    if (currPositionIsATarget3)
                    {
                        indexHeightTarget = 7 - i;
                        indexWidthTarget = j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget4 = CheckIfThereIsAR(7 - i, 7 - j);
                    if (currPositionIsATarget4)
                    {
                        indexHeightTarget = 7 - i;
                        indexWidthTarget = 7 - j;
                        goto LoopEnd;
                    }
                }
            }

        LoopEnd:

            int result = 0;
            bool endLeft = false;
            bool endRight = false;
            bool endTop = false;
            bool endBottom = false;
            int indexMove = 1;
            while (endLeft != true || endRight != true || endTop != true || endBottom != true)
            {
                if (!endLeft)
                {
                    if (indexWidthTarget - indexMove >= 0)
                    {
                        if (_board999[indexHeightTarget][indexWidthTarget - indexMove] == 'B')
                        {
                            endLeft = true;
                        }
                        else if (_board999[indexHeightTarget][indexWidthTarget - indexMove] == 'p')
                        {
                            result++;
                            endLeft = true;
                        }
                    }
                    else
                    {
                        endLeft = true;
                    }
                }
                if (!endRight)
                {
                    if (indexWidthTarget + indexMove < 8)
                    {
                        if (_board999[indexHeightTarget][indexWidthTarget + indexMove] == 'B')
                        {
                            endRight = true;
                        }
                        else if (_board999[indexHeightTarget][indexWidthTarget + indexMove] == 'p')
                        {
                            result++;
                            endRight = true;
                        }
                    }
                    else
                    {
                        endRight = true;
                    }
                }
                if (!endTop)
                {
                    if (indexHeightTarget - indexMove >= 0)
                    {
                        if (_board999[indexHeightTarget - indexMove][indexWidthTarget] == 'B')
                        {
                            endTop = true;
                        }
                        else if (_board999[indexHeightTarget - indexMove][indexWidthTarget] == 'p')
                        {
                            result++;
                            endTop = true;
                        }
                    }
                    else
                    {
                        endTop = true;
                    }
                }
                if (!endBottom)
                {
                    if (indexHeightTarget + indexMove < 8)
                    {
                        if (_board999[indexHeightTarget + indexMove][indexWidthTarget] == 'B')
                        {
                            endBottom = true;
                        }
                        else if (_board999[indexHeightTarget + indexMove][indexWidthTarget] == 'p')
                        {
                            result++;
                            endBottom = true;
                        }
                    }
                    else
                    {
                        endBottom = true;
                    }
                }
                indexMove++;
            }


            return result;
        }
        private bool CheckIfThereIsAR(int indexHeight, int indexWidth)
        {
            if (_board999[indexHeight][indexWidth] == 'R')
            {
                return true;
            }
            return false;
        }
        public IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();

            Dictionary<char, int> firstDictionary = new Dictionary<char, int>();
            Dictionary<char, int> secondDictionary = new Dictionary<char, int>();


            for (int i = 0; i < words[0].Length; i++)
            {
                if (firstDictionary.ContainsKey(words[0][i]))
                {
                    firstDictionary[words[0][i]]++;
                }
                else
                {
                    firstDictionary.Add(words[0][i], 1);
                }
            }

            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (secondDictionary.ContainsKey(words[i][j]))
                    {
                        secondDictionary[words[i][j]]++;
                    }
                    else
                    {
                        secondDictionary.Add(words[i][j], 1);
                    }
                }
                foreach (var item in firstDictionary)
                {
                    if (secondDictionary.ContainsKey(item.Key))
                    {
                        int minValue = Math.Min(item.Value, secondDictionary[item.Key]);
                        firstDictionary[item.Key] = minValue;
                    }
                    else
                    {
                        firstDictionary.Remove(item.Key);
                    }
                }
                secondDictionary.Clear();
            }
            foreach (var item in firstDictionary)
            {
                int count = item.Value;
                while (count != 0)
                {
                    result.Add(item.Key.ToString());
                    count--;
                }
            }

            return result;
        }
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            int length = nums.Length;

            int index = 1;
            nums[0] *= -1;
            k--;

            if (nums[0] == 0)
            {
                return nums.Sum();
            }

            while (k != 0)
            {
                if (nums[index] < 0)
                {
                    nums[index] *= -1;
                    if (index != length - 1)
                    {
                        index++;
                    }
                }
                else if (nums[index] == 0)
                {
                    break;
                }
                else
                {
                    if (nums[index - 1] >= nums[index])
                    {
                        nums[index] *= -1;
                    }
                    else
                    {
                        nums[index - 1] *= -1;
                    }
                }

                k--;
            }

            return nums.Sum();
        }
        public int BitwiseComplement(int n)
        {
            string convertNtoString = Convert.ToString(n, 2);
            int result = 0;

            for (int i = convertNtoString.Length - 1; i >= 0; i--)
            {
                if (convertNtoString[i] == '0')
                {
                    result += (int)Math.Pow(2, convertNtoString.Length - 1 - i);
                }
            }

            return result;
        }
        public bool CanThreePartsEqualSum(int[] arr)
        {
            int sum = arr.Sum();
            if (sum % 3 != 0)
            {
                return false;
            }
            int groupSum = sum / 3;
            int length = arr.Length;
            int increaseIndex = 1;
            bool foundAGroup1 = false;
            bool foundAGroup2 = false;
            int sumGroup1 = arr[0];
            int sumGroup2 = arr[length - 1];
            int indexStopGroup1 = int.MaxValue;
            int indexStopGroup2 = int.MaxValue;

            while (foundAGroup1 == false || foundAGroup2 == false)
            {
                if (increaseIndex == length - 1 || length - 1 - increaseIndex == indexStopGroup1)
                {
                    return false;
                }
                if (foundAGroup1 == false)
                {
                    if (sumGroup1 != groupSum)
                    {
                        sumGroup1 += arr[increaseIndex];
                    }
                    else
                    {
                        foundAGroup1 = true;
                        indexStopGroup1 = increaseIndex - 1;
                    }
                }

                if (foundAGroup2 == false)
                {
                    if (sumGroup2 != groupSum)
                    {
                        sumGroup2 += arr[length - 1 - increaseIndex];
                    }
                    else
                    {
                        indexStopGroup2 = length - 1 - (increaseIndex - 1);
                        foundAGroup2 = true;
                    }
                }

                if (foundAGroup1 && !foundAGroup2)
                {
                    if (increaseIndex <= indexStopGroup1)
                    {
                        return false;
                    }
                }
                else if (!foundAGroup1 && foundAGroup2)
                {
                    if (increaseIndex >= indexStopGroup2)
                    {
                        return false;
                    }
                }
                else if (!foundAGroup1 && !foundAGroup2)
                {
                    if ((increaseIndex) * 2 + 1 >= length - 1)
                    {
                        return false;
                    }
                }
                increaseIndex++;
            }

            if (foundAGroup1 && foundAGroup2)
            {
                return true;
            }

            return false;
        }
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            IList<bool> result = new List<bool>();
            int currValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currValue = (currValue * 2 + nums[i]) % 5;
                result.Add(currValue % 5 == 0);
            }
            return result;
        }
        public string RemoveOuterParentheses(string s)
        {

            int howMany = 0;
            StringBuilder result = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    if (howMany > 0) result.Append('(');
                    howMany++;
                }
                else
                {
                    howMany--;
                    if (howMany > 0) result.Append(')');
                }
            }

            return result.ToString();
        }

        private int _sum1022;
        public int SumRootToLeaf(TreeNode root)
        {
            _sum1022 = 0;
            if (root != null)
            {
                DeepSumSumRootToLeaf(root, 0);
            }
            return _sum1022;
        }
        private void DeepSumSumRootToLeaf(TreeNode root, int target)
        {
            if (root == null)
            {
                return;
            }

            target = target * 2 + root.val;

            if (root.left == null && root.right == null)
            {
                _sum1022 += target;
            }

            DeepSumSumRootToLeaf(root.left, target);
            DeepSumSumRootToLeaf(root.right, target);
        }
        public bool DivisorGame(int n)
        {
            bool AliceWin = false;
            bool outLoop = false;
            int x = 1;

            while (n > 1)
            {
                while (x < n)
                {
                    if (n % x == 0)
                    {
                        if (AliceWin)
                        {
                            AliceWin = false;
                        }
                        else
                        {
                            AliceWin = true;
                        }
                        n -= x;
                        break;
                    }
                    x++;
                }
            }

            return AliceWin;
        }
        public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            List<(int, int, int)> distanceList = new List<(int, int, int)>();

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    distanceList.Add((row, column, (Math.Abs(column - cCenter) + Math.Abs(row - rCenter))));
                }
            }

            distanceList = distanceList.OrderBy(c => c.Item3).ToList();

            int[][] sortedCells = new int[distanceList.Count][];

            for (int indexSortedCells = 0; indexSortedCells < distanceList.Count; indexSortedCells++)
            {
                sortedCells[indexSortedCells] = new int[] { distanceList[indexSortedCells].Item1, distanceList[indexSortedCells].Item2 };
            }

            return sortedCells.ToArray();
        }
        public bool IsBoomerang(int[][] points)
        {
            if (points[0][0] * (points[1][1] - points[2][1]) + points[1][0] * (points[2][1] - points[0][1]) + points[2][0] * (points[0][1] - points[1][1]) != 0)
            {
                return true;
            }

            return false;
        }
        public int LastStoneWeight(int[] stones)
        {
            List<int> listWeight = new List<int>();

            foreach (var item in stones)
            {
                listWeight.Add(item);
            }

            int length = listWeight.Count;
            listWeight.Sort();

            while (length > 1)
            {
                if (listWeight[length - 1] == listWeight[length - 2])
                {
                    listWeight.RemoveAt(length - 2);
                    listWeight.RemoveAt(length - 2);
                    length -= 2;
                }
                else if (listWeight[length - 1] != listWeight[length - 2])
                {
                    int temp = listWeight[length - 1] - listWeight[length - 2];

                    listWeight.RemoveAt(length - 2);
                    listWeight.RemoveAt(length - 2);
                    listWeight.Add(temp);
                    listWeight.Sort();

                    length -= 1;
                }
            }

            if (listWeight.Count < 1)
            {
                return 0;
            }

            return listWeight[0];
        }
        public string RemoveDuplicates(string s)
        {
            char[] charS = s.ToCharArray();
            int index = 0;

            for (int i = 0; i < charS.Length; i++)
            {
                charS[index] = charS[i];
                if (index > 0 && charS[index] == charS[index - 1])
                {
                    index -= 2;
                }
                index++;
            }

            return new String(charS, 0, index);
        }
        public int HeightChecker(int[] heights)
        {
            List<int> sortedHeights = heights.ToList();
            sortedHeights.Sort();

            int result = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sortedHeights[i])
                {
                    result++;
                }
            }

            return result;
        }
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            int lengthStr1 = str1.Length;
            int lengthStr2 = str2.Length;
            int minLength = Math.Min(lengthStr1, lengthStr2);

            while (minLength > 0)
            {
                if (lengthStr1 % minLength == 0 && lengthStr2 % minLength == 0)
                {
                    return str1.Substring(0, minLength);
                }
                minLength--;
            }

            return "";
        }
        public string[] FindOcurrences(string text, string first, string second)
        {
            List<string> listWordInText = new List<string>();
            List<string> result = new List<string>();
            text += ' ';
            int lastWordStartIndex = 0;
            bool firstWord = false;
            bool secondWords = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (lastWordStartIndex == 0)
                    {
                        listWordInText.Add(text[lastWordStartIndex..i]);
                        lastWordStartIndex = i + 1;
                    }
                    else
                    {
                        listWordInText.Add(text[lastWordStartIndex..i]);
                        lastWordStartIndex = i + 1;
                    }
                }
            }

            foreach (string word in listWordInText)
            {

                if (firstWord == false)
                {
                    if (word == first)
                    {
                        firstWord = true;
                    }
                    else
                    {
                        firstWord = false;
                    }
                }
                else if (secondWords == false)
                {
                    if (word == second)
                    {
                        secondWords = true;
                    }
                    else
                    {
                        if (word != first)
                        {
                            firstWord = false;
                        }
                    }
                }
                else if (firstWord == true && secondWords == true)
                {
                    result.Add(word);
                    if (first == word)
                    {
                        firstWord = true;
                        secondWords = false;
                        if (first == second)
                        {
                            secondWords = true;
                        }
                    }
                    else
                    {
                        firstWord = false;
                        secondWords = false;
                    }
                }
            }

            return result.ToArray();
        }
        public void DuplicateZeros(int[] arr)
        {
            int[] dudeArr = arr.ToArray();
            int currDudeArrLength = dudeArr.Length;
            int indexArr = 0;
            int arrLength = arr.Length;
            for (int i = 0; i < currDudeArrLength; i++)
            {
                if (dudeArr[i] == 0)
                {
                    arr[indexArr] = 0;
                    if (arrLength > indexArr + 1)
                    {
                        arr[indexArr + 1] = 0;
                    }
                    indexArr += 2;
                    currDudeArrLength--;
                }
                else
                {
                    arr[indexArr] = dudeArr[i];
                    indexArr++;
                }
            }
            //Console.WriteLine(string.Join(",", arr));
        }
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] result = new int[num_people];
            int currIndex = 0;
            int increment = 1;

            while (candies != 0)
            {
                if (candies >= increment)
                {
                    result[currIndex] += increment;
                    candies -= increment;
                    increment++;
                }
                else
                {
                    result[currIndex] += candies;
                    candies = 0;
                }

                currIndex++;
                if (currIndex == num_people)
                {
                    currIndex = 0;
                }
            }

            return result;
        }
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> arrToList = arr1.ToList();
            arrToList.Sort();

            List<int> result = new List<int>();

            for (int i = 0; i < arr2.Length; i++)
            {
                while (arrToList.Contains(arr2[i]))
                {
                    arrToList.Remove(arr2[i]);
                    result.Add(arr2[i]);
                }
            }
            for (int i = 0; i < arrToList.Count; i++)
            {
                result.Add(arrToList[i]);
            }

            return result.ToArray();
        }
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            Dictionary<string, int> countDominoes = new Dictionary<string, int>();

            for (int i = 0; i < dominoes.Length; i++)
            {
                int tempValue1 = dominoes[i][0];
                int tempValue2 = dominoes[i][1];

                if (tempValue1 < tempValue2)
                {
                    string currString = tempValue1 + "," + tempValue2;
                    if (countDominoes.ContainsKey(currString))
                    {
                        countDominoes[currString]++;
                    }
                    else
                    {
                        countDominoes.Add(currString, 0);
                    }
                }
                else
                {
                    string currString = tempValue2 + "," + tempValue1;
                    if (countDominoes.ContainsKey(currString))
                    {
                        countDominoes[currString]++;
                    }
                    else
                    {
                        countDominoes.Add(currString, 0);
                    }
                }
            }

            int result = 0;

            foreach (var item in countDominoes.Values)
            {
                if (item > 0)
                {
                    result += (item + 1) * (item) / 2;
                }
            }

            return result;
        }
        public int Tribonacci(int n)
        {
            int prev = 0;
            int prevprev = 0;
            int prevprevprev = 0;
            int result = 0;

            if (n > 2)
            {
                prev = 1;
            }
            else
            {
                return 0;
            }

            while (n > 1)
            {
                result = prev + prevprev + prevprevprev;
                prevprevprev = prevprev;
                prevprev = prev;
                prev = result;
                n--;
            }

            return result;
        }
        public int DayOfYear(string date)
        {
            DateTime stringToDateTime = DateTime.Parse(date);

            return stringToDateTime.DayOfYear;
        }
        public int CountCharacters(string[] words, string chars)
        {
            Dictionary<char, int> dictionaryChars = new Dictionary<char, int>();
            int result = 0;
            bool allCharsOk = true;

            foreach (char currChar in chars)
            {
                if (dictionaryChars.ContainsKey(currChar))
                {
                    dictionaryChars[currChar]++;
                }
                else
                {
                    dictionaryChars.Add(currChar, 1);
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> currDictionaryChars = new Dictionary<char, int>(dictionaryChars);
                allCharsOk = true;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (currDictionaryChars.ContainsKey(words[i][j]))
                    {
                        if (currDictionaryChars[words[i][j]] > 1)
                        {
                            currDictionaryChars[words[i][j]]--;
                        }
                        else
                        {
                            currDictionaryChars.Remove(words[i][j]);
                        }
                    }
                    else
                    {
                        allCharsOk = false;
                        break;
                    }
                }

                if (allCharsOk)
                {
                    Console.WriteLine(words[i]);
                    result += words[i].Length;
                }
            }

            return result;
        }
        public int NumPrimeArrangements(int n)
        {
            int[] primesNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];
            int howManyPrimeNumbers = 0;
            ulong combinationPrime = 0;
            ulong combinationNoPrime = 0;
            ulong mod = 1000000007;
            if (n == 1)
            {
                return 0;
            }
            if (n >= 97)
            {
                howManyPrimeNumbers = 25;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (primesNumbers[i] <= n)
                    {
                        howManyPrimeNumbers++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int howManyNoPrimeNumbers = n - howManyPrimeNumbers;

            while (howManyPrimeNumbers != 0)
            {
                if (combinationPrime == 0)
                {
                    combinationPrime = (ulong)howManyPrimeNumbers;
                }
                else
                {
                    combinationPrime = (combinationPrime * (ulong)howManyPrimeNumbers) % mod;
                }
                howManyPrimeNumbers--;
            }

            while (howManyNoPrimeNumbers != 0)
            {
                if (combinationNoPrime == 0)
                {
                    combinationNoPrime = (ulong)howManyNoPrimeNumbers;
                }
                else
                {
                    combinationNoPrime = (combinationNoPrime * (ulong)howManyNoPrimeNumbers) % mod;
                }
                howManyNoPrimeNumbers--;
            }

            ulong result = ((ulong)combinationNoPrime * (ulong)combinationPrime) % mod;
            return (int)result;
        }
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int length = distance.Length;
            int reverseRouteDistance = 0;
            int routeDistance = 0;
            int indexReverseRoute = start;
            int indexRoute = start;
            bool endRoute = false;
            bool endReverseRoute = false;

            while (!endRoute || !endReverseRoute)
            {
                if (!endRoute)
                {
                    if (indexRoute == destination)
                    {
                        endRoute = true;
                    }
                    else
                    {
                        if (indexRoute >= length)
                        {
                            indexRoute = 0;
                            if (indexRoute == destination)
                            {
                                endRoute = true;
                            }
                            else
                            {
                                routeDistance += distance[0];
                            }
                        }
                        else
                        {
                            if (indexRoute < 1)
                            {
                                routeDistance += distance[0];
                            }
                            else
                            {
                                routeDistance += distance[indexRoute];
                            }
                        }
                    }
                    indexRoute++;
                }
                else
                {
                    if (routeDistance < reverseRouteDistance)
                    {
                        return routeDistance;
                    }
                }

                if (!endReverseRoute)
                {
                    if (indexReverseRoute == destination)
                    {
                        endReverseRoute = true;
                    }
                    else
                    {
                        if (indexReverseRoute < 0)
                        {
                            indexReverseRoute = length;
                            if (indexReverseRoute == destination)
                            {
                                endReverseRoute = true;
                            }
                        }
                        else
                        {
                            if (indexReverseRoute < 1)
                            {
                                reverseRouteDistance += distance[length - 1];
                            }
                            else
                            {
                                reverseRouteDistance += distance[indexReverseRoute - 1];
                            }
                        }
                    }
                    indexReverseRoute--;
                }
                else
                {
                    if (reverseRouteDistance < routeDistance)
                    {
                        return reverseRouteDistance;
                    }
                }
            }

            return Math.Min(reverseRouteDistance, routeDistance);
        }
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dateTime = new DateTime(year, month, day);

            return dateTime.DayOfWeek.ToString();
        }
        public int MaxNumberOfBalloons(string text)
        {
            Dictionary<char, int> dictionaryBallon = new Dictionary<char, int>() { { 'b', 1 }, { 'a', 1 }, { 'l', 2 }, { 'o', 2 }, { 'n', 1 } };
            Dictionary<char, int> dictionaryTextOnlyCharsBallon = new Dictionary<char, int>() { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
            int result = int.MaxValue;

            foreach (char letter in text)
            {
                if (dictionaryTextOnlyCharsBallon.ContainsKey(letter))
                {
                    dictionaryTextOnlyCharsBallon[letter]++;
                }
            }

            foreach (var item in dictionaryTextOnlyCharsBallon)
            {
                int temp = item.Value / dictionaryBallon[item.Key];
                result = result < temp ? result : temp;
            }

            return result;
        }
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(arr);

            int minAbs = int.MaxValue;

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = 0;
                if (arr[i - 1] < 0 && arr[i] > 0)
                {
                    temp = arr[i] + Math.Abs(arr[i - 1]);
                }
                else
                {
                    temp = Math.Abs(Math.Abs(arr[i - 1]) - Math.Abs(arr[i]));
                }
                minAbs = minAbs < temp ? minAbs : temp;
            }

            //Console.WriteLine(minAbs);

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = 0;
                if (arr[i - 1] < 0 && arr[i] > 0)
                {
                    temp = arr[i] + Math.Abs(arr[i - 1]);
                }
                else
                {
                    temp = Math.Abs(Math.Abs(arr[i - 1]) - Math.Abs(arr[i]));
                }
                if (temp == minAbs)
                {
                    result.Add(new List<int>() { arr[i - 1], arr[i] });
                }
            }

            return result;
        }
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dictionaryArr = new Dictionary<int, int>();

            foreach (int item in arr)
            {
                if (dictionaryArr.ContainsKey(item))
                {
                    dictionaryArr[item]++;
                }
                else
                {
                    dictionaryArr.Add(item, 1);
                }
            }

            HashSet<int> uniqueCount = new HashSet<int>();

            foreach (var item in dictionaryArr)
            {
                if (uniqueCount.Contains(item.Value))
                {
                    return false;
                }
                else
                {
                    uniqueCount.Add(item.Value);
                }
            }

            return true;
        }
        public int MinCostToMoveChips(int[] position)
        {
            int howManyDivisibleByOne = 0;
            int howManyDivisibleByTwo = 0;

            foreach (int i in position)
            {
                if (i % 2 != 0)
                {
                    howManyDivisibleByOne++;
                }
                else
                {
                    howManyDivisibleByTwo++;
                }
            }

            return Math.Min(howManyDivisibleByOne, howManyDivisibleByTwo);
        }
        public int BalancedStringSplit(string s)
        {
            int result = 0;
            int balance = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if (balance == 0)
                {
                    result++;
                }
            }

            return result;
        }
        public int RemoveDuplicatesTask80(int[] nums)
        {
            int countingTheSameNumbers = 1;
            int lastNumber = nums[0];
            int trueIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int currValue = nums[i];
                if (currValue == lastNumber)
                {
                    countingTheSameNumbers++;
                    if (countingTheSameNumbers > 2)
                    {
                        continue;
                    }
                    else
                    {
                        trueIndex++;
                        nums[trueIndex] = currValue;
                    }
                }
                else
                {
                    lastNumber = currValue;
                    countingTheSameNumbers = 1;
                    trueIndex++;
                    nums[trueIndex] = currValue;
                }
            }

            return ++trueIndex;
        }
        public void Rotate(int[] nums, int k)
        {
            //[1, 2, 3, 4, 5, 6, 7], k = 3
            int length = nums.Length;
            k = k % length;
            int[] dummyNums = nums.ToArray();

            ////Only for test
            Console.WriteLine(string.Join(',', nums));

            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine(i);
                int tempValue = dummyNums[i];
                if (i + k >= length)
                {
                    nums[(i + k) % length] = tempValue;
                }
                else
                {
                    //nums[i] = nums[i+k];
                    nums[i + k] = tempValue;
                }
            }

            ////Only for test
            Console.WriteLine(string.Join(',', nums));
        }
        public int MaxProfitTask122(int[] prices)
        {
            int result = 0;
            int buy = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else
                {
                    result += prices[i] - buy;
                    buy = prices[i];
                }
            }

            return result;
        }
        public bool CanJump(int[] nums)
        {
            int maxIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (maxIndex < i)
                {
                    return false;
                }

                maxIndex = Math.Max(maxIndex, i + (nums[i]));
                if (maxIndex >= nums.Length - 1)
                {
                    return true;
                }
            }

            return true;
        }
        public int Jump(int[] nums)
        {
            int maxRange = 0;
            int endIndex = nums.Length - 1;
            int jumpCount = 0;
            int currMax = 0;

            for (int i = 0; i < endIndex; i++)
            {
                maxRange = Math.Max(maxRange, i + nums[i]);

                if (currMax == i)
                {
                    jumpCount++;
                    currMax = maxRange;
                    if (currMax >= endIndex)
                    {
                        return jumpCount;
                    }
                }
            }

            return jumpCount;
        }
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int count = 0;
            int publication = 1;
            for (int i = citations.Length; i > 0; i--)
            {
                if (citations[i - 1] >= publication)
                {
                    publication++;
                    count++;
                }
                else
                {
                    return count;
                }
            }

            return publication - 1;
        }
        public class RandomizedSetTask380
        {
            private Dictionary<int, int> dictionaryValue;
            private List<int> listValue;
            private Random rnd;

            public RandomizedSetTask380()
            {
                listValue = new List<int>();
                dictionaryValue = new Dictionary<int, int>();
                rnd = new Random();
            }

            public bool Insert(int val)
            {
                if (dictionaryValue.ContainsKey(val))
                {
                    return false;
                }

                dictionaryValue[val] = dictionaryValue.Count;
                listValue.Add(val);
                return true;
            }

            public bool Remove(int val)
            {
                if (!dictionaryValue.ContainsKey(val)) return false;

                int indexListValue = dictionaryValue[val];
                int lastElementValue = listValue[listValue.Count - 1];
                listValue[indexListValue] = lastElementValue;
                dictionaryValue[lastElementValue] = indexListValue;

                listValue.RemoveAt(listValue.Count - 1);
                dictionaryValue.Remove(val);

                return true;
            }

            public int GetRandom()
            {
                return listValue[rnd.Next(listValue.Count)];
            }
        }
        public int[] ProductExceptSelf(int[] nums)
        {
            int leftSum = 1;
            int rightSum = 1;
            int lengthNums = nums.Length;
            int[] leftArray = new int[lengthNums];
            int[] rightArray = new int[lengthNums];

            if (lengthNums > 2)
            {
                leftArray[0] = 1;
                rightArray[lengthNums - 1] = 1;
            }
            else
            {
                return new int[] { nums[1], nums[0] };
            }

            for (int i = 1; i < lengthNums; i++)
            {
                leftSum *= nums[i - 1];
                leftArray[i] = leftSum;

                rightSum *= nums[lengthNums - i];
                rightArray[lengthNums - i - 1] = rightSum;
            }

            nums[0] = rightArray[0];
            nums[lengthNums - 1] = leftArray[lengthNums - 1];

            for (int i = 1; i < lengthNums - 1; i++)
            {
                nums[i] = leftArray[i] * rightArray[i];
            }

            return nums;
        }
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            bool end = false;

            int index = 1;
            int total = gas[0] - cost[0];
            int currTotal = gas[0];
            int length = gas.Length;
            int counterStationX2 = length * 2;
            int counterStation = length;
            int startIndex = 0;
            int prevIndex = 0;

            if (length == 1)
            {
                if (gas[0] >= cost[0])
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            while (!end)
            {
                if (counterStationX2 == 0)
                {
                    return -1;
                }
                currTotal -= cost[prevIndex];
                if (currTotal < 0)
                {
                    startIndex = index;
                    currTotal = gas[index];
                    counterStation = length;
                }
                else
                {
                    currTotal += gas[index];
                }

                counterStation--;
                if (counterStation == 0)
                {
                    if (startIndex - 1 < 0)
                    {
                        if (currTotal < 0)
                        {
                            startIndex = 1;
                            index = startIndex;
                            currTotal = gas[index];
                            counterStation = length;
                        }
                        else
                        {
                            return startIndex;
                        }
                    }
                    else
                    {
                        if (currTotal < cost[startIndex - 1])
                        {
                            if (startIndex + 1 == length)
                            {
                                startIndex = 0;
                            }
                            else
                            {
                                startIndex = startIndex + 1;
                            }

                            index = startIndex;
                            currTotal = gas[index];
                            counterStation = length;
                        }
                        else
                        {
                            return startIndex;
                        }
                    }
                }
                prevIndex = index;
                index++;
                if (index == length)
                {
                    index = 0;
                }
                counterStationX2--;
            }

            return startIndex;
        }
        public string ReverseWordsTask151(string s)
        {
            string[] splitWords = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            ////Option 1
            //List<string> words = new List<string>();

            //for (int i = splitWords.Length -1; i >=0; i--)
            //{
            //    words.Add(splitWords[i]);
            //}

            //return string.Join(' ', words);



            ////OR
            ////Option 2

            Array.Reverse(splitWords);
            return string.Join(' ', splitWords.ToArray());

        }
        
        Dictionary<int, long[]> dictSumCountTask637;
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> result = new List<double>();
            dictSumCountTask637 = new Dictionary<int, long[]>();
            int level = 0;
            if (root != null)
            {
                AverageOfLevelsDeep(root, 0);
            }

            foreach (var item in dictSumCountTask637)
            {
                //double temp = (double)(Convert.ToDouble(item.Value[0]) / Convert.ToDouble(item.Value[1]));
                result.Add(Convert.ToDouble(item.Value[0]) / Convert.ToDouble(item.Value[1]));
            }

            return result;
        }
        private void AverageOfLevelsDeep(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (dictSumCountTask637.ContainsKey(level))
            {
                long[] temp = dictSumCountTask637[level];
                temp[0] += root.val;
                temp[1]++;
                dictSumCountTask637[level] = temp;
            }
            else
            {
                dictSumCountTask637.Add(level, [root.val, 1]);
            }
            level++;
            AverageOfLevelsDeep(root.left, level);
            AverageOfLevelsDeep(root.right, level);
        }
        public int[] TwoSumTask167(int[] numbers, int target)
        {
            bool end = false;
            int L = 0;
            int R = numbers.Length - 1;
            while (!end)
            {
                if (numbers[L] + numbers[R] < target)
                {
                    L++;
                }
                else if (numbers[L] + numbers[R] > target)
                {
                    R--;
                }
                else if (numbers[L] + numbers[R] == target)
                {
                    return new int[] { L + 1, R + 1 };
                }
            }

            return numbers;
        }
        public int MinSubArrayLen(int target, int[] nums)
        {
            int L = 0;
            int R = 1;
            int result = int.MaxValue;
            bool end = false;

            if (nums.Length == 1)
            {
                if (nums[0] < target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            int sum = nums[L] + nums[R];

            if (nums[L] >= target || nums[R] >= target)
            {
                return 1;
            }

            while (!end)
            {
                if (sum < target)
                {
                    R++;
                    if (R == nums.Length)
                    {
                        if (result != int.MaxValue)
                        {
                            return result;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    if (nums[R] == target)
                    {
                        return 1;
                    }
                    sum += nums[R];
                }
                else
                {
                    //if (nums[R] == target)
                    //{
                    //    return 1;
                    //}
                    result = Math.Min(R - L + 1, result);
                    sum -= nums[L];
                    L++;
                }
                if (R == L)
                {
                    return Math.Min(R - L + 2, result);
                }
            }


            if (result == int.MaxValue)
            {
                return 0;
            }
            return result;
        }
        public void Rotate(int[][] matrix)
        {
            int length = matrix.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][length - 1 - j];
                    matrix[i][length - 1 - j] = temp;
                }
            }
        }
        public class LRUCache
        {
            private List<int> _cacheKey;
            private List<int> _cacheValue;

            private int _maxSize;
            public LRUCache(int capacity)
            {
                _cacheKey = new List<int>();
                _cacheValue = new List<int>();
                _maxSize = capacity;
            }

            public int Get(int key)
            {
                if (_cacheKey.Contains(key))
                {
                    int temp = _cacheKey.IndexOf(key);
                    int tempValue = _cacheValue[temp];
                    _cacheKey.RemoveAt(temp);
                    _cacheValue.RemoveAt(temp);
                    //_lastKeyUsed = key;
                    _cacheKey.Add(key);
                    _cacheValue.Add(tempValue);
                    return tempValue;
                }
                else
                {
                    return -1;
                }
            }

            public void Put(int key, int value)
            {
                if (_maxSize > 0)
                {
                    if (_cacheKey.Contains(key))
                    {
                        int temp = _cacheKey.IndexOf(key);
                        int tempValue = _cacheValue[temp];
                        _cacheKey.RemoveAt(temp);
                        _cacheValue.RemoveAt(temp);
                        //_lastKeyUsed = key;
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                    else
                    {
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                        _maxSize--;
                    }
                }
                else
                {
                    if (_cacheKey.Contains(key))
                    {
                        int temp = _cacheKey.IndexOf(key);
                        int tempValue = _cacheValue[temp];
                        _cacheKey.RemoveAt(temp);
                        _cacheValue.RemoveAt(temp);
                        //_lastKeyUsed = key;
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                    else
                    {
                        _cacheKey.RemoveAt(0);
                        _cacheValue.RemoveAt(0);
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                }
            }
        }
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int height = triangle.Count;
            int[] sum = new int[height + 1];

            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    sum[j] = Math.Min(sum[j], sum[j + 1]) + triangle[i][j];
                    //Console.WriteLine(triangle[i][j]);
                }
            }

            return sum[0];
        }
        public int MinPathSum(int[][] grid)
        {
            int height = grid.Length;
            int length = grid[0].Length;

            int[] DP = new int[length + 1];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            DP[j] = grid[i][j];
                        }
                        else
                        {
                            DP[j] = DP[j - 1] + grid[i][j];
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            DP[j] = DP[j] + grid[i][j];
                        }
                        else
                        {
                            DP[j] = Math.Min(DP[j - 1], DP[j]) + grid[i][j];
                        }
                    }
                }
            }

            return DP[length - 1];
        }
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int height = obstacleGrid.Length;
            int length = obstacleGrid[0].Length;

            int[] DP = new int[length];

            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    DP[i] = 1;
                }
                else
                {
                    if (obstacleGrid[0][i] == 0 && DP[i - 1] == 1)
                    {
                        DP[i] = 1;
                    }
                    else
                    {
                        DP[i] = 0;
                    }
                }
            }

            for (int level = 1; level < height; level++)
            {
                for (int indexLength = 0; indexLength < length; indexLength++)
                {
                    if (indexLength == 0)
                    {
                        if (obstacleGrid[level][indexLength] != 0)
                        {
                            DP[indexLength] = 0;
                        }
                    }
                    else
                    {
                        if (obstacleGrid[level][indexLength] != 0)
                        {
                            DP[indexLength] = 0;
                        }
                        else
                        {
                            DP[indexLength] = DP[indexLength - 1] + DP[indexLength];
                        }
                    }
                }
            }

            return DP[length - 1];
        }
        public bool IsInterleave(string s1, string s2, string s3)
        {
            int lengthS1 = s1.Length;
            int lengthS2 = s2.Length;

            if (lengthS1 + lengthS2 != s3.Length)
            {
                return false;
            }

            bool[] dp = new bool[lengthS2 + 1];

            for (int i = 0; i <= lengthS1; i++)
            {
                for (int j = 0; j <= lengthS2; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[j] = true;
                    }
                    else if (i == 0)
                    {
                        //Console.WriteLine("dp[j-1]: " + dp[j-1] +"");
                        //Console.WriteLine("s3[j - 1] == s2[j - 1]: " + s3[j - 1] + " and : " +s2[j - 1] +" ");
                        //if (s3[j - 1] == s2[j - 1])
                        //{
                        //    Console.WriteLine("s3[j - 1] == s2[j - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[j - 1] == s2[j - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j - 1] && s3[j - 1] == s2[j - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                    else if (j == 0)
                    {
                        //Console.WriteLine("dp[j]: " + dp[j] + "");
                        //Console.WriteLine("s3[i - 1] == s1[i - 1]: " + s3[i - 1] + " and : " + s1[i - 1] + " ");
                        //if (s3[i - 1] == s1[i - 1])
                        //{
                        //    Console.WriteLine("s3[i - 1] == s1[i - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[i - 1] == s1[i - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j] && s3[i - 1] == s1[i - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                    else
                    {
                        //Console.WriteLine("");
                        //Console.WriteLine("dp[j]: " + dp[j] + "");
                        //Console.WriteLine("s3[i + j - 1] == s1[i - 1]: " + s3[j + i - 1] + " and : " + s1[i - 1] + " ");
                        //if (s3[j + i - 1] == s1[i - 1])
                        //{
                        //    Console.WriteLine("s3[i + j - 1] == s1[i - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3i + j - 1] == s1[i - 1]: False");
                        //}
                        //Console.WriteLine("and");
                        //Console.WriteLine("dp[j-1]: " + dp[j - 1] + "");
                        //Console.WriteLine("s3[j + i - 1] == s2[j - 1]: " + s3[j + i - 1] + " and : " + s2[j - 1] + " ");
                        //if (s3[j + i - 1] == s2[j - 1])
                        //{
                        //    Console.WriteLine("s3[j + i - 1] == s2[j - 1]: True");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("s3[j + i - 1] == s2[j - 1]: False");
                        //}
                        //Console.WriteLine("");

                        if (dp[j] && s3[i + j - 1] == s1[i - 1] || dp[j - 1] && s3[j + i - 1] == s2[j - 1])
                        {
                            dp[j] = true;
                        }
                        else
                        {
                            dp[j] = false;
                        }
                    }
                }
            }

            return dp[lengthS2];
        }
        //// Option 2 - recursive, too slow.
        #region Option 2 - code 
        //private bool statusOk;
        //private int lengthS1;
        //private int lengthS2;
        //private int lengthS3;
        //private string _s3;
        //private string _s2;
        //private string _s1;
        //public bool IsInterleave(string s1, string s2, string s3)
        //{
        //    statusOk = false;
        //    lengthS3 = s3.Length;
        //    lengthS2 = s2.Length;
        //    lengthS1 = s1.Length;
        //    _s3 = s3;
        //    _s2 = s2;
        //    _s1 = s1;

        //    if (lengthS2+lengthS1 != lengthS3)
        //    {
        //        return false;
        //    }

        //    int indexS1 = 0;
        //    int indexS2 = 0;

        //    for (int i = 0; i < lengthS3; i++)
        //    {
        //        //Console.WriteLine(s1[indexS1]);
        //        //Console.WriteLine(s2[indexS2]);
        //        //Console.WriteLine(s3[i]);
        //        if (indexS1 < lengthS1 && s3[i] == s1[indexS1])
        //        {
        //            if (indexS2 < lengthS2)
        //            {
        //                if (s3[i] == s2[indexS2])
        //                {
        //                    CheckRecursiveInDP(indexS1+1, indexS2, i+1);
        //                    if (statusOk)
        //                    {
        //                        return true;
        //                    }
        //                    CheckRecursiveInDP(indexS1, indexS2+1, i+1);
        //                    if (statusOk)
        //                    {
        //                        return true;
        //                    }
        //                    break;
        //                }
        //                else
        //                {
        //                    if (_s3[i] == s1[indexS1])
        //                    {
        //                        indexS1++;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (_s3[i] == s1[indexS1])
        //                {
        //                    indexS1++;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        else if (indexS2 < lengthS2)
        //        {
        //            if (s3[i] == s2[indexS2])
        //            {
        //                indexS2++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        else if (statusOk)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //        if (i == lengthS3 - 1)
        //        {
        //            statusOk = true;
        //        }
        //    }

        //    if (statusOk)
        //    {
        //        return true;
        //    }
        //    else if (lengthS1 == 0 && lengthS2 == 0 && lengthS3 == 0) 
        //    {
        //        return true;
        //    }

        //    return false;
        //}


        //private void CheckRecursiveInDP(int indexS1, int indexS2, int indexS3)
        //{
        //    for (int i = indexS3; i < lengthS3; i++)
        //    {
        //        //Console.WriteLine("new");
        //        // Console.WriteLine(_s1[indexS1]);
        //        //Console.WriteLine(_s2[indexS2]);
        //        //Console.WriteLine(_s3[i]);
        //        if (indexS1 < lengthS1 && _s3[i] == _s1[indexS1])
        //        {
        //            if (indexS2 < lengthS2)
        //            {
        //                if (_s3[i] == _s2[indexS2])
        //                {
        //                    CheckRecursiveInDP(indexS1+1, indexS2, i + 1);
        //                    if (statusOk)
        //                    {
        //                        return;
        //                    }
        //                    CheckRecursiveInDP(indexS1, indexS2+1, i + 1);
        //                    if (statusOk) 
        //                    {
        //                        return;
        //                    }
        //                }
        //                else
        //                {
        //                    if (_s3[i] == _s1[indexS1])
        //                    {
        //                        indexS1++;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (_s3[i] == _s1[indexS1])
        //                {
        //                    indexS1++;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        else if (indexS2 < lengthS2)
        //        {
        //            if (_s3[i] == _s2[indexS2])
        //            {
        //                indexS2++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //        if (statusOk)
        //        {
        //            return;
        //        }
        //        if (i == lengthS3 - 1)
        //        {
        //            statusOk = true;
        //            return;
        //        }
        //    }
        //}
        #endregion
        public int MaxDifference(string s)
        {
            Dictionary<char, int> dictionaryS = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dictionaryS.ContainsKey(c))
                {
                    dictionaryS[c]++;
                }
                else
                {
                    dictionaryS.Add(c, 1);
                }
            }

            int minEven = int.MaxValue;
            int maxOdd = int.MinValue;

            foreach (var item in dictionaryS)
            {
                if (item.Value % 2 == 0)
                {
                    if (minEven > item.Value)
                    {
                        minEven = item.Value;
                    }
                }
                else
                {
                    if (maxOdd < item.Value)
                    {
                        maxOdd = item.Value;
                    }
                }
            }

            return maxOdd - minEven;
        }
        public bool IsArraySpecial(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            bool statusEven = false;

            if (nums[0] % 2 == 0)
            {
                statusEven = true;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    if (statusEven == true)
                    {
                        return false;
                    }
                    else
                    {
                        statusEven = true;
                    }
                }
                else
                {
                    if (statusEven == false)
                    {
                        return false;
                    }
                    else
                    {
                        statusEven = false;
                    }
                }
            }

            return true;
        }
        public bool Check(int[] nums)
        {
            int lastValue = nums[0];
            bool statusBreak = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (lastValue > nums[i])
                {
                    if (statusBreak)
                    {
                        return false;
                    }
                    else
                    {
                        statusBreak = true;
                    }
                }
                lastValue = nums[i];
            }

            if (statusBreak)
            {
                if (nums[0] >= nums[nums.Length - 1])
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        public string TriangleType(int[] nums)
        {
            if (nums[0] == nums[1] && nums[0] == nums[2])
            {
                return "equilateral";
            }
            else if (nums[0] == nums[1] || nums[1] == nums[2] || nums[0] == nums[2])
            {
                if (IsTriangleTask3024(nums))
                {
                    return "isosceles";
                }
                else
                {
                    return "none";
                }
            }
            else
            {
                if (IsTriangleTask3024(nums))
                {
                    return "scalene";
                }
                else
                {
                    return "none";
                }
            }
        }
        public bool IsTriangleTask3024(int[] nums)
        {
            if (nums[0] <= nums[1] && nums[0] <= nums[2])
            {
                if (nums[1] <= nums[2])
                {
                    if (nums[2] < nums[1] + nums[0])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[1] < nums[0] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (nums[1] <= nums[2] && nums[1] <= nums[0])
            {
                if (nums[0] <= nums[2])
                {
                    if (nums[2] < nums[0] + nums[1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[0] < nums[1] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (nums[1] <= nums[0])
                {
                    if (nums[0] < nums[1] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[1] < nums[0] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public int MaxAdjacentDistance(int[] nums)
        {
            int max = Math.Abs(nums[0] - nums[nums.Length - 1]);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, Math.Abs(nums[i] - nums[i + 1]));
            }

            return max;
        }
        public int MinDistance(string word1, string word2)
        {
            int lengthWord1 = word1.Length;
            int lengthWord2 = word2.Length;

            int[][] dp = new int[lengthWord2 + 1][];

            for (int i = 0; i <= lengthWord2; i++)
            {
                dp[i] = new int[lengthWord1 + 1];
                dp[i][0] = i;
            }

            for (int i = 1; i <= lengthWord1; i++)
            {
                dp[0][i] = i;
            }

            for (int i = 1; i <= lengthWord2; i++)
            {
                for (int j = 1; j <= lengthWord1; j++)
                {
                    if (word2[i - 1] == word1[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i][j - 1], dp[i - 1][j])) + 1;
                    }
                }
            }


            return dp[lengthWord2][lengthWord1];
        }
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);

            int lengthNums = nums.Length;

            int left = 0;
            int right = nums[lengthNums - 1] - nums[0];

            while (left < right)
            {
                int middle = left + (right - left) / 2;

                if (countValidPairsTask2616(nums, middle, lengthNums) >= p)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return left;

        }
        private int countValidPairsTask2616(int[] nums, int middle, int lengthNums)
        {
            int count = 0;
            int i = 0;

            while (i < lengthNums - 1)
            {
                if (nums[i + 1] - nums[i] <= middle)
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
        public int MinMaxDifference(int num)
        {
            string stringNum = num.ToString();
            string stringMin = string.Empty;
            string stringMax = string.Empty;
            char setToMAx = ' ';
            char setToMin = ' ';

            for (int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] != '9')
                {
                    if (setToMAx == ' ')
                    {
                        setToMAx = stringNum[i];
                    }
                    if (stringNum[i] == setToMAx)
                    {
                        stringMax += '9';
                    }
                    else
                    {
                        stringMax += stringNum[i];
                    }
                }
                else
                {
                    stringMax += '9';
                }

                if (stringNum[i] != '0')
                {
                    if (setToMin == ' ')
                    {
                        setToMin = stringNum[i];
                    }
                    if (stringNum[i] == setToMin)
                    {
                        stringMin += 0;
                    }
                    else
                    {
                        stringMin += stringNum[i];
                    }
                }
                else
                {
                    if (setToMin != ' ')
                    {
                        stringMin += stringNum[i];
                    }
                }
            }

            return Convert.ToInt32(stringMax) - Convert.ToInt32(stringMin);
        }
        public int MaximalSquare(char[][] matrix)
        {
            int max = 0;
            int high = matrix.Length;
            int length = matrix[0].Length;

            int[] dp = new int[length];
            int[] lastDP = new int[length];

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        dp[j] = matrix[i][j] - '0';
                        if (matrix[i][j] == '1')
                        {
                            max = 1;
                        }
                    }
                    else if (j == 0)
                    {
                        if (matrix[i][0] == '0')
                        {
                            dp[0] = 0;
                        }
                        else
                        {
                            dp[0] = 1;
                            if (max == 0)
                            {
                                max = 1;
                            }
                        }
                    }
                    else
                    {
                        if (matrix[i][j] == '1' && matrix[i][j - 1] == '1' && matrix[i - 1][j - 1] == '1' && dp[j - 1] >= 1 && dp[j] >= 1)
                        {
                            if (dp[j - 1] == lastDP[j - 1] && dp[j - 1] == dp[j])
                            {
                                dp[j]++;
                            }
                            else if (dp[j] < dp[j - 1])
                            {
                                dp[j]++;
                            }
                            else if (dp[j] > dp[j - 1])
                            {
                                dp[j] = dp[j - 1] + 1;
                            }
                            else if (dp[j] < lastDP[j - 1])
                            {
                                dp[j]++;
                            }
                            if (dp[j] > max)
                            {
                                max = dp[j];
                            }
                            //if (dp[j - 1] == dp[j])
                            //{
                            //    dp[j] = dp[j] + 1;
                            //}
                            //else
                            //{
                            //    dp[j] = 1;
                            //}
                        }
                        else if (matrix[i][j] == '1')
                        {
                            dp[j] = 1;
                            if (max == 0)
                            {
                                max = 1;
                            }
                        }
                        else
                        {
                            dp[j] = 0;
                        }
                    }
                }
                lastDP = dp.ToArray();
            }

            if (max == 1)
            {
                return 1;
            }
            else
            {
                return max * max;
            }
        }
        public int MaxDiff(int num)
        {
            string stringNum = num.ToString();
            string stringMin = string.Empty;
            string stringMax = string.Empty;
            char setToMAx = ' ';
            char setToMin = ' ';
            bool flagForMax = true;
            bool flagForMin = true;
            bool minToOne = false;
            bool lockOne = false;

            for (int i = 0; i < stringNum.Length; i++)
            {
                if (i == 0)
                {
                    if (stringNum[i] == '9')
                    {
                        stringMax += '9';
                    }
                    else
                    {
                        setToMAx = stringNum[i];
                        stringMax += '9';
                        flagForMax = false;
                    }

                    if (stringNum[i] == '1')
                    {
                        stringMin += '1';
                        lockOne = true;
                    }
                    else
                    {
                        setToMin = stringNum[i];
                        stringMin += '1';
                        flagForMin = false;
                        minToOne = true;
                    }
                }
                else
                {
                    if (flagForMax)
                    {
                        if (stringNum[i] == '9')
                        {
                            stringMax += '9';
                        }
                        else
                        {
                            setToMAx = stringNum[i];
                            stringMax += '9';
                            flagForMax = false;
                        }
                    }
                    else
                    {
                        if (stringNum[i] == '9')
                        {
                            stringMax += '9';
                        }
                        else if (stringNum[i] == setToMAx)
                        {
                            stringMax += '9';
                        }
                        else
                        {
                            stringMax += stringNum[i];
                        }
                    }

                    if (flagForMin)
                    {
                        if (stringNum[i] == '0')
                        {
                            stringMin += '0';
                        }
                        else
                        {
                            if (lockOne && stringNum[i] == '1')
                            {
                                stringMin += '1';
                            }
                            else
                            {
                                setToMin = stringNum[i];
                                stringMin += '0';
                                flagForMin = false;
                            }
                        }
                    }
                    else
                    {
                        if (stringNum[i] == '0')
                        {
                            stringMin += '0';
                        }
                        else if (stringNum[i] == setToMin)
                        {
                            if (minToOne)
                            {
                                stringMin += '1';
                            }
                            else
                            {
                                stringMin += "0";
                            }
                        }
                        else
                        {
                            stringMin += stringNum[i];
                        }
                    }
                }
            }
            return Convert.ToInt32(stringMax) - Convert.ToInt32(stringMin);
        }
        public int MaxProfitTask123(int[] prices)
        {
            int length = prices.Length;

            if (length == 0) return 0;

            int[] left = new int[length];
            int[] right = new int[length];
            int leftMaxProfit = 0;
            int rigthMaxProfit = 0;
            int leftMinBuy = prices[0];
            int rigthMaxSell = prices[length - 1];

            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                if (leftMinBuy > prices[i])
                {
                    leftMinBuy = prices[i];
                    left[i] = leftMaxProfit;
                }
                else
                {
                    if (leftMaxProfit < prices[i] - leftMinBuy)
                    {
                        leftMaxProfit = prices[i] - leftMinBuy;
                        left[i] = leftMaxProfit;
                    }
                    else
                    {
                        left[i] = leftMaxProfit;
                    }
                }


                if (rigthMaxSell < prices[j])
                {
                    rigthMaxSell = prices[j];
                    right[j] = rigthMaxProfit;
                }
                else
                {
                    if (rigthMaxProfit < rigthMaxSell - prices[j])
                    {
                        rigthMaxProfit = rigthMaxSell - prices[j];
                        right[j] = rigthMaxProfit;
                    }
                    else
                    {
                        right[j] = rigthMaxProfit;
                    }
                }
            }

            int max = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, left[i] + right[i]);
            }

            return max;
        }
        public int MaximumDifference(int[] nums)
        {
            int min = nums[0];
            int maxDifference = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= min)
                {
                    min = nums[i];
                }
                else
                {
                    maxDifference = Math.Max(maxDifference, nums[i] - min);
                }

            }

            return maxDifference;
        }
        public int Rob(int[] nums)
        {
            //int sumPrevRob = 0;
            //int sumPrevNoRob = 0;

            //foreach (int i in nums) 
            //{
            //    int temp = Math.Max(sumPrevRob, sumPrevNoRob);

            //    sumPrevRob = sumPrevNoRob + i;

            //    sumPrevNoRob = temp;

            //}

            //return Math.Max(sumPrevRob, sumPrevNoRob);

            ////Option 2 - Dynamic programming, the same principle of operation - difference: instead of a few variables an int array
            int length = nums.Length;
            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];

            for (int i = 1; i < length; i++)
            {
                dp[i + 1] = dp[i - 1] + nums[i];

                dp[i] = Math.Max(dp[i - 1], dp[i]);
            }

            return Math.Max(dp[length], dp[length - 1]);
        }
        public int[][] DivideArray(int[] nums, int k)
        {
            int length = nums.Length;
            int[][] result = new int[length / 3][];
            bool canBeCreated = true;
            Array.Sort(nums);
            int indexPermutation = 0;
            for (int i = 2; i < length; i += 3)
            {
                if (nums[i] - nums[i - 2] > k)
                {
                    canBeCreated = false;
                    break;
                }
                result[indexPermutation] = new int[3] { nums[i - 2], nums[i - 1], nums[i] };
                indexPermutation++;
            }

            if (canBeCreated)
            {
                return result;
            }
            else
            {
                return new int[][] { };
            }
        }
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            int result = 1;
            int start = nums[0];
            int length = nums.Length;

            for (int i = 1; i < length; i++)
            {
                if (k < nums[i] - start)
                {
                    result++;
                    start = nums[i];
                }
            }
            return result;
        }
        public int MaxDistance(string s, int k)
        {
            int result = 0;
            int upN = 0;
            int downS = 0;
            int leftW = 0;
            int rightE = 0;
            int howManyMaxAdd = 0;

            for (int i = 0; i < s.Length; i++)
            {
                howManyMaxAdd = 0;
                switch (s[i])
                {
                    case 'N':
                        upN++;
                        break;
                    case 'S':
                        downS++;
                        break;
                    case 'W':
                        leftW++;
                        break;
                    default:
                        rightE++;
                        break;
                }

                if (upN <= downS)
                {
                    howManyMaxAdd += upN;
                }
                else
                {
                    howManyMaxAdd += downS;
                }

                if (leftW <= rightE)
                {
                    howManyMaxAdd += leftW;
                }
                else
                {
                    howManyMaxAdd += rightE;
                }

                result = Math.Max(result, Math.Abs(downS - upN) + Math.Abs(leftW - rightE) + Math.Min(k, howManyMaxAdd) * 2);

            }

            return result;
        }
        public int MinimumDeletions(string word, int k)
        {
            int minDelete = int.MaxValue;
            int[] listFreq = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                listFreq[word[i] - 'a']++;
            }

            Array.Sort(listFreq);
            int sumLeft = 0;
            int sumRight = 0;
            int prev = int.MaxValue;
            int[] dp = new int[listFreq.Length];

            for (int i = 0; i < listFreq.Length; i++)
            {
                if (prev == listFreq[i])
                {
                    dp[i] = dp[i - 1];
                    sumLeft += prev;
                }
                else
                {
                    sumRight = 0;
                    for (int j = i + 1; j < listFreq.Length; j++)
                    {
                        if (listFreq[j] - listFreq[i] > k)
                        {
                            sumRight += listFreq[j] - (listFreq[i] + k);
                        }
                    }
                    prev = listFreq[i];
                    minDelete = Math.Min(minDelete, sumLeft + sumRight);
                    sumLeft += prev;
                    dp[i] = minDelete;
                }
            }

            return minDelete;
        }
        public string[] DivideString(string s, int k, char fill)
        {
            ////Option 1 with string[]. Beats: 100%, runtime: 0 ms.

            int length = s.Length;
            string[] result = new string[(s.Length + k - 1) / k];
            int indexResult = 0;
            int count = 0;
            char[] currCharsWord = new char[k];

            for (int i = 0; i < length; i++)
            {
                if (count == k)
                {
                    count = 0;
                    result[indexResult] = new string(currCharsWord);
                    indexResult++;
                }
                currCharsWord[count] = s[i];
                count++;
            }

            if (count == 0)
            {
                return result;
            }
            else if (count == k)
            {
                result[indexResult] = new string(currCharsWord);
                return result;
            }
            else
            {
                for (int j = count; j < k; j++)
                {
                    currCharsWord[j] = fill;
                }
                result[indexResult] = new string(currCharsWord);
                return result;
            }

            ////Option 2 with List<string>. Beats: 66,67%, runtime: 1 ms. 
            //List<string> resultList = new List<string>();
            //int length = s.Length;
            //string currString = string.Empty;

            //for (int i = 0, j = 0; i < length; i++, j++)
            //{
            //    if(j == k)
            //    {
            //        resultList.Add(currString);
            //        currString = string.Empty;
            //        j = 0;
            //    }

            //    currString += s[i];

            //}
            //if (currString.Length == 0)
            //{
            //    return resultList.ToArray();
            //}
            //else if (currString.Length == k)
            //{
            //    resultList.Add(currString);
            //    return resultList.ToArray();
            //}
            //else
            //{
            //    while(currString.Length < k)
            //    {
            //        currString += fill;
            //    }
            //    resultList.Add(currString);
            //    return resultList.ToArray();
            //}
        }
        public int DifferenceOfSums(int n, int m)
        {
            int sumNum1 = 0;
            int sumNum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m > 0)
                {
                    sumNum1 += i;
                }
                else
                {
                    sumNum2 += i;
                }
            }

            return sumNum1 - sumNum2;
        }
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> result = new List<int>();

            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Contains(x))
                {
                    result.Add(j);
                }
            }

            return result.ToArray();
        }
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            List<int> result = new List<int>();
            int length = nums.Length;
            List<int> listFindIndex = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == key)
                {
                    listFindIndex.Add(i);
                }
            }
            int startIndex = listFindIndex[0] - k;
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            int howManyFind = listFindIndex.Count;
            int indexlist = 0;

            for (int i = startIndex; i < length; i++)
            {
                if (Math.Abs(listFindIndex[indexlist] - i) <= k)
                {
                    result.Add(i);
                }
                else
                {
                    if (indexlist < howManyFind - 1)
                    {
                        indexlist++;
                        if (Math.Abs(listFindIndex[indexlist] - i) <= k)
                        {
                            i--;
                        }
                        else
                        {
                            i = listFindIndex[indexlist] - 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }

            return result;
        }
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> priorityQueueList = new PriorityQueue<int, int>();
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                priorityQueueList.Enqueue(nums[i], -nums[i]);
            }

            for (int i = 1; i < k; i++)
            {
                priorityQueueList.Dequeue();
            }

            return priorityQueueList.Peek();
        }
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numsHashSet = new HashSet<int>(nums);
            int maxLengthConsecutive = 0;
            int currLength = 1;
            foreach (int i in numsHashSet)
            {
                if (!numsHashSet.Contains(i - 1))
                {
                    currLength = 1;
                    while (numsHashSet.Contains(i + currLength))
                    {
                        currLength++;
                    }

                    maxLengthConsecutive = Math.Max(maxLengthConsecutive, currLength);
                }
            }

            return maxLengthConsecutive;
        }
        public int LongestSubsequence(string s, int k)
        {
            int pow = 1;
            int result = 0;
            int lengthString = s.Length;
            int currValue = 0;

            for (int i = lengthString - 1; i >= 0; i--)
            {
                if (currValue + pow <= k)
                {
                    if (s[i] == '1')
                    {
                        result++;
                        currValue += pow;
                    }
                    else
                    {
                        result++;
                    }

                    pow *= 2;
                }
                else if (s[i] == '0')
                {
                    result++;
                }

            }

            return result;

            ////OR option 2:

            //int pow = 1;
            //int maxOnelength = 0;
            //int lengthString = s.Length;
            //int currValue = 0;

            //for (int i = lengthString - 1; i >= 0 && currValue + pow <= k; i--)
            //{
            //    if (s[i] == '1')
            //    {
            //        maxOnelength++;
            //        currValue += pow;
            //    }
            //    pow *= 2;
            //}

            //return s.Count(c => c == '0') + maxOnelength;
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Runtime: 17 ms.

            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> dictionaryString = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                int[] charsCount = new int[26];

                foreach (char charStr in str)
                {
                    charsCount[charStr - 'a']++;
                }

                string keyForDictionaryString = string.Join(',', charsCount);

                if (!dictionaryString.ContainsKey(keyForDictionaryString))
                {
                    dictionaryString.Add(keyForDictionaryString, new List<string>());
                    dictionaryString[keyForDictionaryString].Add(str);
                }
                else
                {
                    dictionaryString[keyForDictionaryString].Add(str);
                }

            }

            return dictionaryString.Values.ToList<IList<string>>();


            //// Runtime: 226 ms.

            //IList<IList<string>> result = new List<IList<string>>();

            //List<string> sortCharsList = new List<string>();
            //int index;

            //foreach (string str in strs) 
            //{
            //    char[] currChars = str.ToCharArray();
            //    Array.Sort(currChars);
            //    string temp = new string (currChars);
            //    if (sortCharsList.Contains(temp))
            //    {
            //        index = sortCharsList.IndexOf(new string (temp));
            //        result[index].Add(str);
            //    }
            //    else
            //    {
            //        sortCharsList.Add(temp);
            //        result.Add(new List<string> { str });
            //    }
            //}
            //return result;
        }
        public int[] MaxSubsequence(int[] nums, int k)
        {
            int[] result = new int[k];
            int length = nums.Length;

            if (k == length)
            {
                return nums;
            }

            Dictionary<int, int> dictionaryIndexValue = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                dictionaryIndexValue.Add(i, nums[i]);
            }

            Dictionary<int, int> dictionaryIndexValue1 = dictionaryIndexValue.OrderByDescending(x => x.Value).ThenByDescending(y => y.Key).ToDictionary<int, int>();
            Dictionary<int, int> dictionaryIndexValue2 = new Dictionary<int, int>();
            foreach (var item in dictionaryIndexValue1)
            {
                if (k <= 0)
                {
                    break;
                }

                result[k - 1] = item.Value;
                dictionaryIndexValue2.Add(item.Key, item.Value);

                k--;
            }

            dictionaryIndexValue1 = dictionaryIndexValue2.OrderBy(x => x.Key).ToDictionary<int, int>();


            return dictionaryIndexValue1.Values.ToArray();
        }
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> dictionaryForT = new Dictionary<char, int>();
            int lenghtS = s.Length;
            int lenghtT = t.Length;
            int leftIndex = 0;
            int rightIndex = lenghtT - 1;
            int countCharDictionaryForT = 0;
            int minLengthResult = int.MaxValue;
            string stringResult = string.Empty;

            if (lenghtS < lenghtT)
            {
                return "";
            }

            for (int i = 0; i < lenghtT; i++)
            {
                if (!dictionaryForT.ContainsKey(t[i]))
                {
                    dictionaryForT.Add(t[i], 1);
                    countCharDictionaryForT++;
                }
                else
                {
                    dictionaryForT[t[i]]++;
                    countCharDictionaryForT++;
                }
            }

            Dictionary<char, int> currDictionaryForT = dictionaryForT;

            for (int i = countCharDictionaryForT - 1; i >= 0; i--)
            {
                if (dictionaryForT.ContainsKey(s[i]))
                {
                    if (dictionaryForT[s[i]] > 0)
                    {
                        countCharDictionaryForT--;
                        dictionaryForT[s[i]]--;
                    }
                    else
                    {
                        dictionaryForT[s[i]]--;
                    }
                }
            }
            if (countCharDictionaryForT == 0)
            {
                return s.Substring(0, rightIndex + 1 - leftIndex);
            }

            while (rightIndex != lenghtS - 1 || leftIndex - rightIndex < lenghtT || minLengthResult == lenghtT)
            {
                if (countCharDictionaryForT == 0)
                {
                    if (minLengthResult > rightIndex - leftIndex)
                    {
                        minLengthResult = rightIndex - leftIndex + 1;
                        stringResult = s.Substring(leftIndex, rightIndex + 1 - leftIndex);
                    }

                    if (dictionaryForT.ContainsKey(s[leftIndex]))
                    {
                        if (dictionaryForT[s[leftIndex]] < 0)
                        {
                            dictionaryForT[s[leftIndex]]++;
                        }
                        else
                        {
                            countCharDictionaryForT++;
                            dictionaryForT[s[leftIndex]]++;
                        }
                    }

                    leftIndex++;
                }
                else
                {
                    rightIndex++;
                    if (rightIndex < lenghtS)
                    {
                        if (dictionaryForT.ContainsKey(s[rightIndex]))
                        {
                            if (dictionaryForT[s[rightIndex]] > 0)
                            {
                                countCharDictionaryForT--;
                                dictionaryForT[s[rightIndex]]--;
                            }
                            else
                            {
                                dictionaryForT[s[rightIndex]]--;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }

            return stringResult;
        }
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            int leftIndex = 0;
            int rightIndex = length - 1;
            int result = 0;
            const int mod = 1000000007;
            int[] array2Power = new int[length + 1];
            array2Power[0] = 1;
            for (int i = 1; i <= length; ++i)
            {
                array2Power[i] = (array2Power[i - 1] * 2) % mod;
            }

            while (leftIndex <= rightIndex)
            {
                if (nums[leftIndex] + nums[rightIndex] <= target)
                {
                    result = (result + array2Power[rightIndex - leftIndex]) % mod;
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }

            }

            return result;
        }
        public bool IsValidSudoku(char[][] board)
        {
            int levelIndex = 0;
            int widthIndex = 0;

            bool result = true;

            for (int i = 0; i < 9; i++)
            {
                int[] miniFields = new int[9];
                int[] vertical = new int[9];
                int[] horizontal = new int[9];
                int currMiniWidthIndex = 0;
                int currMiniLevelIndex = 0;

                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        vertical[board[j][i] - '1'] += 1;
                    }

                    if (board[i][j] != '.')
                    {
                        horizontal[board[i][j] - '1'] += 1;
                    }

                    if (board[currMiniLevelIndex + levelIndex][currMiniWidthIndex + widthIndex] != '.')
                    {
                        miniFields[board[currMiniLevelIndex + levelIndex][currMiniWidthIndex + widthIndex] - '1'] += 1;
                    }

                    currMiniWidthIndex++;

                    if (currMiniWidthIndex > 2)
                    {
                        currMiniLevelIndex++;
                        currMiniWidthIndex = 0;
                    }
                }

                widthIndex += 3;

                if (widthIndex > 7)
                {
                    widthIndex = 0;
                    levelIndex += 3;
                }

                for (int j = 0; j < 9; j++)
                {
                    if (vertical[j] > 1 || horizontal[j] > 1 || miniFields[j] > 1)
                    {
                        result = false;
                        break;
                    }
                }

                if (!result)
                {
                    break;
                }
            }

            return result;
        }
        public int PossibleStringCount(string word)
        {
            int result = 1;
            char prevChar = word[0];

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == prevChar)
                {
                    result++;
                }
                prevChar = word[i];
            }

            return result;
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


