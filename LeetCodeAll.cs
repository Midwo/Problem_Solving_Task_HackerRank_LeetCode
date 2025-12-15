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
            //Standard way to solve without using BitOperations.IsPow2(n) from NET.
            return (n > 0) && ((n & (n - 1)) == 0);

            ////Solution only for net 6 and newer.
            //return BitOperations.IsPow2(n);

            ////Solution with listPowerTwo
            //    List<int> listPower2 = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384,
            //                                            32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608,
            //                                            16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
            //    if (listPower2.Contains(n))
            //    {
            //        return true;
            //    }
            //    return false;

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
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            int x = matrix[0].Length;
            int y = matrix.Length;

            if (x == 1)
            {
                for (int i = 0; i < y; i++)
                {
                    result.Add(matrix[i][0]);
                }
                return result;
            }

            if (y == 1)
            {
                for (int i = 0; i < x; i++)
                {
                    result.Add(matrix[0][i]);
                }
                return result;
            }

            int blockRange = 0;
            int indexBlockRange = 0;

            while (blockRange * 2 < x - 1)
            {
                switch (indexBlockRange)
                {
                    case 0:
                        for (int j = blockRange; j < x - blockRange - 1; j++)
                        {
                            result.Add(matrix[blockRange][j]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    case 1:
                        for (int j = blockRange; j < y - blockRange - 1; j++)
                        {
                            result.Add(matrix[j][x - blockRange - 1]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    case 2:
                        for (int j = x - 1 - blockRange; j > blockRange; j--)
                        {
                            result.Add(matrix[y - blockRange - 1][j]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    default:
                        for (int j = y - blockRange - 1; j > blockRange; j--)
                        {
                            result.Add(matrix[j][blockRange]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                }

                indexBlockRange++;
                if (indexBlockRange == 4)
                {
                    indexBlockRange = 0;
                    blockRange++;
                    if (result.Count == x * y)
                    {
                        return result;
                    }
                }
            }

            if (result.Count != x * y)
            {
                for (int j = blockRange; j <= x - blockRange - 1; j++)
                {
                    result.Add(matrix[blockRange][j]);
                }
                if (result.Count == x * y)
                {
                    return result;
                }
                for (int j = blockRange + 1; j < y - blockRange; j++)
                {
                    result.Add(matrix[j][blockRange]);
                }
            }
            return result;
        }
        public void SetZeroes(int[][] matrix)
        {
            bool firstColumnZero = false;
            bool firstRowZero = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstColumnZero = true;
                    break;
                }
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    firstRowZero = true;
                    break;
                }
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j][i] == 0)
                    {
                        matrix[j][0] = 0;
                        matrix[0][i] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j][0] == 0 || matrix[0][i] == 0)
                    {
                        matrix[j][i] = 0;
                    }
                }
            }

            if (firstColumnZero)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (firstRowZero)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
        public char KthCharacter(int k)
        {
            List<int> word = new List<int> { 0 };

            while (word.Count <= k)
            {
                List<int> miniList = new List<int>();
                for (int i = 0; i < word.Count; i++)
                {
                    miniList.Add(((int)(word[i] + 1) % 26));
                }
                word.AddRange(miniList);
            }
            return (char)(word[k - 1] + 'a');
        }
        public void GameOfLife(int[][] board)
        {
            int height = board.Length;
            int width = board[0].Length;

            int[][] nextBoard = new int[height][];

            for (int i = 0; i < height; i++)
            {
                nextBoard[i] = board[i].ToArray();
            }
            int countLiveNeighbors = 0;
            if (height == 1 || width == 1)
            {
                if (width == 1 && height == 1)
                {
                    board[0][0] = 0;
                }
                else if (width == 1)
                {
                    for (int i = 0; i < height; i++)
                    {
                        countLiveNeighbors = 0;

                        if (i == 0)
                        {
                            if (nextBoard[i + 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else if (i == height - 1)
                        {
                            if (nextBoard[i - 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (nextBoard[i + 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }


                        if (nextBoard[i][0] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[i][0] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[i][0] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[i][0] = 0;
                            }
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < width; i++)
                    {
                        countLiveNeighbors = 0;

                        if (i == 0)
                        {
                            if (nextBoard[0][i + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else if (i == width - 1)
                        {
                            if (nextBoard[0][i - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (nextBoard[0][i + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[0][i - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }

                        if (nextBoard[0][i] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[0][i] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[0][i] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[0][i] = 0;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        countLiveNeighbors = 0;

                        if (i > 0 && i < height - 1 && j > 0 && j < width - 1)
                        {
                            if (nextBoard[i][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (j == 0)
                                {
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else if (j == width - 1)
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                            }
                            else if (i == height - 1)
                            {
                                if (j == 0)
                                {
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else if (j == width - 1)
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                            }
                            else if (j == 0)
                            {
                                if (nextBoard[i - 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                            }
                            else //j == width - 1
                            {
                                if (nextBoard[i][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                            }
                        }

                        if (nextBoard[i][j] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[i][j] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[i][j] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[i][j] = 0;
                            }
                        }
                    }
                }
            }
        }
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            int countDot = 0;

            foreach (var item in path.Split('/'))
            {
                //Console.WriteLine(item);
                if (item.Length > 0)
                {
                    if (item[0] != '/' && item[0] != '.')
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        countDot = 0;
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (item[i] == '.')
                            {
                                countDot++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (countDot == 2 && item.Length == countDot)
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                        }
                        else if (countDot > 2 && item.Length == countDot)
                        {
                            string temp = string.Concat(Enumerable.Repeat(".", countDot));
                            stack.Push(temp);
                        }
                        else if (countDot < item.Length)
                        {
                            stack.Push(item);
                        }
                    }
                }
            }

            return "/" + string.Join('/', stack.Reverse());
        }
        public int FindLucky(int[] arr)
        {
            //// Option 1 - better, dictionary

            Dictionary<int, int> countNumber = new Dictionary<int, int>();
            int maxLuckyNumber = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (countNumber.ContainsKey(arr[i]))
                {
                    countNumber[arr[i]]++;
                }
                else
                {
                    countNumber.Add(arr[i], 1);
                }
            }

            foreach (var item in countNumber)
            {
                if (item.Key == item.Value && item.Value > maxLuckyNumber)
                {
                    maxLuckyNumber = item.Value;
                }
            }

            return maxLuckyNumber;

            //// Option 2, check i and i-1 and Sort(Arr)

            //int maxLuckyNumber = -1;
            //int count = 1;
            //int length = arr.Length;
            //Array.Sort(arr);

            //for (int i = 1; i < length; i++)
            //{
            //    if (arr[i] == arr[i - 1])
            //    {
            //        count++;
            //        if (i == length - 1)
            //        {
            //            if (count > maxLuckyNumber && count == arr[i - 1])
            //            {
            //                maxLuckyNumber = count;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (count > maxLuckyNumber && count == arr[i - 1])
            //        {
            //            maxLuckyNumber = count;
            //        }
            //        count = 1;
            //    }
            //}

            //return maxLuckyNumber;
        }
        public int CoinChange(int[] coins, int amount)
        {
            int howManyCoins = coins.Length;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int item in coins)
                {
                    if (i - item >= 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - item] + 1);
                    }
                }
            }

            if (dp[amount] == amount + 1)
            {
                return -1;
            }

            return dp[amount];
        }
        public class FindSumPairsTask_1865
        {
            private int[] _nums1;
            private int[] _nums2;
            private int _lengthNums2;
            private Dictionary<int, int> _countForNums2;
            public FindSumPairsTask_1865(int[] nums1, int[] nums2)
            {
                _nums1 = nums1;
                _nums2 = nums2;
                _lengthNums2 = nums2.Length;
                _countForNums2 = new Dictionary<int, int>();

                foreach (int i in _nums2)
                {
                    if (_countForNums2.ContainsKey(i))
                    {
                        _countForNums2[i]++;
                    }
                    else
                    {
                        _countForNums2.Add(i, 1);
                    }
                }
            }

            public void Add(int index, int val)
            {
                int tempValue = _nums2[index];

                if (_countForNums2.TryGetValue(tempValue, out int oldCount))
                {
                    if (oldCount == 1)
                    {
                        _countForNums2.Remove(tempValue);
                    }
                    else
                    {
                        _countForNums2[tempValue] = oldCount - 1;
                    }
                }
                _nums2[index] += val;
                tempValue += val;
                if (_countForNums2.TryGetValue(tempValue, out int countValue))
                {
                    _countForNums2[tempValue] = countValue + 1;
                }
                else
                {
                    _countForNums2.Add(tempValue, 1);
                }
            }

            public int Count(int tot)
            {
                int count = 0;
                foreach (int i in _nums1)
                {
                    int target = tot - i;
                    if (_countForNums2.TryGetValue(target, out int countValue))
                    {
                        count += countValue;
                    }
                }

                return count;
            }
        }
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int resultTime = 0;
            int positionX = points[0][0];
            int positionY = points[0][1];

            for (int i = 1; i < points.Length; i++)
            {
                int currX = points[i][0];
                int currY = points[i][1];

                resultTime += Math.Max(Math.Abs(currX - positionX), Math.Abs(currY - positionY));

                positionX = currX;
                positionY = currY;
            }

            return resultTime;
        }
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();

            int tempValue = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    tempValue = (s[i] - '0') * 10 + s[i + 1] - '0';
                    sb.Append(Convert.ToChar(tempValue + 96));
                    i += 2;
                }
                else
                {
                    sb.Append(Convert.ToChar(s[i] + 48));
                }
            }


            return sb.ToString();




            //List<char> listChars = new List<char>();

            //int tempValue = 0;
            //for (int i = s.Length-1; i >= 0; i--) 
            //{ 
            //    if (s[i] == '#')
            //    {
            //        tempValue = Convert.ToInt32(s[i - 2].ToString() + s[i - 1].ToString());
            //        listChars.Add(Convert.ToChar(tempValue + 96));
            //        i -= 2;
            //    }
            //    else
            //    {
            //        listChars.Add(Convert.ToChar(s[i] + 48));
            //    }            
            //}

            //listChars.Reverse();
            //return string.Concat(listChars);
        }
        public int ScoreOfString(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                result += Math.Abs((s[i] - '0') - (s[i + 1] - '0'));
            }

            return result;
        }
        public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
        {
            int result = 0;

            List<int> breaksTimesList = new List<int>();

            for (int i = 0; i < startTime.Length; i++)
            {
                if (i == 0)
                {
                    if (startTime[i] > 0)
                    {
                        breaksTimesList.Add(startTime[i]);
                    }
                }
                else if (endTime[i - 1] < startTime[i])
                {
                    breaksTimesList.Add(startTime[i] - endTime[i - 1]);
                }
                else
                {
                    breaksTimesList.Add(0);
                }
            }
            if (endTime[(endTime.Length - 1)] < eventTime)
            {
                breaksTimesList.Add(eventTime - endTime[(endTime.Length - 1)]);
            }

            int currSum = 0;

            if (k >= breaksTimesList.Count)
            {
                for (int i = 0; i < breaksTimesList.Count; i++)
                {
                    currSum += breaksTimesList[i];
                }
                return currSum;
            }

            int outValue = breaksTimesList[0];

            for (int j = 0; j <= k; j++)
            {
                currSum += breaksTimesList[j];
            }

            result = Math.Max(result, currSum);

            for (int i = 1; i < breaksTimesList.Count - k; i++)
            {
                currSum += breaksTimesList[k + i] - outValue;
                result = Math.Max(result, currSum);
                outValue = breaksTimesList[i];
            }

            return result;
        }
        public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
        {
            int result = 0;

            List<int> breaksTimesList = new List<int>();
            List<int> noBreaksTimesList = new List<int>();

            for (int i = 0; i < startTime.Length; i++)
            {
                if (i == 0)
                {
                    if (startTime[i] > 0)
                    {
                        breaksTimesList.Add(startTime[i]);
                        noBreaksTimesList.Add(endTime[i] - startTime[i]);
                    }
                    else
                    {
                        noBreaksTimesList.Add(endTime[i] - startTime[i]);
                    }
                }
                else if (endTime[i - 1] == startTime[i])
                {
                    noBreaksTimesList.Add(endTime[i] - startTime[i]);
                }
                else if (endTime[i - 1] < startTime[i])
                {
                    breaksTimesList.Add(startTime[i] - endTime[i - 1]);
                    noBreaksTimesList.Add(endTime[i] - startTime[i]);
                }
                else
                {
                    noBreaksTimesList.Add(startTime[i] - endTime[i]);
                }
                breaksTimesList.Add(0);

            }

            if (endTime[(endTime.Length - 1)] < eventTime)
            {
                breaksTimesList.Add(eventTime - endTime[(endTime.Length - 1)]);
            }

            int indexNoBreaksTimes = 0;
            int leftMaxWithoutAdjacent = 0;
            int left = 0;
            int currLength = 0;

            int maxBreaks = 0;

            int[] intRightBreaksTimes = new int[breaksTimesList.Count];

            for (int i = breaksTimesList.Count - 1; i >= 0; i--)
            {
                if (i == breaksTimesList.Count - 1)
                {
                    intRightBreaksTimes[i] = breaksTimesList[i];
                    maxBreaks = breaksTimesList[i];
                }
                else
                {
                    if (maxBreaks < breaksTimesList[i])
                    {
                        maxBreaks = breaksTimesList[i];
                        intRightBreaksTimes[i] = maxBreaks;
                    }
                    else
                    {
                        intRightBreaksTimes[i] = maxBreaks;
                    }
                }
            }

            for (int i = 0; i < breaksTimesList.Count; i++)
            {
                if (breaksTimesList[i] == 0)
                {
                    currLength = noBreaksTimesList[indexNoBreaksTimes];
                    if (i == breaksTimesList.Count - 1)
                    {
                        if (leftMaxWithoutAdjacent >= currLength)
                        {
                            result = Math.Max(result, left + currLength);
                        }
                        else
                        {
                            result = Math.Max(result, left);
                        }
                    }
                    else
                    {
                        if (leftMaxWithoutAdjacent >= currLength)
                        {
                            result = Math.Max(result, left + currLength + breaksTimesList[i + 1]);
                        }
                        else
                        {
                            //for (int j = i + 2; j < breaksTimesList.Count; j++)
                            //{
                            //    if (breaksTimesList[j] >= currLength)
                            //    {
                            //        result = Math.Max(result, left + currLength + breaksTimesList[i + 1]);
                            //        break;
                            //    }
                            //}
                            //result = Math.Max(result, left + breaksTimesList[i + 1]);

                            if (i < breaksTimesList.Count - 2 && currLength <= intRightBreaksTimes[i + 2])
                            {
                                result = Math.Max(result, left + currLength + breaksTimesList[i + 1]);
                            }
                            result = Math.Max(result, left + breaksTimesList[i + 1]);

                        }
                        leftMaxWithoutAdjacent = Math.Max(left, leftMaxWithoutAdjacent);
                        left = 0;
                        indexNoBreaksTimes++;
                    }
                }
                else
                {
                    leftMaxWithoutAdjacent = Math.Max(left, leftMaxWithoutAdjacent);
                    left = breaksTimesList[i];
                }
            }

            return result;
        }
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode resultListNode = dummyHead;

            dummyHead.next = new ListNode(head.val);
            dummyHead = dummyHead.next;
            int last = head.val;
            int curr = 0;
            head = head.next;
            int a = 0;
            int b = 0;

            if (head != null)
            {
                while (head != null)
                {
                    curr = head.val;
                    a = curr;
                    b = last;

                    //while(a != b)
                    //{
                    //    if (a > b)
                    //    {
                    //        a = a - b;
                    //    }
                    //    else
                    //    {
                    //        b = b - a;
                    //    }
                    //}

                    //Console.WriteLine(head.val);

                    dummyHead.next = new ListNode(GCD(a, b));
                    dummyHead = dummyHead.next;
                    dummyHead.next = new ListNode(curr);
                    dummyHead = dummyHead.next;

                    head = head.next;
                    last = curr;
                }
            }

            return resultListNode.next;
        }
        public int GCD(int a, int b)
        {
            int rem = 0;

            while (b != 0)
            {
                rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];

            nums.CopyTo(result, 0);
            nums.CopyTo(result, nums.Length);


            return result;
        }
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);

            int howManMatching = 0;
            int indexTrainers = 0;
            int lengthTrainers = trainers.Length;
            int currPlayerAbility = 0;

            for (int i = 0; i < players.Length; i++)
            {
                currPlayerAbility = players[i];

                while (indexTrainers < lengthTrainers)
                {
                    if (trainers[indexTrainers] >= currPlayerAbility)
                    {
                        howManMatching++;
                        indexTrainers++;
                        break;
                    }
                    else
                    {
                        indexTrainers++;
                    }
                }
            }

            return howManMatching;
        }
        public int GetDecimalValue(ListNode head)
        {
            int sum = 0;

            while (head != null)
            {
                if (head.val == 1)
                {
                    sum = sum * 2 + 1;
                }
                else
                {
                    sum *= 2;
                }

                head = head.next;
            }

            return sum;
        }
        public int[] BuildArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }
        public double[] ConvertTemperature(double celsius)
        {
            double[] result = new double[2];

            result[0] = celsius + 273.15;
            result[1] = celsius * 1.8 + 32;

            return result;
        }
        public int[] MinOperations(string boxes)
        {
            int leftSumOperations = 0;
            int rightSumOperations = 0;
            int rightSumBallons = 0;
            int leftSumBallons = 0;
            int length = boxes.Length;
            int[] result = new int[length];

            for (int i = length - 1; i > 0; i--)
            {
                rightSumOperations += rightSumBallons;
                if (boxes[i] == '1')
                {
                    rightSumOperations++;
                    rightSumBallons++;
                }
            }

            result[0] = rightSumOperations;

            for (int i = 1; i < length; i++)
            {
                leftSumOperations += leftSumBallons;
                if (boxes[i - 1] == '1')
                {
                    leftSumOperations++;
                    leftSumBallons++;
                }

                if (boxes[i] == '1')
                {
                    rightSumOperations--;
                    rightSumBallons--;
                }
                rightSumOperations -= rightSumBallons;

                result[i] = leftSumOperations + rightSumOperations;
            }

            return result;
        }
        private int sumXor;
        public int SubsetXORSum(int[] nums)
        {
            dfsSubsetXORSum(nums, 0, 0);

            return sumXor;
        }
        private void dfsSubsetXORSum(int[] nums, int index, int currentXor)
        {
            sumXor += currentXor;


            for (int i = index; i < nums.Length; i++)
            {
                currentXor ^= nums[i];

                dfsSubsetXORSum(nums, i + 1, currentXor);

                currentXor ^= nums[i];
            }

        }
        public bool IsValid_Task3136(string word)
        {
            int length = word.Length;

            if (length < 3) return false;

            bool result = true;
            int vowel = 0;
            int consonant = 0;

            for (int i = 0; i < length; i++)
            {
                if (word[i] >= 65 && word[i] <= 90 || word[i] >= 97 && word[i] <= 122)
                {
                    if (vowel < 1 || consonant < 1)
                    {
                        if (word[i] == 'a' || word[i] == 'A' || word[i] == 'e' || word[i] == 'E' || word[i] == 'i' || word[i] == 'I' || word[i] == 'o' ||
                            word[i] == 'O' || word[i] == 'u' || word[i] == 'U')
                        {
                            vowel++;
                        }
                        else
                        {
                            consonant++;
                        }
                    }
                }
                else if (word[i] < 48 || word[i] > 57)
                {
                    result = false;
                    break;
                }
            }

            if (result == false || vowel == 0 || consonant == 0)
            {
                return false;
            }

            return result;
        }
        public int MaximumLength(int[] nums)
        {
            int even = 0;
            int odd = 0;
            int length = nums.Length;
            int wrongSequenceCount = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (nums[i] % 2 != nums[i + 1] % 2)
                {
                    wrongSequenceCount++;
                }

            }

            if (nums[nums.Length - 1] % 2 == 0)
            {
                even++;

            }
            else
            {
                odd++;
            }

            return Math.Max(wrongSequenceCount + 1, Math.Max(even, odd));
        }
        public int MaximumLength(int[] nums, int k)
        {
            int[,] dp = new int[k, k];
            int resultMax = 0;
            int currResultMod = 0;

            //for (int i = 0; i < k; i++)
            //{
            //    dp[i] = new int[k];
            //}

            foreach (int number in nums)
            {
                currResultMod = number % k;

                for (int i = 0; i < k; i++)
                {
                    dp[i, currResultMod] = dp[currResultMod, i] + 1;
                    resultMax = Math.Max(resultMax, dp[i, currResultMod]);
                }
            }

            return resultMax;
        }
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);
            IList<string> result = new List<string>();
            string currText = string.Empty;
            bool add = true;

            foreach (string item in folder)
            {
                var temp = item.Split('/');
                add = true;
                currText = string.Empty;
                for (int i = 1; i < temp.Length; i++)
                {
                    currText += "/" + temp[i];
                    if (result.Contains(currText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public int TheMaximumAchievableX(int num, int t)
        {
            return num + t + t;
        }
        public int[] PivotArray(int[] nums, int pivot)
        {
            int[] result = new int[nums.Length];
            List<int> listGreater = new List<int>();
            int index = 0;
            int howManyPivotValue = 0;
            foreach (int x in nums)
            {
                if (x < pivot)
                {
                    result[index] = x;
                    index++;
                }
                else if (x > pivot)
                {
                    listGreater.Add(x);
                }
                else
                {
                    howManyPivotValue++;
                }
            }

            for (int i = 0; i < howManyPivotValue; i++)
            {
                result[index] = pivot;
                index++;
            }

            foreach (var item in listGreater)
            {
                result[index] = item;
                index++;
            }

            return result;

        }
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> countNumbersDictionary = new Dictionary<int, int>();
            int result = 0;

            foreach (int i in nums)
            {
                if (countNumbersDictionary.ContainsKey(i))
                {
                    countNumbersDictionary[i]++;
                }
                else
                {
                    countNumbersDictionary.Add(i, 1);
                }
            }

            foreach (int i in countNumbersDictionary.Values)
            {
                if (i > 1)
                {
                    result += i * (i - 1) / 2;
                }
            }

            return result;

        }
        public string MakeFancyString(string s)
        {
            char lastChar = s[0];
            int count = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(lastChar);

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    count++;
                    if (count <= 2)
                    {
                        sb.Append(lastChar);
                    }
                }
                else
                {
                    count = 1;
                    lastChar = s[i];
                    sb.Append(lastChar);
                }
            }

            return new string(sb.ToString());
        }
        public int MaximumUniqueSubarray(int[] nums)
        {
            int maxSum = 0;
            int currSum = 0;
            HashSet<int> hashSetValues = new HashSet<int>();

            for (int l = 0, r = 0; r < nums.Length; r++)
            {
                while (!hashSetValues.Add(nums[r]))
                {
                    currSum -= nums[l];
                    hashSetValues.Remove(nums[l]);
                    l++;
                }
                currSum += nums[r];
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
        public int MaximumGain(string s, int x, int y)
        {
            //x = 'ab'
            //y = 'ba'
            bool betterY = false;
            int sum = 0;

            int countA = 0;
            int countB = 0;

            Stack<char> stackChars = new Stack<char>();
            bool nextCheck = true;

            if (y > x)
            {
                betterY = true;
            }

            char temp = 'c';

            if (betterY)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == 'b')
                    {
                        stackChars.TryPeek(out temp);
                        if ('a' == temp)
                        {
                            sum += y;
                            stackChars.Pop();
                        }
                        else
                        {
                            stackChars.Push(s[i]);
                        }
                    }
                    else
                    {
                        stackChars.Push(s[i]);
                    }
                }

                while (stackChars.Count > 0)
                {
                    temp = stackChars.Pop();
                    if (temp == 'a')
                    {
                        countA++;
                    }
                    else if (temp == 'b')
                    {
                        if (countA > 0)
                        {
                            sum += x;
                            countA--;
                        }
                    }
                    else
                    {
                        countA = 0;
                    }
                }
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == 'a')
                    {
                        stackChars.TryPeek(out temp);
                        if ('b' == temp)
                        {
                            sum += x;
                            stackChars.Pop();
                        }
                        else
                        {
                            stackChars.Push(s[i]);
                        }
                    }
                    else
                    {
                        stackChars.Push(s[i]);
                    }
                }

                while (stackChars.Count > 0)
                {
                    temp = stackChars.Pop();
                    if (temp == 'b')
                    {
                        countB++;
                    }
                    else if (temp == 'a')
                    {
                        if (countB > 0)
                        {
                            sum += y;
                            countB--;
                        }
                    }
                    else
                    {
                        countB = 0;
                    }
                }

            }

            return sum;

        }
        public int MaxSum(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            int maxNumber = int.MinValue;
            int maxSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (maxNumber < nums[i]) maxNumber = nums[i];

                if (nums[i] > 0)
                {
                    if (result.Add(nums[i]))
                    {
                        maxSum += nums[i];
                    }
                }

            }

            if (maxNumber >= 0)
            {
                return maxSum;
            }
            return maxNumber;
        }
        public int CountHillValley(int[] nums)
        {
            int sum = 0;
            // 1 up, 2 down, 3 stagnation, -1 no state

            int state = -1;
            int lastValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (lastValue > nums[i])
                {
                    if (state == 1)
                    {
                        sum++;
                        state = 2;
                    }
                    else if (state == -1)
                    {
                        state = 2;
                    }
                }
                else if (lastValue < nums[i])
                {
                    if (state == 2)
                    {
                        sum++;
                        state = 1;
                    }
                    else if (state == -1)
                    {
                        state = 1;
                    }
                }
                lastValue = nums[i];
            }

            return sum;
        }

        private int[] _numsTask2044;
        private int _countMaxValueTask2044;
        private int _allBitwiseORTask2044;
        public int CountMaxOrSubsets(int[] nums)
        {
            _allBitwiseORTask2044 = 0;
            _numsTask2044 = nums;
            _countMaxValueTask2044 = 0;

            foreach (int item in nums)
            {
                _allBitwiseORTask2044 |= item;
            }

            generatePairs(0, 0);

            return _countMaxValueTask2044;
        }
        private void generatePairs(int index, int currentBitwiseOR)
        {
            if (index == _numsTask2044.Length)
            {
                if (currentBitwiseOR == _allBitwiseORTask2044)
                {
                    _countMaxValueTask2044++;
                }
                return;
            }

            generatePairs(index + 1, currentBitwiseOR);

            generatePairs(index + 1, currentBitwiseOR | _numsTask2044[index]);
        }
        public int LongestSubarray(int[] nums)
        {
            int lengthNums = nums.Length;
            int currBitwiseAnd = nums[0];
            int maxValue = 0;
            for (int i = 0; i < lengthNums; i++)
            {
                maxValue = Math.Max(nums[i], maxValue);
            }

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < lengthNums; i++)
            {
                if (nums[i] == maxValue)
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }

            return maxCount;
        }
        public int SubarrayBitwiseORs(int[] arr)
        {
            int length = arr.Length;
            HashSet<int> hashSet = new HashSet<int>();
            int currValue = 0;

            for (int i = 0; i < length; i++)
            {
                int SubValue = 0;
                currValue |= arr[i];

                for (int j = i; j >= 0; j--)
                {
                    SubValue |= arr[j];
                    hashSet.Add(SubValue);

                    if (SubValue == currValue)
                    {
                        break;
                    }
                }
            }

            return hashSet.Count();
        }
        public long MinCost(int[] basket1, int[] basket2)
        {
            Dictionary<int, int> dictionaryBasket = new Dictionary<int, int>();
            int length = basket1.Length;

            for (int i = 0; i < length; i++)
            {
                if (!dictionaryBasket.TryAdd(basket1[i], 1))
                {
                    dictionaryBasket[basket1[i]]++;
                }
                if (!dictionaryBasket.TryAdd(basket2[i], -1))
                {
                    dictionaryBasket[basket2[i]]--;
                }
            }

            List<int> fruitDifferencesList = new List<int>();
            int minFruitValue = int.MaxValue;


            foreach (var item in dictionaryBasket)
            {
                if (item.Value % 2 != 0)
                {
                    return -1;
                }

                for (int i = 0; i < Math.Abs(item.Value) / 2; i++)
                {
                    fruitDifferencesList.Add(item.Key);
                }

                minFruitValue = Math.Min(item.Key, minFruitValue);
            }

            fruitDifferencesList.Sort();

            long resultCost = 0;

            for (int i = 0; i < fruitDifferencesList.Count / 2; i++)
            {
                resultCost += Math.Min(fruitDifferencesList[i], minFruitValue * 2);
            }

            return resultCost;

        }
        public int MaxTotalFruits(int[][] fruits, int startPos, int k)
        {
            int maxFruitResult = 0;
            int currSumFruit = 0;
            int length = fruits.Length;

            int x = 0;

            for (int i = 0; i < length; i++)
            {
                int position = fruits[i][0];
                currSumFruit += fruits[i][1];

                //Console.WriteLine(position - fruits[x][0]);
                //Console.WriteLine(Math.Abs(startPos - fruits[x][0]));
                //Console.WriteLine(Math.Abs(startPos - position));

                while (x <= i && position - fruits[x][0] + Math.Min(Math.Abs(startPos - fruits[x][0]), Math.Abs(startPos - position)) > k)
                {
                    currSumFruit -= fruits[x][1];
                    x++;
                }

                maxFruitResult = Math.Max(maxFruitResult, currSumFruit);

            }

            return maxFruitResult;
        }
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
                if (firstValue && secondValue)
                {
                    if (fruits[i] == firstFruit || fruits[i] == secondFruit)
                    {
                        if (fruits[i] == firstFruit)
                        {
                            if (lastValue != firstFruit)
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
                        if (lastValue == firstFruit)
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
        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "++X":
                        result++;
                        break;
                    case "X++":
                        result++;
                        break;
                    case "--X":
                        result--;
                        break;
                    case "X--":
                        result--;
                        break;
                }
            }

            return result;
        }
        public ListNode MergeNodes(ListNode head)
        {
            ListNode dummy = head;
            ListNode copyDummy = dummy;
            List<int> MergeNodes = new List<int>();

            int currSum = 0;

            while (copyDummy != null)
            {
                if (copyDummy.val == 0)
                {
                    if (currSum > 0)
                    {
                        MergeNodes.Add(currSum);
                        currSum = 0;
                    }
                    else
                    {
                        currSum = 0;
                    }
                }
                else
                {
                    currSum += copyDummy.val;
                }
                copyDummy = copyDummy.next;
            }

            bool first = true;
            for (int i = 0; i < MergeNodes.Count; i++)
            {
                if (first)
                {
                    dummy.val = MergeNodes[i];
                    first = false;
                }
                else
                {
                    dummy.next = new ListNode(MergeNodes[i]);
                    dummy = dummy.next;
                }
            }
            dummy.next = null;

            return head;
        }
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            int result = fruits.Length;
            int lengthBaskets = baskets.Length;

            int indexBaskets = 0;
            int currFruit = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                currFruit = fruits[i];
                indexBaskets = 0;
                while (indexBaskets < lengthBaskets)
                {
                    if (currFruit <= baskets[indexBaskets])
                    {
                        result--;
                        baskets[indexBaskets] = int.MinValue;
                        break;
                    }
                    else
                    {
                        indexBaskets++;
                    }
                }

            }

            return result;
        }
        public int[] TransformArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 0;
                }
            }

            Array.Sort(nums);

            return nums;
        }
        private double[][] cacheTask808;
        public double SoupServings(int n)
        {
            if (n > 4800)
            {
                return 1;
            }
            else
            {
                cacheTask808 = new double[192][];
                for (int i = 0; i < 192; i++)
                {
                    cacheTask808[i] = new double[192];
                }

                return SoupServingsDFS((n + 24) / 25, (n + 24) / 25);
            }
        }
        private double SoupServingsDFS(int typeA, int typeB)
        {
            if (typeA <= 0 && typeB <= 0)
                return 0.5;
            if (typeA <= 0)
                return 1.0;
            if (typeB <= 0)
                return 0.0;
            if (cacheTask808[typeA][typeB] > 0)
                return cacheTask808[typeA][typeB];
            return cacheTask808[typeA][typeB] =
                       0.25 * (SoupServingsDFS(typeA - 4, typeB) + SoupServingsDFS(typeA - 3, typeB - 1) +
                       SoupServingsDFS(typeA - 2, typeB - 2) + SoupServingsDFS(typeA - 1, typeB - 3));
        }
        public int MaximumCount(int[] nums)
        {
            int maxCount = 0;
            int currMaxCountNegative = 0;
            int length = nums.Length;
            int halflength = length / 2;
            int lastI = 0;
            bool posiviteValue = false;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] < 0)
                {
                    currMaxCountNegative++;
                }
                else if (nums[i] == 0)
                {
                    if (currMaxCountNegative > length - currMaxCountNegative - (i - currMaxCountNegative))
                    {
                        return currMaxCountNegative;
                    }
                }
                else
                {
                    if (currMaxCountNegative == 0)
                    {
                        return length - i;
                    }
                    posiviteValue = true;
                    lastI = i;
                    break;
                }
            }

            if (currMaxCountNegative == 0 && posiviteValue == false)
            {
                return 0;
            }

            maxCount = Math.Max(maxCount, Math.Max(currMaxCountNegative, length - lastI));

            return maxCount;
        }
        public bool ReorderedPowerOf2(int n)
        {
            bool result = false;

            List<string> listPow2OrderByDescValue = new List<string>()
            {
               "1","2","4","8","61","32","64","821","652","521","4210","8420","9640","9821",
                "86431","87632","66553","732110","644221","885422","8765410","9752210","9444310",
                "8888630","77766211","55443332","88766410","877432211","866554432","987653210","8774432110"
            };

            char[] temp = n.ToString().ToCharArray();
            temp = temp.OrderByDescending(x => x).ToArray();

            if (listPow2OrderByDescValue.Contains(new string(temp)))
            {
                return true;
            }

            //bool result = false;
            //int tenPowNine = (int)Math.Pow(10, 9);

            //List<string> listPow2 = new List<string>();
            //int lastValue = 1;
            //listPow2.Add(lastValue.ToString());

            //while(lastValue <= tenPowNine)
            //{
            //    lastValue *= 2;
            //    listPow2.Add(lastValue.ToString());
            //}

            //for (int i = 1; i < listPow2.Count; i++)
            //{
            //    char[] temp = listPow2[i].ToString().ToCharArray();
            //    temp = temp.OrderByDescending(x => x).ToArray();
            //    //Console.WriteLine(string.Join(',', temp));
            //    listPow2[i] = new string(temp);
            //}


            //Console.WriteLine(string.Join(',', listPow2));

            return result;
        }
        public int[] ProductQueries(int n, int[][] queries)
        {
            int M = 1000000007;
            string binaryValueN = Convert.ToString(n, 2);
            int[] listPower2 = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384,
                                                        32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608,
                                                        16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
            List<int> listActivePowers = new List<int>();
            int lenght = binaryValueN.Length;
            int indexBinaryValueN = 0;

            for (int i = binaryValueN.Length - 1; i >= 0; i--)
            {
                if (binaryValueN[i] == '1')
                {
                    listActivePowers.Add(listPower2[indexBinaryValueN]);
                }
                indexBinaryValueN++;
            }

            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                long temp = 1;

                for (int j = queries[i][0]; j <= queries[i][1]; j++)
                {
                    temp = (temp * listActivePowers[j]) % M;
                }
                result[i] = (int)temp;
            }


            return result;
        }
        public int MinimumOperations(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i] % 3;

                if (temp > 0)
                {
                    result++;
                }

            }

            return result;
        }
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            int index = n;
            int indexInsert = 0;

            for (int i = 0; i < n; i++)
            {
                result[indexInsert] = nums[i];
                result[indexInsert + 1] = nums[index];
                indexInsert += 2;
                index++;
            }

            return result;
        }
        public string LargestGoodInteger(string num)
        {
            char bestChar = 'x';
            char lastChar = num[0];
            int counter = 1;
            string currResult = string.Empty;

            for (int i = 1; i < num.Length; i++)
            {
                if (lastChar == num[i])
                {
                    counter++;
                    if (counter == 3)
                    {
                        if (bestChar == 'x')
                        {
                            bestChar = num[i];
                            if (bestChar == '9')
                            {
                                break;

                            }
                        }
                        else
                        {
                            if (bestChar < num[i])
                            {
                                bestChar = num[i];
                                if (bestChar == '9')
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    counter = 1;
                    lastChar = num[i];
                }
            }

            if (bestChar == 'x')
            {
                return "";
            }

            return new string(bestChar, 3);
        }
        public int MinPartitions(string n)
        {
            char currHighChar = n[0];

            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > currHighChar)
                {
                    currHighChar = n[i];
                    if (currHighChar == '9')
                    {
                        return 9;
                    }
                }
            }

            return currHighChar - '0';
        }
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = int.MinValue;
            int currWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                currWealth = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currWealth += accounts[i][j];
                }

                maxWealth = Math.Max(maxWealth, currWealth);
            }

            return maxWealth;
        }
        public int[] GetSneakyNumbers(int[] nums)
        {
            HashSet<int> fromNums = new HashSet<int>();
            int a = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!fromNums.Add(nums[i]))
                {
                    if (a == -1)
                    {
                        a = nums[i];
                    }
                    else
                    {
                        return new int[2] { a, nums[i] };
                    }
                }

            }

            return nums;
        }
        public string ConvertDateToBinary(string date)
        {
            string[] arrayDate = date.Split('-');
            StringBuilder sb = new StringBuilder();

            sb.Append(Convert.ToString(int.Parse(arrayDate[0]), 2));
            sb.Append('-');
            sb.Append(Convert.ToString(int.Parse(arrayDate[1]), 2));
            sb.Append('-');
            sb.Append(Convert.ToString(int.Parse(arrayDate[2]), 2));

            return sb.ToString();
        }
        public int CountConsistentStrings(string allowed, string[] words)
        {
            List<char> allowedCharList = allowed.ToList();
            int result = 0;
            bool allGood = true;

            for (int i = 0; i < words.Length; i++)
            {
                allGood = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowedCharList.Contains(words[i][j]))
                    {
                        allGood = false;
                        break;
                    }
                }
                if (allGood)
                {
                    result++;
                }
            }

            return result;
        }
        public int Maximum69Number(int num)
        {
            string result = num.ToString();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '6')
                {
                    result = result.Substring(0, i) + '9' + result.Substring(i + 1, result.Length - i - 1);
                    //string tempPrev = stringNum.Substring(0, i);
                    //string tempAfter = stringNum.Substring(i+1, stringNum.Length - i-1);
                    break;
                }
            }

            return int.Parse(result);
        }

        private int _currValueTask1038;
        public TreeNode BstToGst(TreeNode root)
        {
            _currValueTask1038 = 0;
            TreeNode dummyRoot = root;

            UpdateRootTask1038(root);

            return dummyRoot;
        }
        public void UpdateRootTask1038(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            UpdateRootTask1038(root.right);
            //_listValue.Add(root.val);
            if (_currValueTask1038 == 0)
            {
                _currValueTask1038 += root.val;
            }
            else
            {
                _currValueTask1038 += root.val;
                root.val = _currValueTask1038;
            }
            //Console.WriteLine(root.val);
            UpdateRootTask1038(root.left);
        }
        public bool IsStrictlyPalindromic(int n)
        {
            bool result = true;

            for (int i = 2; i <= n - 2; i++)
            {
                string temp = Convert.ToString(n, i);

                if (temp != temp.Reverse())
                {
                    result = false;
                    break;
                }

            }

            return result;
        }
        public int[] FindArray(int[] pref)
        {
            int[] result = new int[pref.Length];
            result[0] = pref[0];

            for (int i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i - 1];
            }

            return result;
        }
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
            {
                return n;
            }
            else
            {
                return n * 2;
            }
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];

            int maxValue = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (maxValue < candies[i])
                {
                    maxValue = candies[i];
                }
            }

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies < maxValue)
                {
                    result[i] = false;
                }
                else
                {
                    result[i] = true;
                }
            }

            return result;

        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();
            bool openSign = false;

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    sb.Append('G');
                }
                else if (command[i] == '(')
                {
                    openSign = true;
                }
                else if (command[i] == 'a')
                {
                    sb.Append("al");
                    openSign = false;
                    i += 2;
                }
                else
                {
                    sb.Append('o');
                }

            }

            return sb.ToString();

        }
        public int[][] LargestLocal(int[][] grid)
        {
            int length = grid.Length;
            int[][] newResultGrid = new int[length - 2][];
            for (int i = 0; i < length - 2; i++)
            {
                newResultGrid[i] = new int[length - 2];
            }
            int currMax = 0;

            for (int i = 1; i < length - 1; i++)
            {
                for (int j = 1; j < length - 1; j++)
                {
                    currMax = 0;
                    currMax = Math.Max(currMax, grid[i][j]);
                    currMax = Math.Max(currMax, grid[i - 1][j]);
                    currMax = Math.Max(currMax, grid[i + 1][j]);
                    currMax = Math.Max(currMax, grid[i][j - 1]);
                    currMax = Math.Max(currMax, grid[i][j + 1]);
                    currMax = Math.Max(currMax, grid[i + 1][j + 1]);
                    currMax = Math.Max(currMax, grid[i - 1][j + 1]);
                    currMax = Math.Max(currMax, grid[i - 1][j - 1]);
                    currMax = Math.Max(currMax, grid[i + 1][j - 1]);

                    newResultGrid[i - 1][j - 1] = currMax;
                }
            }


            return newResultGrid;
        }
        public int MinBitFlips(int start, int goal)
        {
            int resultSumHowManyFlip = 0;

            string resultXOR = Convert.ToString(start ^ goal, 2);

            for (int i = 0; i < resultXOR.Length; i++)
            {
                if (resultXOR[i] == '1')
                {
                    resultSumHowManyFlip++;
                }
            }

            return resultSumHowManyFlip;
        }
        public int MaxFreqSum(string s)
        {
            int[] charsList = new int[26];

            int maxVowelsFrequency = 0;
            int maxConsonantsFrequency = 0;

            for (int i = 0; i < s.Length; i++)
            {
                charsList[s[i] - 97] += 1;
            }


            for (int i = 0; i < charsList.Length; i++)
            {
                if (i == 0 || i == 4 || i == 8 || i == 14 || i == 20)
                {
                    maxVowelsFrequency = Math.Max(maxVowelsFrequency, charsList[i]);
                }
                else
                {
                    maxConsonantsFrequency = Math.Max(maxConsonantsFrequency, charsList[i]);
                }
            }

            return maxConsonantsFrequency + maxVowelsFrequency;

        }
        public long ZeroFilledSubarray(int[] nums)
        {
            long result = 0;
            long currLengthZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    currLengthZero++;
                }
                else
                {
                    if (currLengthZero > 0)
                    {
                        result += (1 + currLengthZero) * currLengthZero / 2;
                        currLengthZero = 0;
                    }
                }
            }

            if (currLengthZero > 0)
            {
                result += (1 + currLengthZero) * currLengthZero / 2;
            }
            return result;
        }
        public int CountSquares(int[][] matrix)
        {
            int result = 0;
            //int[][] dpTable = new int[matrix.Length][];

            //for (int i = 0; i < matrix[0].Length; i++)
            //{
            //    dpTable[i] = new int[matrix[0].Length];
            //}
            int left = 0;
            int leftDown = 0;
            int down = 0;

            int currValue = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    currValue = matrix[i][j];
                    if (i == 0)
                    {
                        if (currValue == 1)
                        {
                            result++;
                        }
                    }
                    else if (j == 0)
                    {
                        if (currValue == 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        left = matrix[i][j - 1];
                        leftDown = matrix[i - 1][j - 1];
                        down = matrix[i - 1][j];
                        int minValue = int.MaxValue;
                        minValue = Math.Min(minValue, left);
                        minValue = Math.Min(minValue, down);
                        minValue = Math.Min(minValue, leftDown);

                        if (minValue > 0)
                        {
                            if (currValue == 1)
                            {
                                matrix[i][j] = minValue + 1;
                                result += minValue + 1;
                            }
                        }
                        else if (currValue == 1)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int result = 0;

            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                {
                    result++;
                }

            }

            return result;
        }
        public int[] LeftRightDifference(int[] nums)
        {
            int[] leftSum = new int[nums.Length];
            leftSum[0] = 0;
            int[] rightSum = new int[nums.Length];
            rightSum[nums.Length - 1] = 0;


            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + nums[i + 1];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                leftSum[i] = leftSum[i - 1] + nums[i - 1];
                nums[i - 1] = Math.Abs(leftSum[i - 1] - rightSum[i - 1]);
            }
            nums[nums.Length - 1] = Math.Abs(leftSum[nums.Length - 1] - rightSum[nums.Length - 1]);

            return nums;
        }
        public int CountPairs(IList<int> nums, int target)
        {
            int leftIndex = 0;
            int rightIndex = nums.Count - 1;
            int result = 0;

            int[] arrayInt = nums.ToArray();
            Array.Sort(arrayInt);

            while (leftIndex != rightIndex)
            {
                if (arrayInt[leftIndex] + arrayInt[rightIndex] < target)
                {
                    result += Math.Abs(rightIndex - leftIndex);
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
            }


            return result;
        }
        public int ReverseDegree(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //result += s[i];
                result += ('a' - s[i] + 26) * (i + 1);
            }

            return result;
        }
        public int MinOperations(int[] nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int temp = sum % k;

            if (temp != 0)
            {
                return temp;
            }

            return 0;
        }
        private IList<string> _stringsListTask3211;
        public IList<string> ValidStrings(int n)
        {
            _stringsListTask3211 = new List<string>();
            char[] chars = new char[n];

            GenerateStringTask3211(n, 0, chars, 'z');
            return _stringsListTask3211;
        }
        private void GenerateStringTask3211(int length, int currLength, char[] chars, char lastChar)
        {
            if (currLength > length - 1)
            {
                _stringsListTask3211.Add(new string(chars));
                return;
            }

            if (lastChar == '0')
            {
                chars[currLength] = '1';
                GenerateStringTask3211(length, currLength + 1, chars, lastChar = chars[currLength]);
            }
            else
            {
                chars[currLength] = '0';
                GenerateStringTask3211(length, currLength + 1, chars, lastChar = chars[currLength]);
                chars[currLength] = '1';
                GenerateStringTask3211(length, currLength + 1, chars, lastChar = chars[currLength]);
            }
        }

        private int _sumRangeBST;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.val >= low && root.val <= high)
            {
                _sumRangeBST += root.val;
            }

            RangeSumBST(root.left, low, high);

            RangeSumBST(root.right, low, high);

            return _sumRangeBST;
        }
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> listGroup = new List<IList<int>>();

            Dictionary<int, int> dictionaryValueKeyList = new Dictionary<int, int>();

            int indexListGroup = 0;

            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (dictionaryValueKeyList.ContainsKey(groupSizes[i]))
                {
                    listGroup[dictionaryValueKeyList[groupSizes[i]]].Add(i);
                }
                else
                {
                    dictionaryValueKeyList.Add(groupSizes[i], indexListGroup);
                    IList<int> tempNewGroup = new List<int>() { i };
                    listGroup.Add(tempNewGroup);
                    indexListGroup++;
                }
            }

            IList<IList<int>> resultlistGroup = new List<IList<int>>();

            foreach (var item in dictionaryValueKeyList)
            {
                int count = 0;
                int indexValueInList = 0;
                IList<int> tempList = new List<int>();
                for (int i = 0; i < listGroup[item.Value].Count; i++)
                {
                    if (++count == item.Key)
                    {
                        tempList.Add(listGroup[item.Value][indexValueInList]);
                        resultlistGroup.Add(tempList);
                        tempList = new List<int>();
                        indexValueInList++;
                        count = 0;
                    }
                    else
                    {
                        tempList.Add(listGroup[item.Value][indexValueInList]);
                        indexValueInList++;
                    }
                }


            }

            return resultlistGroup;
        }
        public int FindPermutationDifference(string s, string t)
        {
            int[] absValue = new int[26];
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                absValue[s[i] - 'a'] = i;
            }

            for (int i = 0; i < t.Length; i++)
            {
                result += Math.Abs(absValue[t[i] - 'a'] - i);
            }

            return result;
        }
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            int result = 0;

            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }

            return result;
        }
        public int MinimumArea(int[][] grid)
        {
            int minLeft = int.MaxValue;
            int maxRight = int.MinValue;
            int minUp = int.MaxValue;
            int maxDown = int.MinValue;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        minLeft = Math.Min(minLeft, j);
                        maxRight = Math.Max(maxRight, j);
                        minUp = Math.Min(minUp, i);
                        maxDown = Math.Max(maxDown, i);
                    }
                }
            }

            return (maxRight - minLeft + 1) * (maxDown - minUp + 1);
        }
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                int count = 0;
                int currValue = nums[i];
                for (int j = 0; j < length; j++)
                {
                    if (currValue > nums[j])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            int maxWidth = 0;

            int[][] newPoints = points.OrderBy(c => c[0]).ToArray();

            for (int i = 1; i < points.Length; i++)
            {
                maxWidth = Math.Max(newPoints[i][0] - newPoints[i - 1][0], maxWidth);
            }

            return maxWidth;
        }
        public int[] Decode(int[] encoded, int first)
        {
            int[] decode = new int[encoded.Length + 1];
            decode[0] = first;

            for (int i = 0; i < encoded.Length; i++)
            {
                decode[i + 1] = encoded[i] ^ decode[i];
            }

            return decode;
        }
        public int XorOperation(int n, int start)
        {
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result ^= start + 2 * i;
            }

            return result;
        }
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            Dictionary<int, int> dictionaryArray = new Dictionary<int, int>();
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (dictionaryArray.ContainsKey(A[i]))
                {
                    count++;
                }
                else
                {
                    dictionaryArray.Add(A[i], 1);
                }
                if (dictionaryArray.ContainsKey(B[i]))
                {
                    count++;
                }
                else
                {
                    dictionaryArray.Add(B[i], 1);
                }

                A[i] = count;
            }

            return A;
        }
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                priorityQueue.Enqueue(nums[i], nums[i]);
            }

            for (int i = 0; i < k; i++)
            {
                int temp = priorityQueue.Dequeue();
                int newValue = temp * multiplier;
                priorityQueue.Enqueue(newValue, newValue);
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == temp)
                    {
                        nums[j] = newValue;
                        break;
                    }
                }
            }

            return nums;
        }
        public class ParkingSystem
        {
            private int _big;
            private int _medium;
            private int _small;
            public ParkingSystem(int big, int medium, int small)
            {
                _big = big;
                _medium = medium;
                _small = small;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case 1:
                        if (_big > 0)
                        {
                            _big--;
                            return true;
                        }
                        return false;
                    case 2:
                        if (_medium > 0)
                        {
                            _medium--;
                            return true;
                        }
                        return false;
                    case 3:
                        if (_small > 0)
                        {
                            _small--;
                            return true;
                        }
                        return false;
                    default:
                        return false;
                }
            }
        }
        public int[] RunningSum(int[] nums)
        {
            int currValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currValue = currValue + nums[i];
                nums[i] = currValue;
            }
            return nums;
        }
        public int LongestSubarray1493(int[] nums)
        {
            int counterOne = 0;
            int lastValue = 0;
            int countZero = 0;
            int result = 0;
            int lastCounterOne = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counterOne++;
                    result = Math.Max(result, counterOne + lastCounterOne);
                    if (countZero > 1)
                    {
                        countZero = 0;
                    }
                }
                else
                {
                    lastCounterOne = counterOne;
                    countZero++;
                    counterOne = 0;
                    if (nums[i] == lastValue)
                    {
                        lastCounterOne = 0;
                    }
                }
                lastValue = nums[i];
            }

            if (result == nums.Length)
            {
                return result - 1;
            }

            return result;
        }
        public int[] FindDiagonalOrder(int[][] mat)
        {
            bool reverse = true;
            bool change = true;
            int hight = mat.Length;
            int length = mat[0].Length;
            int countAll = hight * length;
            int[] result = new int[countAll];
            int currIndexX = 0;
            int currindexY = 0;
            int lessNormal = 0;

            if (hight == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = mat[0][i];
                }
                return result;
            }
            else if (length == 1)
            {
                for (int i = 0; i < hight; i++)
                {
                    result[i] = mat[i][0];
                }
                return result;
            }

            result[0] = mat[0][0];

            for (int i = 1; i < countAll; i++)
            {
                if (reverse)
                {
                    if (change)
                    {
                        currIndexX++;
                        change = false;
                        if (currIndexX > length - 1)
                        {
                            lessNormal++;
                            currIndexX = length - 1;
                            currindexY++;
                        }
                        if (currindexY > hight - 1)
                        {
                            currindexY = hight - 1;
                        }
                        result[i] = mat[currindexY][currIndexX];
                    }
                    else
                    {
                        change = false;
                        currIndexX--;
                        currindexY++;
                        if (currIndexX < 0 || currindexY > hight - 1)
                        {
                            currIndexX++;
                            currindexY--;
                            reverse = false;
                            change = true;
                            i--;
                        }
                        else
                        {
                            result[i] = mat[currindexY][currIndexX];
                        }
                    }
                }
                else
                {
                    if (change)
                    {
                        currindexY++;
                        change = false;
                        if (currindexY > hight - 1)
                        {
                            currindexY = hight - 1;
                            currIndexX++;
                        }
                        if (currIndexX > length - 1)
                        {
                            currIndexX = length - 1;
                        }
                        result[i] = mat[currindexY][currIndexX];
                    }
                    else
                    {
                        change = false;
                        currIndexX++;
                        currindexY--;
                        if (currIndexX > length - 1 || currindexY < 0)
                        {
                            currIndexX--;
                            currindexY++;
                            reverse = true;
                            change = true;
                            i--;
                        }
                        else
                        {
                            result[i] = mat[currindexY][currIndexX];
                        }
                    }
                }
            }

            return result;
        }
        public int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            {
                return edges[0][0];
            }

            if (edges[0][1] == edges[1][0] || edges[0][1] == edges[1][1])
            {
                return edges[0][1];
            }

            return 0;


            //// Another solution, worse:

            //Dictionary<int, int> countEdgesValue = new Dictionary<int, int>();

            //for (int i = 0; i < edges.Length; i++)
            //{
            //    if (countEdgesValue.ContainsKey(edges[i][0]))
            //    {
            //        countEdgesValue[edges[i][0]]++;
            //    }
            //    else
            //    {
            //        countEdgesValue.Add(edges[i][0], 1);
            //    }

            //    if (countEdgesValue.ContainsKey(edges[i][1]))
            //    {
            //        countEdgesValue[edges[i][1]]++;
            //    }
            //    else
            //    {
            //        countEdgesValue.Add(edges[i][1], 1);
            //    }
            //}

            //int maxCount = 0;
            //int result = 0;

            //foreach (var item in countEdgesValue)
            //{
            //    if (maxCount < item.Value)
            //    {
            //        maxCount = item.Value;
            //        result = item.Key;
            //    }
            //}

            //return result;
        }
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            ReverseOddTreeNodeTask2415(root.left, root.right, 0);
            return root;
        }
        private void ReverseOddTreeNodeTask2415(TreeNode leftRoot, TreeNode rightRoot, int level)
        {
            if (leftRoot == null || rightRoot == null)
            {
                return;
            }

            if (level % 2 == 0)
            {
                int tempValue = rightRoot.val;
                rightRoot.val = leftRoot.val;
                leftRoot.val = tempValue;
            }

            ReverseOddTreeNodeTask2415(leftRoot.left, rightRoot.right, level + 1);
            ReverseOddTreeNodeTask2415(leftRoot.right, rightRoot.left, level + 1);
        }
        public int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;

            foreach (string sentence in sentences)
            {
                maxWords = Math.Max(maxWords, sentence.Split(' ').Count());
            }

            return maxWords;
        }
        public int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            int temp = int.MaxValue;

            while (n != 0)
            {
                temp = n % 10;
                n /= 10;
                sum += temp;
                product *= temp;
            }

            return product - sum;
        }
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            int maximumArea = 0;
            double maxValueWithoutSqrt = 0;

            for (int i = 0; i < dimensions.Length; i++)
            {
                double forIndex0 = dimensions[i][1] * dimensions[i][1] + dimensions[i][0] * dimensions[i][0];

                if (maxValueWithoutSqrt <= forIndex0)
                {
                    int tempArea = dimensions[i][1] * dimensions[i][0];

                    if (maxValueWithoutSqrt < forIndex0)
                    {
                        maxValueWithoutSqrt = forIndex0;
                        maximumArea = tempArea;
                    }
                    else
                    {
                        if (tempArea > maximumArea)
                        {
                            maximumArea = tempArea;
                        }
                    }
                }
            }

            return maximumArea;
        }

        private int _maxLevelTask1302;
        private int _sumMaxLevelTask1302;
        public int DeepestLeavesSum(TreeNode root)
        {
            _maxLevelTask1302 = 0;
            _sumMaxLevelTask1302 = 0;

            SeachrDeepestLeaves(root, 0, 0);

            return _sumMaxLevelTask1302 / 2;
        }
        private void SeachrDeepestLeaves(TreeNode root, int level, int lastValue)
        {
            if (root == null)
            {
                if (_maxLevelTask1302 <= level)
                {
                    if (_maxLevelTask1302 < level)
                    {
                        _maxLevelTask1302 = level;
                        _sumMaxLevelTask1302 = lastValue;
                    }
                    else
                    {
                        _sumMaxLevelTask1302 += lastValue;
                    }
                }
                return;
            }

            SeachrDeepestLeaves(root.left, level + 1, root.val);
            SeachrDeepestLeaves(root.right, level + 1, root.val);

        }
        public class CodecTask535
        {
            private Dictionary<string, string> _dictionaryShortTinyUrl;

            public CodecTask535()
            {
                _dictionaryShortTinyUrl = new Dictionary<string, string>();
            }
            public string encode(string longUrl)
            {
                var newGuid = Guid.NewGuid();
                string shortGuid = Convert.ToBase64String(newGuid.ToByteArray());

                while (_dictionaryShortTinyUrl.ContainsKey(shortGuid))
                {
                    newGuid = Guid.NewGuid();
                    shortGuid = Convert.ToBase64String(newGuid.ToByteArray());
                }

                _dictionaryShortTinyUrl.Add(shortGuid, longUrl);

                return "http://tinyurl.com/" + shortGuid + "";
            }

            public string decode(string shortUrl)
            {
                string temp = shortUrl.Substring(19, shortUrl.Length - 19);
                //return "";
                return _dictionaryShortTinyUrl[temp];
            }
        }
        public string ReversePrefix(string word, char ch)
        {
            int indexDetected = -1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    indexDetected = i;
                    break;
                }
            }

            if (indexDetected < 0)
            {
                return word;
            }
            else
            {
                string temp1 = (word.Substring(0, indexDetected + 1));
                char[] tempChar = temp1.ToCharArray();
                Array.Reverse(tempChar);
                string temp2 = word.Substring(indexDetected + 1, word.Length - 1 - indexDetected);

                return new string(tempChar) + temp2;
            }
        }
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < points.Length; j++)
                {
                    double euclideanDistance = Math.Sqrt(Math.Pow((queries[i][0] - points[j][0]), 2) + Math.Pow((queries[i][1] - points[j][1]), 2));
                    if (euclideanDistance < queries[i][2])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dictionaryNums.ContainsKey(num))
                {
                    dictionaryNums[num]++;
                }
                else
                {
                    dictionaryNums.Add(num, 1);
                }
            }

            int maxLength = 1;
            int currLength = 0;

            while (maxLength != currLength)
            {
                IList<int> temp = new List<int>();
                if (maxLength == 1)
                {
                    foreach (var item in dictionaryNums)
                    {
                        maxLength = Math.Max(maxLength, item.Value);
                        temp.Add(item.Key);
                    }
                    currLength++;
                    result.Add(temp);
                }
                else
                {
                    foreach (var item in dictionaryNums)
                    {
                        if (item.Value > currLength)
                        {
                            temp.Add(item.Key);
                        }
                    }
                    result.Add(temp);
                    currLength++;
                }
            }

            return result;
        }
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> arrayList = new List<int>();

            for (int i = 0; i < index.Length; i++)
            {
                arrayList.Insert(index[i], nums[i]);
            }

            return arrayList.ToArray();
        }
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int[] gridRow = new int[grid[0].Length];
            int[] gridColumn = new int[grid.Length];
            int result = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                int maxValueRow = 0;
                int maxValueColumn = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    maxValueRow = Math.Max(maxValueRow, grid[i][j]);
                    maxValueColumn = Math.Max(maxValueColumn, grid[j][i]);
                }
                gridRow[i] = maxValueRow;
                gridColumn[i] = maxValueColumn;
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int temp = Math.Min(gridRow[i], gridColumn[j]);
                    result += temp - grid[i][j];
                }
            }

            return result;
        }
        public int NumberOfMatches(int n)
        {
            int result = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    result += n;
                }
                else
                {
                    n /= 2;
                    result += n;
                    n++;
                }
            }

            return result;
        }
        public int MinimumSum(int num)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            while (num != 0)
            {
                int temp = num % 10;
                priorityQueue.Enqueue(temp, temp);
                num /= 10;
            }

            int result = 0;
            result += priorityQueue.Dequeue() * 10;
            result += priorityQueue.Dequeue() * 10;
            result += priorityQueue.Dequeue();
            result += priorityQueue.Dequeue();

            return result;
        }
        public IList<int> StableMountains(int[] height, int threshold)
        {
            List<int> listResult = new List<int>();
            int lastValue = height[0];

            for (int i = 1; i < height.Length; i++)
            {
                if (lastValue > threshold)
                {
                    listResult.Add(i);
                }
                lastValue = height[i];
            }

            return listResult.ToArray();
        }
        public string TruncateSentence(string s, int k)
        {
            string[] wordList = s.Split(' ');

            string result = wordList[0];

            for (int i = 1; i < k; i++)
            {
                result += ' ' + wordList[i];
            }

            return result;
        }
        public int MinOperationsTask3065(int[] nums, int k)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < k)
                {
                    result++;
                }
            }

            return result;
        }
        public int[][] SortMatrix(int[][] grid)
        {
            int length = grid.Length;

            int howManyValues = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                int indexY = i;
                int indexX = 0;
                int currHowManyValues = howManyValues;

                int[] ints = new int[howManyValues + 1];
                ints[howManyValues] = grid[indexY][indexX];

                while (currHowManyValues != 0)
                {
                    indexY++;
                    indexX++;
                    currHowManyValues--;
                    ints[currHowManyValues] = grid[indexY][indexX];
                }
                currHowManyValues = howManyValues;
                howManyValues++;
                Array.Sort(ints);
                indexY = i;
                indexX = 0;

                while (currHowManyValues != -1)
                {
                    grid[indexY][indexX] = ints[currHowManyValues];
                    indexX++;
                    indexY++;
                    currHowManyValues--;
                }
            }

            howManyValues = length - 2;
            for (int i = 1; i < length - 1; i++)
            {
                int indexY = 0;
                int indexX = i;
                int currHowManyValues = howManyValues;

                int[] ints = new int[currHowManyValues + 1];
                ints[currHowManyValues] = grid[indexY][indexX];

                while (currHowManyValues != 0)
                {
                    indexY++;
                    indexX++;
                    currHowManyValues--;
                    ints[currHowManyValues] = grid[indexY][indexX];
                }
                currHowManyValues = length - i - 1;
                howManyValues--;
                Array.Sort(ints);
                indexY = 0;
                indexX = i;
                int indexInts = 0;
                while (currHowManyValues != -1)
                {
                    grid[indexY][indexX] = ints[indexInts];
                    indexX++;
                    indexY++;
                    currHowManyValues--;
                    indexInts++;
                }
            }


            return grid;
        }
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    resultList.Add(nums[i + 1]);
                }
            }

            return resultList.ToArray();
        }
        public class SubrectangleQueriesTask1476
        {
            private int[][] _rectangle;
            public SubrectangleQueriesTask1476(int[][] rectangle)
            {
                _rectangle = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        _rectangle[i][j] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return _rectangle[row][col];
            }
        }
        public int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            int result = 0;

            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] *= k;

                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums1[j] % nums2[i] == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string word1String = string.Join("", word1);
            string word2String = string.Join("", word2);

            if (word1String != word2String)
            {
                return false;
            }
            return true;
        }
        public int CountDigits(int num)
        {
            int result = 0;
            int copyNum = num;

            while (copyNum > 0)
            {
                if (num % (copyNum % 10) == 0)
                {
                    result++;
                }
                copyNum /= 10;
            }

            return result;
        }
        public long FlowerGame(int n, int m)
        {
            return (long)n * m / 2;
        }
        public int[][] OnesMinusZeros(int[][] grid)
        {
            int height = grid.Length;
            int length = grid[0].Length;

            int[] oneRow = new int[height];
            int[] oneCol = new int[length];
            int[] zeroRow = new int[height];
            int[] zeroCol = new int[length];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeroCol[j]++;
                        zeroRow[i]++;
                    }
                    else
                    {
                        oneCol[j]++;
                        oneRow[i]++;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    grid[i][j] = oneRow[i] + oneCol[j] - zeroRow[i] - zeroCol[j];
                }
            }

            return grid;
        }
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int length = nums.Length;
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int x = j + 1; x < length; x++)
                    {
                        if (nums[x] - nums[j] == diff && nums[j] - nums[i] == diff)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
        public int SubarraySum(int[] nums)
        {
            int result = nums[0];
            int currSum = 0;
            int indexStart = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                currSum = 0;
                indexStart = i - nums[i];
                if (indexStart < 0)
                {
                    indexStart = 0;
                }

                for (int j = indexStart; j <= i; j++)
                {
                    currSum += nums[j];
                }

                result += currSum;
            }

            return result;
        }
        public int MinOperationsTask2997(int[] nums, int k)
        {
            int allXor = nums[0] ^ k;
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                allXor ^= nums[i];
            }

            string allXorBinaryWithK = Convert.ToString(allXor, 2);

            for (int i = 0; i < allXorBinaryWithK.Length; i++)
            {
                if (allXorBinaryWithK[i] == '1')
                {
                    result++;
                }
            }


            return result;
        }
        public int NumberOfBeams(string[] bank)
        {
            int result = 0;
            int howManyLastLaser = 0;

            for (int i = 0; i < bank.Length; i++)
            {
                int currHowManyLaser = 0;
                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] == '1')
                    {
                        currHowManyLaser++;
                    }
                }
                if (currHowManyLaser > 0)
                {
                    result += howManyLastLaser * currHowManyLaser;

                    howManyLastLaser = currHowManyLaser;
                }
            }

            return result;
        }
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            int length = arr.Length;

            for (int i = 0; i < length - 2; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }
        public int SumOfMultiples(int n)
        {
            int sumResult = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 6 == 0 || i % 7 == 0)
                {
                    sumResult += i;
                }
            }

            return sumResult;
        }
        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                count++;
            }
            return count;
        }
        public int[][] SortTheStudents(int[][] score, int k)
        {
            int[] scores = new int[score.Length];

            for (int i = 0; i < score.Length; i++)
            {
                scores[i] = score[i][k];
            }

            scores = scores.OrderByDescending(c => c).ToArray();

            int indexSwap = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = indexSwap; j < score.Length; j++)
                {
                    if (score[j][k] == scores[indexSwap])
                    {
                        int[] tempRow = score[indexSwap];
                        score[indexSwap] = score[j];
                        score[j] = tempRow;
                        break;
                    }
                }

                indexSwap++;
            }

            return score;
        }
        public int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                string tempBits = Convert.ToString(i, 2);
                int currCountOne = 0;
                for (int j = 0; j < tempBits.Length; j++)
                {
                    if (tempBits[j] == '1')
                    {
                        currCountOne++;
                        if (currCountOne > k)
                        {
                            break;
                        }
                    }
                }

                if (currCountOne == k)
                {
                    sum += nums[i];
                }
            }

            return sum;

        }
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            PriorityQueue<int, double> priorityQueue = new PriorityQueue<int, double>();

            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i][0] != classes[i][1])
                {
                    double temp = (double)classes[i][0] / (double)classes[i][1];
                    double temp1 = ((double)classes[i][0] + 1) / ((double)classes[i][1] + 1);
                    priorityQueue.Enqueue(i, 1 - (temp1 - temp));
                }
            }

            while (extraStudents != 0 && priorityQueue.Count == 0)
            {
                int temp = priorityQueue.Dequeue();
                classes[temp][1]++;
                classes[temp][0]++;


                double temp2 = (double)classes[temp][0] / (double)classes[temp][1];
                double temp3 = ((double)classes[temp][0] + 1) / ((double)classes[temp][1] + 1);
                priorityQueue.Enqueue(temp, 1 - (temp3 - temp2));


                extraStudents--;
            }


            double result = 0;

            for (int i = 0; i < classes.Length; i++)
            {
                result += ((double)classes[i][0] / (double)classes[i][1]);
            }

            return (result / classes.Length);
        }
        public string DecodeMessage(string key, string message)
        {
            int indexAlphabet = 1;
            int[] intSwitch = new int[26];

            for (int i = 0; i < key.Length; i++)
            {
                //Console.WriteLine(key[i] - 'a');
                if (key[i] != ' ' && intSwitch[key[i] - 'a'] == 0)
                {
                    intSwitch[key[i] - 'a'] = indexAlphabet;
                    indexAlphabet++;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {

                if (message[i] != ' ')
                {
                    //Console.WriteLine(message[i]);
                    //Console.WriteLine(message[i] - 'a');
                    //Console.WriteLine(intSwitch[message[i] - 'a']);
                    //char temp = (char)('a'+19);
                    //Console.WriteLine(temp);
                    //Console.WriteLine((char)('a' + intSwitch[message[i] - 'a']-1));
                    sb.Append((char)('a' + intSwitch[message[i] - 'a'] - 1));
                }
                else
                {
                    sb.Append(' ');
                }

            }


            return new string(sb.ToString());
        }
        public string RestoreString(string s, int[] indices)
        {
            char[] resultChars = new char[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                resultChars[indices[i]] = s[i];

            }

            return new string(resultChars);
        }
        List<string> _happyStringsTask1415;
        char[] _charsABCTask1415;
        public string GetHappyStringTask1415(int n, int k)
        {
            int checkRange = 3;
            _happyStringsTask1415 = new List<string>();
            _charsABCTask1415 = new char[3] { 'a', 'b', 'c' };

            for (int i = 1; i < n; i++)
            {
                checkRange *= 2;
            }

            if (checkRange < k)
            {
                return "";
            }

            GenerateHappyStringTask1415(n, "");

            return _happyStringsTask1415[k - 1];
        }
        private void GenerateHappyStringTask1415(int length, string currString)
        {
            if (length == currString.Length)
            {
                _happyStringsTask1415.Add(currString);
                return;
            }

            foreach (char c in _charsABCTask1415)
            {
                if (currString.Length > 0 && c == currString[currString.Length - 1]) { continue; }

                GenerateHappyStringTask1415(length, currString + c);
            }
        }
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int howManyM = 0;
            int howManyG = 0;
            int howMAnyP = 0;

            int lastDistanceM = 0;
            int lastDistanceG = 0;
            int lastDistanceP = 0;

            int currDistance = 0;
            int length = garbage.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < garbage[i].Length; j++)
                {
                    if (garbage[i][j] == 'M')
                    {
                        howManyM++;
                        lastDistanceM = currDistance;
                    }
                    else if (garbage[i][j] == 'G')
                    {
                        howManyG++;
                        lastDistanceG = currDistance;
                    }
                    else
                    {
                        howMAnyP++;
                        lastDistanceP = currDistance;
                    }
                }

                if (length - 1 != i)
                {
                    currDistance += travel[i];
                }
            }


            return howManyM + howManyG + howMAnyP + lastDistanceP + lastDistanceM + lastDistanceG;
        }
        public int DifferenceOfSum(int[] nums)
        {
            int normalSum = 0;
            int digitSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                normalSum += nums[i];

                while (nums[i] > 0)
                {
                    int temp = nums[i] % 10;
                    digitSum += temp;
                    nums[i] /= 10;
                }
            }

            return Math.Abs(normalSum - digitSum);
        }
        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i += 2)
            {
                int temp = nums[i - 1];
                nums[i - 1] = nums[i];
                nums[i] = temp;
            }

            return nums;
        }
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (ruleKey == "type")
                {
                    if (items[i][0] == ruleValue) { count++; }
                }
                else if (ruleKey == "color")
                {
                    if (items[i][1] == ruleValue) { count++; }
                }
                else
                {
                    if (items[i][2] == ruleValue) { count++; }
                }
            }

            return count;
        }
        public int CountKDifference(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public double MinimumAverage(int[] nums)
        {
            double minValue = int.MaxValue;
            int index = 0;
            int length = nums.Length - 1;

            Array.Sort(nums);

            while (index <= (length) / 2)
            {
                minValue = Math.Min((double)(nums[index] + nums[length - index]) / 2, minValue);
                index++;
            }

            return minValue;
        }
        public bool CheckTree(TreeNode root)
        {
            if (root.val == root.left.val + root.right.val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int FindClosest(int x, int y, int z)
        {
            if (Math.Abs(x - z) > Math.Abs(y - z))
            {
                return 2;
            }
            else if (Math.Abs(x - z) < Math.Abs(y - z))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string[] SortPeople(string[] names, int[] heights)
        {
            Array.Sort(heights, names);

            return names.Reverse().ToArray();
        }
        public int CountTriplets(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        int tempA = 0;
                        int tempB = 0;

                        for (int currI = i; currI < j; currI++)
                        {
                            tempA ^= arr[currI];
                        }
                        for (int currJ = j; currJ <= k; currJ++)
                        {
                            tempB ^= arr[currJ];
                        }

                        if (tempA == tempB)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            int prefLength = pref.Length;
            bool goodPref = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= prefLength)
                {
                    goodPref = true;
                    for (int j = 0; j < prefLength; j++)
                    {
                        if (pref[j] != words[i][j])
                        {
                            goodPref = false;
                            break;
                        }
                    }
                    if (goodPref)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public int[] ProcessQueries(int[] queries, int m)
        {
            List<int> permutationM = new List<int>();

            for (int i = 1; i <= m; i++)
            {
                permutationM.Add(i);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int temp = permutationM.IndexOf(queries[i]);
                permutationM.RemoveAt(temp);
                permutationM.Insert(0, queries[i]);
                queries[i] = temp;
            }

            return queries;
        }
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            int sum = 0;

            int length = piles.Length;

            for (int i = length / 3; i < length - 1; i += 2)
            {
                sum += piles[i];
            }

            return sum;
        }
        public int[] SumZero(int n)
        {
            int[] result = new int[n];

            if (n % 2 == 1)
            {
                result[0] = 0;

                for (int i = 1; i < n; i += 2)
                {
                    result[i] = i;
                    result[i + 1] = -i;
                }
            }
            else
            {
                for (int i = 0; i < n; i += 2)
                {
                    result[i] = i + 1;
                    result[i + 1] = -i - 1;
                }
            }

            return result;
        }

        private static int MODTask2327 = 1000000007;
        public int PeopleAwareOfSecret(int n, int delay, int forget)
        {
            int size = n * 2 + 1;
            long[] dpNewKnow = new long[size];
            long[] dpKnow = new long[size];

            dpNewKnow[1] = 1;

            int day = 1;

            while (day <= n)
            {
                if (dpNewKnow[day] > 0)
                {
                    dpKnow[day] = (dpKnow[day] + dpNewKnow[day]) % MODTask2327;

                    dpKnow[day + forget] = (dpKnow[day + forget] - dpNewKnow[day] + MODTask2327) % MODTask2327;

                    int shareStartDay = day + delay;

                    while (shareStartDay < day + forget)
                    {
                        dpNewKnow[shareStartDay] = (dpNewKnow[shareStartDay] + dpNewKnow[day]) % MODTask2327;
                        shareStartDay++;
                    }
                }
                day++;

            }

            long resultKnowing = 0;

            for (int start = 1; start <= n; start++)
            {
                resultKnowing = (resultKnowing + dpKnow[start]) % MODTask2327;
            }

            return (int)resultKnowing;
        }
        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {
            HashSet<int> whoCannotSpeak = new HashSet<int>();

            foreach (var recordFromFriendShips in friendships)
            {
                HashSet<int> availableLanguages = new HashSet<int>();
                bool boolCanCommunicate = false;

                foreach (var item in languages[recordFromFriendShips[0] - 1])
                {
                    availableLanguages.Add(item);
                }

                foreach (var item in languages[recordFromFriendShips[1] - 1])
                {
                    if (availableLanguages.Contains(item))
                    {
                        boolCanCommunicate |= true;
                        break;
                    }
                }

                if (!boolCanCommunicate)
                {
                    whoCannotSpeak.Add(recordFromFriendShips[0] - 1);
                    whoCannotSpeak.Add(recordFromFriendShips[1] - 1);
                }
            }

            int[] languagePopularityTable = new int[n + 1];
            int howManyKnowMostPopularityLanguage = 0;

            foreach (var numberPerson in whoCannotSpeak)
            {
                foreach (var language in languages[numberPerson])
                {
                    languagePopularityTable[language]++;
                    howManyKnowMostPopularityLanguage = Math.Max(howManyKnowMostPopularityLanguage, languagePopularityTable[language]);
                }
            }

            return whoCannotSpeak.Count - howManyKnowMostPopularityLanguage;
        }
        public int[] GetNoZeroIntegers(int n)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                int value = i;
                bool valueStatus = true;

                while (value != 0)
                {
                    if (value % 10 == 0)
                    {
                        valueStatus = false;
                        break;
                    }
                    else
                    {
                        value = value / 10;
                    }
                }
                if (valueStatus)
                {
                    value = n - i;
                    while (value != 0)
                    {
                        if (value % 10 == 0)
                        {
                            valueStatus = false;
                            break;
                        }
                        else
                        {
                            value = value / 10;
                        }
                    }

                    if (valueStatus)
                    {
                        return new int[] { i, n - i };
                    }
                }
            }

            return new int[2];
        }
        public string SortVowels(string s)
        {
            char[] vowels = new char[s.Length];
            int[] numberAsciVowels = new int[s.Length];
            char[] resultChars = new char[s.Length];
            int indexVowels = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                char currChar = s[i];
                if (currChar == 'a' || currChar == 'A' || currChar == 'e' || currChar == 'E' || currChar == 'i' || currChar == 'I'
                    || currChar == 'o' || currChar == 'O' || currChar == 'u' || currChar == 'U')
                {
                    vowels[indexVowels] = currChar;
                    numberAsciVowels[indexVowels] = currChar;
                    indexVowels++;
                }
                else
                {
                    resultChars[i] = currChar;
                }
            }

            Array.Sort(numberAsciVowels, vowels);

            indexVowels = length - indexVowels;
            for (int i = 0; i < s.Length; i++)
            {
                if (resultChars[i] == 0)
                {
                    resultChars[i] = vowels[indexVowels];
                    indexVowels++;
                }
            }

            return new string(resultChars);
        }
        public bool DoesAliceWin(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    return true;
                }
            }
            return false;
        }
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int length = rows * cols;
            int[][] result = new int[length][];
            result[0] = new int[] { rStart, cStart };
            int index = 1;
            int turn = 1;
            int count = 2;
            int howLength = 1;
            int currHowlength = howLength;

            while (index != length)
            {
                if (turn == 1)
                {
                    cStart++;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 2;
                    }
                }
                else if (turn == 2)
                {
                    rStart++;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 3;
                    }
                }
                else if (turn == 3)
                {
                    cStart--;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 4;
                    }
                }
                else
                {
                    rStart--;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 1;
                    }
                }


                if (rStart >= 0 && rStart < rows && cStart >= 0 && cStart < cols)
                {
                    result[index] = new int[] { rStart, cStart };
                    index++;
                }
            }
            return result;
        }
        public int MaxDepth(string s)
        {
            int maxNestingDepth = 0;

            int countLeft = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    countLeft++;
                }
                else if (s[i] == ')')
                {
                    countLeft--;
                }
                else
                {
                    continue;
                }
                maxNestingDepth = Math.Max(maxNestingDepth, countLeft);
            }

            return maxNestingDepth;
        }
        public int[] RearrangeArray(int[] nums)
        {

            //// 5ms, Beats: 58.79%

            int indexPositive = 0;
            int indexNegative = 0;
            int length = nums.Length;
            int[] positiveNums = new int[length / 2];
            int[] negativeNums = new int[length / 2];

            for (int i = 0; i < length; i++)
            {
                if (nums[i] > 0)
                {
                    positiveNums[indexPositive++] = nums[i];
                }
                else
                {
                    negativeNums[indexNegative++] = nums[i];
                }
            }

            indexPositive = 0;
            indexNegative = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    nums[i] = positiveNums[indexPositive++];
                }
                else
                {
                    nums[i] = negativeNums[indexNegative++];
                }
            }

            return nums;


            //// 9ms, Beats: 32.66%.

            //int[] result = new int[nums.Length];

            //int indexLastPositive = 0;
            //int indexLastNegative = 0;
            //int length = nums.Length;

            //for (int i = 0; i < length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = indexLastPositive; j < length; j++)
            //        {
            //            if (nums[j] > 0)
            //            {
            //                indexLastPositive = j;
            //                break;
            //            }
            //        }
            //        result[i] = nums[indexLastPositive];
            //        indexLastPositive++;
            //    }
            //    else
            //    {
            //        for (int j = indexLastNegative; j < length; j++)
            //        {
            //            if (nums[j] < 0)
            //            {
            //                indexLastNegative = j;
            //                break;
            //            }
            //        }
            //        result[i] = nums[indexLastNegative];
            //        indexLastNegative++;
            //    }
            //}

            //return result;
        }
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            Dictionary<string, string> distinctWordList = new Dictionary<string, string>();
            Dictionary<string, string> distinctToLowerWordList = new Dictionary<string, string>();
            Dictionary<string, string> changeCharsDistinctToLowerWordList = new Dictionary<string, string>();

            foreach (string word in wordlist)
            {
                distinctWordList.TryAdd(word, word);
                distinctToLowerWordList.TryAdd(word.ToLower(), word);
                char[] tempWord = word.ToLower().ToCharArray();

                for (int x = 0; x < tempWord.Length; x++)
                {
                    if (tempWord[x] == 'e' || tempWord[x] == 'i' || tempWord[x] == 'o' || tempWord[x] == 'u')
                    {
                        tempWord[x] = 'a';
                    }
                }
                changeCharsDistinctToLowerWordList.TryAdd(new string(tempWord), word);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                if (distinctWordList.ContainsKey(queries[i]))
                {
                    queries[i] = distinctWordList[queries[i]];
                }
                else if (distinctToLowerWordList.ContainsKey(queries[i].ToLower()))
                {
                    queries[i] = distinctToLowerWordList[(queries[i].ToLower())];
                }
                else
                {
                    char[] tempWord = queries[i].ToLower().ToCharArray();

                    for (int x = 0; x < tempWord.Length; x++)
                    {
                        if (tempWord[x] == 'e' || tempWord[x] == 'i' || tempWord[x] == 'o' || tempWord[x] == 'u')
                        {
                            tempWord[x] = 'a';
                        }
                    }

                    if (changeCharsDistinctToLowerWordList.ContainsKey(new string(tempWord)))
                    {
                        queries[i] = changeCharsDistinctToLowerWordList[(new string(tempWord))];
                    }
                    else
                    {
                        queries[i] = string.Empty;
                    }
                }
            }

            return queries;



            //// LTE - Time Limit Exceeded

            //int lengthQueries = queries.Length;
            //int lengthWordList = wordlist.Length;
            //string[] smallWordList = new string[lengthWordList];
            //string[] replaceCharsWordList = new string[lengthWordList];
            //bool replaceCharsWordListGenerate = false;
            //bool generateSmall = false;
            //string last = string.Empty;



            //for (int i = 0; i < lengthQueries; i++) 
            //{
            //    string currString = queries[i];
            //    if (last == currString)
            //    {
            //        queries[i] = queries[i - 1];
            //        continue;
            //    }
            //    bool breakLoop = false;
            //    int findIndex = int.MaxValue;
            //    for (int j = 0; j < lengthWordList; j++)
            //    {
            //        if(currString == wordlist[j])
            //        {
            //            queries[i] = currString;
            //            last = currString;
            //            breakLoop = true;
            //            break;
            //        }
            //    }
            //    if (breakLoop)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        if (!generateSmall)
            //        {
            //            for (int k = 0; k < lengthWordList; k++)
            //            {
            //                smallWordList[k] = wordlist[k].ToLower();
            //            }
            //            generateSmall = true;
            //        }
            //        string currStringLower = currString.ToLower();
            //        for (int j = 0; j < lengthWordList; j++)
            //        {
            //            if (currStringLower == smallWordList[j])
            //            {
            //                findIndex = Math.Min(findIndex, j);
            //                break;
            //            }
            //        }
            //    }
            //    if (findIndex < int.MaxValue)
            //    {
            //        last = wordlist[findIndex];
            //        queries[i] = wordlist[findIndex];
            //        continue;
            //    }
            //    else
            //    {
            //        string currStringLower = currString.ToLower();
            //        for (int j = 0; j < lengthWordList; j++)
            //        {
            //            char[] tempWord = new char[currStringLower.Length];
            //            for (int x = 0; x < currStringLower.Length; x++)
            //            {
            //                if (currStringLower[x] == 'e' || currStringLower[x] == 'i' || currStringLower[x] == 'o' || currStringLower[x] == 'u')
            //                {
            //                    tempWord[x] = 'a';
            //                }
            //                else
            //                {
            //                    tempWord[x] = currStringLower[x];
            //                }
            //            }
            //            currString = new string(tempWord);
            //        }

            //        findIndex = int.MaxValue;
            //        if (!replaceCharsWordListGenerate)
            //        {
            //            for (int h = 0; h < lengthWordList; h++)
            //            {
            //                char[] tempWord = new char[smallWordList[h].Length];
            //                for (int j = 0; j < smallWordList[h].Length; j++)
            //                {
            //                    if (smallWordList[h][j] == 'e' || smallWordList[h][j] == 'i' || smallWordList[h][j] == 'o' || smallWordList[h][j] == 'u')
            //                    {
            //                        tempWord[j] = 'a';
            //                    }
            //                    else
            //                    {
            //                        tempWord[j] = smallWordList[h][j];
            //                    }
            //                }
            //                replaceCharsWordList[h] = new string(tempWord);
            //            }
            //            replaceCharsWordListGenerate = true;
            //        }

            //        for (int x = 0; x < lengthWordList; x++)
            //        {
            //            if (currString == replaceCharsWordList[x])
            //            {
            //                findIndex = x;
            //                last = wordlist[x];
            //                queries[i] = wordlist[x];
            //                break;
            //            }
            //        }
            //        if (findIndex == int.MaxValue)
            //        {
            //            last = queries[i];
            //            queries[i] = String.Empty;
            //        }
            //    }
            //}
            //return queries;
        }
        public int CountPairs(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int tempValue1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (tempValue1 == nums[j] && (i * j) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public IList<string> CellsInRange(string s)
        {
            IList<string> list = new List<string>();
            string[] divideList = s.Split(':');
            char[] chars = new char[2];
            chars[0] = divideList[0][0];
            chars[1] = divideList[1][0];
            int rowsStart = int.Parse(divideList[0][1..(divideList[0].Length)]);
            int rowStop = int.Parse(divideList[1][1..(divideList[0].Length)]);

            while (chars[0] <= chars[1])
            {
                for (int i = rowsStart; i <= rowStop; i++)
                {
                    list.Add(String.Concat(chars[0], i));
                }
                chars[0]++;
            }

            return list;
        }
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            //HashSet<char> brokenLettersCharsList = brokenLetters.ToHashSet();
            HashSet<char> brokenLettersCharsList = new HashSet<char>();

            foreach (char currChar in brokenLetters)
            {
                brokenLettersCharsList.Add(currChar);
            }

            int count = 0;
            bool goodValidation = true;

            foreach (char currChar in text)
            {
                if (currChar == ' ')
                {
                    if (goodValidation)
                    {
                        count++;
                    }
                    goodValidation = true;
                }
                else if (brokenLettersCharsList.Contains(currChar))
                {
                    goodValidation = false;
                }
            }

            if (goodValidation == true)
            {
                count++;
            }

            return count;
        }
        public int MinElement(int[] nums)
        {
            //// 0ms, Beats: 100%

            int minValue = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                int currSum = 0;

                while (currValue > 0)
                {
                    currSum += currValue % 10;
                    currValue /= 10;
                }

                if (currSum < minValue)
                {
                    minValue = currSum;
                }
            }

            return minValue;


            //// 4ms, Beats: 35.42%

            //int minValue = int.MaxValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currValue = 0;
            //    foreach (char item in nums[i].ToString())
            //    {
            //        currValue += int.Parse(item.ToString());
            //    }
            //    if (minValue > currValue)
            //    {
            //        minValue = currValue;
            //    }
            //}

            //return minValue;
        }
        public bool CheckIfPangram(string sentence)
        {
            //// 1ms, Beats: 61,57%

            HashSet<char> hashSetChars = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                hashSetChars.Add(sentence[i]);
            }

            if (hashSetChars.Count == 26)
            {
                return true;
            }
            return false;
        }
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dictionaryNums1Count = new Dictionary<int, int>();
            Dictionary<int, int> dictionaryNums2Count = new Dictionary<int, int>();
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dictionaryNums1Count.ContainsKey(nums1[i]))
                {
                    dictionaryNums1Count[nums1[i]]++;
                }
                else
                {
                    dictionaryNums1Count.Add(nums1[i], 1);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionaryNums2Count.ContainsKey(nums2[i]))
                {
                    dictionaryNums2Count[nums2[i]]++;
                }
                else
                {
                    dictionaryNums2Count.Add(nums2[i], 1);
                }
            }

            foreach (var item in dictionaryNums1Count)
            {
                if (dictionaryNums2Count.ContainsKey(item.Key))
                {
                    result[0] += item.Value;
                }
            }
            foreach (var item in dictionaryNums2Count)
            {
                if (dictionaryNums1Count.ContainsKey(item.Key))
                {
                    result[1] += item.Value;
                }
            }

            return result;
        }
        public IList<int> ReplaceNonCoprimes(int[] nums)
        {
            //// 23ms, Beats: 50%

            IList<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                result.Add(nums[i]);

                while (result.Count > 1)
                {
                    int firstValue = result[result.Count - 2];
                    int secondValue = result[result.Count - 1];

                    int gdcValue = GreatestCommonDivisor2197(firstValue, secondValue);

                    if (gdcValue == 1)
                    {
                        break;
                    }

                    result.RemoveAt(result.Count - 1);

                    result[result.Count - 1] = (int)((long)firstValue * secondValue / gdcValue);
                }
            }

            return result;
        }
        private int GreatestCommonDivisor2197(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GreatestCommonDivisor2197(b, a % b);
        }
        public string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int index = 0;
                bool notAPalindrome = false;
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    if (words[i][index] != words[i][j])
                    {
                        notAPalindrome = true;
                        break;
                    }
                    index++;
                }
                if (!notAPalindrome)
                {
                    return words[i];
                }
            }

            return "";
        }
        public string SortSentence(string s)
        {
            string[] words = s.Split(' ');
            string[] sortedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                sortedWords[int.Parse(words[i][words[i].Length - 1].ToString()) - 1] = words[i][0..(words[i].Length - 1)];
            }

            return string.Join(' ', sortedWords);
        }
        public int DiagonalSum(int[][] mat)
        {            
            //// 0ms, Beats: 100%

            int sum = 0;

            int[] indexPrimaryDiagonal = [0, 0];
            int[] indexSecondaryDiagonal = [0, mat[0].Length - 1];

            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[indexPrimaryDiagonal[0]++][indexPrimaryDiagonal[1]++] + mat[indexSecondaryDiagonal[0]++][indexSecondaryDiagonal[1]--];
            }

            if (mat.Length % 2 != 0)
            {
                sum -= mat[mat.Length / 2][mat.Length / 2];
            }

            return sum;
        }
        public int LargestAltitude(int[] gain)
        {
            //// 0ms, Beats: 100%

            int highestAlitute = 0;
            int sum = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                highestAlitute = Math.Max(highestAlitute, sum);
            }

            return highestAlitute;
        }
        public int PivotInteger(int n)
        {
            //// 1ms, Beats: 72.86%

            int currAn = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                currAn++;
                sum += currAn;

                //int sumN = sum / ((currAn+n) / 2);
                int sumN = (currAn + n) * (n - currAn + 1);

                if (sum * 2 == sumN)
                {
                    return currAn;
                }
                //21 = (6 + 8) / 2 * n
                //n = 21 / ((6 + 8) / 2)
            }

            return -1;
        }
        public int SumOddLengthSubarrays(int[] arr)
        {
            int howMany = 1;
            int sum = 0;

            while (howMany <= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int currValue = 0;
                    if (howMany + i <= arr.Length)
                    {
                        for (int j = i; j < howMany + i; j++)
                        {
                            currValue += arr[j];
                        }
                        sum += currValue;
                    }
                }

                howMany += 2;
            }

            return sum;
        }
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            //// 76ms, Beats: 55.00%

            IList<bool> result = new List<bool>();

            for (int i = 0; i < l.Length; i++)
            {
                int[] tempNums = nums[l[i]..(r[i] + 1)];
                Array.Sort(tempNums);
                int diff = tempNums[1] - tempNums[0];
                bool status = true;
                for (int j = 2; j < tempNums.Length; j++)
                {
                    if (diff != tempNums[j] - tempNums[j - 1])
                    {
                        status = false;
                        break;
                    }
                }
                result.Add(status);
            }

            return result;
        }
        public int SumOfTheDigitsOfHarshadNumber(int x)
        {
            // 0ms, Beats: 100.00%

            int sum = 0;
            int copyX = x;

            while (copyX != 0)
            {
                sum += copyX % 10;
                copyX = copyX / 10;
            }
            if (x % sum != 0)
            {
                return -1;
            }

            return sum;
        }
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            // 1ms, Beats: 98.65%

            int[] result = new int[2];
            int[] listValue = new int[grid.Length * grid[1].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (listValue[grid[i][j] - 1] == 0)
                    {
                        listValue[grid[i][j] - 1] = grid[i][j];
                    }
                    else
                    {
                        result[0] = grid[i][j];
                    }
                }
            }

            for (int i = 0; i < listValue.Length; i++)
            {
                if (listValue[i] == 0)
                {
                    result[1] = i + 1;
                    break;
                }
            }

            return result;
        }

        IList<IList<int>> _resultListTask797;
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            _resultListTask797 = new List<IList<int>>();

            IList<int> currPath = new List<int>();
            currPath.Add(0);

            GeneratePathTask797(currPath, 0, graph);

            return _resultListTask797;
        }
        private void GeneratePathTask797(IList<int> currPath, int value, int[][] graph)
        {
            if (value == graph.Length - 1)
            {
                _resultListTask797.Add(new List<int>(currPath));
                //currPath.RemoveAt(currPath.Count() - 1);
                return;
            }

            foreach (int i in graph[value])
            {
                currPath.Add(i);
                GeneratePathTask797(currPath, i, graph);
                currPath.RemoveAt(currPath.Count() - 1);
            }
        }
        public class SpreadsheetTask3484
        {
            //// 28ms, Beats: 80.00%

            private int[][] _tableExcel;
            public SpreadsheetTask3484(int rows)
            {
                _tableExcel = new int[26][];
                for (int i = 0; i < 26; i++)
                {
                    _tableExcel[i] = new int[rows];
                }
            }

            public void SetCell(string cell, int value)
            {
                _tableExcel[(cell[0] - 'A')][int.Parse(cell[1..cell.Length]) - 1] = value;
            }

            public void ResetCell(string cell)
            {
                _tableExcel[(cell[0] - 'A')][int.Parse(cell[1..cell.Length]) - 1] = 0;
            }

            public int GetValue(string formula)
            {
                string[] tempString = formula.Split('+');
                int value1 = 0;
                if (tempString[0][1] >= 'A' && tempString[0][1] <= 'Z')
                {
                    value1 = _tableExcel[tempString[0][1] - 'A'][int.Parse(tempString[0][2..tempString[0].Length]) - 1];
                }
                else
                {
                    value1 = int.Parse(tempString[0][1..tempString[0].Length]);
                }
                if (tempString[1][0] >= 'A' && tempString[1][0] <= 'Z')
                {
                    return value1 + (_tableExcel[tempString[1][0] - 'A'][int.Parse(tempString[1][1..tempString[1].Length]) - 1]);
                }
                else
                {
                    return value1 + int.Parse(tempString[1]);
                }
            }
        }
        public int MaxProduct(int[] nums)
        {
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > secondMax)
                {
                    if (nums[i] > firstMax)
                    {
                        secondMax = firstMax;
                        firstMax = nums[i];
                    }
                    else
                    {
                        secondMax = nums[i];
                    }
                }
            }

            return ((firstMax - 1) * (secondMax - 1));
        }
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            //// 4ms, Beats: 95.24%

            int length = deck.Length;
            Array.Sort(deck);
            int[] newDeck = new int[length];
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < length; i++)
            {
                queue.Enqueue(i);
            }

            int index = 0;

            while (queue.Count > 0)
            {
                newDeck[queue.Dequeue()] = deck[index++];
                if (queue.Count == 0)
                {
                    break;
                }
                int temp = queue.Dequeue();
                queue.Enqueue(temp);
            }

            return newDeck;
        }
        public int[] FinalPrices(int[] prices)
        {
            //// 1ms, Beats: 97.54%

            int length = prices.Length;

            for (int i = 0; i < length; i++)
            {
                int tempValue = prices[i];
                int lessValue = 0;
                for (int j = i + 1; j < length; j++)
                {
                    if (tempValue >= prices[j])
                    {
                        lessValue = prices[j];
                        break;
                    }
                }
                prices[i] = tempValue - lessValue;
            }

            return prices;
        }

        HashSet<string> _hashsetStringTask1079;
        public int NumTilePossibilities(string tiles)
        {
            Dictionary<char, int> countCharDictionary = new Dictionary<char, int>();

            for (int i = 0; i < tiles.Length; i++)
            {
                if (countCharDictionary.ContainsKey(tiles[i]))
                {
                    countCharDictionary[tiles[i]]++;
                }
                else
                {
                    countCharDictionary.Add(tiles[i], 1);
                }
            }

            _hashsetStringTask1079 = new HashSet<string>();

            GenerateLetterPossibilities(countCharDictionary, string.Empty);

            return _hashsetStringTask1079.Count;
        }
        private void GenerateLetterPossibilities(Dictionary<char, int> countCharDictionary, string currPath)
        {
            foreach (var item in countCharDictionary)
            {
                if (item.Value == 0)
                {
                    continue;
                }
                if (countCharDictionary.Count == 0)
                {
                    return;
                }
                countCharDictionary[item.Key]--;
                currPath += item.Key;
                _hashsetStringTask1079.Add(currPath);
                GenerateLetterPossibilities(countCharDictionary, currPath);
                countCharDictionary[item.Key]++;
                currPath = currPath[0..(currPath.Length - 1)];
            }
        }
        public TreeNode SearchBST(TreeNode root, int val)
        {
            ////0ms, Beats: 100.00%

            while (root != null)
            {
                if (root.val == val)
                {
                    return root;
                }
                if (root.val > val)
                {
                    root = root.right;
                }
                if (root.val < val)
                {
                    root = root.left;
                }
            }

            return null;
        }
        public int FindTheWinner(int n, int k)
        {
            Queue<int> ints = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                ints.Enqueue(i);
            }

            int currNext = 0;
            while (ints.Count > 1)
            {
                int temp = ints.Dequeue();
                currNext++;
                if (currNext == k)
                {
                    currNext = 0;
                }
                else
                {
                    ints.Enqueue(temp);
                }
            }

            return ints.Dequeue();
        }
        public string MergeAlternately(string word1, string word2)
        {
            ////58ms, Beats: 88.90%

            int length1 = word1.Length;
            int length2 = word2.Length;
            int sumLength = length1 + length2;
            int curr = 0;

            StringBuilder resultStringBuilder = new StringBuilder();

            int index1 = 0;
            int index2 = 0;

            while (curr < sumLength)
            {
                if (index1 < length1)
                {
                    resultStringBuilder.Append(word1[index1]);
                    index1++;
                    curr++;
                }
                if (index2 < length2)
                {
                    resultStringBuilder.Append(word2[index2]);
                    index2++;
                    curr++;
                }
            }

            return new string(resultStringBuilder.ToString());
        }
        public int NumOfStrings(string[] patterns, string word)
        {
            ////0ms, Beats: 100.00% 

            int count = 0;

            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                {
                    count++;
                }
            }

            return count;
        }
        public int MaxFrequencyElements(int[] nums)
        {
            ////1ms, Beats: 95.96%

            int[] countValue = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                countValue[nums[i]]++;
            }

            int maxfrequency = 0;
            int sumCount = 0;

            for (int i = 0; i < countValue.Length; i++)
            {
                if (countValue[i] > maxfrequency)
                {
                    maxfrequency = countValue[i];
                    sumCount = maxfrequency;
                }
                else if (countValue[i] == maxfrequency)
                {
                    sumCount += countValue[i];
                }
            }

            return sumCount;
        }
        public int MinSteps(string s, string t)
        {
            ////2ms, Beats: 98.08%

            int count = 0;
            int[] intsS = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                intsS[s[i] - 'a']++;
                intsS[t[i] - 'a']--;
            }

            for (int i = 0; i < intsS.Length; i++)
            {
                //Console.WriteLine((char)(intsS[i] + 'a'));
                if (intsS[i] < 0)
                {
                    count += Math.Abs(intsS[i]);
                }

            }

            return count;



            //// 4ms, Beats: 51.92%

            //int count = 0;
            //int[] intsS = new int[26];
            //int[] intsT = new int[26];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    intsS[s[i] - 'a']++;
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    intsT[t[i] - 'a']++;
            //}

            //for (int i = 0; i < intsS.Length; i++)
            //{
            //    //Console.WriteLine((char)(intsS[i] + 'a'));
            //    if (intsS[i] > intsT[i])
            //    {
            //        count += intsS[i] - intsT[i];
            //    }

            //}

            //return count;
        }
        public class OrderedStreamTask1656
        {
            private string[] _strings;
            private int _index;
            public OrderedStreamTask1656(int n)
            {
                _index = 0;
                _strings = new string[n];
            }

            public IList<string> Insert(int idKey, string value)
            {
                if (_index != idKey - 1)
                {
                    _strings[idKey - 1] = value;
                    return [];
                }
                else
                {
                    int howLong = 0;
                    _strings[idKey - 1] = value;
                    for (int i = idKey; i < _strings.Length; i++)
                    {
                        if (_strings[i] == null)
                        {
                            break;
                        }
                        else
                        {
                            howLong++;
                        }
                    }
                    _index += howLong + 1;
                    return _strings[(_index - howLong - 1)..(_index)];
                }
            }
        }
        public int AddedInteger(int[] nums1, int[] nums2)
        {
            ////0ms, Beats: 100.00%

            int sum1 = 0;
            int sum2 = 0;
            int length = nums1.Length;

            for (int i = 0; i < nums1.Length; i++)
            {
                sum1 += nums1[i];
                sum2 += nums2[i];
            }

            if (sum1 == sum2)
            {
                return 0;
            }

            return (sum2 - sum1) / length;
        }
        public string ReplaceDigits(string s)
        {
            //0ms, Beats: 100.00%

            StringBuilder sb = new StringBuilder();
            char lastChar = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(s[i]);
                    lastChar = s[i];
                }
                else
                {
                    //int temp = int.Parse(s[i].ToString());
                    sb.Append((char)(lastChar + char.GetNumericValue(s[i])));
                }
            }

            return new string(sb.ToString());
        }
        public int MinOperations(int n)
        {
            int result = 0;

            int[] arrayN = new int[n];
            int length = arrayN.Length;
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = (2 * i) + 1;
            }

            int indexL = 0;
            int indexR = length - 1;
            int seachrNumber = 0;

            if (length % 2 == 0)
            {
                seachrNumber = (arrayN[length / 2] + arrayN[length / 2 - 1]) / 2;
                while (indexL < indexR)
                {
                    result += seachrNumber - arrayN[indexL++];
                    indexR--;
                }
            }
            else
            {
                seachrNumber = arrayN[length / 2];
                while (indexL < indexR)
                {
                    result += seachrNumber - arrayN[indexL++];
                    indexR--;
                }
            }

            return result;
        }

        private bool[][] _visitedGridTask980;
        private int[][] _gridTask980;
        private int _countRowTask980;
        private int _countColTask980;
        private int _howManyZeroTask980;
        private int _howManyPathTask980;
        private int[] _directionTask980;
        public int UniquePathsIII(int[][] grid)
        {
            _gridTask980 = grid;
            _countRowTask980 = grid.Length;
            _countColTask980 = grid[0].Length;
            _howManyZeroTask980 = 0;
            int positionRow = 0;
            int positionCol = 0;
            _howManyPathTask980 = 0;
            _directionTask980 = new int[5] { 0, 1, 0, -1, 0 };
            _visitedGridTask980 = new bool[_countRowTask980][];

            for (int i = 0; i < _countRowTask980; i++)
            {
                _visitedGridTask980[i] = new bool[_countColTask980];
                for (int j = 0; j < _countColTask980; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        _howManyZeroTask980++;
                    }
                    else if (grid[i][j] == 1)
                    {
                        positionRow = i;
                        positionCol = j;
                    }
                }
            }
            _visitedGridTask980[positionRow][positionCol] = true;

            dfsPath(positionRow, positionCol, 0);

            return _howManyPathTask980;
        }
        private void dfsPath(int row, int col, int countZero)
        {
            if (_gridTask980[row][col] == 2)
            {
                if (countZero == _howManyZeroTask980 + 1)
                {
                    _howManyPathTask980++;
                }
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                int currRow = row + _directionTask980[i];
                int currCol = col + _directionTask980[i + 1];

                if (currRow >= 0 && currCol >= 0 && currRow < _countRowTask980 && currCol < _countColTask980 && !_visitedGridTask980[currRow][currCol] && _gridTask980[currRow][currCol] != -1)
                {
                    _visitedGridTask980[currRow][currCol] = true;

                    dfsPath(currRow, currCol, countZero + 1);

                    _visitedGridTask980[currRow][currCol] = false;
                }
            }
        }
        public ListNode MergeInBetweenTask1669(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode resultListNode = new ListNode(0);
            ListNode dummyResultListNode = resultListNode;
            int indexList1 = 0;
            bool runLoop = false;
            while (list1 != null)
            {
                if (indexList1 == a && !runLoop)
                {
                    while (list2 != null)
                    {
                        dummyResultListNode.next = list2;
                        dummyResultListNode = dummyResultListNode.next;
                        list2 = list2.next;
                    }
                    runLoop = true;
                }
                else
                {
                    indexList1++;
                    if (runLoop)
                    {
                        for (int i = a; i <= b; i++)
                        {
                            list1 = list1.next;
                        }
                        runLoop = false;
                    }
                    else
                    {
                        dummyResultListNode.next = list1;
                        dummyResultListNode = dummyResultListNode.next;
                        list1 = list1.next;
                    }
                }

            }

            return resultListNode.next;
        }
        public string ClearDigits(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            bool end = false;
            int index = 0;

            if (s.Length < 2)
            {
                return s;
            }

            while (!end)
            {
                if (sb[index + 1] < 'a' && sb[index] >= 'a')
                {
                    sb.Remove(index, 2);
                    index--;
                }
                else
                {
                    index++;
                }

                if (index + 1 >= sb.Length)
                {
                    end = true;
                }
            }

            return new string(sb.ToString());
        }
        public int TriangleNumber(int[] nums)
        {
            ////25ms, Beats: 98.53%
            int count = 0;
            int length = nums.Length;
            Array.Sort(nums);

            for (int i = length - 1; i > 0; i--)
            {
                int left = 0;
                int right = i - 1;
                int currValue = nums[i];

                while (left < right)
                {
                    if (nums[left] + nums[right] > currValue)
                    {
                        count += right - left;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return count;

            //// Brute Force: 607ms, Beats: 11.76%
            //int count = 0;
            //int length = nums.Length;
            //Array.Sort(nums);

            //if(length < 3)
            //{
            //    return count;
            //}

            //for(int i = 0; i < length-2; i++)
            //{
            //    int currFirstValue = nums[i];
            //    for(int j = i+1; j < length-1; j++)
            //    {
            //        int secondValue = nums[j];
            //        for(int k = j+1; k < length; k++)
            //        {
            //            if(currFirstValue + secondValue > nums[k])
            //            {
            //                count++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}

            //return count;
        }
        public int[] MinCosts(int[] cost)
        {
            int currMinValue = cost[0];

            for (int i = 0; i < cost.Length; i++)
            {
                if (currMinValue < cost[i])
                {
                    cost[i] = currMinValue;
                }
                else
                {
                    currMinValue = cost[i];
                    cost[i] = currMinValue;
                }
            }

            return cost;
        }
        public bool IsAcronym(IList<string> words, string s)
        {
            bool result = true;
            int lengthS = s.Length;

            if (lengthS != words.Count)
            {
                return false;
            }

            for (int i = 0; i < lengthS; i++)
            {
                if (s[i] != words[i][0])
                {
                    return false;
                }
            }

            return result;
        }
        public string MaximumOddBinaryNumber(string s)
        {
            int countOne = -1;
            int countZero = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    countZero++;
                }
                else
                {
                    countOne++;
                }
            }

            for (int i = 0; i < countOne; i++)
            {
                sb.Append('1');
            }
            for (int i = 0; i < countZero; i++)
            {
                sb.Append('0');
            }
            sb.Append('1');

            return new string(sb.ToString());
        }
        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int height = rowSum.Length;
            int width = colSum.Length;

            int[][] resultTable = new int[height][];
            for (int i = 0; i < height; i++)
            {
                resultTable[i] = new int[width];
            }

            int indexRow = 0, indexCol = 0;

            while (indexRow < height && indexCol < width)
            {
                int temp = Math.Min(rowSum[indexRow], colSum[indexCol]);
                resultTable[indexRow][indexCol] = temp;
                rowSum[indexRow] -= temp;
                colSum[indexCol] -= temp;

                if (rowSum[indexRow] == 0)
                {
                    indexRow++;
                }
                if (colSum[indexCol] == 0)
                {
                    indexCol++;
                }
            }

            return resultTable;
        }
        public int MaxProductDifference(int[] nums)
        {
            ////129ms, Beats: 57.41%
            //int length = nums.Length;
            //Array.Sort(nums);

            //return (nums[length - 1] * nums[length - 2] - nums[0] * nums[1]);

            //OR

            ////106ms, Beats: 96.30%
            int length = nums.Length;
            int firstMax = nums[0];
            int secondMax = int.MinValue;
            int firstMin = nums[0];
            int secondMin = int.MaxValue;

            for (int i = 1; i < length; i++)
            {
                int temp = nums[i];
                if (firstMax <= temp)
                {
                    if (firstMax < temp)
                    {
                        if (secondMax < firstMax)
                        {
                            secondMax = firstMax;
                        }
                        firstMax = temp;
                    }
                    else if (secondMax < firstMax)
                    {
                        secondMax = firstMax;
                    }

                }
                else if (secondMax < temp)
                {
                    secondMax = temp;
                }

                if (firstMin >= temp)
                {
                    if (firstMin > temp)
                    {
                        if (secondMin > firstMin)
                        {
                            secondMin = firstMin;
                        }
                        firstMin = temp;
                    }
                    else if (secondMin > firstMin)
                    {
                        secondMin = firstMin;
                    }
                }
                else if (secondMin > temp)
                {
                    secondMin = temp;
                }
            }

            return firstMax * secondMax - firstMin * secondMin;
        }
        public int CountAsterisks(string s)
        {
            int count = 0;
            bool active = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|')
                {
                    if (active)
                    {
                        active = false;
                    }
                    else
                    {
                        active = true;
                    }
                }
                if (s[i] == '*' && active)
                {
                    count++;
                }
            }

            return count;
        }
        public string StringHash(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int currValue = 0;

            for (int i = 0; i < s.Length; i++)
            {
                count++;
                currValue += (s[i] - 'a');
                if (count == k)
                {
                    count = 0;
                    sb.Append(Convert.ToChar((currValue % 26) + 'a'));
                    currValue = 0;
                }
            }

            return new string(sb.ToString());
        }
        public int CountSymmetricIntegers(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)
            {
                char[] temp = i.ToString().ToCharArray();

                if (temp.Length % 2 == 0)
                {
                    int l = 0;
                    int r = temp.Length - 1;
                    int result = 0;
                    while (l < r)
                    {
                        result += (int)temp[l++] - (int)temp[r--];
                    }
                    if (result == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int TriangularSum(int[] nums)
        {
            ////31ms, Beats: 92.86%
            int lengthJ = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    nums[j] = (nums[j] + nums[j + 1]) % 10;
                }
                lengthJ--;
            }

            return nums[0];
        }
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            ////0ms, 100.00%
            int result = numBottles;

            while (numBottles >= numExchange)
            {
                int temp = numBottles / numExchange;
                result += temp;
                numBottles = numBottles % numExchange + temp;
            }

            return result;
        }
        public int[][] DiagonalSort(int[][] mat)
        {
            ////7ms, Beats: 74.00%
            int height = mat.Length;
            int width = mat[0].Length;


            for (int j = 0; j < width; j++)
            {
                int indexX = j;
                int indexY = 0;
                List<int> list = new List<int>();
                while (indexX < width && indexY < height)
                {
                    list.Add(mat[indexY++][indexX++]);
                }
                indexX = j;
                indexY = 0;
                list.Sort();
                int indexlist = 0;
                while (indexX < width && indexY < height)
                {
                    mat[indexY++][indexX++] = list[indexlist++];
                }
            }

            for (int i = 1; i < height; i++)
            {
                int indexX = 0;
                int indexY = i;
                List<int> list = new List<int>();
                while (indexX < width && indexY < height)
                {
                    list.Add(mat[indexY++][indexX++]);
                }
                indexX = 0;
                indexY = i;
                int indexlist = 0;
                list.Sort();
                while (indexX < width && indexY < height)
                {
                    mat[indexY++][indexX++] = list[indexlist++];

                }

            }

            return mat;

            ////17ms, Beats: 10.00%
            //int height = mat.Length;
            //int width = mat[0].Length;

            //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            //for (int j = 0; j < width; j++)
            //{
            //    int indexX = j;
            //    int indexY = 0;
            //    priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    while (indexX < width && indexY < height)
            //    {
            //        priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);

            //    }
            //    indexX = j;
            //    indexY = 0;
            //    mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    while (indexX < width && indexY < height)
            //    {
            //        mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    }
            //}

            //for (int i = 1; i < height; i++)
            //{
            //    int indexX = 0;
            //    int indexY = i;
            //    priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    while (indexX < width && indexY < height)
            //    {
            //        priorityQueue.Enqueue(mat[indexY][indexX], mat[indexY++][indexX++]);
            //    }
            //    indexX = 0;
            //    indexY = i;
            //    mat[indexY++][indexX++] = priorityQueue.Dequeue();
            //    while (indexX < width && indexY < height)
            //    {
            //        mat[indexY++][indexX++] = priorityQueue.Dequeue();

            //    }

            //}

            //return mat;
        }
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            return false;
        }
        public long MinSum(int[] nums1, int[] nums2)
        {
            //85ms, Beasts: 93.75%
            long sumNums1 = 0;
            long sumNums2 = 0;
            int countZeroNums1 = 0;
            int countZeroNums2 = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] > 0)
                {
                    sumNums1 += nums1[i];
                }
                else
                {
                    countZeroNums1++;
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] > 0)
                {
                    sumNums2 += nums2[i];
                }
                else
                {
                    countZeroNums2++;
                }
            }

            long minSumNums1 = sumNums1 + countZeroNums1;
            long minSumNums2 = sumNums2 + countZeroNums2;


            if (minSumNums1 >= minSumNums2)
            {
                if (countZeroNums2 > 0)
                {
                    return minSumNums1;
                }
                else if (minSumNums1 == minSumNums2)
                {
                    return minSumNums1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (countZeroNums1 > 0)
                {
                    return minSumNums2;
                }
                else if (minSumNums1 == minSumNums2)
                {
                    return minSumNums2;
                }
                else
                {
                    return -1;
                }
            }
        }
        public int MaxBottlesDrunk(int numBottles, int numExchange)
        {
            int count = numBottles;
            while (numBottles >= numExchange)
            {
                numBottles -= numExchange++ - 1;
                count++;
            }

            return count;
        }
        public int PairSum(ListNode head)
        {
            List<int> numsHead = new List<int>();
            int maxSum = int.MinValue;

            while (head != null)
            {
                numsHead.Add(head.val);
                head = head.next;
            }
            int length = numsHead.Count;

            for (int i = 0; i < numsHead.Count / 2; i++)
            {
                maxSum = Math.Max(maxSum, numsHead[i] + numsHead[length - 1 - i]);
            }

            return maxSum;
        }
        public int CountSeniors(string[] details)
        {
            ////0ms, Beats: 100.00%
            int count = 0;

            foreach (string item in details)
            {
                if (item[11] >= 54)
                {
                    if (item[11] > 54)
                    {
                        count++;
                    }
                    else if (item[12] > 48)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> dictionaryCountNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionaryCountNums.ContainsKey(nums[i]))
                {
                    dictionaryCountNums[nums[i]]++;
                }
                else
                {
                    dictionaryCountNums.Add(nums[i], 1);
                }
            }

            List<int> listValue = dictionaryCountNums.OrderBy(x => x.Value).ThenByDescending(x => x.Key).Select(x => x.Key).ToList();

            int index = 0;

            foreach (int num in listValue)
            {
                for (int i = 0; i < dictionaryCountNums[num]; i++)
                {
                    nums[index] = num;
                    index++;
                }
            }

            return nums;
        }
        public int WateringPlants(int[] plants, int capacity)
        {
            int sum = 1;
            int restWater = capacity - plants[0];

            for (int i = 1; i < plants.Length; i++)
            {
                if (restWater >= plants[i])
                {
                    sum++;
                    restWater -= plants[i];
                }
                else
                {
                    restWater = capacity - plants[i];
                    sum += (i * 2) + 1;
                }
            }

            return sum;
        }
        public int RemovePalindromeSub(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                {
                    return 2;
                }
            }

            return 1;
        }
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> result = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                int[] patternTest = new int[26];
                bool status = true;
                HashSet<int> hashSetInt = new HashSet<int>();

                for (int j = 0; j < pattern.Length; j++)
                {
                    int x = words[i][j];
                    int y = pattern[j];

                    if (patternTest[y - 97] == 0)
                    {
                        if (!hashSetInt.Add(x))
                        {
                            status = false;
                            break;
                        }
                        patternTest[y - 97] = x;
                    }
                    else if (patternTest[y - 97] != x)
                    {
                        status = false;
                        break;
                    }
                }

                if (status)
                {
                    result.Add(words[i]);
                }
            }

            return result;
        }
        public string SortString(string s)
        {
            StringBuilder sb = new StringBuilder();
            int[][] countS = new int[26][];

            for (int i = 0; i < 26; i++)
            {
                countS[i] = new int[1];
            }

            for (int i = 0; i < s.Length; i++)
            {
                countS[s[i] - 97][0]++;
            }

            //int minIndex = 0;
            //int maxIndex = 25;
            int howMany = 1;
            while (howMany != 0)
            {
                howMany = 0;
                int lastRemove = int.MinValue;

                for (int i = 0; i < 26; i++)
                {
                    if (lastRemove < i && countS[i][0] > 0)
                    {
                        lastRemove = i;
                        sb.Append((char)(lastRemove + 97));
                        countS[lastRemove][0]--;
                    }
                }

                lastRemove = int.MaxValue;

                for (int i = 25; i >= 0; i--)
                {
                    if (lastRemove > i && countS[i][0] > 0)
                    {
                        lastRemove = i;
                        sb.Append((char)(lastRemove + 97));
                        countS[lastRemove][0]--;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    if (countS[i][0] > 0)
                    {
                        howMany = 1;
                        break;
                    }
                }

            }

            return new string(sb.ToString());
        }
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int length = potions.Length;
            for (int i = 0; i < spells.Length; i++)
            {
                long tempValueSpell = spells[i];
                long minValue = success / tempValueSpell;
                if ((long)minValue * tempValueSpell < success)
                {
                    minValue++;
                }
                minValue--;
                int lIndex = 0;
                int rIndex = length;

                while (lIndex < rIndex)
                {
                    int mid = (lIndex + rIndex) / 2;

                    if (potions[mid] > minValue)
                    {
                        rIndex = mid;

                    }
                    else
                    {
                        lIndex = mid + 1;
                    }

                }

                spells[i] = length - lIndex;
            }
            return spells;
        }
        public int MinimizedStringLength(string s)
        {
            ////6ms, Betas: 81.13%

            HashSet<char> countUniqueChars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                countUniqueChars.Add(s[i]);
            }

            return countUniqueChars.Count;
        }
        public long MinTime(int[] skill, int[] mana)
        {
            int skillsCount = skill.Length;
            long[] times = new long[skillsCount];
            int manaCount = mana.Length;

            for (int indexMana = 0; indexMana < manaCount; indexMana++)
            {
                long currTime = 0;

                for (int indexSkill = 0; indexSkill < skillsCount; indexSkill++)
                {
                    currTime = Math.Max(currTime, times[indexSkill]) + (long)mana[indexMana] * skill[indexSkill];
                }

                times[skillsCount - 1] = currTime;

                for (int indexSkill = skillsCount - 2; indexSkill >= 0; indexSkill--)
                {
                    times[indexSkill] = times[indexSkill + 1] - (long)mana[indexMana] * skill[indexSkill + 1];
                }
            }

            return times[skillsCount - 1];
        }
        public int[] SeparateDigits(int[] nums)
        {
            List<int> listAllNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 9)
                {
                    listAllNums.Add(nums[i]);
                }
                else
                {
                    string tempValue = nums[i].ToString();

                    for (int j = 0; j < tempValue.Length; j++)
                    {
                        listAllNums.Add((int)char.GetNumericValue(tempValue[j]));
                    }
                }
            }

            return listAllNums.ToArray();
        }
        public int MaximumEnergy(int[] energy, int k)
        {
            int maxEnergyEnd = int.MinValue;
            int lengthEnergy = energy.Length;

            for (int i = lengthEnergy - k; i < lengthEnergy; i++)
            {
                int currSumEnergy = 0;
                for (int j = i; j >= 0; j -= k)
                {
                    currSumEnergy += energy[j];
                    maxEnergyEnd = Math.Max(maxEnergyEnd, currSumEnergy);
                }
            }
            return maxEnergyEnd;
        }
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            ////20ms, Beats: 87.33%

            IList<IList<int>> result = new List<IList<int>>();
            IList<int> listNum1 = nums1.ToList();
            IList<int> listNum2 = nums2.ToList();
            IList<int> listNum1Unique = new List<int>();
            IList<int> listNum2Unique = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!listNum2.Contains(nums1[i]) && !listNum1Unique.Contains(nums1[i]))
                {
                    listNum1Unique.Add(nums1[i]);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (!listNum1.Contains(nums2[i]) && !listNum2Unique.Contains(nums2[i]))
                {
                    listNum2Unique.Add(nums2[i]);
                }
            }

            result.Add(listNum1Unique);
            result.Add(listNum2Unique);

            return result;

            //OR - bad method
            //IList<IList<int>> result = new List<IList<int>>();
            //int lengthNums1 = nums1.Length;
            //int lengthNums2 = nums2.Length;

            //for (int i = 0; i < 2; i++)
            //{
            //    IList<int> currList = new List<int>();
            //    result.Add(currList);

            //    if (i == 0)
            //    {
            //        for (int j = 0; j < lengthNums1; j++)
            //        {
            //            int tempValue = nums1[j];
            //            bool addStatus = true;

            //            for (int k = 0; k < lengthNums2; k++)
            //            {
            //                if (tempValue == nums2[k])
            //                {
            //                    addStatus = false;
            //                    break;
            //                }
            //            }
            //            if (addStatus)
            //            {
            //                if (!currList.Contains(nums1[j]))
            //                {
            //                    currList.Add(nums1[j]);
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < lengthNums2; j++)
            //        {
            //            int tempValue = nums2[j];
            //            bool addStatus = true;

            //            for (int k = 0; k < lengthNums1; k++)
            //            {
            //                if (tempValue == nums1[k])
            //                {
            //                    addStatus = false;
            //                    break;
            //                }
            //            }
            //            if (addStatus)
            //            {
            //                if (!currList.Contains(nums2[j]))
            //                {
            //                    currList.Add(nums2[j]);
            //                }
            //            }
            //        }
            //    }
            //}

            //return result;
        }
        public bool CanAliceWin(int[] nums)
        {
            long singleDigitSum = 0;
            long doubleDigitSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 10)
                {
                    singleDigitSum += nums[i];
                }
                else
                {
                    doubleDigitSum += nums[i];
                }
            }

            if (singleDigitSum != doubleDigitSum) { return true; }
            return false;
        }
        public int CountCompleteDayPairs(int[] hours)
        {
            int count = 0;
            int length = hours.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int firstValue = hours[i];
                for (int j = i + 1; j < length; j++)
                {
                    if ((firstValue + hours[j]) % 24 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public class BrowserHistoryTask1472
        {
            Stack<string> _forwardStack = new Stack<string>();
            Stack<string> _backStack = new Stack<string>();
            public BrowserHistoryTask1472(string homepage)
            {
                _backStack.Push(homepage);
            }

            public void Visit(string url)
            {
                _backStack.Push(url);
                _forwardStack.Clear();
            }

            public string Back(int steps)
            {
                if (_backStack.Count > 1)
                {
                    if (_backStack.Count < steps)
                    {
                        steps = _backStack.Count - 1;
                    }
                    for (int i = 0; i < steps - 1; i++)
                    {
                        _forwardStack.Push(_backStack.Pop());
                    }
                    if (_backStack.Count != 1)
                    {
                        _forwardStack.Push(_backStack.Pop());
                    }
                }
                return _backStack.Peek();
            }

            public string Forward(int steps)
            {
                if (_forwardStack.Count > 0)
                {
                    if (steps > _forwardStack.Count)
                    {
                        steps = _forwardStack.Count;
                    }
                    for (int i = 0; i < steps - 1; i++)
                    {
                        _backStack.Push(_forwardStack.Pop());
                    }
                    _backStack.Push(_forwardStack.Pop());
                }
                return _backStack.Peek();
            }
        }
        public int MaxSatisfaction(int[] satisfaction)
        {
            int maxSum = int.MinValue;
            Array.Sort(satisfaction);
            int length = satisfaction.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int tempValue = satisfaction[i];
                int numberIndex = 2;
                for (int j = i + 1; j < length; j++)
                {
                    tempValue += satisfaction[j] * numberIndex++;
                    maxSum = Math.Max(maxSum, tempValue);
                }
            }
            if (maxSum < 0)
            {
                return 0;
            }
            return maxSum;
        }
        public IList<string> RemoveAnagrams(string[] words)
        {
            string lastString = string.Empty;
            List<string> resultList = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] temp = words[i].ToCharArray();
                Array.Sort(temp);
                string tempString = new string(temp);

                if (lastString != tempString)
                {
                    resultList.Add(words[i]);
                }
                lastString = tempString;
            }

            return resultList;
        }
        public int CountNegatives(int[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public int CountPrefixSuffixPairs(string[] words)
        {
            int count = 0;
            int length = words.Length;

            for (int i = 0; i < length - 1; i++)
            {
                string currWords = words[i];
                int lengthWordI = currWords.Length;

                for (int j = i + 1; j < length; j++)
                {
                    int lengthWordJ = words[j].Length;

                    //Console.WriteLine(words[j][0..lengthWordI]);
                    //Console.WriteLine(words[j][(lengthWordJ-lengthWordI)..lengthWordJ]);

                    if (lengthWordI <= lengthWordJ && currWords == words[j][0..lengthWordI] && words[j][(lengthWordJ - lengthWordI)..lengthWordJ] == currWords)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public int CountPoints(string rings)
        {
            int count = 0;
            int[][] countColorPosition = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                countColorPosition[i] = new int[3];
            }

            for (int i = 0; i < rings.Length; i += 2)
            {
                int indexRings = (int)char.GetNumericValue(rings[i + 1]);
                switch (rings[i])
                {
                    case 'B':
                        countColorPosition[indexRings][0]++;
                        break;
                    case 'R':
                        countColorPosition[indexRings][1]++;
                        break;
                    default:
                        countColorPosition[indexRings][2]++;
                        break;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                if (countColorPosition[i][0] > 0 && countColorPosition[i][1] > 0 && countColorPosition[i][2] > 0)
                {
                    count++;
                }
            }

            return count;
        }
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            int countIncreasing = 1;
            int lastValue = int.MaxValue;
            int length = nums.Count;
            if (k == 1)
            {
                return true;
            }

            for (int i = 0; i < length; i++)
            {
                int temp = nums[i];
                if (i + k >= length)
                {
                    return false;
                }
                else if (lastValue < temp)
                {
                    countIncreasing++;
                    if (countIncreasing >= k)
                    {
                        bool status = true;
                        int currLastValue = nums[i + 1];
                        for (int j = i + 2; j <= i + k; j++)
                        {
                            if (currLastValue >= nums[j])
                            {
                                status = false;
                                break;
                            }
                            currLastValue = nums[j];
                        }
                        if (status)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    countIncreasing = 1;
                }
                lastValue = temp;
            }

            return false;
        }
        public int MaxIncreasingSubarrays(IList<int> nums)
        {
            int maxCountIncreasing = 0;
            int currCountIncreasing = 1;
            int prevCountIntressing = 0;
            int length = nums.Count;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currCountIncreasing++;
                }
                else
                {
                    prevCountIntressing = currCountIncreasing;
                    currCountIncreasing = 1;
                }

                maxCountIncreasing = Math.Max(maxCountIncreasing, currCountIncreasing / 2);
                maxCountIncreasing = Math.Max(maxCountIncreasing, Math.Min(currCountIncreasing, prevCountIntressing));
            }

            return maxCountIncreasing;
        }
        public bool IsSameAfterReversals(int num)
        {
            ////Option 1

            if (num > 0 && num % 10 != 0)
            {
                return true;
            }
            else if (num > 0 && num % 10 == 0)
            {
                return false;
            }
            return true;

            ////Option 2
            //string charsNum = num.ToString();
            //if (charsNum.Length == 1)
            //{
            //    return true;
            //}

            //if (charsNum[charsNum.Length-1] == '0')
            //{
            //    return false;
            //}

            //return true;

            ////Option 3
            //string resultString = string.Empty;
            //int copyNum = num;
            //if (num == 0)
            //{
            //    return true;
            //}
            //while(copyNum != 0)
            //{
            //    int temp = copyNum % 10;
            //    if (temp > 0)
            //    {
            //        resultString += temp;
            //    }
            //    else if( resultString.Length > 0)
            //    {
            //        resultString += temp;
            //    }
            //    copyNum /= 10;
            //}

            //resultString = new string(resultString.Reverse().ToArray());
            //return int.Parse(resultString) == num; 
        }
        public int GcdOfOddEvenSums(int n)
        {
            return (n * (n + 1)) - (n * n);

            //// OR
            //int sumOdd = n * n;
            //int sumEven = n * (n + 1);

            //return sumEven - sumOdd;
        }
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            IList<IList<int>> result = new List<IList<int>>();

            items1 = items1.OrderBy(c => c[0]).ToArray();
            items2 = items2.OrderBy(c => c[0]).ToArray();

            int currValue1 = 0;
            int currValue2 = 0;
            int currWeight1 = 0;
            int currWeight2 = 0;
            int lengthItem1 = items1.Length;
            int lengthItem2 = items2.Length;
            int index1 = 0;
            int index2 = 0;

            while (index1 < lengthItem1 || index2 < lengthItem2)
            {
                if (index1 < lengthItem1)
                {
                    currValue1 = items1[index1][0];
                }
                if (index2 < lengthItem2)
                {
                    currValue2 = items2[index2][0];
                }
                if (currValue1 == currValue2)
                {
                    if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                    }
                    if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                    }
                    result.Add(new List<int> { currValue1, (currWeight1 + currWeight2) });
                }
                else if (currValue1 < currValue2)
                {
                    if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                        result.Add(new List<int> { currValue1, (currWeight1) });
                    }
                    else if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                        result.Add(new List<int> { currValue2, (currWeight2) });

                    }
                }
                else
                {
                    if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                        result.Add(new List<int> { currValue2, (currWeight2) });

                    }
                    else if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                        result.Add(new List<int> { currValue1, (currWeight1) });
                    }
                }
            }
            return result;
        }
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;

            for (int i = 0; i < endTime.Length; i++)
            {
                if (endTime[i] >= queryTime && startTime[i] <= queryTime)
                {
                    count++;
                }
            }

            return count;
        }
        public int MaxDistinctElements(int[] nums, int k)
        {
            int count = 0;
            Array.Sort(nums);
            int currMinValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - k > currMinValue)
                {
                    currMinValue = nums[i] - k;
                    count++;
                }
                else if (currMinValue != nums[i] + k)
                {
                    currMinValue++;
                    count++;
                }
            }

            return count;
        }
        public string FindLexSmallestString(string s, int a, int b)
        {
            Queue<String> queue = new Queue<string>();
            queue.Enqueue(s);

            HashSet<String> hashSetVisited = new HashSet<string>();
            hashSetVisited.Add(s);

            String smallestString = s;

            int length = s.Length;

            while (queue.Count != 0)
            {
                String currentString = queue.Dequeue();

                if (smallestString.CompareTo(currentString) > 0)
                {
                    smallestString = currentString;
                }

                char[] charArray = currentString.ToCharArray();

                for (int i = 1; i < length; i += 2)
                {
                    charArray[i] = (char)(((charArray[i] - '0' + a) % 10) + '0');
                }

                String newString = new string(charArray);
                String rotateString = currentString.Substring(length - b) + currentString.Substring(0, length - b);

                if (hashSetVisited.Add(newString))
                {
                    queue.Enqueue(newString);
                }
                if (hashSetVisited.Add(rotateString))
                {
                    queue.Enqueue(rotateString);
                }
            }

            return smallestString;
        }
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] countPassengers = new int[1001];

            trips = trips.OrderBy(x => x[1]).ToArray();

            for (int i = 0; i < trips.Length; i++)
            {
                int currPassengers = trips[i][0];
                for (int j = trips[i][1]; j < trips[i][2]; j++)
                {
                    countPassengers[j] += currPassengers;
                    if (countPassengers[j] > capacity)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public class MedianFinderTask295
        {
            private PriorityQueue<int, int> _smallPriorityQueue;
            private PriorityQueue<int, int> _bigPriorityQueue;
            public MedianFinderTask295()
            {
                _bigPriorityQueue = new PriorityQueue<int, int>();
                _smallPriorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
            }

            public void AddNum(int num)
            {
                if (_bigPriorityQueue.Count != 0 && num > _bigPriorityQueue.Peek())
                {
                    _bigPriorityQueue.Enqueue(num, num);
                }
                else
                {
                    _smallPriorityQueue.Enqueue(num, num);
                }

                if (_smallPriorityQueue.Count > _bigPriorityQueue.Count + 1)
                {
                    int tempValue = _smallPriorityQueue.Dequeue();
                    _bigPriorityQueue.Enqueue(tempValue, tempValue);
                }
                else if (_bigPriorityQueue.Count > _smallPriorityQueue.Count + 1)
                {
                    int tempValue = _bigPriorityQueue.Dequeue();
                    _smallPriorityQueue.Enqueue(tempValue, tempValue);
                }

            }

            public double FindMedian()
            {
                if (_bigPriorityQueue.Count > _smallPriorityQueue.Count)
                {
                    return _bigPriorityQueue.Peek();
                }
                else if (_smallPriorityQueue.Count > _bigPriorityQueue.Count)
                {
                    return _smallPriorityQueue.Peek();
                }

                return ((_smallPriorityQueue.Peek() + _bigPriorityQueue.Peek()) / 2.0);
            }
        }
        public int[] RecoverOrder(int[] order, int[] friends)
        {
            int[] resultArray = new int[friends.Length];
            int indexResultArray = 0;
            for (int i = 0; i < order.Length; i++)
            {
                int temp = order[i];
                for (int j = 0; j < friends.Length; j++)
                {
                    if (temp == friends[j])
                    {
                        resultArray[indexResultArray++] = friends[j];
                        break;
                    }
                }
            }

            return resultArray;
        }
        public int AlternatingSum(int[] nums)
        {
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum -= nums[i];
                }
                else
                {
                    sum += nums[i];
                }
            }

            return sum;
        }
        public bool HasSameDigits(string s)
        {
            string newString = string.Empty;
            while (s.Length > 2)
            {
                newString = string.Empty;

                for (int j = 1; j < s.Length; j++)
                {
                    newString += (char)((((s[j] - '0') + (s[j - 1] - '0')) % 10) + '0');
                }
                s = newString;
            }

            if (s[0] == s[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int[] XorQueries(int[] arr, int[][] queries)
        {
            int[] result = new int[queries.Length];
            int lengthArr = arr.Length;
            int[] prefixArrSum = new int[lengthArr];
            prefixArrSum[0] = arr[0];

            for (int i = 1; i < lengthArr; i++)
            {
                prefixArrSum[i] = arr[i] ^ prefixArrSum[i - 1];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int sumXOR = 0;
                int l = queries[i][0];
                int r = queries[i][1];

                if (l == 0)
                {
                    sumXOR = prefixArrSum[r];
                }
                else
                {
                    sumXOR = prefixArrSum[l - 1] ^ prefixArrSum[r];
                }

                result[i] = sumXOR;
            }

            return result;


            ////OR - very slow 

            //int[] result = new int[queries.Length];

            //for (int i = 0; i < queries.Length; i++)
            //{
            //    int sumXOR = 0;
            //    for (int j = queries[i][0]; j <= queries[i][1]; j++) 
            //    {
            //        sumXOR ^= arr[j];
            //    }

            //    result[i] = sumXOR;
            //}

            //return result;
        }
        public bool IsBalanced(string num)
        {
            ////0ms, Beats: 100.00%

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sumOdd += (int)num[i] - '0';
                }
                else
                {
                    sumEven += (int)num[i] - '0';
                }
            }

            return sumEven == sumOdd ? true : false;
        }
        public IList<int> PartitionLabels(string s)
        {
            int[] lastCharTable = new int[26];
            int lengthS = s.Length;
            IList<int> result = new List<int>();
            int startIndex = 0;
            int currMax = int.MinValue + 1;

            for (int i = 0; i < lengthS; i++)
            {
                lastCharTable[s[i] - 'a'] = i;
            }

            while (startIndex <= lengthS - 1)
            {
                int copyStartIndex = startIndex;
                while (startIndex != currMax)
                {
                    if (currMax < lastCharTable[s[startIndex] - 'a'])
                    {
                        currMax = lastCharTable[s[startIndex] - 'a'];
                        if (currMax == startIndex)
                        {
                            break;
                        }
                    }
                    startIndex++;
                }
                result.Add((startIndex) - copyStartIndex + 1);
                startIndex++;
            }

            return result;
        }
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> result = new List<string>();

            Dictionary<string, int> dictionaryStringCount = new Dictionary<string, int>();

            for (int i = 0; i < cpdomains.Length; i++)
            {
                string[] stringsSplit = cpdomains[i].Split(' ');
                int countValue = int.Parse(stringsSplit[0]);
                int length = stringsSplit[1].Length;
                int startIndex = 0;
                for (int j = 0; j < length; j++)
                {
                    if (stringsSplit[1][j] == '.')
                    {
                        if (dictionaryStringCount.ContainsKey(stringsSplit[1][startIndex..(length)]))
                        {
                            dictionaryStringCount[stringsSplit[1][startIndex..(length)]] += countValue;
                        }
                        else
                        {
                            dictionaryStringCount.Add(stringsSplit[1][startIndex..(length)], countValue);
                        }
                        startIndex = j + 1;
                    }
                }
                if (dictionaryStringCount.ContainsKey(stringsSplit[1][startIndex..(length)]))
                {
                    dictionaryStringCount[stringsSplit[1][startIndex..(length)]] += countValue;
                }
                else
                {
                    dictionaryStringCount.Add(stringsSplit[1][startIndex..(length)], countValue);
                }
            }

            foreach (var item in dictionaryStringCount)
            {
                result.Add(item.Value + " " + item.Key);
            }

            return result;
        }
        public int CountBattleships(char[][] board)
        {
            int lengthY = board.Length;
            int lengthX = board[0].Length;
            int countX = 0;
            int countY = 0;
            bool statusX = false;
            for (int y = 0; y < lengthY; y++)
            {
                statusX = false;
                for (int x = 0; x < lengthX; x++)
                {
                    if (board[y][x] == 'X')
                    {
                        statusX = true;
                        int tempY = y + 1;
                        while (tempY < lengthY)
                        {
                            if (board[tempY][x] == 'X')
                            {
                                board[tempY][x] = '.';
                                tempY++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (tempY != y + 1)
                        {
                            statusX = false;
                            x++;
                            countY++;
                        }
                    }
                    else
                    {
                        if (statusX)
                        {
                            countX++;
                            statusX = false;
                        }
                    }
                }
                if (statusX)
                {
                    countX++;
                    statusX = false;
                }
            }
            if (statusX)
            {
                countX++;
                statusX = false;
            }

            return countY + countX;
        }
        public int NextBeautifulNumber(int n)
        {
            bool status = false;
            bool breakLoop = false;
            n++;

            string stringN = string.Empty;
            while (!status)
            {
                stringN = n.ToString();
                int[] countNumber = new int[10];
                breakLoop = false;
                for (int i = 0; i < stringN.Length; i++)
                {
                    countNumber[stringN[i] - '0']++;
                }
                for (int i = 0; i < countNumber.Length; i++)
                {
                    if (countNumber[i] != i && countNumber[i] > 0)
                    {
                        breakLoop = true;
                        break;
                    }
                }
                if (breakLoop)
                {
                    n++;
                }
                else
                {
                    status = true;
                }
            }

            return int.Parse(stringN);
        }
        public IList<int> TargetIndices(int[] nums, int target)
        {
            ////0ms, Beats: 100.00%

            int countTarget = 0;
            int countLessValue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target)
                {
                    countLessValue++;
                }
                else if (nums[i] == target)
                {
                    countTarget++;
                }
            }

            int[] result = new int[countTarget];

            for (int i = countLessValue; i < countLessValue + countTarget; i++)
            {
                result[i - countLessValue] = i;
            }
            return result.ToList();
        }
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            ////Solution #1. 4ms, Beats: 80.49% 
            ////Faster execution and less memory used.

            HashSet<int> result = new HashSet<int>();

            foreach (var item in nums1)
            {
                if (nums2.Contains(item) || nums3.Contains(item))
                {
                    result.Add(item);
                }
            }
            foreach (var item in nums2)
            {
                if (nums1.Contains(item) || nums3.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToList();

            ////Solution #2. 8ms, Beats: 56.10%
            #region solution 2 context
            //HashSet<int> result = new HashSet<int>();

            //HashSet<int> distinctListNums1 = new HashSet<int>();
            //HashSet<int> distinctListNums2 = new HashSet<int>();
            //HashSet<int> distinctListNums3 = new HashSet<int>();

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    distinctListNums1.Add(nums1[i]);
            //}

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    distinctListNums2.Add(nums2[i]);
            //}

            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    distinctListNums3.Add(nums3[i]);
            //}

            //foreach (int item in distinctListNums2) 
            //{
            //    if (!distinctListNums1.Add(item))
            //    {
            //        result.Add(item);
            //    }
            //}

            //foreach (int item in distinctListNums3)
            //{
            //    if (!distinctListNums1.Add(item))
            //    {
            //        result.Add(item);
            //    }
            //}

            //return result.ToList();
            #endregion
        }
        public IList<int> FindDuplicates(int[] nums)
        {
            ////Solution 1
            ////3ms, Beasts: 75.77%, Memory: 69.25MB, Beats: 71.13%

            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] = -nums[Math.Abs(nums[i]) - 1];
                }
            }

            return result;

            ////Solution 2
            ////27ms, Beats: 24.74%, Memory: 72.00MB, Beats: 6.70%

            //HashSet<int> checkNumbers = new HashSet<int>();
            //IList<int> resultList = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!checkNumbers.Add(nums[i]))
            //    {
            //        resultList.Add(nums[i]);
            //    }
            //}

            //return resultList.ToList();
        }
        public int TotalMoney(int n)
        {
            ////0ms, Beats: 100.00%
            decimal sum = 0;

            int countFullWeek = n / 7;
            int countRemainingDays = n - (countFullWeek * 7);

            if (countFullWeek > 0)
            {
                sum = ((decimal)(28 * 2 + (countFullWeek - 1) * 7) / 2) * countFullWeek;
                countFullWeek++;
            }
            else
            {
                countFullWeek = 1;
            }
            if (countRemainingDays > 0)
            {
                sum += ((countFullWeek * 2) + (decimal)(countRemainingDays - 1) * 1) / 2 * countRemainingDays;
            }
            return (int)sum;
        }
        public int MaxSum(int[][] grid)
        {
            ////1ms, Beats: 100.00%
            int lengthX = grid[0].Length;
            int lengthY = grid.Length;
            int maxSum = int.MinValue;

            for (int y = 0; y < lengthY - 2; y++)
            {
                int currSum = 0;
                for (int x = 0; x < lengthX - 2; x++)
                {
                    currSum = grid[y][x] + grid[y][x + 1] + grid[y][x + 2] + grid[y + 1][x + 1] + grid[y + 2][x] + grid[y + 2][x + 1] + grid[y + 2][x + 2];
                    maxSum = currSum > maxSum ? currSum : maxSum;
                }
            }

            return maxSum;
        }
        public int[] FindEvenNumbers(int[] digits)
        {
            HashSet<int> firstValue = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int indexFirst = 0; indexFirst < digits.Length; indexFirst++)
            {
                int tempFirstValue = digits[indexFirst];
                if (tempFirstValue != 0 && firstValue.Add(tempFirstValue))
                {
                    for (int indexSecond = 0; indexSecond < digits.Length; indexSecond++)
                    {
                        int tempSecondValue = digits[indexSecond];
                        if (indexFirst != indexSecond)
                        {
                            for (int indexLast = 0; indexLast < digits.Length; indexLast++)
                            {
                                if (indexLast != indexFirst && indexLast != indexSecond && digits[indexLast] % 2 == 0)
                                {
                                    result.Add(tempFirstValue * 100 + tempSecondValue * 10 + digits[indexLast]);
                                }
                            }
                        }
                    }
                }
            }
            int[] resultArray = result.ToArray();
            Array.Sort(resultArray);
            return resultArray;
        }
        public int TotalNumbers(int[] digits)
        {
            HashSet<int> firstValue = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int indexFirst = 0; indexFirst < digits.Length; indexFirst++)
            {
                int tempFirstValue = digits[indexFirst];
                if (tempFirstValue != 0 && firstValue.Add(tempFirstValue))
                {
                    for (int indexSecond = 0; indexSecond < digits.Length; indexSecond++)
                    {
                        int tempSecondValue = digits[indexSecond];
                        if (indexFirst != indexSecond)
                        {
                            for (int indexLast = 0; indexLast < digits.Length; indexLast++)
                            {
                                if (indexLast != indexFirst && indexLast != indexSecond && digits[indexLast] % 2 == 0)
                                {
                                    result.Add(tempFirstValue * 100 + tempSecondValue * 10 + digits[indexLast]);
                                }
                            }
                        }
                    }
                }
            }
            return result.Count;
        }
        public int MinLength(string s)
        {
            ////Solution #1
            ////3ms, Beats: 85.71%

            while (s.Contains("AB") || s.Contains("CD"))
            {
                s = s.Replace("AB", "");
                s = s.Replace("CD", "");
            }

            return s.Length;

            ////Solution #2
            ////10ms, Beats: 14.29%

            //StringBuilder sb = new StringBuilder(s);
            //bool status = false;

            //while (!status)
            //{
            //    status = true;

            //    for (int i = 0; i < sb.Length-1; i++) 
            //    {
            //        if (sb[i] == 'A' && sb[i+1] == 'B' || sb[i] == 'C' && sb[i+1] == 'D')
            //        {
            //            status = false;
            //            sb.Remove(i, 2);
            //            break;
            //        }
            //    }
            //}

            //return sb.Length;
        }
        public class BankTask2043
        {
            ////3ms, Beats: 100.00%
            
            private long[] _balance;
            private int _countAccount;
            public BankTask2043(long[] balance)
            {
                _balance = balance;
                _countAccount = balance.Length;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                if (account1 <= _countAccount && account2 <= _countAccount && _balance[account1 - 1] >= money)
                {
                    _balance[account1 - 1] -= money;
                    _balance[account2 - 1] += money;
                    return true;
                }
                return false;
            }

            public bool Deposit(int account, long money)
            {
                if (account <= _countAccount)
                {
                    _balance[account - 1] += money;
                    return true;
                }
                return false;
            }

            public bool Withdraw(int account, long money)
            {
                if (account <= _countAccount && _balance[account - 1] >= money)
                {
                    _balance[account - 1] -= money;
                    return true;
                }
                return false;
            }
        }
        public int SumDivisibleByK(int[] nums, int k)
        {
            ////Solution #1
            ////0ms, 100.00%

            Span<int> frequencyNums = stackalloc int[101];
            int sum = 0;

            foreach (var item in nums)
            {
                frequencyNums[item]++;
            }

            for (int i = 1; i < 101; i++)
            {
                if (frequencyNums[i] % k == 0)
                {
                    sum += i * frequencyNums[i];
                }
            }

            return sum;


            ////Solution #2
            ////1ms, Beats: 94.71%

            //int[] frequencyNums = new int[101];
            //int sum = 0;

            //foreach (var item in nums)
            //{
            //    frequencyNums[item]++;
            //}

            //for (int i = 1; i < 101; i++)
            //{
            //    if (frequencyNums[i] % k == 0)
            //    {
            //        sum += i * frequencyNums[i];
            //    }
            //}

            //return sum;


            ////Solution #3
            ////1ms, Beats: 94.71%

            //Dictionary<int, int> dictionaryNumsAndFrequency = new Dictionary<int, int>();
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dictionaryNumsAndFrequency.TryAdd(nums[i], 1))
            //    {
            //        dictionaryNumsAndFrequency[nums[i]]++;
            //    }
            //}

            //foreach (var item in dictionaryNumsAndFrequency)
            //{
            //    if (item.Value > 0 && item.Value % k == 0)
            //    {
            //        sum += item.Key * item.Value;
            //    }
            //}

            //return sum;
        }
        public int ReturnToBoundaryCount(int[] nums)
        {
            ////60ms, Beats: 96.00%
            int result = 0;
            int currPosition = 0;

            foreach (var item in nums)
            {
                currPosition += item;
                if (currPosition == 0)
                {
                    result++;
                }
            }

            return result;
        }
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            ////0ms, Beats: 100.00%
            int result = -1;
            int numberword = 1;
            bool check = true;
            int indexCheck = 0;
            int lastIndexSearchWord = searchWord.Length - 1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (check)
                {
                    if (sentence[i] == searchWord[indexCheck])
                    {
                        if (indexCheck == lastIndexSearchWord)
                        {
                            return numberword;
                        }
                        indexCheck++;
                        continue;
                    }
                    else if (sentence[i] == ' ')
                    {
                        numberword++;
                        check = true;
                        indexCheck = 0;
                    }
                    else
                    {
                        check = false;
                        indexCheck = 0;
                    }

                }
                else if (sentence[i] == ' ')
                {
                    indexCheck = 0;
                    check = true;
                    numberword++;
                }
            }

            return result;
        }
        public int FindNumbers(int[] nums)
        {
            ////0ms, Beats: 100.00%

            int countEvenLength = 0;

            foreach (var item in nums)
            {
                if (item.ToString().Length % 2 == 0)
                {
                    countEvenLength++;
                }
            }

            return countEvenLength;
        }
        public int MaxContainers(int n, int w, int maxWeight)
        {
            ////0ms, Beats: 100.00%

            return Math.Min(n * n, maxWeight / w);
        }
        public int FindNonMinOrMax(int[] nums)
        {
            ////1ms, Beats: 100.00%

            int length = nums.Length;

            if (length > 2)
            {
                int max = Math.Max(nums[0], nums[1]);
                int min = Math.Min(nums[0], nums[1]);
                int nextValue = nums[2];
                if (nextValue > max)
                {
                    return max;
                }
                else if (nextValue < min)
                {
                    return min;
                }
                return nextValue;
            }
            else
            {
                return -1;
            }
        }
        public bool CheckDivisibility(int n)
        {
            ////0ms, Beats: 100.00%

            int copyN = n;
            int digitSum = 0;
            int digitProduct = 1;

            while (copyN != 0)
            {
                int temp = copyN % 10;
                digitSum += temp;
                digitProduct *= temp;
                copyN /= 10;
            }

            if (n % (digitProduct + digitSum) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CanBeEqual(int[] target, int[] arr)
        {
            ////Solution #1
            ////0ms, Beats: 100.00%

            int[] countValueTarget = new int[1001];

            for (int i = 0; i < target.Length; i++)
            {
                countValueTarget[target[i]]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (countValueTarget[arr[i]] == 0)
                {
                    return false;
                }
                countValueTarget[arr[i]]--;
            }
            return true;

            ////Solution #2
            ////10ms, Beats: 35.48%

            //Array.Sort(target);
            //Array.Sort(arr);

            //for(int i = 0; i < target.Length; i++)
            //{
            //    if (target[i] != arr[i])
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }
        public int SumOfSquares(int[] nums)
        {
            ////0ms, Beats: 100.00%

            int sum = 0;
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (length % (i + 1) == 0)
                {
                    sum += nums[i] * nums[i];
                }
            }

            return sum;
        }
        public int AverageValue(int[] nums)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0 && nums[i] % 3 == 0)
                {
                    count++;
                    sum += nums[i];
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        }
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            ////3ms, Beats: 91.43%

            Array.Sort(arr);

            int diff = arr[1] - arr[0];

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != diff)
                {
                    return false;
                }
            }
            return true;
        }
        public char RepeatedCharacter(string s)
        {
            ////0ms, Beats: 100.00%

            HashSet<char> distinctChars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!distinctChars.Add(s[i]))
                {
                    return s[i];
                }
            }
            return ' ';
        }
        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            ////0ms, Beats: 100.00%

            int[] result = new int[2] { -1, -1 };
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                int tempValue = nums[i];
                for (int j = i + indexDifference; j < length; j++)
                {
                    if (Math.Abs(tempValue - nums[j]) >= valueDifference)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return result;
        }
        public int PercentageLetter(string s, char letter)
        {
            ////0ms, Beats: 100.00%

            int count = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                if (s[i] == letter)
                {
                    count++;
                }
            }

            return count * 100 / length;
        }
        public bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            ////51ms, Beats: 91.18%

            if (Math.Abs(coordinate1[0] - coordinate2[0]) % 2 == 0)
            {
                if (Math.Abs(coordinate1[1] - coordinate2[1]) % 2 == 0)
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
                if (Math.Abs(coordinate1[1] - coordinate2[1]) % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public int CountValidSelections(int[] nums)
        {
            ////62ms, Beats: 100.00% 

            int result = 0;
            int length = nums.Length;
            List<int> listIndexZero = new List<int>();
            int[] sumInts = new int[nums.Length];
            int currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                sumInts[i] = currSum;
                if (nums[i] == 0)
                {
                    listIndexZero.Add(i);
                }
            }

            foreach (var item in listIndexZero)
            {
                if (item > 0 & item < length - 1)
                {
                    //Console.WriteLine(Math.Abs(sumInts[item - 1] - Math.Abs(sumInts[item -1] - sumInts[length - 1])) == 1);
                    int temp = Math.Abs(sumInts[item - 1] - Math.Abs(sumInts[item - 1] - sumInts[length - 1]));
                    if (temp == 0)
                    {
                        result += 2;
                    }
                    else if (temp == 1)
                    {
                        result++;
                    }
                }
                else if (sumInts[length - 1] == 0)
                {
                    return sumInts.Length * 2;
                }
                else if (item == 0 || item == length - 1)
                {
                    if (item == 0)
                    {
                        int temp = Math.Abs(sumInts[item] - Math.Abs(sumInts[item] - sumInts[length - 1]));
                        if (temp == 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        int temp = Math.Abs(sumInts[length - 2] - Math.Abs(sumInts[length - 2] - sumInts[length - 1]));
                        if (temp == 1)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
        public string GenerateTheString(int n)
        {
            ////1ms, Beats: 76.79%
            if (n % 2 == 0)
            {
                return new string('a', n - 1) + 'b';
            }
            else
            {
                return new string('a', n);
            }
        }
        public string RemoveTrailingZeros(string num)
        {
            int indexFirstZero = -1;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                {
                    indexFirstZero = i;
                }
                else
                {
                    break;
                }
            }

            if (indexFirstZero == -1)
            {
                return num;
            }
            else
            {
                return num[0..indexFirstZero];
            }
        }
        public int MaxPower(string s)
        {
            int maxCount = 1;
            char lastChar = s[0];
            int currCount = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                    lastChar = s[i];
                }
                maxCount = currCount > maxCount ? currCount : maxCount;
            }

            return maxCount;
        }
        public int FindMaxK(int[] nums)
        {
            int[] intsTablePlus = new int[1001];
            int[] intsTableMinus = new int[1001];

            foreach (int i in nums)
            {
                if (i > 0)
                {
                    intsTablePlus[i]++;
                }
                else
                {
                    intsTableMinus[i * -1]++;
                }
            }

            for (int i = 1000; i > 0; i--)
            {
                if (intsTableMinus[i] > 0 & intsTablePlus[i] > 0)
                {
                    return i;
                }
            }

            return -1;
        }
        public int SmallestEqual(int[] nums)
        {
            ////0ms, Beats: 100.00%

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public int SmallestNumber(int n)
        {
            ////0ms, Beats: 100.00%

            //string nStringBits = Convert.ToString(n, 2);
            int result = 0;
            string nBits = Convert.ToString(n, 2);

            for (int i = 0; i < nBits.Length; i++)
            {
                result += (int)Math.Pow(2, i);
            }

            return result;
        }
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            ////0ms, Beats: 100.00%

            return (arrivalTime + delayedTime) % 24;
        }
        public int CountTestedDevices(int[] batteryPercentages)
        {
            ////0ms, Beats: 100.00%

            int countTestedDevices = 0;

            for (int i = 0; i < batteryPercentages.Length; i++)
            {
                if (batteryPercentages[i] - countTestedDevices > 0)
                {
                    countTestedDevices++;
                }
            }
            return countTestedDevices;
        }
        public int FinalPositionOfSnake(int n, IList<string> commands)
        {
            ////0ms, Beats: 100.00%

            int x = 0;
            int y = 0;

            foreach (var item in commands)
            {
                switch (item)
                {
                    case "UP":
                        y--;
                        break;
                    case "DOWN":
                        y++;
                        break;
                    case "LEFT":
                        x--;
                        break;
                    case "RIGHT":
                        x++;
                        break;
                }
            }

            return (y * n) + x;
        }
        public int DuplicateNumbersXOR(int[] nums)
        {
            ////0ms, Beats: 100.00%

            int[] countNums = new int[51];
            int resultXOR = 0;

            foreach (int num in nums)
            {
                countNums[num]++;
            }

            for (int i = 1; i < 51; i++)
            {
                if (countNums[i] == 2)
                {
                    resultXOR ^= i;
                }
            }

            return resultXOR;
        }
        public int CommonFactors(int a, int b)
        {
            ////0ms, Beats: 100.00%

            int count = 0;

            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0 & b % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
        public bool IsSubstringPresent(string s)
        {
            string sReverse = new string(s.Reverse().ToArray());

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (sReverse.Contains(s[i..(i + 2)]))
                {
                    return true;
                }
            }

            return false;
        }
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            int length = mat.Length;
            int lengthRow = mat[0].Length;

            int firstIndex = 0;
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                int currCount = 0;
                for (int j = 0; j < lengthRow; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        currCount++;
                    }
                }
                if (currCount > count)
                {
                    count = currCount;
                    firstIndex = i;
                    if (currCount == lengthRow)
                    {
                        break;
                    }
                }
            }

            return new int[] { firstIndex, count };
        }
        public int CountKeyChanges(string s)
        {
            ////0ms, Beats: 100.00%
            int count = 0;
            int first = s[0];
            int second = -1;

            if (first < 97)
            {
                first += 32;
            }

            for (int i = 1; i < s.Length; i++)
            {
                second = s[i];
                if (second < 97)
                {
                    second += 32;
                }

                if (second != first)
                {
                    count++;
                }

                first = second;
            }

            return count;
        }
        public int MinNumberOperations(int[] target)
        {
            int count = target[0];
            for (int i = 1; i < target.Length; i++)
            {
                count += Math.Max(target[i] - target[i - 1], 0);
            }

            return count;
        }
        public int VowelStrings(string[] words, int left, int right)
        {
            int count = 0;

            for (int j = left; j <= right; j++)
            {
                int length = words[j].Length - 1;
                if (words[j][0] == 'a' | words[j][0] == 'e' | words[j][0] == 'i' | words[j][0] == 'o' | words[j][0] == 'u')
                {
                    if (words[j][length] == 'a' | words[j][length] == 'e' | words[j][length] == 'i' | words[j][length] == 'o' | words[j][length] == 'u')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public int FindSpecialInteger(int[] arr)
        {
            int lenght = arr.Length;
            int size = lenght / 4;

            for (int i = 0; i < lenght - size; i++)
            {
                if (arr[i] == arr[i + size])
                {
                    return arr[i];
                }
            }

            return -1;
        }
        public string GetEncryptedString(string s, int k)
        {
            int length = s.Length;
            k = k % length;

            StringBuilder sb = new StringBuilder();
            int index = 0;
            int currIndexS = k;

            while (index < length)
            {
                if (currIndexS == length)
                {
                    currIndexS = 0;
                }
                sb.Append(s[currIndexS++]);
                index++;
            }

            return new string(sb.ToString());
        }
        public IList<string> BuildArray(int[] target, int n)
        {
            ////Solution #1
            ///0ms

            List<string> resultList = new List<string>();
            int index = 0;
            for (int i = 1; i <= n && index < target.Length; i++)
            {
                if (i == target[index])
                {
                    resultList.Add("Push");
                    index++;
                }
                else
                {
                    resultList.Add("Push");
                    resultList.Add("Pop");
                }
            }

            return resultList;

            ////Solution #2 
            ///1ms

            //Stack<int> intsStack = new Stack<int>();
            //intsStack.Push(1);
            //int length = target.Length;
            //IList<string> resultList = new List<string>();
            ////Console.WriteLine(intsStack.Peek());
            //int indexTarget = 0;
            //bool newValue = false;
            //int currValuePop = 0;
            //int currFirstValue = 1;

            //if (target[0] != currFirstValue)
            //{
            //    resultList.Add("Push");
            //    while (target[0] != currFirstValue)
            //    {
            //        resultList.Add("Pop");
            //        currFirstValue++;
            //        resultList.Add("Push");
            //    }
            //    if (intsStack.Peek() != currFirstValue)
            //    {
            //        intsStack.Pop();
            //        intsStack.Push(currFirstValue);
            //    }
            //    indexTarget++;
            //    newValue = true;
            //} 
            //else if (length == 1)
            //{
            //    resultList.Add("Push");
            //}
            //while (intsStack.Peek() != target[length - 1])
            //{
            //    if (newValue)
            //    {
            //        resultList.Add("Push");
            //        if (currValuePop > intsStack.Peek() + 1)
            //        {
            //            intsStack.Push(currValuePop);
            //        }
            //        else
            //        {
            //            intsStack.Push(intsStack.Peek() + 1);
            //        }
            //        if (target[indexTarget] == intsStack.Peek())
            //        {
            //            indexTarget++;
            //        }
            //        else
            //        {
            //            newValue = false;
            //        }
            //    }
            //    else
            //    {
            //        if (target[indexTarget] == intsStack.Peek())
            //        {
            //            indexTarget++;
            //            resultList.Add("Push");
            //            newValue = true;
            //        }
            //        else
            //        {
            //            currValuePop = intsStack.Pop() + 1;
            //            resultList.Add("Pop");
            //            newValue = true;
            //        }
            //    }
            //}
            //return resultList;
        }
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int lengthMatrix = matrix.Length;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                List<int> listWithMinusOne = new List<int>();
                int currMax = int.MinValue;
                for (int j = 0; j < lengthMatrix; j++)
                {
                    if (matrix[j][i] == -1)
                    {
                        listWithMinusOne.Add(j);
                    }
                    currMax = Math.Max(matrix[j][i], currMax);
                }
                if (listWithMinusOne.Count > 0)
                {
                    foreach (var item in listWithMinusOne)
                    {
                        matrix[item][i] = currMax;
                    }
                }
            }

            return matrix;
        }
        public int PeakIndexInMountainArray(int[] arr)
        {
            ////Solution 1#

            int indexL = 0;
            int indexR = arr.Length - 1;
            while (indexL < indexR)
            {
                int mid = (indexL + indexR) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    indexL = mid + 1;
                }
                else
                {
                    indexR = mid;
                }
            }

            return indexL;

            ////Solution 2#

            //int lastValue = arr[0];
            //bool grow = false;
            //int length = arr.Length;
            //int maxPeakValue = int.MinValue;
            //int indexMaxPeak = -1;

            //for (int i = 1; i < length - 1; i++) 
            //{
            //    if (arr[i] > lastValue)
            //    {
            //        grow = true;
            //    }
            //    else if (arr[i] < lastValue)
            //    {
            //        if (grow)
            //        {
            //            if (arr[i-1] > maxPeakValue)
            //            {
            //                maxPeakValue = arr[i-1];
            //                indexMaxPeak = i-1;
            //            }
            //            grow = false;
            //        }
            //    }
            //    else
            //    {
            //        grow = false;
            //    }
            //    lastValue = arr[i];
            //}

            //if (arr[length-1] < lastValue & grow)
            //{
            //    if (arr[length - 2] > maxPeakValue)
            //    {
            //        maxPeakValue = arr[length - 2];
            //        indexMaxPeak = length - 2;
            //    }
            //}

            //return indexMaxPeak;
        }
        public int AlternateDigitSum(int n)
        {
            int sumOne = 0;
            int sumTwo = 0;
            string nString = n.ToString();
            bool sumOneStatus = true;

            while (n != 0)
            {
                int temp = n % 10;
                n /= 10;

                if (sumOneStatus)
                {
                    sumOne += temp;
                    sumOneStatus = false;
                }
                else
                {
                    sumTwo += temp;
                    sumOneStatus = true;
                }
            }

            if (nString.Length % 2 == 0)
            {
                return sumTwo - sumOne;
            }
            else
            {
                return sumOne - sumTwo;
            }
        }
        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            ////Solution #1

            bool[] statusNums = new bool[100001];

            foreach (var item in nums)
            {
                statusNums[item] = true;
            }

            while (head != null & statusNums[head.val] == true)
            {
                head = head.next;
            }

            if (head == null)
            {
                return null;
            }

            ListNode dummy = head;

            while (dummy.next != null)
            {
                if (statusNums[dummy.next.val] == true)
                {
                    dummy.next = dummy.next.next;
                }
                else
                {
                    dummy = dummy.next;
                }
            }

            return head;

            ////Solution #2

            //HashSet<int> numsToDelete = new HashSet<int>();

            //foreach (var item in nums)
            //{
            //    numsToDelete.Add(item);
            //}

            //while (head != null & numsToDelete.Contains(head.val))
            //{
            //    head = head.next;
            //}

            //if (head == null)
            //{
            //    return null;
            //}

            //ListNode dummy = head;

            //while (dummy.next != null)
            //{
            //    if (numsToDelete.Contains(dummy.next.val))
            //    {
            //        dummy.next = dummy.next.next;
            //    }
            //    else
            //    {
            //        dummy = dummy.next;
            //    }
            //}

            //return head;
        }
        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            int[][] testGrid = new int[m][];
            int lengthWalls = walls.Length;
            int lengthGurads = guards.Length;
            int result = 0;

            for (int i = 0; i < m; i++)
            {
                testGrid[i] = new int[n];
            }

            ////number 2 is wall/guard
            for (int i = 0; i < lengthWalls; i++)
            {
                testGrid[walls[i][0]][walls[i][1]] = 2;
            }

            ////number 2 is wall/guard
            for (int i = 0; i < lengthGurads; i++)
            {
                testGrid[guards[i][0]][guards[i][1]] = 2;
            }

            ////number 1 is guarded
            for (int i = 0; i < lengthGurads; i++)
            {
                int y = guards[i][0];
                int x = guards[i][1];

                if (y > 0)
                {
                    for (int j = y - 1; j >= 0; j--)
                    {
                        if (testGrid[j][x] == 0)
                        {
                            testGrid[j][x] = 1;
                        }
                        else if (testGrid[j][x] == 2)
                        {
                            break;
                        }
                    }
                }

                if (y < m - 1)
                {
                    for (int j = y + 1; j < m; j++)
                    {
                        if (testGrid[j][x] == 0)
                        {
                            testGrid[j][x] = 1;
                        }
                        else if (testGrid[j][x] == 2)
                        {
                            break;
                        }
                    }
                }

                if (x > 0)
                {
                    for (int j = x - 1; j >= 0; j--)
                    {
                        if (testGrid[y][j] == 0)
                        {
                            testGrid[y][j] = 1;
                        }
                        else if (testGrid[y][j] == 2)
                        {
                            break;
                        }
                    }
                }

                if (x < n - 1)
                {
                    for (int j = x + 1; j < n; j++)
                    {
                        if (testGrid[y][j] == 0)
                        {
                            testGrid[y][j] = 1;
                        }
                        else if (testGrid[y][j] == 2)
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (testGrid[i][j] == 0)
                    {
                        result++;
                    }
                }
            }


            return result;
        }
        public int MinCost(string colors, int[] neededTime)
        {
            int result = 0;
            int currSum = 0;
            char lastChar = '/';
            int currMax = 0;

            for (int i = 0; i < colors.Length; i++)
            {
                char tempChar = colors[i];
                if (lastChar != tempChar)
                {
                    if (currSum != currMax)
                    {
                        result += currSum - currMax;
                    }
                    currSum = neededTime[i];
                    currMax = neededTime[i];
                    lastChar = tempChar;
                }
                else
                {
                    currSum += neededTime[i];
                    if (neededTime[i] > currMax)
                    {
                        currMax = neededTime[i];
                    }
                }
            }
            if (currSum != currMax)
            {
                result += currSum - currMax;
            }
            return result;
        }
        public int[] FindXSum(int[] nums, int k, int x)
        {
            List<int> resultList = new List<int>();

            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            for (int i = 0; i < k; i++)
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]]++;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }
            }

            List<int[]> currList = new List<int[]>();
            foreach (var item in numsCount)
            {
                currList.Add(new int[] { item.Value, item.Key });
            }

            currList = currList.OrderByDescending(x => x[0]).ThenByDescending(x => x[1]).ToList();
            int currSum = 0;

            int copyX = x;
            if (x > currList.Count)
            {
                copyX = currList.Count;
            }
            for (int i = 0; i < copyX; i++)
            {
                currSum += currList[i][1] * currList[i][0];
            }
            resultList.Add(currSum);

            for (int i = k; i < nums.Length; i++)
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]]++;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }

                if (numsCount[nums[i - k]] == 1)
                {
                    numsCount.Remove(nums[i - k]);
                }
                else
                {
                    numsCount[nums[i - k]]--;
                }

                currList = new List<int[]>();
                foreach (var item in numsCount)
                {
                    currList.Add(new int[] { item.Value, item.Key });
                }

                currList = currList.OrderByDescending(x => x[0]).ThenByDescending(x => x[1]).ToList();
                currSum = 0;

                copyX = x;
                if (x > currList.Count)
                {
                    copyX = currList.Count;
                }
                for (int j = 0; j < copyX; j++)
                {
                    currSum += currList[j][1] * currList[j][0];
                }
                resultList.Add(currSum);

            }
            return resultList.ToArray();
        }
        public int FindGCD(int[] nums)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                min = nums[i] < min ? nums[i] : min;
                max = nums[i] > max ? nums[i] : max;
            }

            if (min == max)
            {
                return min;
            }

            for (int i = min; i >= 1; i--)
            {
                if (min % i == 0 & max % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
        public int[] NumberOfPairs(int[] nums)
        {
            int[] countNums = new int[101];
            int pairs = 0;
            int noPairs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                countNums[nums[i]]++;
            }

            for (int i = 0; i < 101; i++)
            {
                if (countNums[i] > 0)
                {
                    if (countNums[i] % 2 != 0)
                    {
                        noPairs++;
                    }
                    pairs += countNums[i] / 2;
                }
            }

            return new int[] { pairs, noPairs };
        }
        public string ProcessStr(string s)
        {
            ////Solution #1
            ////4ms, Beats: 100.00%

            StringBuilder sb = new StringBuilder();

            foreach (char item in s)
            {
                if (item == '#')
                {
                    sb.Append(sb);
                }
                else if (item == '%')
                {
                    StringBuilder temp = new StringBuilder();

                    for (int i = sb.Length - 1; i >= 0; i--)
                    {
                        temp.Append(sb[i]);
                    }

                    sb = temp;
                }
                else if (item == '*')
                {
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();


            ////Solution #2
            ////7ms, Beats: 66.67%

            //List<char> listChar = new List<char>();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == '#')
            //    {
            //        listChar.AddRange(listChar);
            //    }
            //    else if (s[i] == '%')
            //    {
            //        listChar.Reverse();
            //    }
            //    else if (s[i] == '*')
            //    {
            //        if(listChar.Count > 0)
            //        {
            //            listChar.RemoveAt(listChar.Count-1);
            //        }
            //    }
            //    else
            //    {
            //        listChar.Add(s[i]);
            //    }
            //}

            //return new string(listChar.ToArray());
        }
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int firstValue = 0;
            int secondValue = 0;
            int targetValue = 0;

            int currLength = 0;
            for (int i = targetWord.Length - 1; i >= 0; i--)
            {
                targetValue += (int)Math.Pow(10, currLength) * (targetWord[i] - 'a');
                currLength++;
            }

            currLength = 0;
            for (int i = firstWord.Length - 1; i >= 0; i--)
            {
                firstValue += (int)Math.Pow(10, currLength) * (firstWord[i] - 'a');
                currLength++;
            }

            currLength = 0;
            for (int i = secondWord.Length - 1; i >= 0; i--)
            {
                secondValue += (int)Math.Pow(10, currLength) * (secondWord[i] - 'a');
                currLength++;
            }

            if (secondValue + firstValue == targetValue)
            {
                return true;
            }

            return false;
        }
        public int CountOperations(int num1, int num2)
        {
            int count = 0;

            while (num1 != 0 && num2 != 0)
            {
                if (num1 < num2)
                {
                    count++;
                    num2 = num2 - num1;
                }
                else if (num1 > num2)
                {
                    num1 = num1 - num2;
                    count++;
                }
                else
                {
                    count++;
                    break;
                }
            }

            return count;
        }
        public int MinOperations(int[] nums)
        {
            int countOperation = 0;
            List<int> listFromNums = new List<int>();

            foreach (int num in nums)
            {
                while (listFromNums.Count > 0 && num < listFromNums[listFromNums.Count - 1])
                {
                    listFromNums.RemoveAt(listFromNums.Count - 1);
                }

                if (num == 0)
                {
                    continue;
                }

                else if (listFromNums.Count == 0 || listFromNums[listFromNums.Count - 1] < num)
                {
                    countOperation++;
                    listFromNums.Add(num);
                }
            }
            return countOperation;
        }
        public IList<int> FindPeaks(int[] mountain)
        {
            IList<int> result = new List<int>();

            for (int i = 1; i < mountain.Length - 1; i++)
            {
                if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            List<int> resultList = new List<int>();
            int currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    currSum += nums[i];
                }
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int tempValue = queries[i][0];
                int tempIndex = queries[i][1];

                if (nums[tempIndex] % 2 == 0)
                {
                    currSum -= nums[tempIndex];
                }
                nums[tempIndex] += tempValue;
                if (nums[tempIndex] % 2 == 0)
                {
                    currSum += nums[tempIndex];
                }
                resultList.Add(currSum);
            }

            return resultList.ToArray();
        }
        public string DestCity(IList<IList<string>> paths)
        {
            ////Solution #1
            ////1ms, Beats: 94.85%

            HashSet<string> locationFirst = new HashSet<string>();

            foreach (var path in paths)
            {
                locationFirst.Add(path[0]);
            }

            foreach (var path in paths)
            {
                if (!locationFirst.Contains(path[1]))
                {
                    return path[1];
                }
            }

            return "";

            ////Solution #2
            ////8ms, Beats: 5.15%

            //string result = string.Empty;
            //int countList = paths.Count;

            //for (int i = 0; i < countList; i++)
            //{
            //    bool status = false;
            //    string temp = paths[i][1];

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (paths[j][0] == temp)
            //        {
            //            status = true;
            //            break;
            //        }
            //    }
            //    if (status == false)
            //    {
            //        for (int k = i + 1; k < countList; k++)
            //        {
            //            if (paths[k][0] == temp)
            //            {
            //                status = true;
            //                break;
            //            }
            //        } 
            //    }
            //    if (!status)
            //    {
            //        return temp;
            //    }
            //}

            //return result;
        }
        public string FinalString(string s)
        {
            ////Solution #1
            ////2ms, Beats: 100.00%

            List<char> listChars = new List<char>();

            foreach (char c in s)
            {
                if (c == 'i')
                {
                    listChars.Reverse();
                }
                else
                {
                    listChars.Add(c);
                }
            }

            return new string(listChars.ToArray());

            ////Solution #2
            ////7ms, Beats: 33.33%
            //StringBuilder sb = new StringBuilder();

            //foreach (char c in s)
            //{
            //    if (c == 'i')
            //    {
            //        StringBuilder temp = new StringBuilder();

            //        for (int i = sb.Length - 1; i >= 0; i--)
            //        {
            //            temp.Append(sb[i]);
            //        }

            //        sb = temp;
            //    }
            //    else
            //    {
            //        sb.Append(c);
            //    }
            //}


            //return sb.ToString();
        }
        public int MaxOperations(string s)
        {
            int result = 0;

            int countZero = 0;
            int lastChar = int.MaxValue;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0' && lastChar != s[i])
                {
                    countZero++;
                }
                else if (s[i] == '1')
                {
                    result += countZero;
                }

                lastChar = s[i];
            }

            return result;
        }
        public bool KLengthApart(int[] nums, int k)
        {
            int lastIndexOneValue = 0;
            int lengthNums = nums.Length;

            for (int i = 0; i < lengthNums; i++)
            {
                if (nums[i] == 1)
                {
                    lastIndexOneValue = i;
                    break;
                }
            }

            for (int i = lastIndexOneValue + 1; i < lengthNums; i++)
            {
                if (nums[i] == 1)
                {
                    if (lastIndexOneValue + k >= i)
                    {
                        return false;
                    }
                    lastIndexOneValue = i;
                }
            }

            return true;
        }
        public bool ReportSpam(string[] message, string[] bannedWords)
        {
            int count = 0;
            HashSet<string> bannedWordsHashSet = new HashSet<string>();

            foreach (string word in bannedWords)
            {
                bannedWordsHashSet.Add(word);
            }

            foreach (string item in message)
            {
                if (bannedWordsHashSet.Contains(item))
                {
                    count++;
                    if (count > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public int MinimumBoxes(int[] apple, int[] capacity)
        {
            int sumApple = 0;
            int minBoxes = 0;
            foreach (int item in apple)
            {
                sumApple += item;
            }

            Array.Sort(capacity);
            int index = capacity.Length - 1;

            while (sumApple > 0 && index > -1)
            {
                sumApple -= capacity[index--];
                minBoxes++;
            }

            if (sumApple > 0)
            {
                return -1;
            }

            return minBoxes;
        }
        public int NumSub(string s)
        {
            int mod = 1000000007;
            long result = 0;
            long currCountOne = 0;

            foreach (char c in s)
            {
                if (c == '1')
                {
                    currCountOne++;
                }
                else if (c == '0' && currCountOne > 0)
                {
                    result = ((currCountOne + 1) * currCountOne / 2 + result) % mod;

                    currCountOne = 0;
                }
            }

            if (currCountOne > 0)
            {
                result = ((currCountOne + 1) * currCountOne / 2 + result) % mod;
            }

            return (int)result;
        }
        public int EarliestTime(int[][] tasks)
        {
            int earliesTime = int.MaxValue;

            for (int i = 0; i < tasks.Length; i++)
            {
                earliesTime = (tasks[i][0] + tasks[i][1]) < earliesTime ? tasks[i][0] + tasks[i][1] : earliesTime;
            }

            return earliesTime;
        }
        public int MaxProduct(int n)
        {
            int maxValue = int.MinValue;
            int secondMaxValue = int.MinValue;

            while (n > 0)
            {
                int temp = n % 10;

                if (temp > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = temp;
                }
                else if (secondMaxValue < temp)
                {
                    secondMaxValue = temp;

                    if (secondMaxValue == 9)
                    {
                        return maxValue * secondMaxValue;
                    }
                }

                n /= 10;
            }

            return maxValue * secondMaxValue;
        }
        public int SumOfGoodNumbers(int[] nums, int k)
        {
            int resultSum = 0;
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                int temp = nums[i];
                if (i - k < 0)
                {
                    if (i + k < length)
                    {
                        if (temp > nums[i + k])
                        {
                            resultSum += temp;
                        }
                    }
                    else
                    {
                        resultSum += temp;
                    }
                }
                else
                {
                    if (i + k < length)
                    {
                        if (temp > nums[i + k] && temp > nums[i - k])
                        {
                            resultSum += temp;
                        }
                    }
                    else
                    {
                        if (temp > nums[i - k])
                        {
                            resultSum += temp;
                        }
                    }
                }
            }

            return resultSum;
        }
        public int CountPartitions(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int resultCountEven = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];
                rightSum -= temp;
                leftSum += temp;
                if ((leftSum - rightSum) % 2 == 0)
                {
                    resultCountEven++;
                }
            }

            return resultCountEven;
        }
        public int SmallestIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (temp > 9)
                {
                    int sum = 0;

                    while (temp != 0)
                    {
                        int moduloRest = temp % 10;
                        sum += moduloRest;
                        temp /= 10;
                    }
                    if (sum == i)
                    {
                        return i;
                    }
                }
                else if (nums[i] == i)
                {
                    return i;
                }

            }

            return -1;
        }
        public int CountSubarrays(int[] nums)
        {
            int count = 0;
            int length = nums.Length;
            for (int i = 1; i < length - 1; i++)
            {
                if ((nums[i - 1] + nums[i + 1]) * 2 == nums[i])
                {
                    count++;
                }
            }

            return count;
        }
        public int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
            {
                original *= 2;
            }
            return original;
        }
        public bool CheckXMatrix(int[][] grid)
        {
            int length = grid.Length;
            int numberCheck = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j == numberCheck || j == length - 1 - numberCheck)
                    {
                        if (grid[i][j] == 0)
                        {
                            return false;
                        }
                    }
                    else if (grid[i][j] > 0)
                    {
                        return false;
                    }
                }
                numberCheck++;
            }

            return true;
        }
        public double Average(int[] salary)
        {
            double sumSalary = 0;
            int minSalary = int.MaxValue;
            int maxSalary = int.MinValue;

            foreach (int item in salary)
            {
                sumSalary += item;
                if (minSalary > item)
                {
                    minSalary = item;
                }
                if (maxSalary < item)
                {
                    maxSalary = item;
                }
            }

            return (sumSalary - minSalary - maxSalary) / (salary.Length - 2);
        }
        public bool CheckString(string s)
        {
            bool status = true;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == 'b' && s[i] == 'a')
                {
                    return false;
                }
            }

            return status;
        }
        public int MaxOperations(int[] nums)
        {
            int count = 1;
            int sum = nums[0] + nums[1];

            for (int i = 2; i < nums.Length - 1; i += 2)
            {
                if (sum == nums[i] + nums[i + 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
        public int CountPalindromicSubsequence(string s)
        {
            HashSet<string> possiblePalindromes = new HashSet<string>();
            HashSet<char> leftChars = new HashSet<char>();
            leftChars.Add(s[0]);
            int[] rightChars = new int[27];
            int length = s.Length;

            for (int i = 1; i < length; i++)
            {
                rightChars[s[i] - 'a']++;
            }

            for (int i = 1; i < length - 1; i++)
            {
                char tempChar = s[i];
                rightChars[tempChar - 'a']--;

                foreach (var item in leftChars)
                {
                    if (rightChars[item - 'a'] > 0)
                    {
                        char[] chars = { item, tempChar };
                        possiblePalindromes.Add(new string(chars));
                    }
                }

                leftChars.Add(tempChar);
            }

            return possiblePalindromes.Count;
        }
        public int CountElements(int[] nums)
        {
            int countMin = 0;
            int countMax = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            if (nums.Length < 3)
            {
                return 0;
            }

            foreach (var item in nums)
            {
                if (max <= item)
                {
                    if (max < item)
                    {
                        max = item;
                        countMax = 1;
                    }
                    else
                    {
                        countMax++;
                    }
                }
                if (min >= item)
                {
                    if (min > item)
                    {
                        min = item;
                        countMin = 1;
                    }
                    else
                    {
                        countMin++;
                    }
                }
            }

            if (min == max)
            {
                return 0;
            }

            return nums.Length - countMin - countMax;
        }
        public bool IsThree(int n)
        {
            //Solution #1
            int countPositiveDivisors = 2;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    countPositiveDivisors++;
                    if (countPositiveDivisors > 3)
                    {
                        return false;
                    }
                }
            }

            if (countPositiveDivisors == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

            ////Solution #2
            //int countPositiveDivisors = 0;

            //for (int i = 1; i <= n; i++) 
            //{
            //    if (n % i == 0)
            //    {
            //        countPositiveDivisors++;
            //        if (countPositiveDivisors > 3)
            //        {
            //            return false;
            //        }
            //    }
            //}

            //if (countPositiveDivisors == 3)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public int[] ResultArray(int[] nums)
        {
            int lastArr1Value = nums[0];
            int lastArr2Value = nums[1];
            List<int> arr1 = new List<int>() { lastArr1Value };
            List<int> arr2 = new List<int>() { lastArr2Value };

            for (int i = 2; i < nums.Length; i++)
            {
                int tempValue = nums[i];
                if (lastArr1Value > lastArr2Value)
                {
                    lastArr1Value = tempValue;
                    arr1.Add(tempValue);
                }
                else
                {
                    lastArr2Value = tempValue;
                    arr2.Add(tempValue);
                }
            }

            arr1.AddRange(arr2);
            return arr1.ToArray();
        }
        public int MaxSumDivThree(int[] nums)
        {
            int sumNums = 0;
            int minValueModuloRest1 = int.MaxValue;
            int secondMinValueModuloRest1 = int.MaxValue;
            int minValueModuloRest2 = int.MaxValue;
            int secondMinValueModuloRest2 = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                sumNums += currValue;

                if (currValue % 3 == 1)
                {
                    if (currValue < minValueModuloRest1)
                    {
                        if (minValueModuloRest1 < secondMinValueModuloRest1)
                        {
                            secondMinValueModuloRest1 = minValueModuloRest1;
                        }
                        minValueModuloRest1 = currValue;
                    }
                    else if (currValue < secondMinValueModuloRest1)
                    {
                        secondMinValueModuloRest1 = currValue;
                    }
                }
                else if (currValue % 3 == 2)
                {
                    if (currValue < minValueModuloRest2)
                    {
                        if (minValueModuloRest2 < secondMinValueModuloRest2)
                        {
                            secondMinValueModuloRest2 = minValueModuloRest2;
                        }
                        minValueModuloRest2 = currValue;
                    }
                    else if (currValue < secondMinValueModuloRest2)
                    {
                        secondMinValueModuloRest2 = currValue;
                    }
                }
            }

            if (sumNums % 3 == 0)
            {
                return sumNums;
            }
            else if (sumNums % 3 == 1)
            {
                int temp1 = int.MaxValue;
                int temp2 = int.MaxValue;

                if (minValueModuloRest1 < int.MaxValue)
                {
                    temp1 = sumNums - minValueModuloRest1;
                }
                if (minValueModuloRest2 < int.MaxValue && secondMinValueModuloRest2 < int.MaxValue)
                {
                    temp2 = sumNums - minValueModuloRest2 - secondMinValueModuloRest2;
                }

                if (temp1 == int.MaxValue && temp2 == int.MaxValue)
                {
                    return 0;
                }
                else if (temp1 == int.MaxValue && temp2 < int.MaxValue)
                {
                    if (temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (temp2 == int.MaxValue && temp1 < int.MaxValue)
                {
                    if (temp1 > 0)
                    {
                        return temp1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (temp1 > 0 && temp2 > 0)
                    {
                        if (temp1 > temp2)
                        {
                            return temp1;
                        }
                        else
                        {
                            return temp2;
                        }
                    }
                    else if (temp1 == 0 && temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return temp1;
                    }
                }
            }
            else
            {
                int temp1 = int.MaxValue;
                int temp2 = int.MaxValue;

                if (minValueModuloRest2 < int.MaxValue)
                {
                    temp1 = sumNums - minValueModuloRest2;
                }
                if (minValueModuloRest1 < int.MaxValue && secondMinValueModuloRest1 < int.MaxValue)
                {
                    temp2 = sumNums - minValueModuloRest1 - secondMinValueModuloRest1;
                }

                if (temp1 == int.MaxValue && temp2 == int.MaxValue)
                {
                    return 0;
                }
                else if (temp1 == int.MaxValue && temp2 < int.MaxValue)
                {
                    if (temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (temp2 == int.MaxValue && temp1 < int.MaxValue)
                {
                    if (temp1 > 0)
                    {
                        return temp1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (temp1 > 0 && temp2 > 0)
                    {
                        if (temp1 > temp2)
                        {
                            return temp1;
                        }
                        else
                        {
                            return temp2;
                        }
                    }
                    else if (temp1 == 0 && temp2 > 0)
                    {
                        return temp2;
                    }
                    else
                    {
                        return temp1;
                    }
                }
            }
        }
        public int EvenNumberBitwiseORs(int[] nums)
        {
            int bitwiseEvenResult = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    bitwiseEvenResult |= num;
                }
            }

            return bitwiseEvenResult;
        }
        public bool CheckZeroOnes(string s)
        {
            int maxContiguousOnes = 0;
            int maxContiguousZeros = 0;
            char lastChar = 'k';
            int currContiguous = 0;

            foreach (char c in s)
            {
                if (lastChar == c)
                {
                    currContiguous++;
                    if (c == '0')
                    {
                        maxContiguousZeros = currContiguous > maxContiguousZeros ? currContiguous : maxContiguousZeros;
                    }
                    else
                    {
                        maxContiguousOnes = currContiguous > maxContiguousOnes ? currContiguous : maxContiguousOnes;
                    }
                }
                else
                {
                    currContiguous = 1;
                    if (c == '0')
                    {
                        maxContiguousZeros = currContiguous > maxContiguousZeros ? currContiguous : maxContiguousZeros;
                    }
                    else
                    {
                        maxContiguousOnes = currContiguous > maxContiguousOnes ? currContiguous : maxContiguousOnes;
                    }
                }
                lastChar = c;
            }

            if (maxContiguousOnes > maxContiguousZeros)
            {
                return true;
            }
            return false;
        }
        public int SmallestRepunitDivByK(int k)
        {
            if (k % 5 == 0 || k % 2 == 0)
            {
                return -1;
            }

            int actSum = 1 % k;
            int length = 1;

            while (actSum != 0)
            {
                actSum = (actSum * 10 + 1) % k;
                length++;
            }

            return length;
        }
        public int GenerateKey(int num1, int num2, int num3)
        {
            int[] minIntTable = new int[4] { 10, 10, 10, 10 };

            int indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num1 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num1 /= 10;
                indexResultInts--;
            }
            indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num2 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num2 /= 10;
                indexResultInts--;
            }
            indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num3 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num3 /= 10;
                indexResultInts--;
            }

            int result = 0;

            for (int i = 0; i < 4; i++)
            {
                if (minIntTable[i] < 10)
                {
                    result = result * 10 + minIntTable[i];
                }
            }

            return result;
        }
        public int NumberOfSpecialChars(string word)
        {
            HashSet<char> upperChars = new HashSet<char>();
            HashSet<char> lowerChars = new HashSet<char>();

            foreach (char c in word)
            {
                if (c < 96)
                {
                    upperChars.Add(c);
                }
                else
                {
                    lowerChars.Add(c);
                }
            }

            int count = 0;

            foreach (char c in upperChars)
            {
                //int x = 'a' - 'A';
                if (lowerChars.Contains((char)(c + 32)))
                {
                    count++;
                }
            }

            return count;
        }
        public bool CheckOnesSegment(string s)
        {
            bool zero = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '0' && !zero) { zero = true; }
                else if (s[i] == '1' && zero) { return false; }
            }
            return true;
        }
        public int[] EvenOddBit(int n)
        {
            int countEven = 0;
            int countOdd = 0;

            string nToBitsString = Convert.ToString(n, 2);
            int length = nToBitsString.Length;

            for (int i = 0; i < length; i++)
            {
                if (nToBitsString[i] == '1')
                {
                    if (i % 2 == 0)
                    {
                        countEven++;
                    }
                    else
                    {
                        countOdd++;
                    }
                }
            }

            if (length % 2 == 0)
            {
                return new int[] { countOdd, countEven };
            }

            return new int[] { countEven, countOdd };
        }
        public bool HalvesAreAlike(string s)
        {
            HashSet<char> sets = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int lenght = s.Length;
            int diff = lenght / 2;
            int countFirstSector = 0;
            int countSecondSector = 0;

            for (int i = 0; i < diff; i++)
            {
                if (sets.Contains(s[i]))
                {
                    countFirstSector++;
                }
                if (sets.Contains(s[i + diff]))
                {
                    countSecondSector++;
                }
            }

            if (countFirstSector != countSecondSector)
            {
                return false;
            }
            return true;
        }
        public int BuyChoco(int[] prices, int money)
        {
            int firstMinValue = prices[0];
            int secondMinValue = int.MaxValue;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < firstMinValue)
                {
                    secondMinValue = firstMinValue;
                    firstMinValue = prices[i];
                }
                else if (prices[i] < secondMinValue)
                {
                    secondMinValue = prices[i];
                }
            }

            if (firstMinValue + secondMinValue > money)
            {
                return money;
            }
            return money - firstMinValue - secondMinValue;
        }
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int countColumn = matrix[0].Length;
            int countRow = matrix.Length;

            int[] maxValueColumn = new int[countColumn];
            int[] maxValueRow = new int[countRow];
            IList<int> resultList = new List<int>();

            for (int i = 0; i < countRow; i++)
            {
                maxValueRow[i] = matrix[i][0];
                for (int j = 0; j < countColumn; j++)
                {
                    if (matrix[i][j] < maxValueRow[i])
                    {
                        maxValueRow[i] = matrix[i][j];
                    }
                    if (matrix[i][j] > maxValueColumn[j])
                    {
                        maxValueColumn[j] = matrix[i][j];
                    }
                }
            }

            foreach (int i in maxValueColumn)
            {
                if (maxValueRow.Contains(i))
                {
                    resultList.Add(i);
                }
            }

            return resultList;
        }
        public int CountOdds(int low, int high)
        {
            if (low % 2 == 0)
            {
                low++;
            }
            if (high % 2 == 0)
            {
                high--;
            }

            return (high - low) / 2 + 1;
        }
        public int ArraySign(int[] nums)
        {
            bool positiveValue = true;
            foreach (int item in nums)
            {
                if (item < 0)
                {
                    if (positiveValue)
                    {
                        positiveValue = false;
                    }
                    else
                    {
                        positiveValue = true;
                    }
                }
                else if (item == 0)
                {
                    return 0;
                }
            }

            if (positiveValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public int MinDeletion(string s, int k)
        {
            int[] countChars = new int[26];

            foreach (char item in s)
            {
                countChars[item - 'a']++;
            }

            Array.Sort(countChars);
            int minDelete = 0;

            for (int i = 25 - k; i >= 0; i--)
            {
                if (countChars[i] == 0)
                {
                    break;
                }
                else
                {
                    minDelete += countChars[i];
                }
            }

            return minDelete;
        }
        public int MinimumChairs(string s)
        {
            int minChairs = 0;
            int currChairs = 0;
            foreach (char c in s)
            {
                if (c == 'E')
                {
                    currChairs++;
                    minChairs = minChairs < currChairs ? currChairs : minChairs;
                }
                else
                {
                    currChairs--;
                }
            }
            return minChairs;
        }
        public bool IsPossibleToSplit(int[] nums)
        {
            int[] countNums = new int[101];

            foreach (int item in nums)
            {
                countNums[item]++;
                if (countNums[item] > 2)
                {
                    return false;
                }
            }

            return true;
        }
        public int MinStartValue(int[] nums)
        {
            int startValue = 1;
            int currSum = 1;

            foreach (int item in nums)
            {
                currSum += item;
                if (currSum < 1)
                {
                    startValue += Math.Abs(currSum - 1);
                    currSum = 1;
                }
            }

            return startValue;
        }
        public int MaximizeSum(int[] nums, int k)
        {
            int maxValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxValue = maxValue < nums[i] ? nums[i] : maxValue;
            }
            return (((maxValue + (maxValue + (k - 1)))) * k / 2);
        }
        public int[][] KClosest(int[][] points, int k)
        {
            int[][] distancePoints = new int[points.Length][];
            int minimumDistance = int.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                int temp = points[i][0] * points[i][0] + points[i][1] * points[i][1];
                distancePoints[i] = new int[] { temp, i };
            }

            List<int[]> listResult = new List<int[]>();

            distancePoints = distancePoints.OrderBy(x => x[0]).ToArray();

            for (int i = 0; i < k; i++)
            {
                listResult.Add(points[distancePoints[i][1]]);
            }

            return listResult.ToArray();
        }
        public int AccountBalanceAfterPurchase(int purchaseAmount)
        {
            int moduloResult = purchaseAmount % 10;
            if (moduloResult > 4)
            {
                return 90 - purchaseAmount + moduloResult;
            }
            return 100 - purchaseAmount + moduloResult;
        }
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int minDistance = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    int currDistance = Math.Abs(i - start);
                    minDistance = minDistance > currDistance ? currDistance : minDistance;
                }
            }

            return minDistance;
        }
        public int LongestMonotonicSubarray(int[] nums)
        {
            int maxStricly = 1;
            int status = -1;
            int currStricly = 1;
            int lastValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (lastValue < nums[i])
                {
                    if (status == 2)
                    {
                        currStricly++;
                    }
                    else
                    {
                        status = 2;
                        currStricly = 2;
                    }
                    maxStricly = maxStricly < currStricly ? currStricly : maxStricly;
                }
                else if (lastValue > nums[i])
                {
                    if (status == 1)
                    {
                        currStricly++;
                    }
                    else
                    {
                        status = 1;
                        currStricly = 2;
                    }
                    maxStricly = maxStricly < currStricly ? currStricly : maxStricly;
                }
                else
                {
                    status = 0;
                    currStricly = 1;
                }
                lastValue = nums[i];
            }

            return maxStricly;
        }
        public IList<int> FindMissingElements(int[] nums)
        {
            IList<int> result = new List<int>();
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                minValue = minValue > nums[i] ? nums[i] : minValue;
                maxValue = maxValue < nums[i] ? nums[i] : maxValue;
            }

            for (int i = minValue; i <= maxValue; i++)
            {
                if (!nums.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
        public int CountDistinctIntegers(int[] nums)
        {
            HashSet<int> numsList = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                numsList.Add(currValue);

                int reverceValue = 0;
                while (currValue != 0)
                {
                    int tempModulo = currValue % 10;
                    reverceValue = reverceValue * 10 + tempModulo;
                    currValue /= 10;
                }
                numsList.Add(reverceValue);
            }

            return numsList.Count;
        }
        public int[] ReplaceElements(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            int currMAx = arr[arr.Length - 1];
            newArr[arr.Length - 1] = -1;

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                newArr[i] = currMAx;
                currMAx = currMAx < arr[i] ? arr[i] : currMAx;
            }

            return newArr;
        }
        public int LongestContinuousSubstring(string s)
        {
            int maxLenghtAlphabeticalContinuous = 1;
            char lastChar = '\0';
            int currLenghtAlpabeticalContinuous = 1;

            foreach (char item in s)
            {
                if (lastChar + 1 == item)
                {
                    currLenghtAlpabeticalContinuous++;
                    maxLenghtAlphabeticalContinuous = maxLenghtAlphabeticalContinuous < currLenghtAlpabeticalContinuous ? currLenghtAlpabeticalContinuous : maxLenghtAlphabeticalContinuous;
                }
                else
                {
                    currLenghtAlpabeticalContinuous = 1;
                }
                lastChar = item;
            }

            return maxLenghtAlphabeticalContinuous;
        }
        public IList<string> StringMatching(string[] words)
        {
            List<string> result = new List<string>();
            int lenght = words.Length;

            for (int i = 0; i < lenght; i++)
            {
                string currWord = words[i];
                for (int j = 0; j < lenght; j++)
                {
                    if (j != i && words[j].Contains(currWord))
                    {
                        result.Add(currWord);
                        break;
                    }

                }
            }

            return result;
        }
        public bool DivideArray(int[] nums)
        {
            Span<int> spanNums = stackalloc int[501];

            foreach (int num in nums)
            {
                spanNums[num]++;
            }

            foreach (int num in spanNums)
            {
                if (num % 2 != 0)
                {
                    return false;
                }
            }

            return true;
        }
        public int NumberOfAlternatingGroups(int[] colors)
        {
            int countAlternatingGroups = 0;
            int lastColor = colors[colors.Length - 2];
            int middleColor = colors[colors.Length - 1];
            int nextColor;

            for (int i = 0; i < colors.Length; i++)
            {
                nextColor = colors[i];
                if (lastColor == nextColor && lastColor != middleColor)
                {
                    countAlternatingGroups++;
                }
                lastColor = middleColor;
                middleColor = nextColor;
            }

            return countAlternatingGroups;
        }
        public int CountTriples(int n)
        {
            int countTriples = 0;
            int maxC = n * n;

            for (int i = 1; i <= n; i++)
            {
                int currA = i;
                int temp = 0;
                int currB = 1;
                while (temp <= maxC)
                {
                    temp = currB * currB + currA * currA;
                    if (temp <= maxC)
                    {
                        int sqrtTemp = (int)Math.Sqrt(temp);
                        if (sqrtTemp * sqrtTemp == temp)
                        {
                            countTriples++;
                        }
                    }
                    currB++;
                }
            }
            return countTriples;
        }
        public int[] ApplyOperations(int[] nums)
        {
            int[] newNums = new int[nums.Length];
            int indexNewNums = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    nums[i] = 0;
                    nums[i - 1] = nums[i - 1] * 2;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    newNums[indexNewNums++] = nums[i];
                }
            }

            return newNums;
        }
        public int SumOfEncryptedInt(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                int tempNum = num;
                int maxValue = 0;
                int howLong = 0;
                while (tempNum != 0)
                {
                    int moduloNum = tempNum % 10;
                    maxValue = maxValue < moduloNum ? moduloNum : maxValue;
                    tempNum /= 10;
                    howLong++;
                }
                int currSum = maxValue;
                for (int i = 1; i < howLong; i++)
                {
                    currSum = currSum * 10 + maxValue;
                }
                sum += currSum;
            }
            return sum;
        }
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] weakestRow = new int[k];
            int[][] indexRowCount = new int[mat.Length][];

            for (int i = 0; i < mat.Length; i++)
            {
                int countSoldier = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        countSoldier++;
                    }
                }
                indexRowCount[i] = new int[] { i, countSoldier };
            }

            //indexRowCount = indexRowCount.OrderBy(x => x[1]).ToArray().Select(x => x[0]).ToArray();

            return indexRowCount.OrderBy(x => x[1]).ToArray().Select(x => x[0]).ToArray()[0..k];
        }
        public bool CheckIfExist(int[] arr)
        {
            bool status = false;

            for (int j = 0; j < arr.Length; j++)
            {
                int doubleValue = arr[j] * 2;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != j & arr[i] == doubleValue)
                    {
                        return true;
                    }
                }
            }

            return status;
        }
        public int MinimumOperations2357(int[] nums)
        {
            HashSet<int> countUniqueNums = new HashSet<int>();

            foreach (int num in nums)
            {
                if (num > 0)
                {
                    countUniqueNums.Add(num);
                }
            }

            return countUniqueNums.Count;
        }
        public string FindValidPair(string s)
        {
            Dictionary<char, int> sDictionaryCharCount = new Dictionary<char, int>();

            foreach (char item in s)
            {
                if (!sDictionaryCharCount.TryAdd(item, 1))
                {
                    sDictionaryCharCount[item]++;
                }
            }

            for (int i = 1; i < s.Length; i++)
            {
                //Console.WriteLine(sDictionaryCharCount[s[i - 1]] + sDictionaryCharCount[s[i]]);
                //Console.WriteLine((s[i] - '0') + (s[i - 1] - '0'));
                if (s[i] != s[i - 1] & sDictionaryCharCount[s[i]] == (s[i] - '0') & sDictionaryCharCount[s[i - 1]] == (s[i - 1] - '0'))
                {
                    return string.Concat(s[i - 1], s[i]);
                }
            }

            return "";
        }
        public long SplitArray(int[] nums)
        {
            bool[] isPrime = new bool[111000];
            for (int i = 0; i < 111000; i++)
            {

                isPrime[i] = true;

            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < 111000; i++)
            {
                if (isPrime[i])
                {
                    for (int multiple = i + i; multiple < 111000; multiple += i)
                    {
                        isPrime[multiple] = false;
                    }
                }
            }

            long sumA = 0;
            long sumB = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (isPrime[i] == true)
                {
                    sumA += nums[i];
                }
                else
                {
                    sumB += nums[i];
                }
            }

            return Math.Abs(sumA - sumB);
        }
        public int MissingMultiple(int[] nums, int k)
        {
            HashSet<int> hashSetNums = new HashSet<int>(nums);

            int currValue = k;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashSetNums.Contains(currValue))
                {
                    return currValue;
                }
                currValue += k;
            }
            return currValue;
        }
        public bool IsFascinating(int n)
        {
            HashSet<int> numbers = new HashSet<int>();
            int currValue = n * 1;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                int temp = currValue % 10;
                if (temp == 0 || !numbers.Add(temp))
                {
                    return false;
                }
                currValue /= 10;
            }
            if (numbers.Count != 3)
            {
                return false;
            }
            currValue = n * 2;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                int temp = currValue % 10;
                if (temp == 0 || numbers.Contains(temp))
                {
                    return false;
                }
                numbers.Add(temp);
                currValue /= 10;
            }
            if (numbers.Count != 6)
            {
                return false;

            }
            currValue = n * 3;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                int temp = currValue % 10;
                if (temp == 0 || numbers.Contains(temp))
                {
                    return false;
                }
                numbers.Add(temp);

                currValue /= 10;
            }
            if (numbers.Count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

            //bool isFacinating = false;

            //for (int i = 1; i < 7; i++)
            //{
            //    HashSet<int> numbersI = new HashSet<int>();
            //    int currValueI = n * i;
            //    if (currValueI > 987)
            //    {
            //        break;
            //    }
            //    while(currValueI != 0)
            //    {
            //        int temp = currValueI % 10;
            //        if (temp == 0 | !numbersI.Add(temp))
            //        {
            //            break;
            //        }
            //        currValueI /= 10;
            //    }
            //    if (numbersI.Count != 3)
            //    {
            //        continue;
            //    }
            //    for (int j = i+1; j < 6; j++)
            //    {
            //        HashSet<int> numbersJ = new HashSet<int>();
            //        int currValueJ = n * j;
            //        if (currValueJ > 987)
            //        {
            //            break;
            //        }
            //        while (currValueJ != 0)
            //        {
            //            int temp = currValueJ % 10;
            //            if (temp == 0 | numbersI.Contains(temp) | numbersJ.Contains(temp))
            //            {
            //                break;
            //            }
            //            numbersJ.Add(temp);
            //            currValueJ /= 10;
            //        }
            //        if (numbersJ.Count != 3)
            //        {
            //            continue;
            //        }
            //        for (int y = j + 1; y < 5; y++)
            //        {
            //            HashSet<int> numbersY = new HashSet<int>();
            //            int currValueY = n * y;
            //            if (currValueY > 987)
            //            {
            //                break;
            //            }
            //            while (currValueY != 0)
            //            {
            //                int temp = currValueY % 10;
            //                if (temp == 0 | numbersI.Contains(temp) | numbersJ.Contains(temp) | numbersY.Contains(temp))
            //                {
            //                    break;
            //                }
            //                numbersY.Add(temp);

            //                currValueY /= 10;
            //            }
            //            if (numbersY.Count != 3)
            //            {
            //                continue;
            //            }
            //            else
            //            {
            //                return true;
            //            }
            //        }
            //    }


            //}
            //return isFacinating;
        }
        public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
        {
            List<string[]> codeBusinessLineList = new List<string[]>();

            for (int i = 0; i < code.Length; i++)
            {
                if (isActive[i] == true && code[i].Length > 0)
                {
                    if (IsCorrectCode(code[i]))
                    {
                        string temp = businessLine[i];
                        if (temp == "electronics")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "0" });
                        }
                        else if (temp == "grocery")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "1" });
                        }
                        else if (temp == "pharmacy")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "2" });
                        }
                        else if (temp == "restaurant")
                        {
                            codeBusinessLineList.Add(new string[] { code[i], "3" });
                        }
                    }
                }
            }
            codeBusinessLineList = codeBusinessLineList.OrderBy(x => x[1]).ThenBy(x => x[0], StringComparer.Ordinal).ToList();

            return codeBusinessLineList.Select(x => x[0]).ToList();
        }
        private bool IsCorrectCode(string item)
        {
            foreach (char c in item)
            {
                if (c >= 'a' && c <= 'z') continue;
                if (c >= 'A' && c <= 'Z') continue;
                if (c >= '0' && c <= '9') continue;
                if (c == '_') continue;
                return false;
            }
            return true;
        }
        public int SumOfUnique(int[] nums)
        {
            int sumOfUnique = 0;
            int[] tableNums = new int[101];

            foreach (var item in nums)
            {
                tableNums[item]++;
                if (tableNums[item] < 2)
                {
                    sumOfUnique += item;
                }
                else if (tableNums[item] == 2)
                {
                    sumOfUnique -= item;
                }
            }

            return sumOfUnique;
        }
        public int MaxAscendingSum(int[] nums)
        {
            int last = nums[0];
            int maxAscendingSum = last;
            int currAscendingSum = last;
            for (int i = 1; i < nums.Length; i++)
            {
                if (last < nums[i])
                {
                    last = nums[i];
                    currAscendingSum += last;
                    maxAscendingSum = maxAscendingSum < currAscendingSum ? currAscendingSum : maxAscendingSum;
                }
                else
                {
                    last = nums[i];
                    currAscendingSum = last;
                }
            }

            return maxAscendingSum;
        }
        public long GetDescentPeriods(int[] prices)
        {
            long sum = 0;
            long currContiguousCount = 1;
            int last = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (last - prices[i] == 1)
                {
                    currContiguousCount++;
                }
                else if (currContiguousCount > 1)
                {
                    sum += (1 + currContiguousCount) * currContiguousCount / 2;
                    currContiguousCount = 1;
                }
                else
                {
                    sum += 1;
                }
                last = prices[i];
            }

            if (currContiguousCount > 0)
            {
                sum += (1 + currContiguousCount) * currContiguousCount / 2;
            }

            return sum;
        }
        public int CountGoodRectangles(int[][] rectangles)
        {
            int countGoodRectagles = 0;
            int maxLenght = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                int currMin = rectangles[i][0];
                for (int j = 1; j < rectangles[i].Length; j++)
                {
                    currMin = currMin > rectangles[i][j] ? rectangles[i][j] : currMin;
                }
                if (maxLenght < currMin)
                {
                    maxLenght = currMin;
                    countGoodRectagles = 1;
                }
                else if (maxLenght == currMin)
                {
                    countGoodRectagles++;
                }
            }

            return countGoodRectagles;
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

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
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


