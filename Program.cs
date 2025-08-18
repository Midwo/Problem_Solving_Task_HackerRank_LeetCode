using Newtonsoft.Json;
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
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static ProblemSolving.LeetCode.LeetCode_225;
using static ProblemSolving.LeetCode.LeetCode_232;
using static ProblemSolving.LeetCode.LeetCode_303;
using static ProblemSolving.LeetCode.LeetCode_380;
using static ProblemSolving.LeetCode.LeetCode_703;
using static ProblemSolving.LeetCode.LeetCode_705;
using static ProblemSolving.LeetCode.LeetCode_706;
using static ProblemSolving.LeetCode.LeetCode_933;
using static ProblemSolving.LeetCodeAll;
using static System.Net.Mime.MediaTypeNames;
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

            ////(36.) Valid Sudoku (MEDIUM)
            //char[][] board = [['5','3','.','.','7','.','.','.','.']
            //                 ,['6','.','.','1','9','5','.','.','.']
            //                 ,['.','9','8','.','.','.','.','6','.']
            //                 ,['8','.','.','.','6','.','.','.','3']
            //                 ,['4','.','.','8','.','3','.','.','1']
            //                 ,['7','.','.','.','2','.','.','.','6']
            //                 ,['.','6','.','.','.','.','2','8','.']
            //                 ,['.','.','.','4','1','9','.','.','5']
            //                 ,['.','.','.','.','8','.','.','7','9']];

            //LeetCode_36 classLeetCode = new LeetCode_36();
            //Console.WriteLine(classLeetCode.IsValidSudoku(board));

            ////OR

            //Console.WriteLine(leetCodeAll.IsValidSudoku(board));

            ////(45.) Jump Game II (MEDIUM)
            //int[] nums = [2, 3, 1, 1, 4];

            //LeetCode_45 classLeetCode = new LeetCode_45();
            //Console.WriteLine(classLeetCode.Jump(nums));

            ////OR

            //Console.WriteLine(classLeetCode.Jump(nums));

            ////(48.) Rotate Image (MEDIUM)
            //int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            //LeetCode_48 classLeetCode = new LeetCode_48();
            //classLeetCode.Rotate(matrix);

            ////OR

            //leetCodeAll.Rotate(matrix);

            ////(49.) Group Anagrams (MEDIUM)
            //string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

            //LeetCode_49 classLeetCode = new LeetCode_49();
            //IList<IList<string>> result = classLeetCode.GroupAnagrams(strs);

            //foreach (List<string> str in result) 
            //{
            //    Console.WriteLine(string.Join(',', str));
            //}

            ////OR

            //IList<IList<string>> result1 = classLeetCode.GroupAnagrams(strs);
            //foreach (List<string> str in result1)
            //{
            //    Console.WriteLine(string.Join(',', str));
            //}

            ////(54.) Spiral Matrix (MEDIUM)
            //int[][] matrix = [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15]];

            //LeetCode_54 classLeetCode = new LeetCode_54();
            //Console.WriteLine(string.Join(',', classLeetCode.SpiralOrder(matrix)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SpiralOrder(matrix)));

            ////(55.) Jump Game (MEDIUM)
            //int[] nums = [2, 3, 1, 1, 4];

            //LeetCode_55 classLeetCode = new LeetCode_55();
            //Console.WriteLine(classLeetCode.CanJump(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CanJump(nums));

            ////(58.) Lenght of Last Word (EASY)
            //Console.WriteLine(leetCodeAll.LengthOfLastWord(" fly me   to   the moon  "));

            ////(63.) Unique Paths II (MEDIUM)
            //int[][] obstacleGrid = [[0, 1, 0, 0]];

            //LeetCode_63 classLeetCode = new LeetCode_63();
            //Console.WriteLine(classLeetCode.UniquePathsWithObstacles(obstacleGrid));

            ////OR

            //Console.WriteLine(leetCodeAll.UniquePathsWithObstacles(obstacleGrid));


            ////(64.) Minimum Path Sum (MEDIUM)
            //int[][] grid = [[1, 3, 1], [1, 5, 1], [4, 2, 1]];

            //LeetCode_64 classLeetCode = new LeetCode_64();
            //Console.WriteLine(classLeetCode.MinPathSum(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.MinPathSum(grid));

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

            ////(71.) Simplify Path (MEDIUM)
            //string path = "/.hidden";

            //LeetCode_71 classLeetCode = new LeetCode_71();
            //Console.WriteLine(classLeetCode.SimplifyPath(path));

            ////OR

            //Console.WriteLine(leetCodeAll.SimplifyPath(path));

            ////(72.) Edit Distance (MEDIUM)
            //string word1 = "zoologicoarchaeologist";
            //string word2 = "zoogeologist";

            //LeetCode_72 classLeetCode = new LeetCode_72();
            //Console.WriteLine(classLeetCode.MinDistance(word1, word2));

            ////OR

            //Console.WriteLine(leetCodeAll.MinDistance(word1, word2));

            ////(73.) Set Matrix Zeroes (MEDIUM)
            //int[][] matrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];

            //LeetCode_73 classLeetCode = new LeetCode_73();
            //classLeetCode.SetZeroes(matrix);

            ////OR

            //classLeetCode.SetZeroes(matrix);

            ////(76.) Minimum Window Substring (HARD)
            //string s = "ADOBECODEBANC";
            //string t = "ABC";

            //LeetCode_76 classLeetCode = new LeetCode_76();
            //Console.WriteLine(classLeetCode.MinWindow(s, t));

            ////OR

            //Console.WriteLine(leetCodeAll.MinWindow(s, t));

            ////(80.) Remove Duplicates from Sorted Array II  (MEDIUM)
            //int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];

            //LeetCode_80 classLeetCode = new LeetCode_80();
            //Console.WriteLine(classLeetCode.RemoveDuplicates(nums));

            ////OR
            //Console.WriteLine(leetCodeAll.RemoveDuplicatesTask80(nums));

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

            ////(97.) Interleaving String (MEDIUM)
            //string s1 = "aabcc";
            //string s2 = "dbbca";
            //string s3 = "aadbbcbcac";

            //LeetCode_97 classLeetCode = new LeetCode_97();
            //Console.WriteLine(classLeetCode.IsInterleave(s1, s2, s3));

            ////OR

            //Console.WriteLine(leetCodeAll.IsInterleave(s1, s2, s3));

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

            ////(120.) Triangle (MEDIUM)
            //IList<IList<int>> triangle = [[-1], [3, 2], [-3, 1, -1]];

            //LeetCode_120 classLeetCode = new LeetCode_120();
            //Console.WriteLine(classLeetCode.MinimumTotal(triangle));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumTotal(triangle));

            ////(121.) Best Time to Boy and Sell Stock (EASY)
            //int[] prices = [7, 1, 5, 3, 6, 4];
            //Console.WriteLine(leetCodeAll.MaxProfit(prices));

            ////(122.) Best Time to Buy and Sell Stock II (MEDIUM)
            //int[] prices = [7, 1, 5, 3, 6, 4];

            //LeetCode_122 classLeetCode = new LeetCode_122();
            //Console.WriteLine(classLeetCode.MaxProfit(prices));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxProfitTask122(prices));

            ////(123.) Best Time to Buy and Sell Stock III (HARD)
            //int[] prices = [3, 3, 5, 0, 0, 3, 1, 4];

            //LeetCode_123 classLeetCode = new LeetCode_123();
            //Console.WriteLine(classLeetCode.MaxProfit(prices));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxProfitTask123(prices));

            ////(125.) Valid Palindrome (EASY)
            //string s = "A man, a plan, a canal: Panama";
            //Console.WriteLine(leetCodeAll.IsPalindrome(s));

            ////(134.) Gas Station (MEDIUM)
            //int[] gas = [2, 0, 1, 2, 3, 4, 0];
            //int[] cost = [0, 1, 0, 0, 0, 0, 11];

            //LeetCode_134 classLeetCode = new LeetCode_134();
            //Console.WriteLine(classLeetCode.CanCompleteCircuit(gas, cost));

            ////OR

            //Console.WriteLine(classLeetCode.CanCompleteCircuit(gas, cost));

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

            ////(146.) LRU Cache (MEDIUM)
            //LeetCode_146.LRUCache lRUCache = new LeetCode_146.LRUCache(2);
            //lRUCache.Get(2);
            //lRUCache.Put(2, 6);
            //lRUCache.Get(1);
            //lRUCache.Put(1, 5);
            //lRUCache.Put(1, 2);
            //lRUCache.Get(1);
            //lRUCache.Get(2);

            ////OR

            //LRUCache lRUCache1 = new LRUCache(2);
            //lRUCache1.Get(2);
            //lRUCache1.Put(2, 6);
            //lRUCache1.Get(1);
            //lRUCache1.Put(1, 5);
            //lRUCache1.Put(1, 2);
            //lRUCache1.Get(1);
            //lRUCache1.Get(2);

            //////(151.) Reverse Words in a String (MEDIUM)
            //string s = "a good   example";

            //LeetCode_151 classLeetCode = new LeetCode_151();
            //Console.WriteLine(classLeetCode.ReverseWords(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ReverseWordsTask151(s));

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

            ////(167.) Two Sum II - Input Array Is Sorted (MEDIUM)
            //int[] numbers = [2, 7, 11, 15];
            //int target = 9;

            //LeetCode_167 classLeetCode = new LeetCode_167();
            //Console.WriteLine(string.Join(" ", classLeetCode.TwoSum(numbers, target)));

            ////OR

            //Console.WriteLine(string.Join(" ", leetCodeAll.TwoSumTask167(numbers, target)));

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

            ////(176.) Second Highest Salary (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.employee_id
            //        --    a.name, 
            //        --    a.manager_id, 
            //        --    a.salary,
            //        --    b.employee_id 
            //        From Employees as a 
            //        Left join Employees b
            //        ON a.manager_id = b.employee_id 
            //        Where a.salary < 30000 and  b.employee_id is null and a.manager_id is not null
            //        order by a.employee_id
            //    ";

            ////OR
            //LeetCode_176 classLeetCode = new LeetCode_176();

            ////(180.) Consecutive Numbers (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            distinct a.num as ConsecutiveNums 
            //        From
            //        (
            //            Select
            //                id,
            //                num,
            //                LAG(num)
            //                OVER (ORDER BY [id]) AS PrevNum,
            //                LEAD(num) 
            //                OVER (ORDER BY [id]) AS NextNum
            //            From Logs 
            //        ) a
            //        where a.num = a.PrevNum and a.num = a.NextNum
            //    ";

            ////OR

            //LeetCode_180 classLeetCode = new LeetCode_180();

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

            ////(185.) Department Top Three Salaries (HARD)
            //string SqlQuery =
            //    @"
            //         Select 
            //             b.Name as Department,
            //             a.Name as Employee,
            //             a.Salary
            //         From 
            //         (
            //             Select
            //                 id,
            //                 name,
            //                 salary,
            //                 departmentId,
            //                 Dense_Rank() OVER (PARTITION BY departmentId ORDER BY [salary] desc) as Rank
            //             From Employee
            //         ) a
            //         left join Department as b
            //         On a.departmentId = b.id
            //         Where a.Rank < 4
            //    ";

            ////OR
            //LeetCode_185 classLeetCode = new LeetCode_185();

            ////(189.) Rotate Array (MEDIUM)
            //int[] nums = [1, 2, 3, 4, 5, 6, 7];
            //int k = 3;

            //LeetCode_189 classLeetCode = new LeetCode_189();
            //classLeetCode.Rotate(nums, k);

            ////OR

            //leetCodeAll.Rotate(nums, k);

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

            ////(198.) House Robber (MEDIUM)
            //int[] nums = [2, 1, 1, 2];

            //LeetCode_198 classLeetCode = new LeetCode_198();
            //Console.WriteLine(classLeetCode.Rob(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.Rob(nums));

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

            ////(209.) Minimum Size Subarray Sum (MEDIUM)
            //int target = 7;
            //int[] nums = [5];

            //LeetCode_209 classLeetCode = new LeetCode_209();
            //Console.WriteLine(classLeetCode.MinSubArrayLen(target, nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinSubArrayLen(target, nums));

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

            ////(128.) Longest Consecutive Sequence (MEDIUM)
            //int[] nums = [100, 4, 200, 1, 3, 2];

            //LeetCode_128 classLeetCode = new LeetCode_128();
            //Console.WriteLine(classLeetCode.LongestConsecutive(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestConsecutive(nums));

            ////(215.) Kth Largest Element in an Array (MEDIUM)
            //int[] nums = [3, 2, 1, 5, 6, 4];
            //int k = 2;

            //LeetCode_215 classLeetCode = new LeetCode_215();
            //Console.WriteLine(classLeetCode.FindKthLargest(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.FindKthLargest(nums, k));

            ////(221.) Maximal Square (MEDIUM)
            ////char[][] matrix = [['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']];

            ////char[][] matrix = [['1', '1', '1', '1', '0'], ['1', '1', '1', '1', '0'], ['1', '1', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['0', '0', '1', '1', '1']];

            ////char[][] matrix = 
            ////    [
            ////        ['1', '0', '1', '0', '0', '1', '1', '1', '0'],
            ////        ['1', '1', '1', '0', '0', '0', '0', '0', '1'],
            ////        ['0', '0', '1', '1', '0', '0', '0', '1', '1'],
            ////        ['0', '1', '1', '0', '0', '1', '0', '0', '1'],
            ////        ['1', '1', '0', '1', '1', '0', '0', '1', '0'],
            ////        ['0', '1', '1', '1', '1', '1', '1', '0', '1'],
            ////        ['1', '0', '1', '1', '1', '0', '0', '1', '0'],
            ////        ['1', '1', '1', '0', '1', '0', '0', '0', '1'],
            ////        ['0', '1', '1', '1', '1', '0', '0', '1', '0'],
            ////        ['1', '0', '0', '1', '1', '1', '0', '0', '0']
            ////    ];

            //char[][] matrix =
            //    [
            //        ['1','1','1','1','1','1','1','1'],
            //        ['1','1','1','1','1','1','1','0'],
            //        ['1','1','1','1','1','1','1','0'],
            //        ['1','1','1','1','1','0','0','0'],
            //        ['0','1','1','1','1','0','0','0']
            //    ];

            //LeetCode_221 classLeetCode = new LeetCode_221();
            //Console.WriteLine(classLeetCode.MaximalSquare(matrix));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximalSquare(matrix));

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

            //(231.) Power of Two (EASY)
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

            ////(238.) Product of Array Except Self (MEDIUM)
            //int[] nums = [1, 2  , 3 ,  4];

            //LeetCode_238 classLeetCode = new LeetCode_238();
            //Console.WriteLine(string.Join(',', classLeetCode.ProductExceptSelf(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ProductExceptSelf(nums)));

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

            ////(274.) H-Index (MEDIUM)
            //int[] citations = [0, 0, 2];

            //LeetCode_274 classLeetCode = new LeetCode_274();
            //Console.WriteLine(classLeetCode.HIndex(citations));

            ////OR

            //Console.WriteLine(leetCodeAll.HIndex(citations));

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

            ////(289.) Game of Life (MEDIUM)
            //int[][] board = [[0, 1]];

            //LeetCode_289 classLeetCode = new LeetCode_289();
            //classLeetCode.GameOfLife(board);

            ////OR

            //leetCodeAll.GameOfLife(board);

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

            ////(322.) Coin Change (MEDIUM)
            //int[] coins = [1, 2, 5];
            //int amount = 11;

            //LeetCode_322 classLeetCode = new LeetCode_322();
            //Console.WriteLine(classLeetCode.CoinChange(coins, amount));

            ////OR

            //Console.WriteLine(leetCodeAll.CoinChange(coins, amount));

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

            ////(380.) Insert Delete GetRandom O(1) (MEDIUM)
            //LeetCode_380.RandomizedSet randomizedSet1 = new RandomizedSet();
            //randomizedSet1.Insert(1); 
            //randomizedSet1.Remove(2);
            //randomizedSet1.Insert(2);
            //randomizedSet1.GetRandom();
            //randomizedSet1.Remove(1);
            //randomizedSet1.Insert(2); 
            //randomizedSet1.GetRandom();

            ////OR

            //RandomizedSetTask380 randomizedSet2 = new RandomizedSetTask380();
            //randomizedSet2.Insert(1);
            //randomizedSet2.Remove(2);
            //randomizedSet2.Insert(2);
            //randomizedSet2.GetRandom();
            //randomizedSet2.Remove(1);
            //randomizedSet2.Insert(2);
            //randomizedSet2.GetRandom();

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

            ////(550.) Game Play Analysis IV (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            Round(Count(b.player_id)*1.0/(Select Count(distinct player_id) from Activity),2) as fraction 
            //        From
            //        (
            //            Select     
            //                a.player_id, 
            //                a.event_date,
            //                a.Row_numberResult
            //            From 
            //            (
            //                Select 
            //                    player_id, 
            //                    event_date,
            //                    Row_number () OVER (PARTITION BY player_id ORDER BY event_date) as Row_numberResult
            //                From Activity
            //            ) as a
            //            Where a.Row_numberResult = 1
            //        ) b
            //        left join 
            //        (
            //            Select     
            //                a.player_id, 
            //                a.event_date,
            //                a.Row_numberResult
            //            From 
            //            (
            //                Select 
            //                    player_id, 
            //                    event_date,
            //                    Row_number () OVER (PARTITION BY player_id ORDER BY event_date) as Row_numberResult
            //                From Activity
            //            ) as a
            //            Where a.Row_numberResult = 2
            //        ) c
            //        ON b.player_id = c.player_id
            //        Where DateDiff(day, b.event_date, c.event_date) = 1
            //    ";

            ////OR
            //LeetCode_550 classLeetCode = new LeetCode_550();

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

            ////(570.) Managers with at Least 5 Direct Reports (Medium)
            //string SqlQuery =
            //    @"
            //        With CTE AS 
            //        (
            //            Select
            //                managerId
            //            From Employee
            //            GROUP BY managerId
            //            HAVING Count(*) >= 5
            //        )

            //        Select 
            //            a.name
            //        From Employee as a
            //        Where ID in (Select managerId From CTE)
            //    ";

            ////OR
            //LeetCode_570 classLeetCode = new LeetCode_570();

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

            ////(585.) Investments in 2016 (MEDIUM)
            //string SqlQuery =
            //    @"
            //         Select 
            //             ROUND(SUM(a.tiv_2016), 2) as tiv_2016 
            //         From
            //         (
            //             Select 
            //                 tiv_2016,
            //                 CONCAT(lat, lon) as latlon
            //             From Insurance
            //             Where tiv_2015 in 
            //                 (
            //                     Select
            //                         tiv_2015
            //                         --Count(*) as howMany
            //                     From Insurance 
            //                     Group by tiv_2015
            //                     Having Count(*) > 1
            //                 )
            //         ) a
            //         Where a.latlon in 
            //         (
            //             Select
            //                 b.latlon
            //                 --Count(*)
            //             From
            //             (
            //                 Select 
            //                     CONCAT(lat, lon) as latlon
            //                 From Insurance 
            //             ) b
            //             Group by b.latlon
            //             Having Count(*) = 1
            //         )
            //    ";

            ////OR
            //LeetCode_585 classLeetCode = new LeetCode_585();

            ////(586.) Customer Placing the Largest Number of Orders (EASY)
            //LeetCode_586 classLeetCode = new LeetCode_586();
            //////OR
            //leetCodeAll.LeetCode_586();

            ////(590.) N-ary Tree Postorder Traversal (EASY)


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

            ////(602.) Friend Requests II: Who Has the Most Friends (MEDIUM)
            //string SqlQuery =
            //    @"
            //          With CTE AS
            //          (
            //              Select
            //                  a.id,
            //                  IIF(b.howMany is null, 0, b.howMany)+IIF(c.howMany is null, 0, c.howMany) as num
            //              From
            //              (
            //                  Select
            //                      distinct requester_id as id
            //                  From RequestAccepted 
            //                  UNION 
            //                  Select
            //                      distinct accepter_id  as id
            //                  From RequestAccepted
            //              ) a
            //              left join 
            //              (
            //                  Select
            //                      accepter_id,
            //                      count(*) as howMany
            //                  From RequestAccepted 
            //                  Group by accepter_id
            //              ) b
            //              ON a.id = b.accepter_id
            //              left join 
            //              (
            //                  Select
            //                      requester_id,
            //                      count(*) as howMany
            //                  From RequestAccepted 
            //                  Group by requester_id
            //              ) c 
            //              ON a.id = c.requester_id
            //          )

            //          Select top 1
            //              id,
            //              num
            //          From CTE
            //          Order by num desc
            //    ";

            ////OR

            //LeetCode_602 classLeetCode = new LeetCode_602();

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

            ////(626.) Exchange Seats (MEDIUM)
            //string SqlQuery =
            //    @"
            //         Select
            //             id,
            //             IIF(id % 2 = 0, 
            //         LAG(student, 1, student) OVER (order by id), 
            //         LEAD(student, 1, student) OVER (order by id)
            //             ) as student 
            //         From Seat 
            //    ";

            ////OR

            //LeetCode_626 classLeetCode = new LeetCode_626();

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

            ////(637.) Average of Levels in Binary Tree (EASY)
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);

            //LeetCode_637 classLeetCode = new LeetCode_637();
            //IList<double> result = classLeetCode.AverageOfLevels(root);

            //Console.WriteLine(string.Join(',', result));

            ////OR

            //IList<double> result1 = classLeetCode.AverageOfLevels(root);

            //Console.WriteLine(string.Join(',', result1));

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

            ////(808.) Soup Servings (MEDIUM)
            //int n = 100;

            //LeetCode_808 classLeetCode = new LeetCode_808();
            //Console.WriteLine(classLeetCode.SoupServings(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SoupServings(n));

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
            //int[][] matrix = [[1, 2, 3], [4, 5, 6]];

            //LeetCode_867 classLeetCode = new LeetCode_867();

            //int[][] result = classLeetCode.Transpose(matrix);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = classLeetCode.Transpose(matrix);

            //foreach (var item in result1) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(868.) Binary Gap (EASY)
            //int n = 22;

            //LeetCode_868 classLeetCode = new LeetCode_868();
            //Console.WriteLine(classLeetCode.BinaryGap(n));

            ////OR

            //Console.WriteLine(leetCodeAll.BinaryGap(n));

            ////(872.) Leaf-Similar Trees (EASY)
            //TreeNode root1 = new TreeNode(3);
            //root1.left = new TreeNode(5);
            //root1.left.left = new TreeNode(6);
            //root1.left.right = new TreeNode(2);
            //root1.left.right.left = new TreeNode(7);
            //root1.left.right.right = new TreeNode(4);
            //root1.right = new TreeNode(1);
            //root1.right.left = new TreeNode(9);
            //root1.right.right = new TreeNode(8);

            //TreeNode root2 = new TreeNode(3);
            //root2.left = new TreeNode(5);
            //root2.left.left = new TreeNode(6);
            //root2.left.right = new TreeNode(7);
            //root2.right = new TreeNode(1);
            //root2.right.left = new TreeNode(4);
            //root2.right.right = new TreeNode(2);
            //root2.right.right.left = new TreeNode(9);
            //root2.right.right.right =new TreeNode(8);

            //LeetCode_872 classLeetCode = new LeetCode_872();

            //Console.WriteLine(classLeetCode.LeafSimilar(root1, root2));

            ////OR

            //Console.WriteLine(leetCodeAll.LeafSimilar(root1, root2));

            ////(876.) Middle of the Linked List (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next = new ListNode(6);

            //LeetCode_876 classLeetCode = new LeetCode_876();

            //ListNode result = classLeetCode.MiddleNode(head);

            //while (result != null) 
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            //ListNode result1 = leetCodeAll.MiddleNode(head);

            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(883.) Projection Area of 3D Shapes (EASY)
            //int[][] grid = [[1, 2], [3, 4]];

            //LeetCode_883 classLeetCode = new LeetCode_883();

            //Console.WriteLine(classLeetCode.ProjectionArea(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.ProjectionArea(grid));

            ////(884.) Uncommon Words from Two Sentences (EASY)
            //string s1 = "this apple is sweet";
            //string s2 = "this apple is sour";

            //LeetCode_884 classLeetCode = new LeetCode_884();
            //Console.WriteLine(string.Join(',', classLeetCode.UncommonFromSentences(s1, s2)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.UncommonFromSentences(s1, s2)));

            ////(888.) Fair Candy Swap (EASY)
            //int[] aliceSizes = [1, 2, 5];
            //int[] bobSizes = [2, 4];

            //LeetCode_888 classLeetCode = new LeetCode_888();
            //Console.WriteLine(string.Join(',', classLeetCode.FairCandySwap(aliceSizes, bobSizes)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FairCandySwap(aliceSizes, bobSizes)));

            ////(869.) Reordered Power of 2 (MEDIUM)
            //int n = 111;

            //LeetCode_869 classLeetCode = new LeetCode_869();
            //Console.WriteLine(classLeetCode.ReorderedPowerOf2(n));

            ////OR

            //Console.WriteLine(leetCodeAll.ReorderedPowerOf2(n));

            ////(892.) Surface Area of 3D Shapes (EASY)
            //int[][] grid = [[1, 2], [3, 4]];

            //LeetCode_892 classLeetCode = new LeetCode_892();
            //Console.WriteLine(classLeetCode.SurfaceArea(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.SurfaceArea(grid));

            ////(896.) Monotonic Array (EASY)
            //int[] nums = [1, 3, 2];

            //LeetCode_896 classLeetCode = new LeetCode_896();
            //Console.WriteLine(classLeetCode.IsMonotonic(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.IsMonotonic(nums));

            ////(897.) Increasing Order Search Tree (EASY)
            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(3);
            //root.right = new TreeNode(6);
            //root.left.left = new TreeNode(2);
            //root.left.right = new TreeNode(4);
            //root.left.left.left = new TreeNode(1);
            //root.right.right = new TreeNode(8);
            //root.right.right.left = new TreeNode(7);
            //root.right.right.right = new TreeNode(9);

            //LeetCode_897 classLeetCode = new LeetCode_897();
            //TreeNode result = classLeetCode.IncreasingBST(root);

            ////(898.) Bitwise ORs of Subarrays (MEDIUM) 
            //int[] arr = [1, 1, 2];

            //LeetCode_898 classLeetCode = new LeetCode_898();
            //Console.WriteLine(classLeetCode.SubarrayBitwiseORs(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.SubarrayBitwiseORs(arr));

            ////(904.) Fruit Into Baskets (MEDIUM)
            //int[] fruits = [0, 1, 1, 5, 1, 5, 5, 1, 5, 5, 1, 5, 11, 5, 11, 11, 5, 5, 11, 5, 11, 11, 11, 11, 11, 11, 22, 11, 11, 11];

            //LeetCode_904 classLeetCode = new LeetCode_904();
            //Console.WriteLine(classLeetCode.TotalFruit(fruits));

            ////OR

            //Console.WriteLine(leetCodeAll.TotalFruit(fruits));

            ////(905.) Sort Array By Parity (EASY)
            //int[] nums = [3, 1, 2, 4];

            //LeetCode_905 classLeetCode = new LeetCode_905();
            //Console.WriteLine(string.Join(',', classLeetCode.SortArrayByParity(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortArrayByParity(nums)));

            ////(908.) Smallest Range I (EASY)
            //int[] nums = [1, 3, 6];
            //int k = 3;

            //LeetCode_908 classLeetCode = new LeetCode_908();
            //Console.WriteLine(classLeetCode.SmallestRangeI(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestRangeI(nums, k));


            ////(914.) X of a Kind in a Deck of Cards (EASY)
            //int[] deck = [1, 2, 3, 4, 4, 3, 2, 1];

            //LeetCode_914 classLeetCode = new LeetCode_914();
            //Console.WriteLine(classLeetCode.HasGroupsSizeX(deck));

            ////OR

            //Console.WriteLine(leetCodeAll.HasGroupsSizeX(deck));

            ////(917.) Reverse Only Letters (EASY)
            //string s = "Test1ng-Leet=code-Q!";

            //LeetCode_917 classLeetCode = new LeetCode_917();
            //Console.WriteLine(classLeetCode.ReverseOnlyLetters(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ReverseOnlyLetters(s));

            ////(922.) Sort Array By Parity II (EASY)
            //int[] nums = [4, 2, 5, 7];

            //LeetCode_922 classLeetCode = new LeetCode_922();
            //Console.WriteLine(string.Join(',', classLeetCode.SortArrayByParityII(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortArrayByParityII(nums)));

            ////(925.) Long Pressed Name (EASY)
            //string name = "alex";
            //string typed = "aaleex";

            //LeetCode_925 classLeetCode = new LeetCode_925();
            //Console.WriteLine(classLeetCode.IsLongPressedName(name, typed));

            ////OR

            //Console.WriteLine(leetCodeAll.IsLongPressedName(name, typed));

            ////(929.) Unique Email Addresses (EASY)
            //string[] emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"];

            //LeetCode_929 classLeetCode = new LeetCode_929();
            //Console.WriteLine(classLeetCode.NumUniqueEmails(emails));

            ////OR

            //Console.WriteLine(leetCodeAll.NumUniqueEmails(emails));

            ////(933.) Number of Recent Calls (EASY)

            //RecentCounter recentCounter = new RecentCounter();
            //Console.WriteLine(recentCounter.Ping(1));
            //Console.WriteLine(recentCounter.Ping(100));
            //Console.WriteLine(recentCounter.Ping(3001));
            //Console.WriteLine(recentCounter.Ping(3002));

            ////OR

            //RecentCounter933 recentCounter1 = new RecentCounter933();
            //Console.WriteLine(recentCounter1.Ping(1));
            //Console.WriteLine(recentCounter1.Ping(100));
            //Console.WriteLine(recentCounter1.Ping(3001));
            //Console.WriteLine(recentCounter1.Ping(3002));

            ////(941.) Valid Mountain Array (EASY)
            //int[] arr = [0, 3, 2, 1];

            //LeetCode_941 classLeetCode = new LeetCode_941();
            //Console.WriteLine(classLeetCode.ValidMountainArray(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.ValidMountainArray(arr));

            ////(942.) DI String Match (EASY)
            //string s = "IDID";

            //LeetCode_942 classLeetCode = new LeetCode_942();
            //Console.WriteLine(string.Join(',',classLeetCode.DiStringMatch(s)));

            ////OR

            //Console.WriteLine(string.Join(',', classLeetCode.DiStringMatch(s)));

            ////(944.) Delete Columns to Make Sorted (EASY)
            //string[] strs = ["zyx", "wvu", "tsr"];

            //LeetCode_944 classLeetCode = new LeetCode_944();
            //Console.WriteLine(classLeetCode.MinDeletionSize(strs));

            ////OR

            //Console.WriteLine(leetCodeAll.MinDeletionSize(strs));

            ////(953.) Verifying an Alien Dictionary (EASY)
            //string[] words = ["hello", "leetcode"];
            //string order = "hlabcdefgijkmnopqrstuvwxyz";

            //LeetCode_953 classLeetCode = new LeetCode_953();
            //Console.WriteLine(classLeetCode.IsAlienSorted(words, order));

            ////OR

            //Console.WriteLine(leetCodeAll.IsAlienSorted(words, order));

            ////(961.) N-Repeated Element in Size 2N Array (EASY)
            //int[] nums = [5, 1, 5, 2, 5, 3, 5, 4];

            //LeetCode_961 classLeetCode = new LeetCode_961();
            //Console.WriteLine(classLeetCode.RepeatedNTimes(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.RepeatedNTimes(nums));

            ////(965.) Univalued Binary Tree (EASY)
            //TreeNode root = new TreeNode(2);
            //root.right = new TreeNode(2);
            //root.left = new TreeNode(2);
            //root.left.right = new TreeNode(2);
            //root.left.left = new TreeNode(5);

            //LeetCode_965 classLeetCode = new LeetCode_965();
            //Console.WriteLine(classLeetCode.IsUnivalTree(root));

            ////OR

            //Console.WriteLine(leetCodeAll.IsUnivalTree(root));

            ////(976.) Largest Perimeter Triangle (EASY)
            //int[] nums = [2, 1, 2];

            //LeetCode_976 classLeetCode = new LeetCode_976();
            //Console.WriteLine(classLeetCode.LargestPerimeter(nums));

            ////OR 

            //Console.WriteLine(leetCodeAll.LargestPerimeter(nums));

            ////(977.) Squares of a Sorted Array (EASY)
            //int[] nums = [-4, -1, 0, 3, 10];

            //LeetCode_977 classLeetCode = new LeetCode_977();
            //Console.WriteLine(string.Join(',', classLeetCode.SortedSquares(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortedSquares(nums)));

            ////(989.) Add to Array-Form of Integer (EASY)
            //int[] num = [1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3];
            //int k = 516;

            //LeetCode_989 classLeetCode = new LeetCode_989();
            //Console.WriteLine(string.Join(',', classLeetCode.AddToArrayForm(num, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.AddToArrayForm(num, k)));

            ///(997.) Find the Town Judge (EASY)
            //int n = 3;
            //int[][] trust = [[1, 2], [2, 3]];

            //LeetCode_997 classLeetCode = new LeetCode_997();
            //Console.WriteLine(classLeetCode.FindJudge(n, trust));

            ////OR

            //Console.WriteLine(leetCodeAll.FindJudge(n, trust));

            ////(999.) Available Captures for Rook (EASY)

            //char[][] board = [['.','.','.','.','.','.','.','.'],
            //                  ['p','.','.','p','.','.','.','p'],
            //                  ['p','p','.','.','.','.','p','p'],
            //                  ['p','p','p','.','R','p','p','p'],
            //                  ['p','p','.','.','.','.','p','p'],
            //                  ['p','.','.','p','.','.','.','p'],
            //                  ['.','.','.','.','.','.','.','.'],
            //                  ['.','.','.','.','.','.','.','.']];

            //LeetCode_999 classLeetCode = new LeetCode_999();
            //Console.WriteLine(classLeetCode.NumRookCaptures(board));

            ////OR

            //Console.WriteLine(leetCodeAll.NumRookCaptures(board));

            /////(1002.) Find Common Characters (EASY)
            //string[] words = ["bella", "label", "roller"];

            //LeetCode_1002 classLeetCode = new LeetCode_1002();
            //Console.WriteLine(string.Join(',', classLeetCode.CommonChars(words)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.CommonChars(words)));

            ////(1005.) Maximize Sum Of Array After K Negations (EASY)
            //int[] nums = [-4, -2, -3];
            //int k = 4;

            //LeetCode_1005 classLeetCode = new LeetCode_1005();
            //Console.WriteLine(classLeetCode.LargestSumAfterKNegations(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestSumAfterKNegations(nums, k));

            ////(1009.) Complement of Base 10 Integer (EASY)
            //int n = 5;

            //LeetCode_1009 classLeetCode = new LeetCode_1009();
            //Console.WriteLine(classLeetCode.BitwiseComplement(n));

            ////OR

            //Console.WriteLine(leetCodeAll.BitwiseComplement(n));

            ////(1013.) Partition Array Into Three Parts With Equal Sum (EASY)
            //int[] arr = [18, 12, -18, 18, -19, -1, 10, 10];

            //LeetCode_1013 classLeetCode = new LeetCode_1013();
            //Console.WriteLine(classLeetCode.CanThreePartsEqualSum(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.CanThreePartsEqualSum(arr));

            ////(1018.) Binary Prefix Divisible By 5 (EASY)
            //int[] nums = [1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0];

            //LeetCode_1018 classLeetCode = new LeetCode_1018();
            //Console.WriteLine(string.Join(',', classLeetCode.PrefixesDivBy5(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.PrefixesDivBy5(nums)));

            ////(1021.) Remove Outermost Parentheses (EASY)
            //string s = "(()())(())";

            //LeetCode_1021 classLeetCode = new LeetCode_1021();
            //Console.WriteLine(classLeetCode.RemoveOuterParentheses(s));

            ////OR

            //Console.WriteLine(leetCodeAll.RemoveOuterParentheses(s));

            ////(1022.) Sum of Root To Leaf Binary Numbers (EASY)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(0);
            //root.left.left = new TreeNode(0);
            //root.left.right = new TreeNode(1);
            //root.right = new TreeNode(1);
            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(1);

            //LeetCode_1022 classLeetCode = new LeetCode_1022();
            //Console.WriteLine(classLeetCode.SumRootToLeaf(root));

            ////OR

            //Console.WriteLine(leetCodeAll.SumRootToLeaf(root));

            ////(1025.) Divisor Game (EASY)
            //int n = 2;

            //LeetCode_1025 classLeetCode = new LeetCode_1025();
            //Console.WriteLine(classLeetCode.DivisorGame(n));

            ////OR

            //Console.WriteLine(leetCodeAll.DivisorGame(n));

            ////(1030.) Matrix Cells in Distance Order (EASY)
            //int rows = 2;
            //int cols = 3;
            //int rCenter = 1;
            //int cCenter = 2;

            //LeetCode_1030 classLeetCode = new LeetCode_1030();
            //int[][] result = classLeetCode.AllCellsDistOrder(rows, cols, rCenter, cCenter);

            //foreach (var row in result)
            //{
            //    Console.WriteLine(string.Join(',', row));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.AllCellsDistOrder(rows, cols, rCenter, cCenter);

            //foreach (var row in result1)
            //{
            //    Console.WriteLine(string.Join(',', row));
            //}

            ////(1037.) Valid Boomerang (EASY)

            //int[][] points = [[1, 1], [2, 2], [7, 7]];

            //LeetCode_1037 classLeetCode = new LeetCode_1037();
            //Console.WriteLine(classLeetCode.IsBoomerang(points));

            ////OR

            //Console.WriteLine(leetCodeAll.IsBoomerang(points));

            ////(1038.) Binary Search Tree to Greater Sum Tree (MEDIUM)
            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(6);
            //root.left.left = new TreeNode(0);
            //root.left.right = new TreeNode(2);
            //root.left.right.right = new TreeNode(3);
            //root.right.left = new TreeNode(5);
            //root.right.right = new TreeNode(7);
            //root.right.right.right = new TreeNode(8);

            //LeetCode_1038 classLeetCode = new LeetCode_1038();
            //classLeetCode.BstToGst(root);

            ////OR

            //leetCodeAll.BstToGst(root);

            ////(1045.) Customers Who Bought All Products (MEDIUM)
            //string SqlQuery =
            //    @"
            //        With CTE as 
            //        (
            //            Select
            //                Count(distinct product_key) as howMany
            //            From Product 
            //        )

            //        Select
            //            customer_id
            //        From 
            //        (
            //            Select
            //                customer_id,
            //                Count(distinct product_key) as howMany
            //            From Customer 
            //            Group by customer_id
            //        ) as a 
            //        Where howMany = (select howMany from CTE)
            //    ";

            ////OR

            //LeetCode_1045 classLeetCode = new LeetCode_1045();


            ////(1046.) Last Stone Weight (EASY)
            //int[] stones = [2, 2];

            //LeetCode_1046 classLeetCode = new LeetCode_1046();
            //Console.WriteLine(classLeetCode.LastStoneWeight(stones));

            ////OR

            //Console.WriteLine(leetCodeAll.LastStoneWeight(stones));

            ////(1047.) Remove All Adjacent Duplicates In String (EASY)
            //string s = "abbaca";

            //LeetCode_1047 classLeetCode = new LeetCode_1047();
            //Console.WriteLine(string.Join(',', classLeetCode.RemoveDuplicates(s)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RemoveDuplicates(s)));

            ////(1050.) Actors and Directors Who Cooperated At Least Three Times (EASY);
            //string SqlQuery = 
            //    @"
            //         Select
            //            actor_id,
            //            director_id
            //         FROM (Select
            //                  actor_id,
            //                  director_id,
            //                  count(director_id) as HowMany
            //                  FROM ActorDirector 
            //                  GROUP BY  actor_id, director_id) a
            //         Where HowMany > 2;
            //    ";

            ////OR

            //LeetCode_1050 classLeetCode = new LeetCode_1050();

            ////(1051.) Height Checker (EASY)
            //int[] heights = [1, 1, 4, 2, 1, 3];

            //LeetCode_1051 classLeetCode= new LeetCode_1051();
            //Console.WriteLine(classLeetCode.HeightChecker(heights));

            ////OR

            //Console.WriteLine(leetCodeAll.HeightChecker(heights));

            ////(1068.) Product Sales Analysis I (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            b.product_name,
            //            a.year,
            //            a.price
            //        FROM Sales as a
            //        left JOIN Product as b
            //        ON a.product_id = b.product_id 
            //    ";

            ////OR

            //LeetCode_1068 classLeetCode = new LeetCode_1068();

            ////(1070.) Product Sales Analysis III (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.product_id,
            //            a.first_year,
            //            a.quantity,
            //            a.price
            //        FROM
            //        (
            //            Select
            //                product_id,
            //                year as first_year,
            //                quantity,
            //                price,
            //                RANK() OVER (PARTITION BY product_id ORDER BY year) AS Rank
            //            FROM Sales 
            //        ) a
            //        Where Rank = 1;
            //    ";

            ////OR
            //LeetCode_1070 classLeetCode = new LeetCode_1070();

            ////(1071.) Greatest Common Divisor of Strings (EASY)
            //string str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
            //string str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";

            //LeetCode_1071 classLeetCode = new LeetCode_1071();
            //Console.WriteLine(classLeetCode.GcdOfStrings(str1, str2));

            ////OR

            //Console.WriteLine(leetCodeAll.GcdOfStrings(str1, str2));

            ////(1075.) Project Employees I (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.project_id,
            //            ROUND(CAST(a.Sum_Years AS decimal)/CAST(a.How_Many_Peoples AS decimal),2) as average_years 
            //        FROM (
            //                Select 
            //                    a.project_id,
            //                    SUM(b.experience_years) as Sum_Years, 
            //                    Count(a.employee_id) as How_Many_Peoples
            //                From Project as a
            //                left join Employee as b
            //                ON a.employee_id  = b.employee_id 
            //                GROUP BY a.project_id
            //             ) a
            //    ";

            ////OR

            //LeetCode_1075 classLeetCode = new LeetCode_1075();

            //////(1078.) Occurrences After Bigram (EASY)
            //string text = "we we we we will rock you";
            //string first = "we";
            //string second = "we";

            //LeetCode_1078 classLeetCode = new LeetCode_1078();
            //Console.WriteLine(string.Join(",", classLeetCode.FindOcurrences(text, first, second)));

            ////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.FindOcurrences(text, first, second)));

            ////(1084.) Sales Analysis III (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            DISTINCT a.product_id,
            //            b.product_name 
            //        From Sales as a
            //        Left Join Product as b
            //        ON a.product_id = b.product_id
            //        Where a.sale_date between '2019-01-01' and '2019-03-31' and a.product_id Not IN 
            //            (Select
            //                product_id
            //             From Sales 
            //             Where sale_date < '2019-01-01' or sale_date > '2019-03-31' )  
            //    ";

            ////OR

            //LeetCode_1084 classLeetCode = new LeetCode_1084();

            ////(1089.) Duplicate Zeros (EASY)
            //int[] arr = [0, 0, 0, 0, 0, 0, 0];

            //LeetCode_1089 classLeetCode = new LeetCode_1089();

            //classLeetCode.DuplicateZeros(arr);

            ////OR

            //leetCodeAll.DuplicateZeros(arr);

            ////(1103.) Distribute Candies to People (EASY)
            //int candies = 10;
            //int num_people = 3;

            //LeetCode_1103 classLeetCode = new LeetCode_1103();
            //Console.WriteLine(string.Join(",",classLeetCode.DistributeCandies(candies, num_people)));

            ////OR

            //Console.WriteLine(string.Join(",", leetCodeAll.DistributeCandies(candies, num_people)));

            ////(1108.) Defanging an IP Address (EASY)
            //string address = "255.100.50.0";

            //LeetCode_1108 classLeetCode = new LeetCode_1108();
            //Console.WriteLine(classLeetCode.DefangIPaddr(address));

            ////OR

            //Console.WriteLine(leetCodeAll.DefangIPaddr(address));


            ////(1114.) Print in Order (EASY)

            //LeetCode_1114.Foo123 classLeetCode = new LeetCode_1114.Foo123();

            //OR

            ////(1122.) Relative Sort Array (EASY)
            //int[] arr1 = [2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19];
            //int[] arr2 = [2, 1, 4, 3, 9, 6];

            //LeetCode_1122 classLeetCode = new LeetCode_1122();
            //Console.WriteLine(string.Join(',',classLeetCode.RelativeSortArray(arr1, arr2)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RelativeSortArray(arr1, arr2)));

            ////(1128.) Number of Equivalent Domino Pairs (EASY)
            //int[][] dominoes = [[1, 1], [2, 2], [1, 1], [1, 2], [1, 2], [1, 1]];

            //LeetCode_1128 classLeetCode = new LeetCode_1128();
            //Console.WriteLine(classLeetCode.NumEquivDominoPairs(dominoes));

            ////OR

            //Console.WriteLine(leetCodeAll.NumEquivDominoPairs(dominoes));

            ////(1137.) N-th Tribonacci Number (EASY)
            //int n = 25;

            //LeetCode_1137 classLeetCode = new LeetCode_1137();
            //Console.WriteLine(classLeetCode.Tribonacci(n));

            ////OR

            //Console.WriteLine(leetCodeAll.Tribonacci(n));

            ////(1141.) User Activity for the Past 30 Days I (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            activity_date as day,
            //            COUNT(distinct user_id)  as active_users 
            //        FROM Activity 
            //        Where activity_date > DATEADD(Day, -30, '2019-07-27') and activity_date <= '2019-07-27'
            //        GROUP BY activity_date
            //    ";

            ////OR

            //LeetCode_1141 classLeetCode = new LeetCode_1141();


            ////(1148.) Article Views I (EASY)
            //string SqlQuery =
            //    @"
            //        WITH Views_CTE
            //        AS 
            //        (
            //            Select 
            //                article_id,
            //                author_id,
            //                viewer_id 
            //            From Views
            //            Where author_id = viewer_id
            //        )

            //        Select 
            //            DISTINCT a.author_id as id
            //        From Views_CTE as a
            //    ";

            ////OR

            //LeetCode_1148 classLeetCode = new LeetCode_1148();

            ////(1154.) Day of the Year (EASY)
            //string date = "2019-01-09";

            //LeetCode_1154 classLeetCode = new LeetCode_1154();
            //Console.WriteLine(classLeetCode.DayOfYear(date));

            ////OR

            //Console.WriteLine(leetCodeAll.DayOfYear(date));

            ////(1160.) Find Words That Can Be Formed by Characters (EASY)
            //string[] words = ["cat", "bt", "hat", "tree"];
            //string chars = "atach";

            //LeetCode_1160 classLeetCode = new LeetCode_1160();
            //Console.WriteLine(classLeetCode.CountCharacters(words, chars));

            ////OR

            //Console.WriteLine(leetCodeAll.CountCharacters(words, chars));

            ////(1164.) Product Price at a Given Date (MEDIUM)
            //string SqlQuery =
            //    @"
            //         Select 
            //             c.product_id,
            //             IIF(d.price is null, 10, d.price) as price
            //         From
            //         (
            //             Select
            //                 distinct product_id
            //             From Products
            //         ) c
            //         left join 
            //         (   
            //             Select
            //                 a.product_id,
            //                 b.new_price as price
            //                 from 
            //                 (
            //                     Select
            //                         product_id,
            //                         max(change_date) as lastDate
            //                     From Products 
            //                     Where change_date <= '2019-08-16'
            //                     Group by product_id
            //                 ) a
            //                 left join Products as b
            //                 On a.product_id = b.product_id and a.lastDate = b.change_date
            //         ) as d
            //         On c.product_id = d.product_id
            //    ";

            ////OR

            //LeetCode_1164 classLeetCode = new LeetCode_1164();

            ////(1174.) Immediate Food Delivery II (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            ROUND((d.immediate*1.0/d.allDelivery)*100,2) as immediate_percentage
            //        From
            //        ( 
            //            Select
            //                --b.customer_id,
            //                SUM(IIF(c.order_date = c.customer_pref_delivery_date, 1, 0)) as immediate,
            //                COUNT(*) as allDelivery
            //            From (
            //                    Select 
            //                    a.customer_id,
            //                    (Select top 1 delivery_id From Delivery Where a.customer_id = customer_id Order by order_date) as firstBuyID
            //                    From 
            //                    (   
            //                        Select
            //                            Distinct customer_id
            //                        From Delivery 
            //                    ) as a
            //            ) as b
            //            Left join Delivery as c
            //            On c.delivery_id  = b.firstBuyID
            //        ) as d
            //    ";

            ////OR

            //LeetCode_1174 classLeetCode = new LeetCode_1174();

            ////(1175.) Prime Arrangements (EASY)
            //int n = 5;

            //LeetCode_1175 classLeetCode = new LeetCode_1175();
            //Console.WriteLine(classLeetCode.NumPrimeArrangements(n));

            ////OR

            //Console.WriteLine(leetCodeAll.NumPrimeArrangements(n));

            /////1179. Reformat Department Table (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            id,
            //            SUM(IIF(month ='Jan', Revenue, null)) as Jan_Revenue,
            //            SUM(IIF(month ='Feb', Revenue, null)) as Feb_Revenue,
            //            SUM(IIF(month ='Mar', Revenue, null)) as Mar_Revenue,
            //            SUM(IIF(month ='Apr', Revenue, null)) as Apr_Revenue,
            //            SUM(IIF(month ='May', Revenue, null)) as May_Revenue,
            //            SUM(IIF(month ='Jun', Revenue, null)) as Jun_Revenue,
            //            SUM(IIF(month ='Jul', Revenue, null)) as Jul_Revenue,
            //            SUM(IIF(month ='Aug', Revenue, null)) as Aug_Revenue,
            //            SUM(IIF(month ='Sep', Revenue, null)) as Sep_Revenue,
            //            SUM(IIF(month ='Oct', Revenue, null)) as Oct_Revenue,
            //            SUM(IIF(month ='Nov', Revenue, null)) as Nov_Revenue,
            //            SUM(IIF(month ='Dec', Revenue, null)) as Dec_Revenue
            //        From Department 
            //        Group by id
            //    ";

            ////OR

            //LeetCode_1179 classLeetCode = new LeetCode_1179();

            ////(1184.) Distance Between Bus Stops (EASY)
            //int[] distance = [14, 13, 4, 7, 10, 17, 8, 3, 2, 13];
            //int start = 2;
            //int destination = 9;

            //LeetCode_1184 classLeetCode = new LeetCode_1184();
            //Console.WriteLine(classLeetCode.DistanceBetweenBusStops(distance, start, destination));

            ////OR

            //Console.WriteLine(leetCodeAll.DistanceBetweenBusStops(distance, start, destination));

            ////(1185.) Day of the Week (EASY)
            //int day = 31;
            //int month = 8;
            //int year = 2019;

            //LeetCode_1185 classLeetCode = new LeetCode_1185();
            //Console.WriteLine(classLeetCode.DayOfTheWeek(day, month, year));

            ////OR

            //Console.WriteLine(leetCodeAll.DayOfTheWeek(day, month, year));

            ////(1189.) Maximum Number of Balloons (EASY)
            //string text = "loonbalxballpoon";

            //LeetCode_1189 classLeetCode = new LeetCode_1189();
            //Console.WriteLine(classLeetCode.MaxNumberOfBalloons(text));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxNumberOfBalloons(text));

            ////(1193.) Monthly Transactions I (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            a.month,
            //            a.country,
            //            Count(*) as trans_count,
            //            SUM(a.approved_count) as approved_count,
            //            SUM(a.trans_total_amount) as trans_total_amount,
            //            SUM(a.approved_total_amount) as approved_total_amount
            //        From (Select
            //                FORMAT(trans_date, 'yyyy-MM') as month,
            //                country,
            //                IIF(state = 'approved', 1, 0) as approved_count,
            //                amount as  trans_total_amount,
            //                IIF(state = 'approved', amount, 0) as approved_total_amount 
            //              From Transactions 
            //             ) as a
            //        Group by a.month, a.country
            //        order by a.month   
            //    ";

            //////OR

            //LeetCode_1193 classLeetCode = new LeetCode_1193();

            ////(1200.) Minimum Absolute Difference (EASY)
            //int[] arr = [4, 2, 1, 3];

            //LeetCode_1200 classLeetCode = new LeetCode_1200();

            //IList<IList<int>> list = classLeetCode.MinimumAbsDifference(arr);

            //foreach (var item in list) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //IList<IList<int>> list1 = leetCodeAll.MinimumAbsDifference(arr);

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(1204.) Last Person to Fit in the Bus (MEDIUM)
            //string SqlQuery =
            //    @"
            //         Select top 1
            //             a.person_name
            //         FROM
            //         ( 
            //             Select
            //                 person_id, 
            //                 person_name,
            //                 weight,
            //                 turn,
            //                 SUM(weight)
            //                 OVER (order by turn) as SumWeight
            //             FROM Queue
            //         ) a
            //         Where SumWeight <= 1000
            //         order by a.turn desc
            //    ";

            //////OR

            //LeetCode_1204 classLeetCode = new LeetCode_1204();

            ////(1207.) Unique Number of Occurrences (EASY)
            //int[] arr = [-130, 21, -154, 159, -44, -126, 165, 68, -126, -126, -126, 128, -94, 165, -30, -44, -39, -94, 21, -130, 68, 68, 128, -130, -39, 181, 68, 68, 68, 139, 139, -39, 21, 21, -39, 68, 128, 131, -126, -154, -30, 165, 21, 159, 181, -39, -126, 131, -94, -44, 131, 128, 21, -44, 128, -94, 183, -94, 131, 139, -44, 128, 21, 181, -44, 131, 128, 131, 21, 68, 181, -44, -126, -130, 131, -190, 131, 181, 165, -94, 165, 165, -30, -154, 68, -39, -44, 165, -39, -126, 68, 68, -130, 68, -94, 181, -44, 131, 21, 183, -44, 21, -39, -130, -39, 131, 21, 165, 165, -126, 165, -44, -94, 68, 68, -94, -126, -126, -30, 181, 165, 68, -44, -39, -94, -126, -126, -30, 68, 181, -44, -94, -126, -44, -94, -30, 131, 165, -190, -130, -94, -94, 181, 128, 181, 181, 181, 139, -130, -94, -130, -130, 139, -130, -90, -154, 181, 165, -30, -154, 165, -190, 159, 165, 139, -126, -44, 131, -44, -190, -126, -130, -94, 128, -154, 68, -130, -130, 68, 21, -44, -30, -126, -126, 131, 159, -190, -126, 181, 139];

            //LeetCode_1207 classLeetCode = new LeetCode_1207();
            //Console.WriteLine(classLeetCode.UniqueOccurrences(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.UniqueOccurrences(arr));

            ////(1211.) Queries Quality and Percentage (EASY)
            //string SqlQuery =
            //    @"
            //        WITH CTE as 
            //        (
            //            Select 
            //                query_name,
            //                 --CONVERT(DECIMAL(16,2), rating/1.0 / position/1.0) as quality,
            //                 --rating 
            //                 CONVERT(DECIMAL(16,2),SUM(CONVERT(DECIMAL(16,4), rating/1.0 / position/1.0))/COUNT(*)) as quality,
            //                 COUNT(*) as count,
            //                 SUM(IIF(rating<3, 1, 0)) as sum
            //             From Queries
            //             GROUP BY query_name
            //        )

            //        Select 
            //            query_name,
            //            quality,
            //            CONVERT(DECIMAL(16,4),sum*1.0/count*1.0)*100 as poor_query_percentage 
            //        From CTE
            //    ";

            //////OR

            //LeetCode_1211 classLeetCode = new LeetCode_1211();

            ////(1217.) Minimum Cost to Move Chips to The Same Position (EASY)
            //int[] position = [2, 2, 2, 3, 3];

            //LeetCode_1217 classLeetCode = new LeetCode_1217();
            //Console.WriteLine(classLeetCode.MinCostToMoveChips(position));

            ////OR

            //Console.WriteLine(leetCodeAll.MinCostToMoveChips(position));

            ////(1221.) Split a String in Balanced Strings (EASY)
            //string s = "RLRRRLLRLL";

            //LeetCode_1221 classLeetCode = new LeetCode_1221();
            //Console.WriteLine(classLeetCode.BalancedStringSplit(s));

            ////OR

            //Console.WriteLine(leetCodeAll.BalancedStringSplit(s));

            ////(1233.) Remove Sub-Folders from the Filesystem (MEDIUM)
            //string[] folder = ["/a", "/a/b", "/a/c", "/a/b/a", "/c/d", "/c/d/e", "/c/f"];

            //LeetCode_1233 classLeetCode = new LeetCode_1233();

            //Console.WriteLine(string.Join(',', classLeetCode.RemoveSubfolders(folder)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RemoveSubfolders(folder)));

            ////(1251.) Average Selling Price (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            c.product_id,
            //            IIF(c.average_price is null, 0, c.average_price) as average_price
            //        From (
            //                Select
            //                    b.product_id,
            //                    ROUND(SUM(a.unitAndPrice*1.0)/SUM(a.units*1.0), 2) as average_price 
            //                From (
            //                        Select
            //                            a.product_id, 
            //                            a.units * b.price as unitAndPrice,
            //                            a.units
            //                        From UnitsSold as a
            //                        left Join Prices as b
            //                        ON a.product_id = b.product_id and a.purchase_date between b.start_date and b.end_date 
            //                     ) AS a
            //                Right join Prices  as b
            //                ON b.product_id = a.product_id
            //                Group by b.product_id
            //             ) as c   
            //    ";

            ////OR
            //LeetCode_1251 classLeetCode = new LeetCode_1251();

            ////(1266.) Minimum Time Visiting All Points (EASY)
            //int[][] points = [[559, 511], [932, 618], [-623, -443], 
            //[431, 91], [838, -127], [773, -917], [-500, -910], [830, -417], 
            //[-870, 73], [-864, -600], [450, 535], [-479, -370], [856, 573],
            //[-549, 369], [529, -462], [-839, -856], [-515, -447], [652, 197],
            //[-83, 345], [-69, 423], [310, -737], [78, -201], [443, 958], 
            //[-311, 988], [-477, 30], [-376, -153], [-272, 451], [322, -125],
            //[-114, -214], [495, 33], [371, -533], [-393, -224], [-405, -633],
            //[-693, 297], [504, 210], [-427, -231], [315, 27], [991, 322], [811, -746], 
            //[252, 373], [-737, -867], [-137, 130], [507, 380], [100, -638], [-296, 700],
            //[341, 671], [-944, 982], [937, -440], [40, -929], [-334, 60], [-722, -92],
            //[-35, -852], [25, -495], [185, 671], [149, -452]];

            //LeetCode_1266 classLeetCode = new LeetCode_1266();
            //Console.WriteLine(classLeetCode.MinTimeToVisitAllPoints(points));

            ////OR

            //Console.WriteLine(leetCodeAll.MinTimeToVisitAllPoints(points));

            ////(1280.) Students and Examinations (EASY)
            //string SqlQuery =
            //    @"
            //        With CTE AS 
            //        (
            //            Select
            //                a.student_id,
            //                a.student_name,
            //                subject_name
            //            From Students as a
            //            CROSS JOIN Subjects 
            //        )

            //        Select 
            //            b.student_id, 
            //            b.student_name,
            //            b.subject_name,
            //            Count(a.subject_name) as attended_exams 
            //        From Examinations as a
            //        right join CTE as b
            //        ON a.student_id = b.student_id and a.subject_name = b.subject_name
            //        Group by b.student_id, b.student_name, b.subject_name
            //        order by b.student_id, b.subject_name    
            //    ";

            ////OR
            //LeetCode_1280 classLeetCode = new LeetCode_1280();

            ////(1290.) Convert Binary Number in a Linked List to Integer (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(0);
            //head.next.next = new ListNode(1);

            //LeetCode_1290 classLeetCode = new LeetCode_1290();
            //Console.WriteLine(classLeetCode.GetDecimalValue(head));

            ////OR

            //Console.WriteLine(leetCodeAll.GetDecimalValue(head));

            ////(1309.) Decrypt String from Alphabet to Integer Mapping (EASY)
            //string s = "1326#";

            //LeetCode_1309 classLeetCode = new LeetCode_1309();
            //Console.WriteLine(classLeetCode.FreqAlphabets(s));

            ////OR

            //Console.WriteLine(leetCodeAll.FreqAlphabets(s));

            ////(1321.) Restaurant Growth (MEDIUM)
            //string SqlQuery =
            //    @"
            //         Select 
            //             b.visited_on,
            //             --b.startCalc,
            //             --b.YES_NO,
            //             (Select SUM(amount) From Customer Where visited_on >= b.startCalc and visited_on <= b.visited_on) as amount, 
            //             (Select ROUND(AVG(f.amount*1.0),2) From (Select 
            //         	                                            visited_on,
            //         	                                            SUM(amount) as amount
            //                                                     From Customer 
            //                                                     Group by visited_on) f Where f.visited_on >= b.startCalc and f.visited_on <= b.visited_on) as average_amount
            //         From
            //         (
            //         Select
            //             distinct a.end_date as visited_on,
            //             a.startCalc,
            //             a.YES_NO
            //         From
            //         (
            //             Select
            //                 visited_on as startCalc,
            //                 IIF(DATEADD(DAY, 6, visited_on) <= (Select max(visited_on) From Customer), 1, 0) as YES_NO,
            //                 DATEADD(DAY, 6, visited_on) as end_date
            //             From Customer
            //         ) a
            //         Where a.YES_NO = 1
            //         ) b  
            //    ";

            ////OR
            //LeetCode_1321 classLeetCode = new LeetCode_1321();

            ////(1323.) Maximum 69 Number (EASY)
            //int num = 9996;

            //LeetCode_1323 classLeetCode = new LeetCode_1323();
            //Console.WriteLine(classLeetCode.Maximum69Number(num));

            ////OR

            //Console.WriteLine(leetCodeAll.Maximum69Number(num));

            /////(1327.) List the Products Ordered in a Period (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            product_name,
            //            a.unit
            //        From 
            //        (
            //            Select  
            //            product_id,
            //            SUM(unit) as unit        
            //            From Orders 
            //            Where Year(order_date) = 2020 and Month(order_Date) = 2 
            //            Group by product_id
            //            Having SUM(unit) >= 100
            //        ) as a
            //        left join Products as b
            //        ON a.product_id = b.product_id  
            //    ";

            ////OR
            //LeetCode_1327 classLeetCode = new LeetCode_1327();

            ////(1341.) Movie Rating  (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            f.results
            //        From (
            //        Select top 1
            //            c.name as results             
            //        From
            //        (
            //            Select 
            //                user_id,
            //                COUNT(user_id) as howManyTimes
            //            From MovieRating 
            //            Group by user_id 
            //        ) as a
            //        left join Users as c
            //        On c.user_id = a.user_id 
            //        Where a.howManyTimes = (Select Max(b.howManyTimes) From (Select 
            //                user_id,
            //                COUNT(user_id) as howManyTimes
            //                From MovieRating 
            //                Group by user_id ) b)
            //        order by c.name
            //        ) f

            //        UNION ALL 

            //        Select
            //            g.results
            //        From 
            //        ( 
            //            Select top 1
            //            d.title as results
            //        From
            //        (
            //            Select
            //                movie_id,
            //                AVG(rating*1.0) as averageRating
            //            From MovieRating 
            //            Where MONTH(created_at) = 2 and YEAR(created_at) = 2020
            //            Group by movie_id
            //        ) as a
            //        Left join Movies as d
            //        On d.movie_id = a.movie_id
            //        Where a.averageRating = (Select MAX(b.averageRating) FROM 
            //                        (Select
            //                            movie_id,
            //                            AVG(rating*1.0) as averageRating
            //                        From MovieRating 
            //                        Where MONTH(created_at) = 2 and YEAR(created_at) = 2020
            //                        Group by movie_id) b
            //                        ) 
            //        order by d.title
            //        ) g
            //    ";

            ////OR
            //LeetCode_1341 classLeetCode = new LeetCode_1341();

            ////(1378.) Replace Employee ID With The Unique Identifier (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            unique_id,
            //            b.name
            //        From EmployeeUNI as a
            //        right Join Employees as b
            //        ON a.id = b.id      
            //    ";

            ////OR
            //LeetCode_1378 classLeetCode = new LeetCode_1378();

            ////(1394.) Find Lucky Integer in an Array (EASY)
            //int[] arr = [1, 2, 2, 3, 3, 3];

            //LeetCode_1394 classLeetCode = new LeetCode_1394();
            //Console.WriteLine(classLeetCode.FindLucky(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLucky(arr));

            ////(1432.) Max Difference You Can Get From Changing an Integer (MEDIUM)
            //int num = 90270580;

            //LeetCode_1432 classLeetCode = new LeetCode_1432();
            //Console.WriteLine(classLeetCode.MaxDiff(num));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDiff(num));

            ////(1470.) Shuffle the Array (EASY)
            //int[] nums = [1, 2, 3, 4, 4, 3, 2, 1];
            //int n = 4;

            //LeetCode_1470 classLeetCode = new LeetCode_1470();
            //Console.WriteLine(string.Join(',', classLeetCode.Shuffle(nums, n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.Shuffle(nums, n)));

            ////(1484.) Group Sold Products By The Date (EASY)
            //string SqlQuery =
            //    @"
            //        With my_CTE as 
            //        (
            //            Select
            //                distinct sell_date,
            //                product  
            //            From Activities 
            //        )

            //        Select 
            //            sell_date,
            //            Count(*) as num_sold , 
            //            String_AGG(product, ',') as products   
            //        From my_CTE
            //        Group by sell_date     
            //    ";

            ////OR
            //LeetCode_1484 classLeetCode = new LeetCode_1484();

            ////(1498.) Number of Subsequences That Satisfy the Given Sum Condition (MEDIUM)
            //int[] nums = [5, 2, 4, 1, 7, 6, 8];
            //int target = 16;

            //LeetCode_1498 classLeetCode = new LeetCode_1498();
            //Console.WriteLine(classLeetCode.NumSubseq(nums, target));

            ////OR

            //Console.WriteLine(leetCodeAll.NumSubseq(nums, target));

            ////(1512.) Number of Good Pairs (EASY)
            //int[] nums = [1, 2, 3, 1, 1, 3];

            //LeetCode_1512 classLeetCode = new LeetCode_1512();
            //Console.WriteLine(classLeetCode.NumIdenticalPairs(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.NumIdenticalPairs(nums));

            ////(1517.) Find Users With Valid E-Mails (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            user_id,
            //            name,
            //            mail
            //        From Users
            //        Where mail LIKE '[a-zA-Z]%@leetcode.com'
            //        and mail NOT LIKE '%[!#()$^%=*@+&]%@leetcode.com'   
            //    ";

            ////OR
            //LeetCode_1517 classLeetCode = new LeetCode_1517();

            ////(1527.) Patients With a Condition (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            patient_id,
            //            patient_name,
            //            conditions
            //        From Patients 
            //        Where conditions like 'DIAB1%' OR conditions like '% DIAB1%'     
            //    ";

            ////OR
            //LeetCode_1527 classLeetCode = new LeetCode_1527();

            ////(1581.) Customer Who Visited but Did Not Make Any Transactions (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            unique_id,
            //            b.name
            //        From EmployeeUNI as a
            //        right Join Employees as b
            //        ON a.id = b.id      
            //    ";

            //////OR
            //LeetCode_1581 classLeetCode = new LeetCode_1581();

            ////(1633.) Percentage of Users Attended a Contest (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            contest_id,
            //            Round(Count(Distinct user_id)*1.0 / (Select Count(distinct user_id ) from Users)*100,2) as percentage  
            //        From Register 
            //        Group by contest_id
            //        order by percentage desc, contest_id asc  
            //    ";

            ////OR
            //LeetCode_1633 classLeetCode = new LeetCode_1633();

            ////(1661.) Average Time of Process per Machine (EASY)
            //string SqlQuery =
            //    @"
            //        With CTE AS
            //        (
            //            Select
            //                machine_id,
            //                process_id,
            //                timestamp as start
            //            From Activity 
            //            Where activity_type = 'start'
            //        )

            //        Select 
            //            a.machine_id,
            //            Round(AVG(timestamp - start),3) as processing_time 
            //        FROM CTE as a
            //        Left Join Activity as b
            //        ON a.machine_id = b.machine_id and a.process_id  = b.process_id 
            //        where activity_type = 'end'
            //        Group by a.machine_id   
            //    ";

            ////OR
            //LeetCode_1661 classLeetCode = new LeetCode_1661();

            ////(1667.) Fix Names in a Table (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            user_id,
            //            Concat(UPPER(SUBSTRING(name, 1, 1)),LOWER(SUBSTRING(name, 2, LEN(name)))) as name  
            //        From Users 
            //        order by user_id     
            //    ";

            ////OR
            //LeetCode_1667 classLeetCode = new LeetCode_1667();

            ////(1672.) Richest Customer Wealth (EASY)
            //int[][] accounts = [[1,2,3], [3,2,1]];

            //LeetCode_1672 classLeetCode = new LeetCode_1672();
            //Console.WriteLine(classLeetCode.MaximumWealth(accounts));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumWealth(accounts));

            ////1683. Invalid Tweets (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            tweet_id 
            //        From Tweets 
            //        Where Length(content) > 15        
            //    ";

            ////OR
            //LeetCode_1683 classLeetCode = new LeetCode_1683();

            ////(1684.) Count the Number of Consistent Strings (EASY)
            //string allowed = "ab";
            //string[] words = ["ad","bd","aaab","baa","badab"];

            //LeetCode_1684 classLeetCode = new LeetCode_1684();
            //Console.WriteLine(classLeetCode.CountConsistentStrings(allowed, words));

            ////OR

            //Console.WriteLine(leetCodeAll.CountConsistentStrings(allowed, words));

            ////(1689.) Partitioning Into Minimum Number Of Deci-Binary Numbers (MEDIUM)
            //string n = "32";

            //LeetCode_1689 classLeetCode = new LeetCode_1689();
            //Console.WriteLine(classLeetCode.MinPartitions(n));

            ////OR

            //Console.WriteLine(leetCodeAll.MinPartitions(n));

            ////(1695.) Maximum Erasure Value (MEDIUM)
            //int[] nums = [5, 2, 1, 2, 5, 2, 1, 2, 5];

            //LeetCode_1695 classLeetCode = new LeetCode_1695();
            //Console.WriteLine(classLeetCode.MaximumUniqueSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumUniqueSubarray(nums));

            ////(1717.) Maximum Score From Removing Substrings (MEDIUM)
            //string s = "abbmzgaabtaabsbabhaahabnaeabdbaababbbiabaavababtabwbababzbdabbaaabhbyabdvabbaabbquapaaaaqbbblbuaawlnbbaxaubbbbbpbabbbpaaaacbbaabaaaahbbcoyaauabanqaabpbbbgaawbhabbbbaobsaaababbafbababbbbaaaqbabsbsmabbxqylbbbba";
            //int x = 9421;
            //int y = 8003;

            //LeetCode_1717 classLeetCode = new LeetCode_1717();
            //Console.WriteLine(classLeetCode.MaximumGain(s, x, y));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumGain(s, x, y));

            ////(1729.) Find Followers Count (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            user_id,
            //            Count(*) as followers_count
            //        From Followers 
            //        Group by user_id
            //    ";

            ////OR
            //LeetCode_1729 classLeetCode = new LeetCode_1729();

            ////(1731.) Recyclable and Low Fat Products (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.reports_to as employee_id, 
            //            b.name,
            //            a.reports_count,
            //            ROUND(a.sumAge*1.0/reports_count,0) as average_age 
            //        FROM
            //        (
            //            Select 
            //                reports_to,
            //                SUM(age) as sumAge,
            //                Count(*) as reports_count
            //            From Employees 
            //            Where reports_to is not null
            //            Group by reports_to
            //        ) as a 
            //        left join Employees as b 
            //        ON a.reports_to = b.employee_id 
            //    ";

            ////OR
            //LeetCode_1731 classLeetCode = new LeetCode_1731();

            ////(1752.) Check if Array Is Sorted and Rotated (EASY)
            //int[] nums = [2, 1, 3, 4];

            //LeetCode_1752 classLeetCode = new LeetCode_1752();
            //Console.WriteLine(classLeetCode.Check(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.Check(nums));

            ////(1757.) Recyclable and Low Fat Products (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            product_id  
            //        From Products 
            //        Where low_fats = 'Y' and recyclable = 'Y'
            //    ";

            ////OR
            //LeetCode_1757 classLeetCode = new LeetCode_1757();

            ////(1769.) Minimum Number of Operations to Move All Balls to Each Box (MEDIUM)
            //string boxes = "001011";

            //LeetCode_1769 classLeetCode = new LeetCode_1769();
            //Console.WriteLine(string.Join(',', classLeetCode.MinOperations(boxes)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MinOperations(boxes)));

            ////(1789.) Primary Department for Each Employee (EASY)
            //string SqlQuery =
            //    @"
            //        With CTE AS 
            //        (
            //            Select 
            //                employee_id,
            //                Count(*) as howManyDepartment
            //            From Employee 
            //            Group by employee_id
            //        )

            //        Select
            //            a.employee_id,
            //            a.department_id  
            //        From 
            //        (
            //            Select
            //                a.employee_id,
            //                b.department_id  
            //            From CTE a
            //            Left join Employee b
            //            On a.employee_id = b.employee_id
            //            Where howManyDepartment > 1 and b.primary_flag = 'Y'
            //        ) a
            //        Union
            //        Select
            //            b.employee_id,
            //            b.department_id
            //        From
            //        (
            //            Select
            //                a.employee_id,
            //                b.department_id 
            //            From CTE a
            //            Left join Employee b
            //            On a.employee_id = b.employee_id
            //            Where howManyDepartment = 1
            //        ) b
            //    ";

            ////OR
            //LeetCode_1789 classLeetCode = new LeetCode_1789();

            //(1863.) Sum of All Subset XOR Totals (EASY)
            //int[] nums = [5, 1, 6];

            //LeetCode_1863 classLeetCode = new LeetCode_1863();
            //Console.WriteLine(classLeetCode.SubsetXORSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SubsetXORSum(nums));

            ////(1865.) Finding Pairs With a Certain Sum (MEDIUM)

            //LeetCode_1865.FindSumPairs classLeetCode = new LeetCode_1865.FindSumPairs([1, 1, 2, 2, 2, 3], [1, 4, 5, 2, 5, 4]);
            //Console.WriteLine(classLeetCode.Count(7));
            //classLeetCode.Add(3, 2);
            //Console.WriteLine(classLeetCode.Count(8));
            //Console.WriteLine(classLeetCode.Count(4));
            //classLeetCode.Add(0, 1);
            //classLeetCode.Add(1, 1);
            //Console.WriteLine(classLeetCode.Count(7));

            ////OR

            //FindSumPairsTask_1865 leetCodeTask = new FindSumPairsTask_1865([1, 1, 2, 2, 2, 3], [1, 4, 5, 2, 5, 4]);
            //Console.WriteLine(leetCodeTask.Count(7));
            //leetCodeTask.Add(3, 2);
            //Console.WriteLine(leetCodeTask.Count(8));
            //Console.WriteLine(leetCodeTask.Count(4));
            //leetCodeTask.Add(0, 1);
            //leetCodeTask.Add(1, 1);
            //Console.WriteLine(leetCodeTask.Count(7));

            ////(1907.) Count Salary Categories (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            'High Salary' as category,
            //            Count(account_id) as accounts_count
            //        From 
            //        (
            //            Select 
            //                account_id
            //            From Accounts 
            //            Where income > 50000
            //        ) a 
            //        UNION ALL
            //        Select
            //            'Average Salary' as category,
            //            Count(account_id) as accounts_count
            //        From 
            //        (
            //            Select 
            //                account_id
            //            From Accounts 
            //            Where income >= 20000 and income <= 50000
            //        ) a 
            //        UNION ALL
            //        Select
            //            'Low Salary' as category,
            //            Count(account_id) as accounts_count
            //        From 
            //        (
            //            Select 
            //                account_id
            //            From Accounts 
            //            Where income < 20000
            //        ) a 
            //    ";

            ////OR
            //LeetCode_1907 classLeetCode = new LeetCode_1907();

            ////(1920.) Build Array from Permutation (EASY)
            //int[] nums = [0,2,1,5,3,4];

            //LeetCode_1920 classLeetCode = new LeetCode_1920();
            //Console.WriteLine(string.Join(',', classLeetCode.BuildArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.BuildArray(nums)));

            ////(1929.) Concatenation of Array (EASY)
            //int[] nums = [1, 2, 1];

            //LeetCode_1929 classLeetCode = new LeetCode_1929();
            //Console.WriteLine(string.Join(',', classLeetCode.GetConcatenation(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', classLeetCode.GetConcatenation(nums)));

            ////(1934.) Confirmation Rate (MEDIUM)
            //string SqlQuery =
            //    @"
            //        With CTE AS
            //        (
            //            Select
            //                user_id,
            //                (SUM(IIF([action] = 'timeout', 1, 0))) as countTimeout,
            //                (SUM(IIF([action] = 'confirmed', 1, 0))) as countConfirmed
            //            From Confirmations 
            //            GROUP BY user_id
            //        )

            //        Select 
            //            a.user_id,
            //            IIF(b.confirmation_rate is null, 0, b.confirmation_rate) as confirmation_rate
            //        From Signups as a
            //        Left Join (Select 
            //                    user_id,
            //                    ROUND(countConfirmed*1.0 / (countTimeout*1.0 + countConfirmed*1.0),2) as confirmation_rate 
            //                  From CTE ) as b
            //        ON a.user_id = b.user_id
            //    ";

            ////OR
            //LeetCode_1934 classLeetCode = new LeetCode_1934();

            ////(1957.) Delete Characters to Make Fancy String (EASY)
            //string s = "leeetcode";

            //LeetCode_1957 classLeetCode = new LeetCode_1957();
            //Console.WriteLine(classLeetCode.MakeFancyString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MakeFancyString(s));

            ////(1978.) Employees Whose Manager Left the Company (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.employee_id
            //        --    a.name, 
            //        --    a.manager_id, 
            //        --    a.salary,
            //        --    b.employee_id 
            //        From Employees as a 
            //        Left join Employees b
            //        ON a.manager_id = b.employee_id 
            //        Where a.salary < 30000 and  b.employee_id is null and a.manager_id is not null
            //        order by a.employee_id
            //    ";

            ////OR
            //LeetCode_1978 classLeetCode = new LeetCode_1978();

            ////(2011.) Final Value of Variable After Performing Operations (EASY)
            //string[] operations = ["X++", "++X", "--X", "X--"];

            //LeetCode_2011 classLeetCode = new LeetCode_2011();
            //Console.WriteLine(classLeetCode.FinalValueAfterOperations(operations));

            ////OR

            //Console.WriteLine(leetCodeAll.FinalValueAfterOperations(operations));

            ////(2016.) Maximum Difference Between Increasing Elements (EASY)
            //int[] nums = [999, 997, 980, 976, 948, 940, 938, 928, 924, 917, 907, 907, 881, 878, 864, 862, 859, 857, 848, 840, 824, 824, 824, 805, 802, 798, 788, 777, 775, 766, 755, 748, 735, 732, 727, 705, 700, 697, 693, 679, 676, 644, 634, 624, 599, 596, 588, 583, 562, 558, 553, 539, 537, 536, 509, 491, 485, 483, 454, 449, 438, 425, 403, 368, 345, 327, 287, 285, 270, 263, 255, 248, 235, 234, 224, 221, 201, 189, 187, 183, 179, 168, 155, 153, 150, 144, 107, 102, 102, 87, 80, 57, 55, 49, 48, 45, 26, 26, 23, 15];

            //LeetCode_2016 classLeetCode = new LeetCode_2016();
            //Console.WriteLine(classLeetCode.MaximumDifference(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumDifference(nums));

            //(2044.) Count Number of Maximum Bitwise-OR Subsets (MEDIUM)
            //int[] nums = [3, 2, 1, 5];

            //LeetCode_2044 classLeetCode = new LeetCode_2044();
            //Console.WriteLine(classLeetCode.CountMaxOrSubsets(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountMaxOrSubsets(nums));

            ////(2099.) Find Subsequence of Length K With the Largest Sum (EASY)
            //int[] nums = [-1, -2, 3, 4];
            //int k = 3;

            //LeetCode_2099 classLeetCode = new LeetCode_2099();
            //Console.WriteLine(string.Join(',', classLeetCode.MaxSubsequence(nums, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MaxSubsequence(nums, k)));

            ////(2106.) Maximum Fruits Harvested After at Most K Steps (HARD)
            //int[][] fruits = [[2, 8], [6, 3], [8, 6]];
            //int startPos = 5;
            //int k = 4;

            //LeetCode_2106 classLeetCode = new LeetCode_2106();
            //Console.WriteLine(classLeetCode.MaxTotalFruits(fruits, startPos, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxTotalFruits(fruits, startPos, k));

            ////(2138.) Divide a String Into Groups of Size k (EASY)
            //string s = "abcdefghij";
            //int k = 3;
            //char fill = 'x';

            //LeetCode_2138 classLeetCode = new LeetCode_2138();
            //string[] result = classLeetCode.DivideString(s, k, fill);

            //Console.WriteLine(string.Join(',', result));

            ////OR

            //string[] result1 = leetCodeAll.DivideString(s, k, fill);
            //Console.WriteLine(string.Join(',', result1));

            ////(2161.) Partition Array According to Given Pivot (MEDIUM)
            //int[] nums = [9,12,5,10,14,3,10];
            //int pivot = 10;

            //LeetCode_2161 classLeetCode = new LeetCode_2161();
            //Console.WriteLine(string.Join(',', classLeetCode.PivotArray(nums, pivot)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.PivotArray(nums, pivot)));

            ////(2181.) Merge Nodes in Between Zeros (MEDIUM)
            //ListNode head = new ListNode(0);
            //head.next = new ListNode(3);
            //head.next.next = new ListNode(1);
            //head.next.next.next = new ListNode(0);
            //head.next.next.next.next = new ListNode(4);
            //head.next.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next.next = new ListNode(2);
            //head.next.next.next.next.next.next.next = new ListNode(0);

            //ListNode head = new ListNode(0);
            //head.next = new ListNode(24);
            //head.next.next = new ListNode(14);
            //head.next.next.next = new ListNode(0);

            //LeetCode_2181 classLeetCode = new LeetCode_2181();
            //ListNode result = classLeetCode.MergeNodes(head);

            //while (result != null) 
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            ////OR

            //ListNode result1 = leetCodeAll.MergeNodes(head);
            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(2200.) Find All K-Distant Indices in an Array (EASY)
            //int[] nums = [2, 1, 1, 1, 2];
            //int key = 2;
            //int k = 1;

            //LeetCode_2200 classLeetCode = new LeetCode_2200();
            //Console.WriteLine(string.Join(',', classLeetCode.FindKDistantIndices(nums, key, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindKDistantIndices(nums, key, k)));

            ////(2210.) Count Hills and Valleys in an Array (EASY)
            //int[] nums = [2, 4, 1, 1, 6, 5];

            //LeetCode_2210 classLeetCode = new LeetCode_2210();
            //Console.WriteLine(classLeetCode.CountHillValley(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountHillValley(nums));

            ////(2264.) Largest 3-Same-Digit Number in String (EASY)
            //string num = "42352338";

            //LeetCode_2264 classLeetCode = new LeetCode_2264();
            //Console.WriteLine(classLeetCode.LargestGoodInteger(num));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestGoodInteger(num));

            ////(2294.) Partition Array Such That Maximum Difference Is K (MEDIUM)
            //int[] nums = [3, 6, 1, 2, 5];
            //int k = 2;

            //LeetCode_2294 classLeetCode = new LeetCode_2294();
            //Console.WriteLine(classLeetCode.PartitionArray(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.PartitionArray(nums, k));

            ////(2311.) Longest Binary Subsequence Less Than or Equal to K (MEDIUM)
            //string s = "1001010";
            //int k = 5;

            //LeetCode_2311 classLeetCode = new LeetCode_2311();
            //Console.WriteLine(classLeetCode.LongestSubsequence(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestSubsequence(s, k));

            ////(2356.) Number of Unique Subjects Taught by Each Teacher (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            teacher_id,
            //            Count(distinct subject_id) as cnt 
            //        From Teacher 
            //        Group by teacher_id
            //    ";

            ////OR
            //LeetCode_2356 classLeetCode = new LeetCode_2356();

            ////(2396.) Strictly Palindromic Number (MEDIUM)
            //int n = 9;

            //LeetCode_2396 classLeetCode = new LeetCode_2396();
            //Console.WriteLine(classLeetCode.IsStrictlyPalindromic(n));

            ////OR

            //Console.WriteLine(leetCodeAll.IsStrictlyPalindromic(n));

            ////(2410.) Maximum Matching of Players With Trainers (MEDIUM)
            //int[] players = [4, 7, 9];
            //int[] trainers = [8, 2, 5, 8];

            //LeetCode_2410 classLeetCode = new LeetCode_2410();
            //Console.WriteLine(classLeetCode.MatchPlayersAndTrainers(players, trainers));

            ////OR

            //Console.WriteLine(leetCodeAll.MatchPlayersAndTrainers(players, trainers));

            ////(2413.) Smallest Even Multiple (EASY)
            int n = 6;

            LeetCode_2413 classLeetCode = new LeetCode_2413();
            Console.WriteLine(classLeetCode.SmallestEvenMultiple(n));

            //OR

            Console.WriteLine(leetCodeAll.SmallestEvenMultiple(n));

            ////(2419.) Longest Subarray With Maximum Bitwise AND (MEDIUM)
            //int[] nums = [100, 5, 5];

            //LeetCode_2419 classLeetCode = new LeetCode_2419();
            //Console.WriteLine(classLeetCode.LongestSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestSubarray(nums));

            ////(2433.) Find The Original Array of Prefix Xor (MEDIUM)
            //int[] pref = [5, 2, 0, 3, 1];

            //LeetCode_2433 classLeetCode = new LeetCode_2433();
            //Console.WriteLine(string.Join(',', classLeetCode.FindArray(pref)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindArray(pref)));

            ////(2438.) Range Product Queries of Powers (MEDIUM)
            //int n = 15;
            //int[][] queries = [[0,1],[2, 2],[0,3]];

            //LeetCode_2438 classLeetCode = new LeetCode_2438();
            //Console.WriteLine(string.Join(',', classLeetCode.ProductQueries(n, queries)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ProductQueries(n, queries)));

            ////(2469.) Convert the Temperature (EASY)
            //double celsius = 36.5;

            //LeetCode_2469 classLeetCode = new LeetCode_2469();
            //Console.WriteLine(string.Join((':'), classLeetCode.ConvertTemperature(celsius)));

            ////OR

            //Console.WriteLine(string.Join((':'), leetCodeAll.ConvertTemperature(celsius)));

            ////(2529.) Maximum Count of Positive Integer and Negative Integer (EASY)
            //int[] nums = [-2, -1, -1, 0, 0, 0];

            //LeetCode_2529 classLeetCode = new LeetCode_2529();
            //Console.WriteLine(classLeetCode.MaximumCount(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumCount(nums));

            ////(2561.) Rearranging Fruits (HARD)
            //int[] basket1 = [4, 2, 2, 2];
            //int[] basket2 = [1, 4, 1, 2];

            //LeetCode_2561 classLeetCode = new LeetCode_2561();
            //Console.WriteLine(classLeetCode.MinCost(basket1, basket2));

            ////OR

            //Console.WriteLine(leetCodeAll.MinCost(basket1, basket2));

            ////(2566.) Maximum Difference by Remapping a Digit (EASY)
            //int num = 11891;

            //LeetCode_2566 classLeetCode = new LeetCode_2566();
            //Console.WriteLine(classLeetCode.MinMaxDifference(num));

            ////OR

            //Console.WriteLine(leetCodeAll.MinMaxDifference(num));

            ////(2616.) Minimize the Maximum Difference of Pairs (MEDIUM)
            //int[] nums = [10,1,2,7,1,3];
            //int p = 2;

            //LeetCode_2616 classLeetCode = new LeetCode_2616();
            //Console.WriteLine(classLeetCode.MinimizeMax(nums, p));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimizeMax(nums, p));

            ////(2769.) Find the Maximum Achievable Number (EASY)
            //int num = 3;
            //int t = 2;

            //LeetCode_2769 classLeetCode = new LeetCode_2769();
            //Console.WriteLine(classLeetCode.TheMaximumAchievableX(num, t));

            ////OR

            //Console.WriteLine(leetCodeAll.TheMaximumAchievableX(num, t));

            ////(2807.) Insert Greatest Common Divisors in Linked List (MEDIUM)
            //ListNode head = new ListNode(18);
            //head.next = new ListNode(6);
            //head.next.next = new ListNode(10);
            //head.next.next.next = new ListNode(3);

            //LeetCode_2807 classLeetCode = new LeetCode_2807();
            //var result = classLeetCode.InsertGreatestCommonDivisors(head);

            //while (result != null) 
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            ////OR

            //var result1 = leetCodeAll.InsertGreatestCommonDivisors(head);

            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(2894.) Divisible and Non-divisible Sums Difference (EASY)
            //int n = 10;
            //int m = 3;

            //LeetCode_2894 classLeetCode = new LeetCode_2894();
            //Console.WriteLine(classLeetCode.DifferenceOfSums(n, m));

            ////OR

            //Console.WriteLine(leetCodeAll.DifferenceOfSums(n, m));

            ////(2942.) Find Words Containing Character (EASY)
            //string[] words = ["leet", "code"];
            //char x = 'e';

            //LeetCode_2942 classLeetCode = new LeetCode_2942();
            //Console.WriteLine(string.Join(',', classLeetCode.FindWordsContaining(words, x)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindWordsContaining(words, x)));

            ////(2966.) Divide Array Into Arrays With Max Difference (MEDIUM)
            //int[] nums = [1, 3, 4, 8, 7, 9, 3, 5, 1];
            //int k = 2;

            //LeetCode_2966 classLeetCode = new LeetCode_2966();
            //int[][] result = classLeetCode.DivideArray(nums, k);

            //foreach (int[] num in result) 
            //{
            //    Console.WriteLine(string.Join(',', num));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.DivideArray(nums, k);

            //foreach (int[] num in result1)
            //{
            //    Console.WriteLine(string.Join(',', num));
            //}

            ////(3024.) Type of Triangle (EASY)
            //int[] nums = [8, 4, 2];

            //LeetCode_3024 classLeetCode = new LeetCode_3024();
            //Console.WriteLine(classLeetCode.TriangleType(nums));

            ////OR
            //Console.WriteLine(leetCodeAll.TriangleType(nums));

            ////(3085). Minimum Deletions to Make String K-Special (MEDIUM)
            //string word = "gzpgogrg";
            //int k = 1;

            //LeetCode_3085 classLeetCode = new LeetCode_3085();
            //Console.WriteLine(classLeetCode.MinimumDeletions(word, k));

            ////OR

            //Console.WriteLine(classLeetCode.MinimumDeletions(word, k));

            ////(3110.) Score of a String (EASY)
            //string s = "hello";

            //LeetCode_3110 classLeetCode = new LeetCode_3110();
            //Console.WriteLine(classLeetCode.ScoreOfString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ScoreOfString(s));

            ////(3136.) Valid Word (EASY)
            //string word = "PO@w8FWZ";

            //LeetCode_3136 classLeetCode = new LeetCode_3136();
            //Console.WriteLine(classLeetCode.IsValid(word));

            ////OR

            //Console.WriteLine(leetCodeAll.IsValid_Task3136(word));

            ////(3151.) Special Array I (EASY)
            //int[] nums = [4, 3, 1, 6];

            //LeetCode_3151 classLeetCode = new LeetCode_3151();
            //Console.WriteLine(classLeetCode.IsArraySpecial(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.IsArraySpecial(nums));

            ////(3190.) Find Minimum Operations to Make All Elements Divisible by Three (EASY)
            //int[] nums = [1, 2, 3, 4];

            //LeetCode_3190 classLeetCode = new LeetCode_3190();
            //Console.WriteLine(classLeetCode.MinimumOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumOperations(nums));

            ////(3201.) Find the Maximum Length of Valid Subsequence I (MEDIUM)
            //int[] nums = [1, 2, 1, 1, 2, 1, 2];

            //LeetCode_3201 classLeetCode = new LeetCode_3201();
            //Console.WriteLine(classLeetCode.MaximumLength(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumLength(nums));

            ////3202. Find the Maximum Length of Valid Subsequence II
            //int[] nums = [1, 4, 2, 3, 1, 4];
            //int k = 3;

            //LeetCode_3202 classLeetCode = new LeetCode_3202();
            //Console.WriteLine(classLeetCode.MaximumLength(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumLength(nums, k));

            ////(3280.) Convert Date to Binary (EASY)
            //string date = "2080-02-29";

            //LeetCode_3280 classLeetCode = new LeetCode_3280();
            //Console.WriteLine(classLeetCode.ConvertDateToBinary(date));

            ////OR

            //Console.WriteLine(leetCodeAll.ConvertDateToBinary(date));

            ////(3289.) The Two Sneaky Numbers of Digitville (EASY)
            //int[] nums = [7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2];

            //LeetCode_3289 classLeetCode = new LeetCode_3289();
            //Console.WriteLine(string.Join(',',classLeetCode.GetSneakyNumbers(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.GetSneakyNumbers(nums)));

            ////(3304.) Find the K-th Character in String Game I (EASY)
            //int k = 5;

            //LeetCode_3304 classLeetCode = new LeetCode_3304();
            //Console.WriteLine(classLeetCode.KthCharacter(k));

            ////OR

            //Console.WriteLine(leetCodeAll.KthCharacter(k));

            ////(3330.) Find the Original Typed String I (EASY)
            //string word = "abbcccc";

            //LeetCode_3330 classLeetCode = new LeetCode_3330();
            //Console.WriteLine(classLeetCode.PossibleStringCount(word));

            ////OR

            //Console.WriteLine(leetCodeAll.PossibleStringCount(word));

            ////(3423.) Maximum Difference Between Adjacent Elements in a Circular Array (EASY)
            //int[] nums = [-5, -10, -5];

            //LeetCode_3423 classLeetCode = new LeetCode_3423();
            //Console.WriteLine(classLeetCode.MaxAdjacentDistance(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxAdjacentDistance(nums));

            ////(3439.) Reschedule Meetings for Maximum Free Time I (MEDIUM)
            //int eventTime = 99;
            //int k = 1;
            //int[] startTime = [7, 21, 25];
            //int[] endTime = [13, 25, 78];

            //LeetCode_3439 classleetCode = new LeetCode_3439();
            //Console.WriteLine(classleetCode.MaxFreeTime(eventTime, k, startTime, endTime));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxFreeTime(eventTime, k, startTime, endTime));

            ////(3440.) Reschedule Meetings for Maximum Free Time II (MEDIUM)
            //int eventTime = 84;
            //int[] startTime = [4, 6, 9, 10, 22, 48, 78];
            //int[] endTime = [6, 7, 10, 11, 46, 60, 84];

            //LeetCode_3440 classLeetCode = new LeetCode_3440();
            //Console.WriteLine(classLeetCode.MaxFreeTime(eventTime, startTime, endTime));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxFreeTime(eventTime, startTime, endTime));

            ////(3442.) Maximum Difference Between Even and Odd Frequency I (EASY)
            //string s = "aaaaabbc";

            //LeetCode_3442 classLeetCode = new LeetCode_3442();
            //Console.WriteLine(classLeetCode.MaxDifference(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDifference(s));

            ////(3443.) Maximum Manhattan Distance After K Changes (MEDIUM)
            //string s = "NWSE";
            //int k = 1;

            //LeetCode_3443 classLeetCode = new LeetCode_3443();
            //Console.WriteLine(classLeetCode.MaxDistance(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDistance(s, k));

            ////(3467.) Transform Array by Parity (EASY)
            //int[] nums = [4, 3, 2, 1];

            //LeetCode_3467 classLeetCode = new LeetCode_3467();
            //int[] result = classLeetCode.TransformArray(nums);

            //Console.WriteLine(string.Join(',', result));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.TransformArray(nums)));

            ////(3477.) Fruits Into Baskets II (EASY)
            //int[] fruits = [4, 2, 5];
            //int[] baskets = [3, 5, 4];

            //LeetCode_3477 classLeetCode = new LeetCode_3477();
            //Console.WriteLine(classLeetCode.NumOfUnplacedFruits(fruits, baskets));

            ////OR

            //Console.WriteLine(leetCodeAll.NumOfUnplacedFruits(fruits, baskets));

            ////(3479.) Fruits Into Baskets III (MEDIUM)
            //int[] fruits = [4, 2, 5];
            //int[] baskets = [3, 5, 4];

            //LeetCode_3479 classLeetCode = new LeetCode_3479();
            //Console.WriteLine(classLeetCode.NumOfUnplacedFruits(fruits, baskets));

            ////OR

            //Console.WriteLine(leetCodeAll.NumOfUnplacedFruits(fruits, baskets));

            ////(3487.) Maximum Unique Subarray Sum After Deletion (EASY)
            //int[] nums = [-10, 18, 1, 18, -5];

            //LeetCode_3487 classLeetCode = new LeetCode_3487();
            //Console.WriteLine(classLeetCode.MaxSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxSum(nums));




























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
