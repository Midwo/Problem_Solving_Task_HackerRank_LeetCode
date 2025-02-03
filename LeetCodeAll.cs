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

            return leftCount + rightCount+1;
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


