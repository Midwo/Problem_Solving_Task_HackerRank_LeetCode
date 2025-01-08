using System.ComponentModel.Design.Serialization;
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
            return new TreeNode();
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


