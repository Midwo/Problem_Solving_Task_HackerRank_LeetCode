using ProblemSolving.LeetCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static ProblemSolving.LeetCode.LeetCode_225;
using static ProblemSolving.LeetCode.LeetCode_232;
using static ProblemSolving.LeetCode.LeetCode_303;
using static ProblemSolving.LeetCode.LeetCode_703;
using static ProblemSolving.LeetCode.LeetCode_705;
using static ProblemSolving.LeetCode.LeetCode_706;
using static ProblemSolving.LeetCodeAll;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            /////(2.) Add Two Numbers (MEDIUM)
            //ListNode l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //LeetCode_2 classLeetCode = new LeetCode_2();
            //var result = classLeetCode.AddTwoNumbers(l1, l2);

            //while (result != null) 
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            ////OR

            //var result1 = classLeetCode.AddTwoNumbers(l1, l2);

            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(3.) Longest Substring Without Repeating Characters (MEDIUM)
            //string s = "abcabcbb";

            //LeetCode_3 classLeetCode = new LeetCode_3();
            //Console.WriteLine(classLeetCode.LengthOfLongestSubstring(s));

            //////OR

            //Console.WriteLine(leetCodeAll.LengthOfLongestSubstring(s));

            /////(4.) Median of Two Sorted Arrays (HARD)
            //int[] nums1 = [1, 2];
            //int[] nums2 = [3, 4];

            //LeetCode_4  classLeetCode1 = new LeetCode_4();
            //Console.WriteLine(classLeetCode1.FindMedianSortedArrays(nums1, nums2));

            //////OR

            //Console.WriteLine(leetCodeAll.FindMedianSortedArrays(nums1, nums2));

            ////(5.) Longest Palindromic Substring (MEDIUM)
            //string s = "bacabab";
            //LeetCode_5 classLeetCode = new LeetCode_5();
            //Console.WriteLine(classLeetCode.LongestPalindrome(s));

            //////OR

            //Console.WriteLine(leetCodeAll.LongestPalindromeMedium(s));

            ////(6.) Zigzag Conversion (MEDIUM)
            //string s = "PAYPALISHIRING";
            //int numRows = 4;

            //LeetCode_6 classLeetCode = new LeetCode_6();
            //Console.WriteLine(classLeetCode.Convert(s, numRows));

            //////OR

            //Console.WriteLine(leetCodeAll.ConvertZigZag(s, numRows));

            ////(7.) Reverse Integer (MEDIUM)
            //int x = 1534236469;

            //LeetCode_7 classLeetCode = new LeetCode_7();
            //Console.WriteLine(classLeetCode.Reverse(x));

            //////OR

            //Console.WriteLine(leetCodeAll.Reverse(x));

            ////(8.) String to Integer (atoi) (MEDIUM)
            //string s = "  244446656565645645645645645645645645645645645645645444440000000000012345678";

            //LeetCode_8 classLeetCode = new LeetCode_8();
            //Console.WriteLine(classLeetCode.MyAtoi(s));

            //////OR

            //Console.WriteLine(leetCodeAll.MyAtoi(s));

            ////(9.) Palindrome Number (EASY)
            //Console.WriteLine(leetCodeAll.IsPalindrome(1234567899));
            ////OR
            //LeetCode_9 classLeetCode = new LeetCode_9();
            //Console.WriteLine(classLeetCode.IsPalindrome(1234567899));

            ////(11.) Container With Most Water (MEDIUM)
            //int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];

            //LeetCode_11 classLeetCode = new LeetCode_11();
            //Console.WriteLine(classLeetCode.MaxArea(height));

            //////OR

            //Console.WriteLine(leetCodeAll.MaxArea(height));

            ////(12.) Integer to Roman (MEDIUM)
            //int num = 58;

            //LeetCode_12 classLeetCode = new LeetCode_12();
            //Console.WriteLine(classLeetCode.IntToRoman(num));

            //////OR

            //Console.WriteLine(leetCodeAll.IntToRoman(num));

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

            ////(15.) 3Sum (MEDIUM)
            //int[] nums = [2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10]; 
            ////int[] nums = [0, 0, 0, 0];
            //LeetCode_15 classLeetCode = new LeetCode_15();
            //IList<IList<int>> result = classLeetCode.ThreeSum(nums);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}

            //////OR

            //IList<IList<int>> result1 = leetCodeAll.ThreeSum(nums);
            //foreach (var item in result1) 
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}

            ////(16.) 3Sum Closest (MEDIUM)
            //int[] nums = [-1, 2, 1, -4];
            //int target = 1;

            //LeetCode_16 classLeetCode = new LeetCode_16();
            //Console.WriteLine(classLeetCode.ThreeSumClosest(nums, target));

            ////OR

            //Console.WriteLine(leetCodeAll.ThreeSumClosest(nums, target));

            ////(17.) Letter Combinations of a Phone Number (MEDIUM)
            //string digits = "5678";

            //LeetCode_17 classLeetCode = new LeetCode_17();
            //IList<string> result = classLeetCode.LetterCombinations(digits);

            //foreach (string resultItem in result) 
            //{
            //    Console.WriteLine(string.Join(",", resultItem));
            //}

            //////OR 
            //IList<string> result1 = leetCodeAll.LetterCombinations(digits);
            //foreach (string resultItem in result1)
            //{
            //    Console.WriteLine(string.Join(",", resultItem));
            //}

            ////(19.) Remove Nth Node From End of List (MEDIUM)
            //int n = 2;
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);

            //LeetCode_19 classLeetCode = new LeetCode_19();

            //ListNode result = classLeetCode.RemoveNthFromEnd(head, n);

            //while (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            //////OR

            //ListNode result1 = leetCodeAll.RemoveNthFromEnd(head, n);

            //while (result1 != null) 
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}


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

            ////(22.) Generate Parentheses (MEDIUM)
            //int n = 5;

            //LeetCode_22 classLeetCode = new LeetCode_22();
            //IList<string> result = classLeetCode.GenerateParenthesis(n);

            //foreach (string s in result) 
            //{
            //    Console.WriteLine(s);
            //}

            //////OR

            //IList<string> result1 = leetCodeAll.GenerateParenthesis(n);

            //foreach (string s in result1) 
            //{
            //    Console.WriteLine(s);
            //}

            ////(23.) Merge k Sorted Lists (HARD)
            //ListNode listNode1 = new ListNode(1);
            //listNode1.next = new ListNode(4);
            //listNode1.next.next = new ListNode(5);

            //ListNode listNode2 = new ListNode(1);
            //listNode2.next = new ListNode(3);
            //listNode2.next.next = new ListNode(4);

            //ListNode listNode3 = new ListNode(2);
            //listNode3.next = new ListNode(6);

            //ListNode[] lists = { listNode1, listNode2, listNode3 };

            //LeetCode_23 classLeetCode = new LeetCode_23();

            //ListNode result = classLeetCode.MergeKLists(lists);

            //while (result != null)
            //{
            //    Console.WriteLine(result.val);

            //    result = result.next;
            //}

            //////OR

            //ListNode result1 = leetCodeAll.MergeKLists(lists);

            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);

            //    result1 = result1.next;
            //}

            ////(24.) Swap Nodes in Pairs (MEDIUM)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);

            //LeetCode_24 classLeetCode = new LeetCode_24();  

            //ListNode result = classLeetCode.SwapPairs(head);

            //while (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;   
            //}

            //////OR

            //ListNode result1 = leetCodeAll.SwapPairs(head);
            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(25.) Reverse Nodes in k-Group (HARD)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //int k = 2;

            //LeetCode_25 classLeetCode = new LeetCode_25();

            //ListNode result = classLeetCode.ReverseKGroup(head, 2);

            //while (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            //////OR

            //ListNode result1 = leetCodeAll.ReverseKGroup(head, 2);
            //while(result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            //(26.) Remove Duplicates from Sorted Array (EASY)
            //Console.WriteLine(leetCodeAll.RemoveDuplicates([1, 1, 2]));

            ////OR

            //LeetCode_26 classLeetCode = new LeetCode_26();
            //Console.WriteLine(classLeetCode.RemoveDuplicates([1, 1, 2]));

            ////(27.) Remove Element (EASY)
            //Console.WriteLine(leetCodeAll.RemoveElement([3,2,2,3], 3));

            ////(28.) Find the Index of the First Occurrence in a String (EASY)
            //Console.WriteLine(leetCodeAll.StrStr("aaa", "aa"));

            ////(29.) Divide Two Integers (MEDIUM)
            //int dividend = -1;
            //int divisor = 1;

            //LeetCode_29 classLeetCode = new LeetCode_29();

            //Console.WriteLine(classLeetCode.Divide(dividend, divisor));

            //////OR

            //Console.WriteLine(leetCodeAll.Divide(dividend, divisor));

            ////(30.) Substring with Concatenation of All Words (HARD)
            //string s = "barfoothefoobarman";
            //string[] words = ["foo", "bar"];

            //LeetCode_30 classLeetCode = new LeetCode_30();

            //IList<int> result = classLeetCode.FindSubstring(s, words);

            //foreach (int i in result) 
            //{
            //    Console.WriteLine(i);
            //}

            //////OR

            //IList<int> result1 = leetCodeAll.FindSubstring(s, words);

            //foreach (int i in result1)
            //{
            //    Console.WriteLine(i);
            //}

            ////(31.) Next Permutation (MEDIUM)
            //int[] nums = [1, 2, 3];

            //LeetCode_31 classLeetCode = new LeetCode_31();

            //classLeetCode.NextPermutation(nums);

            //////OR

            //leetCodeAll.NextPermutation(nums);

            ////(32.) Longest Valid Parentheses (HARD)
            //string s = "(()";            

            //LeetCode_32 classLeetCode = new LeetCode_32();
            //Console.WriteLine(classLeetCode.LongestValidParentheses(s));

            //////OR

            //Console.WriteLine(leetCodeAll.LongestValidParentheses(s));

            ////(33.) Search in Rotated Sorted Array (MEDIUM)
            ////int[] nums = [0, 1, 2, 4, 5, 6, 7];
            //int[] nums = [283, 287, 288, 294, 295, 299, 0, 1, 2, 6, 12, 14, 17, 20, 24, 26, 33, 35, 38, 42, 46, 48, 50, 53, 56, 57, 58, 64, 66, 67, 69, 72, 75, 76, 78, 80, 81, 82, 83, 84, 90, 92, 93, 95, 99, 104, 108, 109, 112, 117, 122, 123, 124, 126, 130, 144, 145, 147, 152, 160, 164, 166, 168, 172, 173, 174, 176, 180, 181, 182, 183, 187, 188, 192, 195, 196, 197, 199, 200, 203, 207, 208, 212, 214, 217, 219, 222, 234, 239, 240, 241, 242, 245, 246, 248, 252, 254, 255, 256, 258, 262, 264, 266, 267, 269, 272, 273, 274, 280, 281];
            //////[4, 5, 6, 7, 0, 1, 2];
            ////int target = 5;
            //int target = 144;
            //LeetCode_33 classLeetCode = new LeetCode_33();

            //Console.WriteLine(classLeetCode.Search(nums, target));

            //////OR

            ////Console.WriteLine(leetCodeAll.Search(nums, target));


            ////(34.) Find First and Last Position of Element in Sorted Array (MEDIUM)

            //int[] nums = [5, 7, 7, 8, 8, 10];
            //int target = 8;

            //LeetCode_34 classLeetCode = new LeetCode_34();

            //int[] result = classLeetCode.SearchRange(nums, target);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //////OR

            //int[] result1 = leetCodeAll.SearchRange(nums, target);

            //foreach (int i in result1)
            //{
            //    Console.WriteLine(i);
            //}

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
            //int num = 808201;

            //LeetCode_367 classLeetCode = new LeetCode_367();
            //Console.WriteLine(classLeetCode.IsPerfectSquare(num));

            ////OR
            //Console.WriteLine(leetCodeAll.IsPerfectSquare(num));

            ////(374.) Guess Number Higher or Lower (EASY)
            //int n = 6;

            //LeetCode_374 classLeetCode = new LeetCode_374();
            //Console.WriteLine(classLeetCode.GuessNumber(n));

            //////OR
            //Console.WriteLine(leetCodeAll.GuessNumber(n));

            ////(383.) Ransom Note (EASY)
            //string ransomNote = "fihjjjjei";
            //string magazine = "hjibagacbhadfaefdjaeaebgi";

            //LeetCode_383 classLeetCode = new LeetCode_383();
            //Console.WriteLine(classLeetCode.CanConstruct(ransomNote, magazine));

            //////OR

            //Console.WriteLine(leetCodeAll.CanConstruct(ransomNote, magazine));

            ////(387.) First Unique Character in a String (EASY)
            //string s = "loveleetcode";

            //LeetCode_387 classLeetCode = new LeetCode_387();
            //Console.WriteLine(classLeetCode.FirstUniqChar(s));

            //////OR

            //Console.WriteLine(leetCodeAll.FirstUniqChar(s));

            ////(389.) Find the Difference (EASY)
            //string s = "abcd";
            //string t = "abcde";

            //LeetCode_389 classLeetCode = new LeetCode_389();
            //Console.WriteLine(classLeetCode.FindTheDifference(s, t));

            //////OR

            //Console.WriteLine(leetCodeAll.FindTheDifference(s, t));

            ////(392.) Is Subsequence (EASY)
            //string s = "abc";
            //string t = "ahbgdc";

            //LeetCode_392 classLeetCode = new LeetCode_392();
            //Console.WriteLine(classLeetCode.IsSubsequence(s, t));

            //////OR

            //Console.WriteLine(leetCodeAll.IsSubsequence(s, t));

            ////(401.) Binary Watch (EASY)
            //int turnedOn = 1;
            //LeetCode_401 classLeetCode = new LeetCode_401();
            //var result1 = classLeetCode.ReadBinaryWatch(turnedOn);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //////OR

            //var result2 = leetCodeAll.ReadBinaryWatch(turnedOn);

            //foreach (var item in result2) 
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////(404.) Sum of Left Leaves (EASY)
            //TreeNode root = new TreeNode(20);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.left.left = null;
            //root.left.right = null;
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);    

            //LeetCode_404 classLeetCode = new LeetCode_404();
            //Console.WriteLine(classLeetCode.SumOfLeftLeaves(root));

            //////OR

            //Console.WriteLine(leetCodeAll.SumOfLeftLeaves(root));

            ////(405.) Convert a Number to Hexadecimal (EASY)
            //int num = 26;

            //LeetCode_405 classLeetCode = new LeetCode_405();
            //Console.WriteLine(classLeetCode.ToHex(num));

            //////OR

            //Console.WriteLine(leetCodeAll.ToHex(num));
            ////(409.) Longest Palindrome (EASY)
            //string s = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";

            //LeetCode_409 classLeetCode = new LeetCode_409();
            //Console.WriteLine(classLeetCode.LongestPalindrome(s));

            //////OR

            //Console.WriteLine(leetCodeAll.LongestPalindrome(s));

            ////(412.) Fizz Buzz (EASY)
            //int n = 15;
            //LeetCode_412 classLeetCode = new LeetCode_412();
            //Console.WriteLine(string.Join(",", classLeetCode.FizzBuzz(n)));

            //////OR
            //Console.WriteLine(string.Join(",",leetCodeAll.FizzBuzz(n)));

            ////(414.) Third Maximum Number (EASY)
            //int[] nums = [1,1,2];

            //LeetCode_414 classLeetCode = new LeetCode_414();
            //Console.WriteLine(classLeetCode.ThirdMax(nums));

            //////OR
            //Console.WriteLine(leetCodeAll.ThirdMax(nums));

            ////(415.) Add Strings (EASY)
            //string num1 = "9";
            //string num2 = "9";

            //LeetCode_415 classLeetCode = new LeetCode_415();
            //Console.WriteLine(classLeetCode.AddStrings(num1, num2));

            //////OR

            //Console.WriteLine(leetCodeAll.AddStrings(num1, num2));

            ////(434.) Number of Segments in a String (EASY)
            //string s = "";

            //LeetCode_434 classLeetCode = new LeetCode_434();
            //Console.WriteLine(classLeetCode.CountSegments(s));

            //////OR

            //Console.WriteLine(leetCodeAll.CountSegments(s));

            ////(441.) Arranging Coins (EASY)
            //int n = 5;

            //LeetCode_441 classLeetCode = new LeetCode_441();
            //Console.WriteLine(classLeetCode.ArrangeCoins(n));

            //////OR

            //Console.WriteLine(leetCodeAll.ArrangeCoins(n));

            ////(448.) Find All Numbers Disappeared in an Array (EASY)
            //int[] nums = [4, 3, 2, 7, 7, 2, 3, 1];

            //LeetCode_448 classLeetCode = new LeetCode_448();
            //var result = classLeetCode.FindDisappearedNumbers(nums);

            //foreach (var i in result) 
            //{
            //    Console.WriteLine(i);
            //}

            //////OR
            //var result1 = leetCodeAll.FindDisappearedNumbers(nums);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////(455.) Assign Cookies (EASY)
            //int[] g = [1, 2];
            //int[] s = [1, 2, 3];

            //LeetCode_455 classLeetCode = new LeetCode_455();
            //Console.WriteLine(classLeetCode.FindContentChildren(g, s));

            //////OR

            //Console.WriteLine(leetCodeAll.FindContentChildren(g, s));

            ////(459.) Repeated Substring Pattern (EASY)
            //string s = "abcabcabcabc";

            //LeetCode_459 classLeetCode = new LeetCode_459();
            //Console.WriteLine(classLeetCode.RepeatedSubstringPattern(s));

            //////OR

            //Console.WriteLine(leetCodeAll.RepeatedSubstringPattern(s));

            ////(461.) Hamming Distance (EASY)
            //int x = 4;
            //int y = 14;

            //LeetCode_461 classLeetCode = new LeetCode_461();
            //Console.WriteLine(classLeetCode.HammingDistance(x, y));

            //////OR

            //Console.WriteLine(leetCodeAll.HammingDistance(x, y));

            ////(463.) Island Perimeter (EASY)
            //int[][] grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]];

            //LeetCode_463 classLeetcode = new LeetCode_463();
            //Console.WriteLine(classLeetcode.IslandPerimeter(grid));

            //////OR

            //Console.WriteLine(leetCodeAll.IslandPerimeter(grid));

            ////(476.) Number Complement (EASY)
            //int num = 2;

            //LeetCode_476 classLeetCode = new LeetCode_476();
            //Console.WriteLine(classLeetCode.FindComplement(num));

            //////OR

            //Console.WriteLine(leetCodeAll.FindComplement(num));

            ////(482.) License Key Formatting (EASY)
            //string s = "2-5g-3-J";
            //int k = 2;

            //LeetCode_482 classLeetCode = new LeetCode_482();
            //Console.WriteLine(classLeetCode.LicenseKeyFormatting(s, k));

            //////OR

            //Console.WriteLine(leetCodeAll.LicenseKeyFormatting(s, k));

            ////(485.) Max Consecutive Ones (EASY)
            //int[] nums = [1, 1, 0, 1, 1, 1];

            //LeetCode_485 classLeetCode = new LeetCode_485();
            //Console.WriteLine(classLeetCode.FindMaxConsecutiveOnes(nums));

            //////OR

            //Console.WriteLine(leetCodeAll.FindMaxConsecutiveOnes(nums));

            ////(492.) Construct the Rectangle (EASY)
            //int area = 4;

            //LeetCode_492 classLeetCode = new LeetCode_492();
            //Console.WriteLine(string.Join(",", classLeetCode.ConstructRectangle(area)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.ConstructRectangle(area)));

            ////(495.) Teemo Attacking (EASY)
            //int[] timeSeries = [1, 4];
            //int duration = 2;

            //LeetCode_495 classLeetCode = new LeetCode_495();
            //Console.WriteLine(classLeetCode.FindPoisonedDuration(timeSeries, duration));

            //////OR

            //Console.WriteLine(leetCodeAll.FindPoisonedDuration(timeSeries, duration));

            ////(496.) Next Greater Element I (EASY)
            //int[] nums1 = [4, 1, 2];
            //int[] nums2 = [1, 3, 4, 2];

            //LeetCode_496 classLeetCode = new LeetCode_496();
            //Console.WriteLine(string.Join(",", classLeetCode.NextGreaterElement(nums1, nums2)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.NextGreaterElement(nums1, nums2)));

            ////(500.) Keyboard Row (EASY)
            //string[] words = ["Hello", "Alaska", "Dad", "Peace"];

            //LeetCode_500 classLeetCode = new LeetCode_500();
            //Console.WriteLine(string.Join(",", classLeetCode.FindWords(words)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.FindWords(words)));

            ////(501.) Find Mode in Binary Search Tree (EASY)
            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(2);
            //root.left = null;
            //root.right.left = new TreeNode(2);

            //LeetCode_501 classLeetCode = new LeetCode_501();
            //Console.WriteLine(string.Join(",", classLeetCode.FindMode(root)));

            //////OR

            //Console.WriteLine(String.Join(",", leetCodeAll.FindMode(root)));

            ////(504.) Base 7 (EASY)
            //int num = 49;

            //LeetCode_504 classLeetCode = new LeetCode_504();
            //Console.WriteLine(classLeetCode.ConvertToBase7(num));

            //////OR

            //Console.WriteLine(leetCodeAll.ConvertToBase7(num));

            ////(506.) Relative Ranks (EASY)
            //int[] score = [10, 3, 8, 9, 4];

            //LeetCode_506 classLeetCode = new LeetCode_506();
            //Console.WriteLine(string.Join(",", classLeetCode.FindRelativeRanks(score)));

            //////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.FindRelativeRanks(score)));

            ////(507.) Perfect Number (EASY)
            //int num = 28;

            //LeetCode_507 classLeetCode = new LeetCode_507();
            //Console.WriteLine(classLeetCode.CheckPerfectNumber(num));

            //////OR

            //Console.WriteLine(leetCodeAll.CheckPerfectNumber(num));

            ////(509.) Fibonacci Number (EASY)
            //int n = 4;

            //LeetCode_509 classLeetCode = new LeetCode_509();
            //Console.WriteLine(classLeetCode.Fib(n));

            //////OR

            //Console.WriteLine(leetCodeAll.Fib(n));

            ////(511.) Game Play Analysis I (EASY)
            //// DATABASE TASK

            //LeetCode_511 classLeetCode = new LeetCode_511();
            //classLeetCode.Task511();

            //////OR

            //leetCodeAll.LeetCode511();

            ////(520.) Detect Capital (EASY)
            //string word = "usa";

            //LeetCode_520 classLeetCode = new LeetCode_520();
            //Console.WriteLine(classLeetCode.DetectCapitalUse(word));

            //////OR

            //Console.WriteLine(leetCodeAll.DetectCapitalUse(word));

            ////(521.) Longest Uncommon Subsequence I (EASY)
            //string a = "aaa";
            //string b = "aaa";

            //LeetCode_521 classLeetCode = new LeetCode_521();
            //Console.WriteLine(classLeetCode.FindLUSlength(a, b));

            //////OR

            //Console.WriteLine(leetCodeAll.FindLUSlength(a, b));

            ////(530.) Minimum Absolute Difference in BST (EASY)
            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(6);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);

            //LeetCode_530 classLeetCode = new LeetCode_530();
            //Console.WriteLine(classLeetCode.GetMinimumDifference(root));

            //////OR

            //Console.WriteLine(leetCodeAll.GetMinimumDifference(root));

            ////(541.) Reverse String II (EASY)
            ////string s = "iopmkexxpatqgmwjlhvexiyjiqyorbjwikszxqzntfxskcpgybgzvhvewrghibivfmydhtydnltopuoakiepttaxubwhfemiagxhjtpbaifvmcskrphrgrqunvcpeshooqzbclaejvdpkgzbiahdaxmyplrkouzzejujzjeytgdzgofqpyxizwqkxujpmucflrzmrccoufdjzngufntzqhgwsxuehysvokgaxbrcbyotivchfwvrzrtcwfjnzbymfeixqtvhwxxwwmgsqgpslwvpdbubsdwfxawjmowvxxlyetytaqqpazhxeyohrahruyjjpzqwrtluzuhcrueagadobkxqgvrgmgebjlvunhjddqbvwggjteyxuvsiqqezhxuocfqgnltadrvrkeibhgxwlwgqzxxhedbtzkneqjpzddogkazbvkfnrgeuhuffrjipiwwgkxklvfdextixvrsrfowwijxcgkwhbkmqgtnzmddadiktodydidabimamfjddjiityanoijqahtzglelgzqauekwhjchlbcmuptbiqsoknjnqrxoczsytpaniysfpxqhydefssttjccauittoicxolnqavlajapbsuubpwfrwgwezujsieqcjldwmsggclqiujfkluzybctmcropkjwqmefxaqaqbwsnvsyepthpwrevblkfedcnryruevewbtyqgocrizztkquanvbrqjrxafproapyituyblxdkerpafemensocnealjckjvwxixdcrqiqikdlkyyjzstealbgjjtrzshupkdnrtzoecgysayjzmszmuidnegshmbdctnwhelopfhfyelgfingqgdgaedadbbxcsfionwhpomgeyoldukqyojjfeybmoihheofztalnpfptqosytucjyaqgaenjuffxpsembaemaajfbceaaxlotzqcueejltfqfugkvvctgjtlvfflymragubfyndirsxsmlsx";
            ////int k = 183;
            //string s = "abcdefg";
            //int k = 2;
            //LeetCode_541 classLeetCode = new LeetCode_541();
            //Console.WriteLine(classLeetCode.ReverseStr(s, k));

            //////OR

            //Console.WriteLine(leetCodeAll.ReverseStr(s, k));

            ////(543.) Diameter of Binary Tree (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);

            //LeetCode_543 classLeetCode = new LeetCode_543();
            //Console.WriteLine(classLeetCode.DiameterOfBinaryTree(root));

            //////OR

            //Console.WriteLine(leetCodeAll.DiameterOfBinaryTree(root));

            ////(551.) Student Attendance Record I (EASY)
            //string s = "LPLPLPLPLPL";

            //LeetCode_551 classLeetCode = new LeetCode_551();
            //Console.WriteLine(classLeetCode.CheckRecord(s));

            //////OR

            //Console.WriteLine(classLeetCode.CheckRecord(s));

            ////(557.) Reverse Words in a String III (EASY)
            //string s = "Let's take LeetCode contest";

            //LeetCode_557 classLeetCode = new LeetCode_557();
            //Console.WriteLine(classLeetCode.ReverseWords(s));

            //////OR

            //Console.WriteLine(leetCodeAll.ReverseWords(s));

            ////(559.) Maximum Depth of N-ary Tree (EASY)
            //Node root = new Node(1);
            //root.children.Add(new Node(3));
            //root.children.Add(new Node(2));
            //root.children.Add(new Node(4));
            //root.children[0].children.Add(new Node(5));
            //root.children[0].children.Add(new Node(6));

            //LeetCode_559 classLeetCode = new LeetCode_559();
            //Console.WriteLine(classLeetCode.MaxDepth(root));

            //////OR

            //Console.WriteLine(leetCodeAll.MaxDepth(root));

            ////(561.) Array Partition (EASY)
            //int[] nums = [1, 4, 3, 2];

            //LeetCode_561 classLeetCode = new LeetCode_561();
            //Console.WriteLine(classLeetCode.ArrayPairSum(nums));

            //////OR

            //Console.WriteLine(leetCodeAll.ArrayPairSum(nums));

            ////(566.) Reshape the Matrix (EASY)
            //int[][] mat = [[1, 2], [3, 4]];
            //int r = 1;
            //int c = 4;

            //int[][] mat = [[1, 2], [3, 4]];
            //int r = 4;
            //int c = 1;
            //LeetCode_566 classLeetCode = new LeetCode_566();

            //int[][] result = classLeetCode.MatrixReshape(mat, r, c);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}

            //////OR
            //int[][] result1 = leetCodeAll.MatrixReshape(mat, r, c);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(",", item));
            //}

            ////(575.) Distribute Candies (EASY)
            //int[] candyType = [1, 1, 2, 2, 3, 3];

            //LeetCode_575 classLeetCode = new LeetCode_575();

            //Console.WriteLine(classLeetCode.DistributeCandies(candyType));

            //////OR

            //Console.WriteLine(leetCodeAll.DistributeCandies(candyType));

            ////(577.) Employee Bonus (EASY)
            //LeetCode_577 classLeetCode = new LeetCode_577();
            ////OR
            //leetCodeAll.LeetCode_577();

            ////(584.) Find Customer Referee (EASY)
            //LeetCode_584 classLeetCode = new LeetCode_584();
            ////OR
            //leetCodeAll.LeetCode_584();

            ////(586.) Customer Placing the Largest Number of Orders (EASY)
            //LeetCode_586 classLeetCode = new LeetCode_586();
            //////OR
            //leetCodeAll.LeetCode_586();

            ////(594.) Longest Harmonious Subsequence (EASY)
            ////int[] nums = [1, 3, 2, 2, 5, 2, 3, 7];
            ////int[] nums = [1, 2, 3, 3, 1, -14, 13, 4];
            //int[] nums = [1, 2, 3, 4, 6, 5, -5, 10, -1, -2, 5, 4, 4, -1, 7];
            //////int[] nums = [1, 4, 1, 3, 1, -14, 1, -13];
            //LeetCode_594 classLeetCode = new LeetCode_594();

            //Console.WriteLine(classLeetCode.FindLHS(nums));

            //////OR

            //Console.WriteLine(leetCodeAll.FindLHS(nums));

            ////(595.) Big Countries (EASY)

            //LeetCode_595 classLeetCode = new LeetCode_595();
            ////OR
            //leetCodeAll.LeetCode_595();

            //////(596.) Classes More Than 5 Students (EASY)
            //LeetCode_596 classLeetCode = new LeetCode_596();
            ////OR
            //leetCodeAll.LeetCode_596();

            ////(598.) Range Addition II (EASY)

            //int m = 3;
            //int n = 3;
            //int[][] ops = [[2, 2], [3, 3], [3, 3], [3, 3], [2, 2], [3, 3], [3, 3], [3, 3], [2, 2], [3, 3], [3, 3], [3, 3]];

            //LeetCode_598 classLeetCode = new LeetCode_598();
            //Console.WriteLine(classLeetCode.MaxCount(m, n, ops));

            //////OR

            //Console.WriteLine(leetCodeAll.MaxCount(m, n, ops));

            ////(599.) Minimum Index Sum of Two Lists (EASY)
            //string[] list1 = ["happy", "sad", "good"];
            //string[] list2 = ["sad", "happy", "good"];

            //LeetCode_599 classLeetCode = new LeetCode_599();

            //string[] result = classLeetCode.FindRestaurant(list1, list2);

            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}

            ////OR 

            //string[] result1 = leetCodeAll.FindRestaurant(list1, list2);

            //foreach (string s in result1)
            //{
            //    Console.WriteLine(s);
            //}

            ////(605.) Can Place Flowers (EASY)
            //int[] flowerbed = [0];
            //int n = 1;

            //LeetCode_605 classLeetCode = new LeetCode_605();
            //Console.WriteLine(classLeetCode.CanPlaceFlowers(flowerbed, n));

            ////OR

            //Console.WriteLine(leetCodeAll.CanPlaceFlowers(flowerbed, n));

            ////(607.) Sales Person (EASY)
            //LeetCode_607 classLeetCode = new LeetCode_607();

            ////OR

            //leetCodeAll.LeetCode_607();

            //(610.) Triangle Judgement (EASY)
            //LeetCode_610 classLeetCode = new LeetCode_610();

            ////OR

            //leetCodeAll.LeetCode_610();

            ////(619.) Biggest Single Number (EASY)

            //LeetCode_619 classLeetCode = new LeetCode_619();

            ////OR

            //leetCodeAll.LeetCode_619();

            ////(620.) Not Boring Movies (EASY)
            //LeetCode_620 classLeetCode = new LeetCode_620();

            ////OR

            //leetCodeAll.LeetCode_620();

            ////(627.) Swap Salary (EASY)
            //LeetCode_627 classLeetCode = new LeetCode_627();

            ////OR

            //leetCodeAll.LeetCode_627();

            ////(628.) Maximum Product of Three Numbers (EASY)
            //int[] nums = [-4, -3, -2, -1, 60];

            //LeetCode_628 classLeetCode = new LeetCode_628();

            //Console.WriteLine(classLeetCode.MaximumProduct(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumProduct(nums));

            ////643.Maximum Average Subarray I (EASY)
            //int[] nums = [1, 12, -5, -6, 50, 3];
            //int k = 4;

            //LeetCode_643 classLeetCode = new LeetCode_643();

            //Console.WriteLine(classLeetCode.FindMaxAverage(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.FindMaxAverage(nums, k));

            ////(645.) Set Mismatch (EASY)
            //int[] nums = [2, 2];

            //LeetCode_645 classLeetCode = new LeetCode_645();

            //int[] result = classLeetCode.FindErrorNums(nums);

            //Console.WriteLine(string.Join(',', result));

            ////OR

            //int[] result1 = leetCodeAll.FindErrorNums(nums);

            //Console.WriteLine(string.Join(',', result1));

            ////(657.) Robot Return to Origin (EASY)
            //string moves = "UD";

            //LeetCode_657 classLeetCode = new LeetCode_657();

            //Console.WriteLine(classLeetCode.JudgeCircle(moves));

            ////OR

            //Console.WriteLine(leetCodeAll.JudgeCircle(moves));

            ////(661.) Image Smoother (EASY)
            //int[][] img = [[100, 200, 100], [200, 50, 200], [100, 200, 100]];
            //int[][] img = [[100, 200, 100], [200, 50, 200], [100, 200, 100]];

            //LeetCode_661 classLeetCode = new LeetCode_661();

            //int[][] result = classLeetCode.ImageSmoother(img);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',',item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.ImageSmoother(img);

            //foreach (var item in result1) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(674.) Longest Continuous Increasing Subsequence (EASY)
            //int[] nums = [1, 3, 5, 4, 7];

            //LeetCode_674 classLeetCode = new LeetCode_674();
            //Console.WriteLine(classLeetCode.FindLengthOfLCIS(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLengthOfLCIS(nums)); 

            ////(680.) Valid Palindrome II (EASY)
            //string s = "adffdslcupuupuculsdffda";

            //LeetCode_680 classLeetCode = new LeetCode_680();
            //Console.WriteLine(classLeetCode.ValidPalindrome(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ValidPalindrome(s));

            ////(682.) Baseball Game (EASY)
            //string[] ops = ["5", "2", "C", "D", "+"];

            //LeetCode_682 classLeetCode = new LeetCode_682();

            //Console.WriteLine(classLeetCode.CalPoints(ops));

            ////OR

            //Console.WriteLine(leetCodeAll.CalPoints(ops));

            ////(693.) Binary Number with Alternating Bits (EASY)
            //int n = 5;

            //LeetCode_693 classLeetCode = new LeetCode_693();
            //Console.WriteLine(classLeetCode.HasAlternatingBits(n));

            ////OR

            //Console.WriteLine(leetCodeAll.HasAlternatingBits(n));

            ////(696.) Count Binary Substrings (EASY)
            //string s = "000111000";

            //LeetCode_696 classLeetCode = new LeetCode_696();
            //Console.WriteLine(classLeetCode.CountBinarySubstrings(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountBinarySubstrings(s));

            ////(697.) Degree of an Array (EASY)
            //int[] nums = [1, 2, 2, 3, 1, 4, 2];

            //LeetCode_697 classLeetCode = new LeetCode_697();
            //Console.WriteLine(classLeetCode.FindShortestSubArray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindShortestSubArray(nums));

            //703. Kth Largest Element in a Stream (EASY)
            //int k = 2;
            //int[] nums = [0];
            //KthLargest kthLargest = new KthLargest(k, nums);
            //int[] addNums = [-1, 1, -2, -4, 3];
            //foreach (int num in addNums)
            //{
            //    kthLargest.Add(num);
            //}

            ////OR

            //KthLargest1 kthLargest1 = new KthLargest1(k, nums);

            //foreach (int num in addNums)
            //{
            //    kthLargest1.Add(num);
            //}

            ////(704.) Binary Search (EASY)
            //int[] nums = [-1, 0, 3, 5, 9, 12];
            //int target = 9;

            //LeetCode_704 classLeetCode = new LeetCode_704();
            //Console.WriteLine(classLeetCode.Search(nums, target));

            ////OR

            //Console.WriteLine(leetCodeAll.Search704(nums, target));

            ////(705.) Design HashSet (EASY)
            //MyHashSet classLeetCode = new MyHashSet();
            //classLeetCode.Add(1);
            //classLeetCode.Add(2);
            //classLeetCode.Contains(1);
            //classLeetCode.Contains(3);
            //classLeetCode.Add(2);
            //classLeetCode.Contains(2);
            //classLeetCode.Remove(2);
            //classLeetCode.Contains(2);

            ////OR

            //MyHashSet1 leetCodeAllDoc = new MyHashSet1();
            //leetCodeAllDoc.Add(1);
            //leetCodeAllDoc.Add(2);
            //leetCodeAllDoc.Contains(1);
            //leetCodeAllDoc.Contains(3);
            //leetCodeAllDoc.Add(2);
            //leetCodeAllDoc.Contains(2);
            //leetCodeAllDoc.Remove(2);
            //leetCodeAllDoc.Contains(2);

            ////(706.) Design HashMap (EASY)
            //MyHashMap classLeetCode = new MyHashMap();
            //classLeetCode.Put(1, 1);
            //classLeetCode.Put(2, 2);
            //classLeetCode.Get(1);
            //classLeetCode.Get(3);
            //classLeetCode.Put(2, 1);
            //classLeetCode.Get(2);
            //classLeetCode.Remove(2);
            //classLeetCode.Get(2);

            ////OR
            //MyHashMap1 leetCodeAllDoc = new MyHashMap1();
            //leetCodeAllDoc.Put(1, 1);
            //leetCodeAllDoc.Put(2, 2);
            //leetCodeAllDoc.Get(1);
            //leetCodeAllDoc.Get(3);
            //leetCodeAllDoc.Put(2, 1);
            //leetCodeAllDoc.Get(2);
            //leetCodeAllDoc.Remove(2);
            //leetCodeAllDoc.Get(2);

            ////(709.) To Lower Case (EASY)
            //string s = "LOVELY";

            //LeetCode_709 classLeetCode = new LeetCode_709();
            //Console.WriteLine(classLeetCode.ToLowerCase(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ToLowerCase(s));

            ////(717.) 1-bit and 2-bit Characters 
            //int[] bits = [1, 1, 1, 0];

            //LeetCode_717 classLeetCode = new LeetCode_717();
            //Console.WriteLine(classLeetCode.IsOneBitCharacter(bits));

            ////OR

            //Console.WriteLine(leetCodeAll.IsOneBitCharacter(bits));

            ////(724.) Find Pivot Index (EASY) 
            //    int[] nums = [1, 7, 3, 6, 5, 6];
            //int[] nums = [2, 1, -1];

            //LeetCode_724 classLeetCode = new LeetCode_724();
            //Console.WriteLine(classLeetCode.PivotIndex(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.PivotIndex(nums));

            ////(728.) Self Dividing Numbers (EASY)
            //int left = 1;
            //int right = 22;

            //LeetCode_728 classLeetCode = new LeetCode_728();
            //IList<int> result = classLeetCode.SelfDividingNumbers(left, right);

            //foreach (int i in result) 
            //{
            //    Console.WriteLine(i);
            //}

            //IList<int> result1 = leetCodeAll.SelfDividingNumbers(left, right);

            //foreach (int i in result1)
            //{
            //    Console.WriteLine(i);
            //}

            ////(733.) Flood Fill (EASY)

            //int[][] image = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
            //int sr = 1;
            //int sc = 1;
            //int color = 2;

            //LeetCode_733 classLeetCode = new LeetCode_733();
            //int[][] result = classLeetCode.FloodFill(image, sr, sc, color);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.FloodFill(image, sr, sc, color);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(744.) Find Smallest Letter Greater Than Target (EASY)
            //char[] letters = ['c', 'f', 'j'];
            //char target = 'g';

            //LeetCode_744 classLeetCode = new LeetCode_744();
            //Console.WriteLine(classLeetCode.NextGreatestLetter(letters, target));

            ////OR

            //Console.WriteLine(leetCodeAll.NextGreatestLetter(letters, target));

            ////(746.) Min Cost Climbing Stairs (EASY)
            //int[] cost = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];

            //LeetCode_746 classLeetCode = new LeetCode_746();

            //Console.WriteLine(classLeetCode.MinCostClimbingStairs(cost));

            ////OR

            //Console.WriteLine(leetCodeAll.MinCostClimbingStairs(cost));

            ////(747.) Largest Number At Least Twice of Others (EASY)
            //int[] nums = nums = [3, 6, 5, 0];

            //LeetCode_747 classLeetCode = new LeetCode_747();

            //Console.WriteLine(classLeetCode.DominantIndex(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.DominantIndex(nums));

            ////(748.) Shortest Completing Word (EASY)
            //string licensePlate = "1s3 PSt";
            //string[] words = ["step", "steps", "stripe", "stepple"];

            //LeetCode_748 classLeetCode = new LeetCode_748();
            //Console.WriteLine(classLeetCode.ShortestCompletingWord(licensePlate, words));

            ////OR

            //Console.WriteLine(leetCodeAll.ShortestCompletingWord(licensePlate, words));

            ////(762.) Prime Number of Set Bits in Binary Representation (EASY)
            //int left = 6;
            //int right = 10;

            //LeetCode_762 classLeetCode = new LeetCode_762();

            //Console.WriteLine(classLeetCode.CountPrimeSetBits(left, right));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPrimeSetBits(left, right));

            ////(766.) Toeplitz Matrix (EASY)
            //int[][] matrix = [[1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2]];

            //LeetCode_766 classLeetCode = new LeetCode_766();
            //Console.WriteLine(classLeetCode.IsToeplitzMatrix(matrix));

            ////OR

            //Console.WriteLine(leetCodeAll.IsToeplitzMatrix(matrix));

            ////(771.) Jewels and Stones (EASY)
            //string jewels = "aA";
            //string stones = "aAAbbbb";

            //LeetCode_771 classLeetCode = new LeetCode_771();
            //Console.WriteLine(classLeetCode.NumJewelsInStones(jewels, stones));

            ////OR

            //Console.WriteLine(leetCodeAll.NumJewelsInStones(jewels, stones));

            ////(783.) Minimum Distance Between BST Nodes (EASY)
            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(6);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);

            //LeetCode_783 classLeetCode = new LeetCode_783();

            //Console.WriteLine(classLeetCode.MinDiffInBST(root));

            ////OR

            //Console.WriteLine(leetCodeAll.MinDiffInBST(root));

            ////796. Rotate String (EASY)
            //string s = "bbbacddceeb";
            //string goal = "ceebbbbacdd";

            //LeetCode_796 classLeetCode = new LeetCode_796();
            //Console.WriteLine(classLeetCode.RotateString(s, goal));

            ////OR

            //Console.WriteLine(leetCodeAll.RotateString(s, goal));

            ////(804.) Unique Morse Code Words (EASY)
            //string[] words = ["gin", "zen", "gig", "msg"];

            //LeetCode_804 classLeetCode = new LeetCode_804();
            //Console.WriteLine(classLeetCode.UniqueMorseRepresentations(words));

            ////OR

            //Console.WriteLine(leetCodeAll.UniqueMorseRepresentations(words));

            ////(806.) Number of Lines To Write String (EASY)
            //int[] widths = [10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10];
            //string s = "abcdefghijklmnopqrstuvwxyz";

            //LeetCode_806 classLeetCode = new LeetCode_806();
            //Console.WriteLine(string.Join(',',classLeetCode.NumberOfLines(widths, s)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.NumberOfLines(widths, s)));

            ////(812.) Largest Triangle Area (EASY)
            //int[][] points = [[8, 3], [5, 6], [3, 5]];

            //LeetCode_812 classLeetCode = new LeetCode_812();
            //Console.WriteLine(classLeetCode.LargestTriangleArea(points));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestTriangleArea(points));

            //////(819.) Most Common Word (EASY)
            //string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            //string[] banned = ["hit"];

            //LeetCode_819 classLeetCode = new LeetCode_819();
            //Console.WriteLine(classLeetCode.MostCommonWord(paragraph, banned));

            ////OR

            //Console.WriteLine(leetCodeAll.MostCommonWord(paragraph, banned));

            ////(821.) Shortest Distance to a Character (EASY)
            //string s = "loveleetcode";
            //char c = 'e';

            //LeetCode_821 classLeetCode = new LeetCode_821();
            //Console.WriteLine(string.Join(',', classLeetCode.ShortestToChar(s, c)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ShortestToChar(s, c)));

            ////(824.) Goat Latin (EASY)
            //string sentence = "I speak Goat Latin";

            //LeetCode_824 classLeetCode = new LeetCode_824();
            //Console.WriteLine(classLeetCode.ToGoatLatin(sentence));

            ////OR

            //Console.WriteLine(leetCodeAll.ToGoatLatin(sentence));

            ////(830.) Positions of Large Groups (EASY)
            //string s = "abcdddeeeeaabbbcd";

            //LeetCode_830 classLeetCode = new LeetCode_830();
            //IList<IList<int>> result = classLeetCode.LargeGroupPositions(s);

            //foreach (IList<int> list in result)
            //{
            //    Console.WriteLine(string.Join(',', list));
            //}

            ////OR

            //IList<IList<int>> result1 = leetCodeAll.LargeGroupPositions(s);

            //foreach(IList<int> list in result1)
            //{
            //    Console.WriteLine(string.Join(',', list));
            //}

            ////(832.) Flipping an Image (EASY)
            //int[][] image = [[1, 1, 0], [1, 0, 1], [0, 0, 0]];

            //LeetCode_832 classLeetCode = new LeetCode_832();

            //int[][] result = classLeetCode.FlipAndInvertImage(image);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            //////OR

            //int[][] result1 = leetCodeAll.FlipAndInvertImage(image);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(836.) Rectangle Overlap (EASY)
            //int[] rec1 = [0, 0, 2, 2];
            //int[] rec2 = [1, 1, 3, 3];

            //LeetCode_836 classLeetCode = new LeetCode_836();
            //Console.WriteLine(classLeetCode.IsRectangleOverlap(rec1, rec2));

            ////OR

            //Console.WriteLine(leetCodeAll.IsRectangleOverlap(rec1,rec2));

            ////(844.) Backspace String Compare (EASY)
            //string s = "ab##";
            //string t = "c#d#";

            //LeetCode_844 classLeetCode = new LeetCode_844();
            //Console.WriteLine(classLeetCode.BackspaceCompare(s, t));

            ////OR

            //Console.WriteLine(leetCodeAll.BackspaceCompare(s, t));

            ////(859.) Buddy Strings (EASY)
            //string s = "ab";
            //string goal = "ab";

            //LeetCode_859 classLeetCode = new LeetCode_859();
            //Console.WriteLine(classLeetCode.BuddyStrings(s, goal));

            ////OR

            //Console.WriteLine(leetCodeAll.BuddyStrings(s, goal));

            ////(860.) Lemonade Change (EASY)
            //int[] bills = [5, 5, 5, 5, 10, 5, 10, 10, 10, 20];


            //LeetCode_860 classLeetCode = new LeetCode_860();
            //Console.WriteLine(classLeetCode.LemonadeChange(bills));

            ////OR

            //Console.WriteLine(leetCodeAll.LemonadeChange(bills));

            ////(867.) Transpose Matrix (EASY)
            int[][] matrix = [[1, 2, 3], [4, 5, 6]];

            LeetCode_867 classLeetCode = new LeetCode_867();

            int[][] result = classLeetCode.Transpose(matrix);

            foreach (var item in result)
            {
                Console.WriteLine(string.Join(',', item));
            }

            //OR

            int[][] result1 = classLeetCode.Transpose(matrix);

            foreach (var item in result1) 
            {
                Console.WriteLine(string.Join(',', item));
            }













































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
