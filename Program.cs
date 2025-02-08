using ProblemSolving.LeetCode;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using static ProblemSolving.LeetCode.LeetCode_225;
using static ProblemSolving.LeetCode.LeetCode_232;
using static ProblemSolving.LeetCode.LeetCode_303;
using static ProblemSolving.LeetCodeAll;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_Task basic_Task = new Basic_Task();
            LeetCodeAll leetCodeAll = new LeetCodeAll();

            //HACKERRANK

            ////Subarray Division 1
            //Console.WriteLine(basic_Task.birthday([2, 2, 1, 3, 2], 4, 2));

            ////Sales by Match
            //Console.WriteLine(basic_Task.sockMerchant(9, [10, 20, 20, 10, 10, 30, 50, 10, 20]));

            ////Cats and a Mouse
            //Console.WriteLine(basic_Task.catAndMouse(1, 2, 3));

            ////Divisible Sum Pairs
            //Console.WriteLine(basic_Task.divisibleSumPairs(6, 3, [1, 3, 2, 6, 1, 2]));

            ////Apple and Orange
            //List<int> oranges = new List<int>();
            //oranges = [5, -6];
            //List<int> apples = new List<int>();
            //apples = [-2, 2, 1];
            //int b = 2;
            //int a = 3;
            //int t = 15;
            //int s = 5;
            //basic_Task.countApplesAndOranges(s, t, a, b, apples, oranges);

            ////Grading Students
            //List<int> grades = new List<int>();
            //grades = [73, 67, 38, 33];
            //foreach (var item in basic_Task.gradingStudents(grades))
            //{
            //    Console.WriteLine(item);
            //}

            ////Happy Ladybugs
            //Console.WriteLine(basic_Task.Happy_ladybugs("RBY_YBR"));

            ////Cavity Map
            //List<string> grid = new List<string>();
            //grid = ["1112", "1912", "1892", "1234"];
            //grid = basic_Task.Cavity_Map(grid);
            //foreach (string item in grid)
            //{
            //    Console.WriteLine(item);
            //}

            ////Modified Kaprekar Numbers
            //Console.WriteLine(basic_Task.kaprekarNumbers(1, 100));

            ////ACM ICPC TEAM
            //List<string> topic = new List<string>();
            //topic = ["10101", "11100", "11010", "00101"];
            //List<int> newList = basic_Task.acmTeam(topic);
            ////foreach (var item in newList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(String.Join(" ", newList.ToArray()));

            ////Fair Rations
            //List<int> B = new List<int>();
            //B = [1, 2];
            //Console.WriteLine(basic_Task.fairRations(B));

            ////Encryption
            //string s = "chillout";
            //Console.WriteLine(basic_Task.encryption(s));

            ////Two Character
            //string s = "beabeefeab";
            //Console.WriteLine(basic_Task.alternate(s));

            ////Flatland Space Stations
            //int n = 5;
            //int[] c = [0, 4];
            //Console.WriteLine(basic_Task.flatlandSpaceStations(n, c));

            ////Ice Cream Parlor 
            //foreach (var item in basic_Task.icecreamParlor(4, [1, 4, 5, 3, 2]))
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////Weighted Uniform Strings
            //List<string> queries = basic_Task.weightedUniformStrings("abbcccdddd",[ 1, 7, 5, 4, 15]);
            //foreach (string query in queries)
            //{
            //    Console.WriteLine(query);
            //}

            ////Poker Nim
            //Console.WriteLine(basic_Task.pokerNim(5, [1,2]));

            ////Introduction to Nim Game
            //Console.WriteLine(basic_Task.nimGame([3, 2, 4]));

            ////Super Reduced String
            //Console.WriteLine(basic_Task.superReducedString1("acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj"));
            ////Faster alernative
            //Console.WriteLine(basic_Task.superReducedString1("acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj"));

            ////Beautiful Paris
            //Console.WriteLine(basic_Task.beautifulPairs([1, 2, 3, 4], [1, 2, 3, 3]));

            ////The Time on Words
            //Console.WriteLine(basic_Task.timeInWords(5, 45));

            ////Greedy Florist
            //Console.WriteLine(basic_Task.getMinimumCost(2, [2,5,6]));

            //////Extra Long Factorials
            //basic_Task.extraLongFactorials(25);

            ////The Power Sum
            //Console.WriteLine(basic_Task.powerSum(100, 3));

            ////Max Min
            //Console.WriteLine(basic_Task.maxMin(4, [3, 4, 10, 20, 30, 40, 100, 200, 1, 2]));

            ////Bigger is Greater
            //Console.WriteLine(basic_Task.biggerIsGreater("ehdegnmorgafrjxvsck"));

            ////Maximum Subarray Sum
            //List<long> a = new List<long>();
            //long m;


            //LEETCODE//LEETCODE//           
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//           
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//
            //LEETCODE//LEETCODE//



            //LEETCODE ALL            //LEETCODE ALL          //LEETCODE ALL            //LEETCODE ALL     //LEETCODE ALL            //LEETCODE ALL
            //LEETCODE ALL            //LEETCODE ALL          //LEETCODE ALL            //LEETCODE ALL     //LEETCODE ALL            //LEETCODE ALL
            //LEETCODE ALL            //LEETCODE ALL          //LEETCODE ALL            //LEETCODE ALL     //LEETCODE ALL            //LEETCODE ALL

            ////(1.) Two Sum (EASY)
            //Console.WriteLine(String.Join("", leetCodeAll.TwoSum([2, 7, 11, 15], 9)));
            ////OR
            //LeetCode_1 classLeetCode = new LeetCode_1();
            //Console.WriteLine(String.Join("", classLeetCode.TwoSum([2, 7, 11, 15], 9)));

            ////(9.) Palindrome Number (EASY)
            //Console.WriteLine(leetCodeAll.IsPalindrome(1234567899));
            ////OR
            //LeetCode_9 classLeetCode = new LeetCode_9();
            //Console.WriteLine(classLeetCode.IsPalindrome(1234567899));

            ////(13.) Roman to Integer (EASY)
            //Console.WriteLine(leetCodeAll.RomanToInt("MCMXCIV"));
            ////OR
            //LeetCode_13 classLeetCode = new LeetCode_13();
            //Console.WriteLine(classLeetCode.RomanToInt("MCMXCIV"));

            ////(14.) Longest Common Prefix (EASY)
            //Console.WriteLine(leetCodeAll.LongestCommonPrefix(["flower", "flow", "flight"]));
            ////OR
            //LeetCode_14 classLeetCode = new LeetCode_14();
            //Console.WriteLine(classLeetCode.LongestCommonPrefix(["flower", "flow", "flight"]));

            ////(20.) Valid Parentheses (EASY)
            //Console.WriteLine(leetCodeAll.IsValid("()[]{}"));
            ////OR
            //LeetCode_20 classLeetCode = new LeetCode_20();
            //Console.WriteLine(classLeetCode.IsValid("()[]{}"));

            ////(21.) Merge Two Sorted Lists (EASY)
            //ListNode list1 = new ListNode(1);
            //list1.next = new ListNode(2);
            //list1.next.next = new ListNode(4);
            //ListNode list2 = new ListNode(1);
            //list2.next = new ListNode(3);
            //list2.next.next = new ListNode(3);

            //var x = leetCodeAll.MergeTwoLists(list1, list2);

            ////OR

            //LeetCode_21 classLeetCode = new LeetCode_21();
            //var x = classLeetCode.MergeTwoLists(list1, list2);

            //bool endLoop = true;
            //do
            //{
            //    Console.WriteLine(x.val);
            //    x = x.next;
            //    if (x == null)
            //    {
            //        endLoop = false;
            //    }
            //} while (endLoop);

            //(26.) Remove Duplicates from Sorted Array (EASY)
            //Console.WriteLine(leetCodeAll.RemoveDuplicates([1, 1, 2]));

            ////OR

            //LeetCode_26 classLeetCode = new LeetCode_26();
            //Console.WriteLine(classLeetCode.RemoveDuplicates([1, 1, 2]));

            ////(27.) Remove Element (EASY)
            //Console.WriteLine(leetCodeAll.RemoveElement([3,2,2,3], 3));

            ////(28.) Find the Index of the First Occurrence in a String (EASY)
            //Console.WriteLine(leetCodeAll.StrStr("aaa", "aa"));

            ////(35.) Search Insert Position (EASY)
            //Console.WriteLine(leetCodeAll.SearchInsert([1, 3, 5, 6], 7));

            ////(58.) Lenght of Last Word (EASY)
            //Console.WriteLine(leetCodeAll.LengthOfLastWord(" fly me   to   the moon  "));

            ////(66.) Plus One (EASY)
            //Console.WriteLine(String.Join("",leetCodeAll.PlusOne([9, 9, 9, 9])));

            ////(67.) Add Binary (EASY)
            //Console.WriteLine(
            //    leetCodeAll.AddBinary("100110000000000000000000000000000000000000000000000000", 
            //                          "111111101010101101010101010101010101010101010111111111"));

            ////(69.) Sqrt(x) (EASY)
            //Console.WriteLine(leetCodeAll.MySqrt(22));

            ////(70.) Climbing Stairs (EASY)
            //Console.WriteLine(leetCodeAll.ClimbStairs(5));

            ////(83.) Remove Duplicates from Sorted List (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(1);
            //head.next.next = new ListNode(2);
            //var x = leetCodeAll.DeleteDuplicates(head); 
            //bool endLoop = true;
            //do
            //{
            //    Console.WriteLine(x.val);
            //    x = x.next;
            //    if (x == null)
            //    {
            //        endLoop = false;
            //    }
            //} while (endLoop);

            ////(88.) Merge Sorted Array (EASY)
            //leetCodeAll.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

            ////(94.) Binary Tree Inorder Traversal (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.right.left = null;
            //root.right.right = new TreeNode(8);
            //root.left.left.left = null;
            //root.left.left.right = null;
            //root.left.right.left = new TreeNode(6);
            //root.left.right.right = new TreeNode(7);
            //root.right.right.left = new TreeNode(9);
            //Console.WriteLine(string.Join("", leetCodeAll.InorderTraversal(root)));

            ////(100.) Same Tree (EASY)
            //TreeNode p = new TreeNode(1);
            //p.left = new TreeNode(2);
            //p.right = new TreeNode(3);
            //TreeNode q = new TreeNode(1);
            //q.left = new TreeNode(2);
            //p.right = new TreeNode(3);
            //Console.WriteLine(leetCodeAll.IsSameTree(p, q));

            ////(101.) Symmetric Tree (EASY)
            #region Symmetric Tree - other test cases
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(2);
            //root.left.left = null;
            //root.left.right = new TreeNode(3);
            //root.right.left = null;
            //root.right.right = new TreeNode(3);

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(2);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(4);
            //root.right.left = new TreeNode(4);
            //root.right.right = new TreeNode(3);

            //TreeNode root = new TreeNode(1);

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(0);
            #endregion Region_1
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(2);
            //root.left.left = null;
            //root.left.right = new TreeNode(3);
            //root.right.left = new TreeNode(3);
            //Console.WriteLine(leetCodeAll.IsSymmetric(root));

            ////(104.) Maximum Depth of Binary Tree (EASY)
            #region Maximum Depth - other test cases
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.left.left = null;
            //root.left.right = null;
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);

            ////Next Test Case
            //TreeNode root = null;
            #endregion
            //[1, 2, 3, 4, null, null, 5]
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = null;
            //root.right.left = null;
            //root.right.right = new TreeNode(5);
            //Console.WriteLine(leetCodeAll.MaxDepth(root));

            ////(108.) Convert Sorted Array to Binary Search Tree (EASY)
            //int[] nums = [-10, -3, 0, 5, 9];
            //TreeNode root = leetCodeAll.SortedArrayToBST(nums);

            ////(111.) Minimum Depth of Binary Tree (EASY)
            #region Minimum Depth - other test cases
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);
            #endregion
            //TreeNode root = new TreeNode(2);
            //root.left = null;
            //root.right = new TreeNode(3);
            //root.right.left = null;
            //root.right.right = new TreeNode(4);
            //root.right.right.left = null;
            //root.right.right.right = new TreeNode(5);
            //root.right.right.right.left = null;
            //root.right.right.right.right = new TreeNode(6);

            //Console.WriteLine(leetCodeAll.MinDepth(root));

            ////(112.) Path Sum (EASY)
            #region Path Sum other test cases 
            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(8);
            //root.left.left = new TreeNode(11);
            //root.left.left.left = new TreeNode(7);
            //root.left.left.right = new TreeNode(2);
            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(4);
            //root.right.right.right = new TreeNode(1);
            //int targetSum = 22;
            #endregion
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //int targetSum = 5;

            //Console.WriteLine(leetCodeAll.HasPathSum(root, targetSum));

            ////(118.) Pascal's Triangle (EASY)
            //int numRows = 30;
            //var x =  leetCodeAll.PascalsTriangleGenerate(numRows);
            //foreach (var i in x) 
            //{
            //    Console.WriteLine("");
            //    foreach (var j in i)
            //    {
            //        Console.Write(j);
            //        Console.Write(" ");
            //    }
            //}

            ////(119.) Pascal's Triangle II (EASY)
            //int numRows = 3;
            //var x = leetCodeAll.GetRow(numRows);
            //foreach (var i in x)
            //{
            //    Console.Write(i + " ");
            //}

            ////(121.) Best Time to Boy and Sell Stock (EASY)
            //int[] prices = [7, 1, 5, 3, 6, 4];
            //Console.WriteLine(leetCodeAll.MaxProfit(prices));

            ////(125.) Valid Palindrome (EASY)
            //string s = "A man, a plan, a canal: Panama";
            //Console.WriteLine(leetCodeAll.IsPalindrome(s));

            ////(136.) Single Number (EASY)
            //int[] nums = [4, 1, 2, 1, 2];
            //Console.WriteLine(leetCodeAll.SingleNumber(nums));

            ////(141.) Linked List Cycle (EASY)
            //ListNode head = new ListNode(3);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(0);
            //head.next.next.next = new ListNode(-4);
            //head.next.next.next.next = head.next;
            //Console.WriteLine(leetCodeAll.HasCycle(head));

            ////(144.) Binary Tree Preorder Traversal (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.left.right.left = new TreeNode(6);
            //root.left.right.right = new TreeNode(7);
            //root.right.right = new TreeNode(8);
            //root.right.right.left = new TreeNode(9);
            //Console.WriteLine(string.Join(" ", leetCodeAll.PreorderTraversal(root)));

            ////(145.) Binary Tree Postorder Traversal (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.left.right.left = new TreeNode(6);
            //root.left.right.right = new TreeNode(7);
            //root.right = new TreeNode(3);
            //root.right.right = new TreeNode(8);
            //root.right.right.left = new TreeNode(9);
            //Console.WriteLine(string.Join(" ", leetCodeAll.PostorderTraversal(root)));

            ////(160.) Intersection of Two Linked List (EASY)
            //ListNode headA = new ListNode(4);
            //ListNode headB = new ListNode(5);
            //ListNode headC = new ListNode(8);
            //headC.next = new ListNode(4);
            //headC.next.next = new ListNode(5);
            //headA.next = new ListNode(1);
            //headA.next.next = headC;
            //headB.next = new ListNode(6);
            //headB.next.next = new ListNode(1);
            //headB.next.next.next = headC;
            #region other cases 
            //ListNode headA = new ListNode(2);
            //headA.next = new ListNode(6);
            //headA = new ListNode(4);
            //ListNode headB = new ListNode(1);
            //headB.next = new ListNode(5);

            //ListNode headC = new ListNode(3);
            //ListNode headA = headC;
            //ListNode headB = new ListNode(2);
            //headB.next = headC;
            #endregion
            #region running the result
            //ListNode result = leetCodeAll.GetIntersectionNode(headA, headB);
            //if (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    do
            //    {
            //        if (result.next != null)
            //        {
            //            result = result.next;
            //            Console.WriteLine(result.val);
            //        }
            //    } while (result.next != null);
            //}
            //else
            //{
            //    Console.WriteLine("No intersection");
            //}
            #endregion

            ////(168.) Excel Sheet Column Title (EASY)
            //int columnNumber = 704;
            //Console.WriteLine(leetCodeAll.ConvertToTitle(columnNumber));

            ////(169.) Majority Element (EASY)
            //int[] nums = [3, 2, 3];
            //Console.WriteLine(leetCodeAll.MajorityElement(nums));

            ////(171.) Excel Sheet Column Number (EASY)
            //Console.WriteLine(leetCodeAll.TitleToNumber("AB"));

            ////(175.) Combine Two Tables (EASY) (MS SQL)
            //string SqlQuery = @"
            //Select
            //[firstName],
            //[lastName],
            //[city],
            //[state]
            //From Person
            //left join Address
            //on Person.personId = Address.personId";

            ////(181.) Employees Earning More Than Their Managers (EASY)
            //string SqlQuery1 = @"
            //    SELECT
            //    a.name as [Employee]
            //    FROM Employee as a
            //    Where a.salary > (SELECT salary FROM Employee Where a.managerId = id)";
            ////Alternative
            //string SqlQuery = @"
            //    SELECT
            //    a.name as [Employee]
            //    FROM Employee as a
            //    left join Employee as b
            //    on a.managerId = b.id
            //    Where a.salary > b.salary";

            ////(182.) Duplicate Emails (EASY)
            //string SqlQuery = @"
            //    SELECT
            //    [email]
            //    FROM [test1].[dbo].[test_email]
            //    Group by [email]
            //    Having Count(email) > 1;";

            ////(183.) Customers Who Never Order (EASY)
            //string SqlQuery = @"
            //    Select 
            //    a.[name] as [Customers]
            //    From Customers as a
            //    left join Orders as b
            //    on a.id = b.customerId
            //    where b.id is null
            //    ";

            ////(190.) Reverse Bits (EASY)
            //uint n = 43261596;
            //Console.WriteLine(leetCodeAll.reverseBits(n));
            ////OR
            //LeetCode_190 classLeetCode = new LeetCode_190();
            //Console.WriteLine(classLeetCode.reverseBits(n));

            ////(191.) Number of 1 Bits (EASY)
            //int n = 3;
            //Console.WriteLine(leetCodeAll.HammingWeight(n));
            ////OR
            //LeetCode_191 classLeetCode = new LeetCode_191();
            //Console.WriteLine(classLeetCode.HammingWeight(n));

            ////(196.) Delete Duplicate Emails (EASY)
            //string SqlQuery = @"
            //    DELETE a
            //    FROM Person  as a 
            //    inner join Person  as b
            //    on a.email = b.email and a.id > b.id";

            ////(197.) Rising Temperature (EASY)
            //string SqlQuery = @"
            //    WITH CTE 
            //    AS
            //    (
            //        SELECT [id]
            //        ,[temperature]
            //        ,recordDate
            //     ,lag(temperature) OVER (ORDER BY [recordDate]) as b
            //        ,DATEDIFF(day, lag(recordDate) OVER (ORDER BY [recordDate]), [recordDate]) as c
            //        FROM Weather
            //    )
            //    SELECT id 
            //    FROM CTE Where temperature > b 
            //    and c = 1
            //    order by [recordDate];";

            ////(202.) Happy Number (EASY)
            //int n = 19;
            //Console.WriteLine(leetCodeAll.IsHappy(n));
            ////OR
            //LeetCode_202 classLeetCode = new LeetCode_202();
            //Console.WriteLine(classLeetCode.IsHappy(n));

            ////(203.) Remove Linked List Elements (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(6);
            //head.next.next.next = new ListNode(3);
            //head.next.next.next.next = new ListNode(4);
            //head.next.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next.next = new ListNode(6);
            //int val = 6;
            //ListNode returnedListNode = leetCodeAll.RemoveElements(head, val);
            //while(returnedListNode != null)
            //{
            //    Console.WriteLine(returnedListNode.val);
            //    returnedListNode = returnedListNode.next;
            //}
            ////OR
            //LeetCode_203 classLeetCode = new LeetCode_203();
            //ListNode returnedListNode1 = classLeetCode.RemoveElements(head, val);
            //while (returnedListNode1 != null)
            //{
            //    Console.WriteLine(returnedListNode1.val);
            //    returnedListNode1 = returnedListNode1.next;
            //}

            ////(205.) Isomorphic Strings (EASY)
            //string s = "badc";
            //string t = "baba";
            //Console.WriteLine(leetCodeAll.IsIsomorphic(s, t));
            ////OR
            //LeetCode_205 classLeetCode = new LeetCode_205();
            //Console.WriteLine(classLeetCode.IsIsomorphic(s, t));

            ////(206.) Reverse Linked List (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);

            //ListNode returnedList = leetCodeAll.ReverseList(head);
            //while (returnedList != null)
            //{
            //    Console.WriteLine(returnedList.val);
            //    returnedList = returnedList.next;
            //}
            ////OR
            //LeetCode_206 classLeetCode = new LeetCode_206();
            //ListNode returnedList1 = classLeetCode.ReverseList(head);
            //while (returnedList1 != null)
            //{
            //    Console.WriteLine(returnedList1.val);
            //    returnedList1 = returnedList1.next;
            //}

            ////(217.) Contains Deplicate (EASY)
            //int[] nums = [1, 2, 3, 1];
            //Console.WriteLine(leetCodeAll.ContainsDuplicate(nums));
            ////OR
            //LeetCode_217 classLeetCode = new LeetCode_217();
            //Console.WriteLine(classLeetCode.ContainsDuplicate(nums));

            ////(219.) Contains Duplicate II (EASY)
            //int[] nums = [1, 2, 3, 1];
            //int k = 3;
            //Console.WriteLine(leetCodeAll.ContainsNearbyDuplicate(nums, k));

            ////OR

            //LeetCode_219 classLeetCode = new LeetCode_219();
            //Console.WriteLine(classLeetCode.ContainsNearbyDuplicate(nums, k));

            //LEETCODE INTERVIEW 150  //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150
            //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 
            //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150 //LEETCODE INTERVIEW 150

            ////(88.) Merge Sorted Array
            //int[] nums1 = [1, 2, 3, 0, 0, 0];
            //int m = 3;
            //int[] nums2 = [2, 5, 6];
            //int n = 3;
            //Console.WriteLine(leetCodeInterview150.Merge(nums1, m, nums2, n));
            //Console.WriteLine(leetCodeInterview150.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3));

            ////(222.) Count Complete Tree Nodes (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.right.left = new TreeNode(6);

            //Console.WriteLine(leetCodeAll.CountNodes(root));

            //////OR

            //LeetCode_222 classLeetCode = new LeetCode_222();
            //Console.WriteLine(classLeetCode.CountNodes(root));

            ////(225.) Implement Stack using Queues (EASY)
            //LeetCode_225_MyStack obj = new LeetCode_225_MyStack();
            //obj.Push(1);
            //obj.Push(2);
            //int param_2 = obj.Top();
            //int param_3 = obj.Pop();
            //bool param_4 = obj.Empty();

            //Console.WriteLine(param_2);
            //Console.WriteLine(param_3);
            //Console.WriteLine(param_4);

            ////OR
            //LeetCodeAll_225_MyStack obj1 = new LeetCodeAll_225_MyStack();
            //obj1.Push(1);
            //obj1.Push(2);
            //int parameter_2 = obj1.Top();
            //int parameter_3 = obj1.Pop();
            //bool parameter_4 = obj1.Empty();

            //Console.WriteLine(parameter_2);
            //Console.WriteLine(parameter_3);
            //Console.WriteLine(parameter_4);


            ////(226.) Invert Binary Tree (EASY)
            //TreeNode root = new TreeNode(2);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(3);

            //LeetCode_226 classLeetCode = new LeetCode_226();
            //TreeNode returnedRoot = classLeetCode.InvertTree(root);

            //Console.WriteLine(returnedRoot.val);
            //Console.WriteLine(returnedRoot.left.val);
            //Console.WriteLine(returnedRoot.right.val);

            ////OR
            //TreeNode root = new TreeNode(2);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(3);

            //TreeNode returnedRoot = leetCodeAll.InvertTree(root);
            //Console.WriteLine(returnedRoot.val);
            //Console.WriteLine(returnedRoot.left.val);
            //Console.WriteLine(returnedRoot.right.val);


            ////(228.) Summary Ranges (EASY)
            //int[] nums = [0, 2, 3, 4, 6, 8, 9];

            //LeetCode_228 classLeetCode = new LeetCode_228();
            //var result = classLeetCode.SummaryRanges(nums);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //var result1 = leetCodeAll.SummaryRanges(nums);
            //foreach (var item in result1) 
            //{
            //    Console.WriteLine(item);
            //}

            ////(231.) Power of Two (EASY)
            //int n = -2147483648;
            //LeetCode_231 classCodeAll = new LeetCode_231();
            //Console.WriteLine(classCodeAll.IsPowerOfTwo(n));

            ////OR
            //Console.WriteLine(leetCodeAll.IsPowerOfTwo(n));

            ////(232.) Implement Queue using Stacks (EASY)
            //LeetCode_232_MyQueue myQueue = new LeetCode_232_MyQueue();
            //myQueue.Push(1); // queue is: [1]
            //myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            //myQueue.Peek(); // return 1
            //myQueue.Pop(); // return 1, queue is [2]
            //myQueue.Empty(); // return false

            ////OR
            //LeetCodeAll_232_MyQueue myQueue1 = new LeetCodeAll_232_MyQueue();
            //myQueue1.Push(1); // queue is: [1]
            //myQueue1.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            //myQueue1.Peek(); // return 1
            //myQueue1.Pop(); // return 1, queue is [2]
            //myQueue1.Empty(); // return false

            ////(234.) Palindrome Linked List (EASY)
            //LeetCode_234 classLeetCode = new LeetCode_234();
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(2);
            //head.next.next.next = new ListNode(1);

            //Console.WriteLine(classLeetCode.IsPalindrome(head));

            //////OR
            //Console.WriteLine(leetCodeAll.IsPalindrome(head));

            ////(242.) Valid Anagram
            //string s = "anagram";
            //string t = "nagaram";

            //LeetCode_242 classLeetCode = new LeetCode_242();
            //Console.WriteLine(classLeetCode.IsAnagram(s, t));

            //////OR
            //Console.WriteLine(leetCodeAll.IsAnagram(s, t));

            ////(257.) Binary Tree Paths (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(5);
            //root.left.right = new TreeNode(6);

            //LeetCode_257 classLeetCode = new LeetCode_257();
            //var resultList = classLeetCode.BinaryTreePaths(root);

            //////OR

            ////var resultList = leetCodeAll.BinaryTreePaths(root);

            //foreach (var item in resultList)
            //{
            //    Console.WriteLine(item);
            //}

            ////(258.) Add Digits (EASY)
            //int num = 18;

            //LeetCode_258 classLeetCode = new LeetCode_258();
            //Console.WriteLine(classLeetCode.AddDigits(num));

            //////OR

            //Console.WriteLine(leetCodeAll.AddDigits(num));

            ////(263.) Ugly Number (EASY)
            //int n = 6;
            //LeetCode_263 classLeetCode = new LeetCode_263();
            //Console.WriteLine(classLeetCode.IsUgly(n));

            //////OR
            //Console.WriteLine(leetCodeAll.IsUgly(n));

            ////(268.) Missing Number (EASY)
            //int[] nums = [3, 0, 1];
            //LeetCode_268 classLeetCode = new LeetCode_268();
            //Console.WriteLine(classLeetCode.MissingNumber(nums));

            //////OR

            //Console.WriteLine(leetCodeAll.MissingNumber(nums));

            ////(278.) First Bad Version (EASY)
            //int n = 2;
            //LeetCode_278 classLeetCode = new LeetCode_278();

            //Console.WriteLine(classLeetCode.FirstBadVersion(n));

            //////OR

            //Console.WriteLine(leetCodeAll.FirstBadVersion(n));

            ////(283.) Move Zeroes (EASY)
            //int[] nums = [0, 1, 0, 3, 12];
            //LeetCode_283 classLeetCode = new LeetCode_283();

            //classLeetCode.MoveZeroes(nums);

            //////OR

            //leetCodeAll.MoveZeroes(nums);

            ////(290.) Word Pattern (EASY)
            //string pattern = "aa";
            //string s = "aaa aaa";

            //LeetCode_290 classLeetCode = new LeetCode_290();
            //Console.WriteLine(classLeetCode.WordPattern(pattern, s));

            //////OR

            //Console.WriteLine(leetCodeAll.WordPattern(pattern, s));

            ////(292.) Nim Game (EASY)
            //int n = 5;

            //LeetCode_292 classLeetCode = new LeetCode_292();
            //Console.WriteLine(classLeetCode.CanWinNim(n));

            //////OR
            //Console.WriteLine(leetCodeAll.CanWinNim(n));

            ////(303.) Range Sum Query - Immutable (EASY)
            //int[] nums = [-2, 0, 3, -5, 2, -1];

            //NumArray numArray = new NumArray(nums);
            //Console.WriteLine(numArray.SumRange(0,2));
            //Console.WriteLine(numArray.SumRange(2,5));
            //Console.WriteLine(numArray.SumRange(0,5));

            //////OR

            //NumArrayLeetCodeAll numArrayLeetCodeAll = new NumArrayLeetCodeAll(nums);
            //Console.WriteLine(numArrayLeetCodeAll.SumRange(0, 2));
            //Console.WriteLine(numArrayLeetCodeAll.SumRange(2, 5));
            //Console.WriteLine(numArrayLeetCodeAll.SumRange(0, 5));

            ////(326.) Power of Three (EASY)
            //int n = 27;

            //LeetCode_326 classLeetCode = new LeetCode_326();
            //Console.WriteLine(classLeetCode.IsPowerOfThree(n));

            //////OR

            //Console.WriteLine(leetCodeAll.IsPowerOfThree(n));

            ////(338.) Counting Bits (EASY)
            //int n = 5;

            //LeetCode_338 classLeetCode = new LeetCode_338();
            //Console.WriteLine(string.Join(",", classLeetCode.CountBits(n)));

            //////OR
            //Console.WriteLine(string.Join(",", leetCodeAll.CountBits(n)));

            ////(342.) Power of Four (EASY)
            //int n = 1;

            //LeetCode_342 classLeetCode = new LeetCode_342();
            //Console.WriteLine(classLeetCode.IsPowerOfFour(n));

            //////OR

            //Console.WriteLine(leetCodeAll.IsPowerOfFour(n));

            ////(344.) Reverse String (EASY)
            //char[] s = ['h', 'e', 'l', 'l', 'o'];
            ////char[] s = ['H', 'a', 'n', 'n', 'a', 'h'];

            //LeetCode_344 classLeetCode = new LeetCode_344();
            //classLeetCode.ReverseString(s);

            //////OR

            //leetCodeAll.ReverseString(s);

            ////(345.) Reverse Vowels of a String (EASY)
            //string s = "IceCreAm";

            //LeetCode_345 classLeetCode = new LeetCode_345();
            //Console.WriteLine(classLeetCode.ReverseVowels(s));

            //////OR

            //Console.WriteLine(leetCodeAll.ReverseVowels(s));

            ////(349.) Intersection of Two Arrays (EASY)
            //int[] nums1 = [1, 2, 2, 1];
            //int[] nums2 = [2, 2];

            //LeetCode_349 classLeetCode = new LeetCode_349();
            //Console.WriteLine(string.Join(",", classLeetCode.Intersection(nums1, nums2)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.Intersection(nums1, nums2)));

            ////(350.) Intersection of Two Arrays II (EASY)
            //int[] nums1 = [1, 2, 2, 1];
            //int[] nums2 = [2, 2];

            //LeetCode_350 classLeetCode = new LeetCode_350();
            //Console.WriteLine(string.Join(",", classLeetCode.Intersect(nums1, nums2)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.Intersect(nums1, nums2)));

            ////(367.) Valid Perfect Square (EASY)
            int num = 808201;

            LeetCode_367 classLeetCode = new LeetCode_367();
            Console.WriteLine(classLeetCode.IsPerfectSquare(num));

            ////OR
            Console.WriteLine(leetCodeAll.IsPerfectSquare(num));
        }

        //public class ListNode
        //{
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int val = 0, ListNode next = null)
        //    {
        //        this.val = val;
        //        this.next = next;
        //    }
        //}

        //public class TreeNode
        //{
        //    public int val;
        //    public TreeNode left;
        //    public TreeNode right;
        //    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        //    {
        //        this.val = val;   
        //        this.left = left;
        //        this.right = right;
        //    }
        //}
        //public static IList<int> InTree(IList<int> resultList, TreeNode root)
        //{
        //    if (root.left != null)
        //    {
        //        resultList = InTree(resultList, root.left);
        //    }
        //    resultList.Add(root.val);
        //    if (root.right != null)
        //    {
        //        resultList = InTree(resultList, root.right);
        //    }
        //    return resultList;
        //}
    }
}
