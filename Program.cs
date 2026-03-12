using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProblemSolving.LeetCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Xml.Linq;
using static ProblemSolving.LeetCode.LeetCode_1476;
using static ProblemSolving.LeetCode.LeetCode_1656;
using static ProblemSolving.LeetCode.LeetCode_2043;
using static ProblemSolving.LeetCode.LeetCode_225;
using static ProblemSolving.LeetCode.LeetCode_232;
using static ProblemSolving.LeetCode.LeetCode_303;
using static ProblemSolving.LeetCode.LeetCode_380;
using static ProblemSolving.LeetCode.LeetCode_535;
using static ProblemSolving.LeetCode.LeetCode_703;
using static ProblemSolving.LeetCode.LeetCode_705;
using static ProblemSolving.LeetCode.LeetCode_706;
using static ProblemSolving.LeetCode.LeetCode_933;
using static ProblemSolving.LeetCodeAll;
using static System.Formats.Asn1.AsnWriter;
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

            //(190.) Reverse Bits (EASY)
            //int n = 43261596;
            //Console.WriteLine(leetCodeAll.ReverseBits(n));
            ////OR
            //LeetCode_190 classLeetCode = new LeetCode_190();
            //Console.WriteLine(classLeetCode.ReverseBits(n));

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

            ////(295.) Find Median from Data Strea (HARD)
            //LeetCode_295.MedianFinder medianFinder1 = new LeetCode_295.MedianFinder();
            //medianFinder1.AddNum(1);    // arr = [1]
            //medianFinder1.AddNum(2);    // arr = [1, 2]
            //Console.WriteLine(medianFinder1.FindMedian()); // return 1.5 (i.e., (1 + 2) / 2)
            //medianFinder1.AddNum(3);    // arr[1, 2, 3]
            //Console.WriteLine(medianFinder1.FindMedian()); // return 2.0

            ////OR

            //MedianFinderTask295 medianFinder2 = new MedianFinderTask295();
            //medianFinder2.AddNum(1);    // arr = [1]
            //medianFinder2.AddNum(2);    // arr = [1, 2]
            //Console.WriteLine(medianFinder2.FindMedian()); // return 1.5 (i.e., (1 + 2) / 2)
            //medianFinder2.AddNum(3);    // arr[1, 2, 3]
            //Console.WriteLine(medianFinder2.FindMedian()); // return 2.0

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

            ////(419.) Battleships in a Board (MEDIUM)
            //char[][] board = [['X', '.', 'X', '.', 'X'], ['.', 'X', '.', 'X', '.'], ['.', 'X', '.', '.', '.'], ['.', 'X', '.', '.', 'X'], ['.', 'X', '.', '.', '.'], ['X', '.', 'X', 'X', 'X'], ['.', 'X', '.', '.', '.'], ['.', 'X', '.', 'X', '.'], ['X', '.', 'X', '.', 'X'], ['.', 'X', '.', '.', 'X']];

            //LeetCode_419 classLeetCode = new LeetCode_419();
            //Console.WriteLine(classLeetCode.CountBattleships(board));

            ////OR

            //Console.WriteLine(leetCodeAll.CountBattleships(board));

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

            ////(442.) Find All Duplicates in an Array (MEDIUM)
            //int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];

            //LeetCode_442 classLeetCode = new LeetCode_442();

            //foreach (var item in classLeetCode.FindDuplicates(nums))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.FindDuplicates(nums))
            //{
            //    Console.WriteLine(item);
            //}

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

            ///(498.) Diagonal Traverse (MEDIUM)
            //int[][] mat = [[2, 5], [8, 4], [0, -1]];

            //LeetCode_498 classLeetCode = new LeetCode_498();
            //Console.WriteLine(string.Join(',', classLeetCode.FindDiagonalOrder(mat)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindDiagonalOrder(mat)));

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

            ////(535.) Encode and Decode TinyURL (MEDIUM)
            //string url = "http://example.com/art.htm";

            //LeetCode_535.Codec codec = new LeetCode_535.Codec();
            //Console.WriteLine(codec.decode(codec.encode(url)));

            ////OR

            //LeetCodeAll.CodecTask535 codec1 = new LeetCodeAll.CodecTask535();
            //Console.WriteLine(codec1.decode(codec1.encode(url)));

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

            ////(611.) Valid Triangle Number (MEDIUM)
            //int[] nums = [2, 2, 3, 4];

            //LeetCode_611 classLeetCode = new LeetCode_611();
            //Console.WriteLine(classLeetCode.TriangleNumber(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.TriangleNumber(nums));

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

            ////(700.) Search in a Binary Search Tree (EASY)
            //int val = 5;
            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);
            //root.right = new TreeNode(7);

            //LeetCode_700 classLeetCode = new LeetCode_700();
            //classLeetCode.SearchBST(root, val);

            ////OR

            //leetCodeAll.SearchBST(root, val);

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

            ////(712.) Minimum ASCII Delete Sum for Two Strings (MEDIUM)
            //string s1 = "delete";
            //string s2 = "leet";

            //LeetCode_712 classLeetCode = new LeetCode_712();
            //Console.WriteLine(classLeetCode.MinimumDeleteSum(s1, s2));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumDeleteSum(s1, s2));

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

            ////(763.) Partition Labels (MEDIUM)
            //string s = "caedbdedda";

            //LeetCode_763 classLeetCode = new LeetCode_763();
            //foreach (var item in classLeetCode.PartitionLabels(s))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.PartitionLabels(s))
            //{
            //    Console.WriteLine(item);
            //}

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

            ////(797.) All Paths From Source to Target (MEDIUM)
            //int[][] graph = [[4, 3, 1], [3, 2, 4], [3], [4], []];

            //LeetCode_797 classLeetCode = new LeetCode_797();
            //IList<IList<int>> result =  classLeetCode.AllPathsSourceTarget(graph);

            //foreach (IList<int> path in result) 
            //{
            //    Console.WriteLine(string.Join(',', path));            
            //}

            ////OR

            //IList<IList<int>> result1 = classLeetCode.AllPathsSourceTarget(graph);

            //foreach (IList<int> path in result1)
            //{
            //    Console.WriteLine(string.Join(',', path));
            //}

            ////(799.) Champagne Tower (MEDIUM)
            //int poured = 0;
            //int query_row = 1;
            //int query_glass = 0;

            //LeetCode_799 classLeetCode = new LeetCode_799();
            //Console.WriteLine(classLeetCode.ChampagneTower(poured, query_row, query_glass));

            ////OR

            //Console.WriteLine(leetCodeAll.ChampagneTower(poured, query_row, query_glass));

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

            ////(807.) Max Increase to Keep City Skyline (MEDIUM)
            //int[][] grid = [[3, 0, 8, 4], [2, 4, 5, 7], [9, 2, 6, 3], [0, 3, 1, 0]];

            //LeetCode_807 classLeetCode = new LeetCode_807();
            //Console.WriteLine(classLeetCode.MaxIncreaseKeepingSkyline(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxIncreaseKeepingSkyline(grid));

            ////(808.) Soup Servings (MEDIUM)
            //int n = 100;

            //LeetCode_808 classLeetCode = new LeetCode_808();
            //Console.WriteLine(classLeetCode.SoupServings(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SoupServings(n));

            ////(811.) Subdomain Visit Count (MEDIUM)
            //string[] cpdomains = ["900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"];

            //LeetCode_811 classLeetCode = new LeetCode_811();

            //foreach (var item in classLeetCode.SubdomainVisits(cpdomains))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.SubdomainVisits(cpdomains))
            //{
            //    Console.WriteLine(item);
            //}

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

            ////(852.) Peak Index in a Mountain Array (MEDIUM)
            //int[] arr = [0, 10, 5, 2];

            //LeetCode_852 classLeetCode = new LeetCode_852();
            //Console.WriteLine(classLeetCode.PeakIndexInMountainArray(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.PeakIndexInMountainArray(arr));

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

            ////(885.) Spiral Matrix III (MEDIUM)
            //int rows = 5, cols = 6, rStart = 1, cStart = 4;

            //LeetCode_885 classLeetCode = new LeetCode_885();
            //int[][] result = classLeetCode.SpiralMatrixIII(rows, cols, rStart, cStart);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.SpiralMatrixIII(rows, cols, rStart, cStart))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

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

            ////(890.) Find and Replace Pattern (MEDIUM)
            //string[] words = ["abc", "deq", "mee", "aqq", "dkd", "ccc"];
            //string pattern = "abb";

            //LeetCode_890 classLeetCode = new LeetCode_890();
            //foreach (string word in classLeetCode.FindAndReplacePattern(words, pattern))
            //{
            //    Console.WriteLine(word);
            //}

            ////OR

            //foreach (string word in leetCodeAll.FindAndReplacePattern(words, pattern))
            //{
            //    Console.WriteLine(word);
            //}

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

            ////(921.) Minimum Add to Make Parentheses Valid (MEDIUM)
            //string s = "())";

            //LeetCode_921 classLeetCode =  new LeetCode_921();
            //Console.WriteLine(classLeetCode.MinAddToMakeValid(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinAddToMakeValid(s));

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

            ////(938.) Range Sum of BST (EASY)
            //TreeNode root = new TreeNode(10);
            //root.left = new TreeNode(5);
            //root.left.left = new TreeNode(3);
            //root.left.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(7);
            //root.left.right.left = new TreeNode(6);
            //root.right = new TreeNode(15);
            //root.right.left = new TreeNode(13);
            //root.right.right = new TreeNode(18);

            //int low = 6;
            //int high = 10;

            //LeetCode_938 classLeetCode = new LeetCode_938();
            //Console.WriteLine(classLeetCode.RangeSumBST(root, low, high));

            ////OR

            //Console.WriteLine(leetCodeAll.RangeSumBST(root, low, high));

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

            ////(950.) Reveal Cards In Increasing Order (MEDIUM)
            //int[] deck = [17, 13, 11, 2, 3, 5, 7];

            //LeetCode_950 classLeetCode = new LeetCode_950();
            //Console.WriteLine(string.Join(',', classLeetCode.DeckRevealedIncreasing(deck)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.DeckRevealedIncreasing(deck)));

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

            ////(966.) Vowel Spellchecker (MEDIUM)
            //string[] wordlist = ["KiTe", "kite", "hare", "Hare"];
            //string[] queries = ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"];

            //LeetCode_966 classLeetCode = new LeetCode_966();
            //Console.WriteLine(string.Join(',', classLeetCode.Spellchecker(wordlist, queries)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.Spellchecker(wordlist, queries)));

            //////(973.) K Closest Points to Origin (MEDIUM)
            //int[][] points = [[3, 3], [5, -1], [-2, 4]];
            //int k = 2;

            //LeetCode_973 classLeetCode = new LeetCode_973();
            //foreach (var item in classLeetCode.KClosest(points, k)) 
            //{
            //    Console.WriteLine(string.Join(',',item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.KClosest(points, k))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

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

            ////(980.) Unique Paths III (HARD)
            //int[][] grid = [[0, 1], [2, 0]];

            //LeetCode_980 classLeetCode = new LeetCode_980();
            //Console.WriteLine(classLeetCode.UniquePathsIII(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.UniquePathsIII(grid));

            ////(985.) Sum of Even Numbers After Queries (MEDIUM)
            //int[] nums = [1, 2, 3, 4];
            //int[][] queries = [[1, 0], [-3, 1], [-4, 0], [2, 3]];

            //LeetCode_985 classLeetCode = new LeetCode_985();
            //Console.WriteLine(string.Join(',', classLeetCode.SumEvenAfterQueries(nums, queries)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SumEvenAfterQueries(nums, queries)));

            ////(989.) Add to Array-Form of Integer (EASY)
            //int[] num = [1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3];
            //int k = 516;

            //LeetCode_989 classLeetCode = new LeetCode_989();
            //Console.WriteLine(string.Join(',', classLeetCode.AddToArrayForm(num, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.AddToArrayForm(num, k)));

            ////(993.) Cousins in Binary Tree (EASY)
            //int x = 2;
            //int y = 3;

            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.right = new TreeNode(4);
            //root.right = new TreeNode(3);

            //LeetCode_993 classLeetCode = new LeetCode_993();
            //Console.WriteLine(classLeetCode.IsCousins(root, x, y));

            ////OR

            //Console.WriteLine(leetCodeAll.IsCousins(root, x, y));

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

            ////(1015.) Smallest Integer Divisible by K (MEDIUM)
            //int k = 3;

            //LeetCode_1015 classLeetCode = new LeetCode_1015();
            //Console.WriteLine(classLeetCode.SmallestRepunitDivByK(k));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestRepunitDivByK(k));

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

            ////(1079.) Letter Tile Possibilities (MEDIUM)
            //string tiles = "AAABBC";

            //LeetCode_1079 classLeetCode = new LeetCode_1079();
            //Console.WriteLine(classLeetCode.NumTilePossibilities(tiles));

            ////OR

            //Console.WriteLine(leetCodeAll.NumTilePossibilities(tiles));

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

            ////(1094.) Car Pooling (MEDIUM)
            //int[][] trips = [[2, 1, 5], [3, 3, 7]];
            //int capacity = 3;

            //LeetCode_1094 classLeetCode = new LeetCode_1094();

            //Console.WriteLine(classLeetCode.CarPooling(trips, capacity));

            ////OR

            //Console.WriteLine(leetCodeAll.CarPooling(trips, capacity));

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

            ////(1161.) Maximum Level Sum of a Binary Tree (MEDIUM)
            //TreeNode root = new TreeNode(1);
            //root.right = new TreeNode(0);
            //root.left = new TreeNode(7);
            //root.left.left = new TreeNode(7);
            //root.left.right = new TreeNode(-8);

            //LeetCode_1161 classLeetCode = new LeetCode_1161();

            //Console.WriteLine(classLeetCode.MaxLevelSum(root));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxLevelSum(root));

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

            ////(1232.) Check If It Is a Straight Line (EASY)
            //int[][] coordinates = [[0, 0], [0, 1], [0, -1]];

            //LeetCode_1232 classLeetCode = new LeetCode_1232();
            //Console.WriteLine(classLeetCode.CheckStraightLine(coordinates));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckStraightLine(coordinates));

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

            ////(1252.) Cells with Odd Values in a Matrix (EASY)
            //int m = 2;
            //int n = 3;
            //int[][] indices = [[0, 1], [1, 1]];

            //LeetCode_1252 classLeetCode = new LeetCode_1252();
            //Console.WriteLine(classLeetCode.OddCells(m, n, indices));

            ////OR

            //Console.WriteLine(leetCodeAll.OddCells(m, n, indices));

            ////(1262. Greatest Sum Divisible by Three (MEDIUM)
            //int[] nums = [1, 2, 3, 4, 4];

            //LeetCode_1262 classLeetCode = new LeetCode_1262();
            //Console.WriteLine(classLeetCode.MaxSumDivThree(nums));

            //////OR

            //Console.WriteLine(leetCodeAll.MaxSumDivThree(nums));

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

            ////(1277.) Count Square Submatrices with All Ones (MEDIUM)
            //int[][] matrix = [[0, 1, 1, 1], [1, 1, 1, 1], [0, 1, 1, 1]];

            //LeetCode_1277 classLeetCode = new LeetCode_1277();
            //Console.WriteLine(classLeetCode.CountSquares(matrix));

            ////OR

            //Console.WriteLine(leetCodeAll.CountSquares(matrix));

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

            ////(1281.) Subtract the Product and Sum of Digits of an Integer (EASY)
            //int n = 4421;

            //LeetCode_1281 classLeetCode =  new LeetCode_1281();
            //Console.WriteLine(classLeetCode.SubtractProductAndSum(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SubtractProductAndSum(n));

            ////(1282.) Group the People Given the Group Size They Belong To (MEDIUM)
            //int[] groupSizes = [3, 3, 3, 3, 3, 1, 3];

            //LeetCode_1282 classLeetCode = new LeetCode_1282();
            //IList<IList<int>> result = classLeetCode.GroupThePeople(groupSizes);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //IList<IList<int>> result1 = leetCodeAll.GroupThePeople(groupSizes);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(1287.) Element Appearing More Than 25% In Sorted Array (EASY)
            //int[] arr = arr = [1, 2, 2, 6, 6, 6, 6, 7, 10];

            //LeetCode_1287 classLeetCode = new LeetCode_1287();
            //Console.WriteLine(classLeetCode.FindSpecialInteger(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.FindSpecialInteger(arr));

            ////(1290.) Convert Binary Number in a Linked List to Integer (EASY)
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(0);
            //head.next.next = new ListNode(1);

            //LeetCode_1290 classLeetCode = new LeetCode_1290();
            //Console.WriteLine(classLeetCode.GetDecimalValue(head));

            ////OR

            //Console.WriteLine(leetCodeAll.GetDecimalValue(head));

            ////(1295.) Find Numbers with Even Number of Digits (EASY)
            //int[] nums = [12, 345, 2, 6, 7896];

            //LeetCode_1295 classLeetCode = new LeetCode_1295();
            //Console.WriteLine(classLeetCode.FindNumbers(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindNumbers(nums));

            ////(1299.) Replace Elements with Greatest Element on Right Side (EASY)
            //int[] arr = [17,18,5,4,6,1];

            //LeetCode_1299 classLeetCode = new LeetCode_1299();
            //Console.WriteLine(string.Join(',',classLeetCode.ReplaceElements(arr)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ReplaceElements(arr)));

            ////(1302.) Deepest Leaves Sum (MEDIUM)
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.left.right = new TreeNode(5);
            //root.left.left = new TreeNode(4);
            //root.left.left.left = new TreeNode(7);
            //root.right = new TreeNode(3);
            //root.right.right = new TreeNode(6);
            //root.right.right.right = new TreeNode(8);

            //LeetCode_1302 classLeetCode = new LeetCode_1302();
            //Console.WriteLine(classLeetCode.DeepestLeavesSum(root));

            ////OR

            //Console.WriteLine(leetCodeAll.DeepestLeavesSum(root));

            ////(1304.) Find N Unique Integers Sum up to Zero (EASY)
            //int n = 4;

            //LeetCode_1304 classLeetCode = new LeetCode_1304();
            //Console.WriteLine(string.Join(',', classLeetCode.SumZero(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SumZero(n)));

            ////(1305.) All Elements in Two Binary Search Trees (MEDIUM)
            //TreeNode root1 = new TreeNode(2);
            //root1.left = new TreeNode(1);
            //root1.right = new TreeNode(4);

            //TreeNode root2 = new TreeNode(1);
            //root2.left = new TreeNode(0);
            //root2.right = new TreeNode(3);

            //LeetCode_1305 classLeetCode = new LeetCode_1305();
            //Console.WriteLine(string.Join(',', classLeetCode.GetAllElements(root1, root2)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.GetAllElements(root1, root2)));

            ////(1309.) Decrypt String from Alphabet to Integer Mapping (EASY)
            //string s = "1326#";

            //LeetCode_1309 classLeetCode = new LeetCode_1309();
            //Console.WriteLine(classLeetCode.FreqAlphabets(s));

            ////OR

            //Console.WriteLine(leetCodeAll.FreqAlphabets(s));

            ////(1310.) XOR Queries of a Subarray (MEDIUM)
            //int[] arr = [1, 3, 4, 8];
            //int[][] queries = [[0, 1], [1, 2], [0, 3], [3, 3]];

            //LeetCode_1310 classLeetCode = new LeetCode_1310();
            //Console.WriteLine(string.Join(',', classLeetCode.XorQueries(arr, queries)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.XorQueries(arr, queries)));

            ////(1313.) Decompress Run-Length Encoded List (EASY)
            //int[] nums = [1, 2, 3, 4];

            //LeetCode_1313 classLeetCode = new LeetCode_1313();
            //Console.WriteLine(string.Join(',', classLeetCode.DecompressRLElist(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.DecompressRLElist(nums)));

            ////(1317.) Convert Integer to the Sum of Two No-Zero Integers (EASY)
            //int n = 10000;

            //LeetCode_1317 classLeetCode = new LeetCode_1317();
            //Console.WriteLine(string.Join(',', classLeetCode.GetNoZeroIntegers(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.GetNoZeroIntegers(n)));

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

            ////(1329.) Sort the Matrix Diagonally (MEDIUM)
            //int[][] mat = mat = [[3, 3, 1, 1], [2, 2, 1, 2], [1, 1, 1, 2]];

            //LeetCode_1329 classLeetCode = new LeetCode_1329();
            //int[][] result = classLeetCode.DiagonalSort(mat);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(string.Join(',',item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.DiagonalSort(mat);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(1332.) Remove Palindromic Subsequences (EASY)
            //string s = "ababa";

            //LeetCode_1332 classLeetCode = new LeetCode_1332();
            //Console.WriteLine(classLeetCode.RemovePalindromeSub(s));

            ////OR

            //Console.WriteLine(leetCodeAll.RemovePalindromeSub(s));

            ////(1337.) The K Weakest Rows in a Matrix (EASY)
            //int[][] mat = [[1,1,0,0,0], [1,1,1,1,0], [1,0,0,0,0], [1,1,0,0,0], [1,1,1,1,1]];
            //int k = 3;

            //LeetCode_1337 classLeetCode = new LeetCode_1337();
            //Console.WriteLine(string.Join(',',classLeetCode.KWeakestRows(mat, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.KWeakestRows(mat, k)));

            ////(1338.) Reduce Array Size to The Half (MEDIUM)
            //int[] arr = [3, 3, 3, 3, 5, 5, 5, 2, 2, 7];

            //LeetCode_1338 classLeetCode = new LeetCode_1338();
            //Console.WriteLine(classLeetCode.MinSetSize(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.MinSetSize(arr));

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

            ////(1342.) Number of Steps to Reduce a Number to Zero (EASY)
            //int num = 14;

            //LeetCode_1342 classLeetCode = new LeetCode_1342();
            //Console.WriteLine(classLeetCode.NumberOfSteps(num));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfSteps(num));

            ////(1346.) Check If N and Its Double Exist (EASY)
            //int[] arr = [10,2,5,3];

            //LeetCode_1346 classLeetCode = new LeetCode_1346();
            //Console.WriteLine(classLeetCode.CheckIfExist(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckIfExist(arr));

            ////(1347.) Minimum Number of Steps to Make Two Strings Anagram ()
            //string s = "leetcode";
            //string t = "practice";

            //LeetCode_1347 classLeetCode = new LeetCode_1347();
            //Console.WriteLine(classLeetCode.MinSteps(s, t));

            ////OR

            //Console.WriteLine(leetCodeAll.MinSteps(s, t));

            ////(1351.) Count Negative Numbers in a Sorted Matrix (EASY)
            //int[][] grid = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]];

            //LeetCode_1351 classLeetCode = new LeetCode_1351();
            //Console.WriteLine(classLeetCode.CountNegatives(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.CountNegatives(grid));

            ////(1356.) Sort Integers by The Number of 1 Bits (EASY)
            //int[] arr = [1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1];

            //LeetCode_1356 classLeetCode = new LeetCode_1356();
            //Console.WriteLine(string.Join(',', classLeetCode.SortByBits(arr)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortByBits(arr)));

            ////(1365.) How Many Numbers Are Smaller Than the Current Number (EASY)
            //int[] nums = [8, 1, 2, 2, 3];

            //LeetCode_1365 classLeetCode = new LeetCode_1365();
            //Console.WriteLine(string.Join(',', classLeetCode.SmallerNumbersThanCurrent(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SmallerNumbersThanCurrent(nums)));

            ////(1370.) Increasing Decreasing String (EASY)
            //string s = "aaaabbbbcccc";

            //LeetCode_1370 classLeetCode = new LeetCode_1370();
            //Console.WriteLine(classLeetCode.SortString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.SortString(s));

            ////(1374.) Generate a String With Characters That Have Odd Counts (EASY)
            //int n = 4;

            //LeetCode_1374 classLeetCode = new LeetCode_1374();
            //Console.WriteLine(classLeetCode.GenerateTheString(n));

            ////OR

            //Console.WriteLine(leetCodeAll.GenerateTheString(n));

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

            ////(1380.) Lucky Numbers in a Matrix (EASY)
            //int[][] matrix = [[3,7,8], [9,11,13], [15,16,17]];

            //LeetCode_1380 classLeetCode = new LeetCode_1380();
            //Console.WriteLine(string.Join(',',classLeetCode.LuckyNumbers(matrix)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.LuckyNumbers(matrix)));

            ////(1381.) Design a Stack With Increment Operation (MEDIUM)
            //LeetCode_1381.CustomStack stk = new LeetCode_1381.CustomStack(3);
            //stk.Push(1);
            //stk.Push(2);
            //Console.WriteLine(stk.Pop());
            //stk.Push(2);
            //stk.Push(3);
            //stk.Push(4);
            //stk.Increment(5, 100);
            //stk.Increment(2, 100);
            //Console.WriteLine(stk.Pop());
            //Console.WriteLine(stk.Pop());
            //Console.WriteLine(stk.Pop());

            ////OR
            //CustomStack stk1 = new CustomStack(3);
            //stk1.Push(1);
            //stk1.Push(2);
            //Console.WriteLine(stk1.Pop());
            //stk1.Push(2);
            //stk1.Push(3);
            //stk1.Push(4);
            //stk1.Increment(5, 100);
            //stk1.Increment(2, 100);
            //Console.WriteLine(stk1.Pop());
            //Console.WriteLine(stk1.Pop());
            //Console.WriteLine(stk1.Pop());

            ////(1385.) Find the Distance Value Between Two Arrays (EASY)
            //int[] arr1 = [4, 5, 8];
            //int[] arr2 = [10,9,1,8];
            //int d = 2;

            //LeetCode_1385 classLeetCode = new LeetCode_1385();
            //Console.WriteLine(classLeetCode.FindTheDistanceValue(arr1, arr2, d));

            ////OR

            //Console.WriteLine(leetCodeAll.FindTheDistanceValue(arr1, arr2, d));

            ////(1389.) Create Target Array in the Given Order (EASY)
            //int[] nums = [0, 1, 2, 3, 4];
            //int[] index = [0, 1, 2, 2, 1];

            //LeetCode_1389 classLeetCode = new LeetCode_1389();
            //Console.WriteLine(string.Join(',', classLeetCode.CreateTargetArray(nums, index)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.CreateTargetArray(nums, index)));

            ////(1390.) Four Divisors (MEDIUM)
            //int[] nums = [21, 4, 7];

            //LeetCode_1390 classLeetCode = new LeetCode_1390();
            //Console.WriteLine(classLeetCode.SumFourDivisors(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SumFourDivisors(nums));

            ////(1393.) Capital Gain/Loss (MEDIUM)
            //string SqlQuery =
            //    @"
            //        Select
            //            Distinct(a.stock_name)
            //            ,(c.SumSell - b.SumBuy) as capital_gain_loss 
            //        From Stocks a 
            //            join (Select
            //            stock_name
            //            ,SUM(price) as SumBuy
            //        From Stocks
            //        Where operation = 'Buy'
            //        GROUP BY stock_name) b
            //        ON a.stock_name = b.stock_name
            //            join (Select
            //            stock_name
            //            ,SUM(price) as SumSell
            //        From Stocks
            //        Where operation = 'Sell'
            //        GROUP BY stock_name) c
            //        ON a.stock_name = c.stock_name
            //    ";

            ////OR

            //LeetCode_1393 classLeetCode = new LeetCode_1393();

            ////(1394.) Find Lucky Integer in an Array (EASY)
            //int[] arr = [1, 2, 2, 3, 3, 3];

            //LeetCode_1394 classLeetCode = new LeetCode_1394();
            //Console.WriteLine(classLeetCode.FindLucky(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLucky(arr));

            ////(1402.) Reducing Dishes (HARD)
            //int[] satisfaction = [4, 3, 2];

            //LeetCode_1402 classLeetCode = new LeetCode_1402();
            //Console.WriteLine(classLeetCode.MaxSatisfaction(satisfaction));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxSatisfaction(satisfaction));

            ////(1403.) Minimum Subsequence in Non-Increasing Order (EASY)
            //int[] nums = [4, 4, 7, 6, 7];

            //LeetCode_1403 classLeetCode = new LeetCode_1403();
            //Console.WriteLine(string.Join(',', classLeetCode.MinSubsequence(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MinSubsequence(nums)));

            ////(1404.) Number of Steps to Reduce a Number in Binary Representation to One (MEDIUM)
            //string s = "1101";

            //LeetCode_1404 classLeetCode = new LeetCode_1404();
            //Console.WriteLine(classLeetCode.NumSteps(s));

            ////OR

            //Console.WriteLine(leetCodeAll.NumSteps(s));

            ////(1408.) String Matching in an Array (EASY)
            //string[] words = ["mass", "as", "hero", "superhero"];

            //LeetCode_1408 classLeetCode = new LeetCode_1408();
            //foreach (string word in classLeetCode.StringMatching(words)) 
            //{
            //    Console.WriteLine(word);
            //}

            ////OR

            //foreach (string word in leetCodeAll.StringMatching(words))
            //{
            //    Console.WriteLine(word);
            //}

            ////(1409.) Queries on a Permutation With Key (MEDIUM)
            //int[] queries = [3, 1, 2, 1];
            //int m = 5;

            //LeetCode_1409 classLeetCode = new LeetCode_1409();
            //Console.WriteLine(string.Join(',', classLeetCode.ProcessQueries(queries, m)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ProcessQueries(queries, m)));

            ////(1413.) Minimum Value to Get Positive Step by Step Sum (EASY)
            //int[] nums = [-3,2,-3,4,2];

            //LeetCode_1413 classLeetCode = new LeetCode_1413();
            //Console.WriteLine(classLeetCode.MinStartValue(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinStartValue(nums));

            ////(1415.) The k-th Lexicographical String of All Happy Strings of Length n (MEDIUM)
            //int n = 3;
            //int k = 9;

            //LeetCode_1415 classLeetCode = new LeetCode_1415();
            //Console.WriteLine(classLeetCode.GetHappyString(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.GetHappyStringTask1415(n, k));

            ////(1417.) Reformat The String (EASY)
            //string s = "covid2019";

            //LeetCode_1417 classLeetCode = new LeetCode_1417();
            //Console.WriteLine(classLeetCode.Reformat(s));

            ////OR

            //Console.WriteLine(leetCodeAll.Reformat(s));

            ////(1422.) Maximum Score After Splitting a String (EASY)
            //string s = "011101";

            //LeetCode_1422 classLeetCode = new LeetCode_1422();
            //Console.WriteLine(classLeetCode.MaxScore(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxScore(s));

            ////(1431.) Kids With the Greatest Number of Candies (EASY)
            //int[] candies = [2, 3, 5, 1, 3];
            //int extraCandies = 3;

            //LeetCode_1431 classLeetCode = new LeetCode_1431();
            //Console.WriteLine(string.Join(',', classLeetCode.KidsWithCandies(candies, extraCandies)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.KidsWithCandies(candies, extraCandies)));

            ////(1432.) Max Difference You Can Get From Changing an Integer (MEDIUM)
            //int num = 90270580;

            //LeetCode_1432 classLeetCode = new LeetCode_1432();
            //Console.WriteLine(classLeetCode.MaxDiff(num));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDiff(num));

            ////(1436.) Destination City (EASY)
            //IList<IList<string>> paths = [["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]];

            //LeetCode_1436 classLeetCode = new LeetCode_1436();
            //Console.WriteLine(classLeetCode.DestCity(paths));

            ////OR

            //Console.WriteLine(leetCodeAll.DestCity(paths));

            ////(1437.) Check If All 1's Are at Least Length K Places Away (EASY)
            //int[] nums = [1, 0, 0, 0, 1, 0, 0, 1];
            //int k = 2;

            //LeetCode_1437 classLeetCode = new LeetCode_1437();
            //Console.WriteLine(classLeetCode.KLengthApart(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.KLengthApart(nums, k));

            ////(1441.) Build an Array With Stack Operations (MEDIUM)
            //int[] target = [1];
            //int n = 2;

            //LeetCode_1441 classLeetCode = new LeetCode_1441();
            //foreach (var item in classLeetCode.BuildArray(target, n))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.BuildArray(target, n))
            //{
            //    Console.WriteLine(item);
            //}

            ////(1442.) Count Triplets That Can Form Two Arrays of Equal XOR (MEDIUM)
            //int[] arr = [2, 3, 1, 6, 7];

            //LeetCode_1442 classLeetCode = new LeetCode_1442();
            //Console.WriteLine(classLeetCode.CountTriplets(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.CountTriplets(arr));

            ////(1446.) Consecutive Characters (EASY)
            //string s = "abbcccddddeeeeedcba";

            //LeetCode_1446 classLeetCode = new LeetCode_1446();
            //Console.WriteLine(classLeetCode.MaxPower(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxPower(s));

            ////(1447.) Simplified Fractions (MEDIUM)
            //int n = 6;

            //LeetCode_1447 classLeetCode = new LeetCode_1447();
            //Console.WriteLine(string.Join(',',classLeetCode.SimplifiedFractions(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SimplifiedFractions(n)));

            ////(1450.) Number of Students Doing Homework at a Given Time (EASY)
            //int[] startTime = [1, 2, 3];
            //int[] endTime = [3, 2, 7];
            //int queryTime = 4;

            //LeetCode_1450 classLeetCode = new LeetCode_1450();
            //Console.WriteLine(classLeetCode.BusyStudent(startTime, endTime, queryTime));

            ////OR

            //Console.WriteLine(leetCodeAll.BusyStudent(startTime, endTime, queryTime));

            ////(1451.) Rearrange Words in a Sentence (MEDIUM)
            //string text = "To be or not to be";

            //LeetCode_1451 classLeetCode = new LeetCode_1451();
            //Console.WriteLine(classLeetCode.ArrangeWords(text));

            ////OR

            //Console.WriteLine(leetCodeAll.ArrangeWords(text));

            ////(1455.) Check If a Word Occurs As a Prefix of Any Word in a Sentence (EASY)
            //string sentence = "b bu bur burg burger";
            //string searchWord = "burg";

            //LeetCode_1455 classLeetCode = new LeetCode_1455();
            //Console.WriteLine(classLeetCode.IsPrefixOfWord(sentence, searchWord));

            ////OR

            //Console.WriteLine(leetCodeAll.IsPrefixOfWord(sentence, searchWord));

            ////(1456.) Maximum Number of Vowels in a Substring of Given Length (MEDIUM)
            //string s = "abciiidef";
            //int k = 3;

            //LeetCode_1456 classLeetCode = new LeetCode_1456();
            //Console.WriteLine(classLeetCode.MaxVowels(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxVowels(s, k));

            ////(1460.) Make Two Arrays Equal by Reversing Subarrays (EASY)
            //int[] target = [1, 2, 3, 4];
            //int[] arr = [2, 4, 1, 3];

            //LeetCode_1460 classLeetCode = new LeetCode_1460();
            //Console.WriteLine(classLeetCode.CanBeEqual(target, arr));

            ////OR

            //Console.WriteLine(leetCodeAll.CanBeEqual(target, arr));

            ////(1461.) Check If a String Contains All Binary Codes of Size K (MEDIUM)
            //string s = "00110110";
            //int k = 2;

            //LeetCode_1461 classLeetCode = new LeetCode_1461();
            //Console.WriteLine(classLeetCode.HasAllCodes(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.HasAllCodes(s, k));

            ////(1464.) Maximum Product of Two Elements in an Array (EASY)
            //int[] nums = [1,5,4,5];

            //LeetCode_1464 classLeetCode = new LeetCode_1464();
            //Console.WriteLine(classLeetCode.MaxProduct(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxProduct(nums));

            ////(1470.) Shuffle the Array (EASY)
            //int[] nums = [1, 2, 3, 4, 4, 3, 2, 1];
            //int n = 4;

            //LeetCode_1470 classLeetCode = new LeetCode_1470();
            //Console.WriteLine(string.Join(',', classLeetCode.Shuffle(nums, n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.Shuffle(nums, n)));

            ////(1472.) Design Browser History (MEDIUM)
            //LeetCode_1472.BrowserHistory browserHistory = new LeetCode_1472.BrowserHistory("zav.com");
            //browserHistory.Visit("kni.com");
            //Console.WriteLine(browserHistory.Back(7));
            //Console.WriteLine(browserHistory.Back(7));
            //Console.WriteLine(browserHistory.Forward(5));
            //Console.WriteLine(browserHistory.Forward(1));
            //browserHistory.Visit("pwrrbnw.com");
            //browserHistory.Visit("mosohif.com");
            //Console.WriteLine(browserHistory.Back(9));

            ////OR

            //BrowserHistoryTask1472 browserHistoryTask1472 = new BrowserHistoryTask1472("zav.com");
            //browserHistoryTask1472.Visit("kni.com");
            //Console.WriteLine(browserHistoryTask1472.Back(7));
            //Console.WriteLine(browserHistoryTask1472.Back(7));
            //Console.WriteLine(browserHistoryTask1472.Forward(5));
            //Console.WriteLine(browserHistoryTask1472.Forward(1));
            //browserHistoryTask1472.Visit("pwrrbnw.com");
            //browserHistoryTask1472.Visit("mosohif.com");
            //Console.WriteLine(browserHistoryTask1472.Back(9));

            ////(1475.) Final Prices With a Special Discount in a Shop (EASY)
            //int[] prices = [8, 4, 6, 2, 3];

            //LeetCode_1475 classLeetCode = new LeetCode_1475();
            //Console.WriteLine(string.Join(',', classLeetCode.FinalPrices(prices)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FinalPrices(prices)));

            ////(1476.) Subrectangle Queries (MEDIUM)
            //int[][] rectangle = [[1, 2, 1], [4, 3, 4], [3, 2, 1], [1, 1, 1]];

            //SubrectangleQueries subrectangleQueries = new SubrectangleQueries(rectangle);
            //Console.WriteLine(subrectangleQueries.GetValue(0, 2));
            //subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
            //Console.WriteLine(subrectangleQueries.GetValue(0, 2));
            //Console.WriteLine(subrectangleQueries.GetValue(3, 1));
            //subrectangleQueries.UpdateSubrectangle(3, 0, 3, 2, 10);
            //Console.WriteLine(subrectangleQueries.GetValue(3, 1));
            //Console.WriteLine(subrectangleQueries.GetValue(3, 1));

            ////OR

            //SubrectangleQueriesTask1476 subrectangleQueries1 = new SubrectangleQueriesTask1476(rectangle);
            //Console.WriteLine(subrectangleQueries1.GetValue(0, 2));
            //subrectangleQueries1.UpdateSubrectangle(0, 0, 3, 2, 5);
            //Console.WriteLine(subrectangleQueries1.GetValue(0, 2));
            //Console.WriteLine(subrectangleQueries1.GetValue(3, 1));
            //subrectangleQueries1.UpdateSubrectangle(3, 0, 3, 2, 10);
            //Console.WriteLine(subrectangleQueries1.GetValue(3, 1));
            //Console.WriteLine(subrectangleQueries1.GetValue(3, 1));

            ////(1480.) Running Sum of 1d Array (EASY)
            //int[] nums = [1, 1, 1, 1, 1];

            //LeetCode_1480 classLeetCode = new LeetCode_1480();
            //Console.WriteLine(string.Join(',', classLeetCode.RunningSum(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RunningSum(nums)));

            ////(1481.) Least Number of Unique Integers after K Removals (MEDIUM)1481. Least Number of Unique Integers after K Removals (MEDIUM)
            //int[] arr = [4, 3, 1, 1, 3, 3, 2];
            //int k = 3;

            //LeetCode_1481 classLeetCode = new LeetCode_1481();
            //Console.WriteLine(classLeetCode.FindLeastNumOfUniqueInts(arr, k));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLeastNumOfUniqueInts(arr, k));

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

            ////(1486.) XOR Operation in an Array (EASY)
            //int n = 5;
            //int start = 0;

            //LeetCode_1486 classLeetCode = new LeetCode_1486();
            //Console.WriteLine(classLeetCode.XorOperation(n, start));

            ////OR

            //Console.WriteLine(leetCodeAll.XorOperation(n, start));

            ////(1491.) Average Salary Excluding the Minimum and Maximum Salary (EASY)
            //int[] salary = [4000, 3000, 1000, 2000];

            //LeetCode_1491 classLeetCode = new LeetCode_1491();
            //Console.WriteLine(classLeetCode.Average(salary));

            ////OR

            //Console.WriteLine(leetCodeAll.Average(salary));

            ////(1492.) The kth Factor of n (MEDIUM)
            //int n = 12;
            //int k = 3;

            //LeetCode_1492 classLeetCode = new LeetCode_1492();
            //Console.WriteLine(classLeetCode.KthFactor(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.KthFactor(n, k));

            ////(1493.) Longest Subarray of 1's After Deleting One Element (MEDIUM)
            //int[] nums = [0, 1, 1, 1, 0, 1, 1, 0, 1];

            //LeetCode_1493 classLeetCode = new LeetCode_1493();
            //Console.WriteLine(classLeetCode.LongestSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestSubarray1493(nums));

            ////(1498.) Number of Subsequences That Satisfy the Given Sum Condition (MEDIUM)
            //int[] nums = [5, 2, 4, 1, 7, 6, 8];
            //int target = 16;

            //LeetCode_1498 classLeetCode = new LeetCode_1498();
            //Console.WriteLine(classLeetCode.NumSubseq(nums, target));

            ////OR

            //Console.WriteLine(leetCodeAll.NumSubseq(nums, target));

            ////(1502.) Can Make Arithmetic Progression From Sequence (EASY)
            //int[] arr = [0, 0, 0, 0];

            //LeetCode_1502 classLeetCode = new LeetCode_1502();
            //Console.WriteLine(classLeetCode.CanMakeArithmeticProgression(arr));

            ////OR

            //Console.WriteLine(classLeetCode.CanMakeArithmeticProgression(arr));

            ////(1507.) Reformat Date (EASY)
            //string date = "29th Oct 1997";

            //LeetCode_1507 classLeetCode = new LeetCode_1507();
            //Console.WriteLine(classLeetCode.ReformatDate(date));

            ////OR

            //Console.WriteLine(leetCodeAll.ReformatDate(date));

            ////(1512.) Number of Good Pairs (EASY)
            //int[] nums = [1, 2, 3, 1, 1, 3];

            //LeetCode_1512 classLeetCode = new LeetCode_1512();
            //Console.WriteLine(classLeetCode.NumIdenticalPairs(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.NumIdenticalPairs(nums));

            ////(1513.) Number of Substrings With Only 1s (MEDIUM)
            //string s = "0110111";

            //LeetCode_1513 classLeetCode = new LeetCode_1513();
            //Console.WriteLine(classLeetCode.NumSub(s));

            ////OR

            //Console.WriteLine(leetCodeAll.NumSub(s));

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

            ////(1518.) Water Bottles (EASY)
            //int numBottles = 9;
            //int numExchange = 3;

            //LeetCode_1518 classLeetCode = new LeetCode_1518();
            //Console.WriteLine(classLeetCode.NumWaterBottles(numBottles, numExchange));

            ////OR

            //Console.WriteLine(leetCodeAll.NumWaterBottles(numBottles, numExchange));

            ////(1523.) Count Odd Numbers in an Interval Range(EASY)
            //int low = 8;
            //int high = 10;

            //LeetCode_1523 classLeetCode = new LeetCode_1523();
            //Console.WriteLine(classLeetCode.CountOdds(low, high));

            ////OR

            //Console.WriteLine(classLeetCode.CountOdds(low, high));

            ////(1526.) Minimum Number of Increments on Subarrays to Form a Target Array (HARD)
            //int[] target = [3, 1, 5, 4, 2];

            //LeetCode_1526 classLeetCode = new LeetCode_1526();
            //Console.WriteLine(classLeetCode.MinNumberOperations(target));

            ////OR

            //Console.WriteLine(leetCodeAll.MinNumberOperations(target));

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

            ////(1528.) Shuffle String (EASY)
            //string s = "codeleet";
            //int[] indices = [4, 5, 6, 7, 0, 2, 1, 3];

            //LeetCode_1528 classLeetCode = new LeetCode_1528();
            //Console.WriteLine(classLeetCode.RestoreString(s, indices));

            ////OR

            //Console.WriteLine(leetCodeAll.RestoreString(s, indices));

            ////(1534.) Count Good Triplets (EASY)
            //int[] arr = [3, 0, 1, 1, 9, 7];
            //int a = 7;
            //int b = 2;
            //int c = 3;

            //LeetCode_1534 classLeetCode = new LeetCode_1534();
            //Console.WriteLine(classLeetCode.CountGoodTriplets(arr, a, b, c));

            ////OR

            //Console.WriteLine(leetCodeAll.CountGoodTriplets(arr, a, b, c));

            ////(1539.) Kth Missing Positive Number (EASY)
            //int[] arr = [2, 3, 4, 7, 11];
            //int k = 5;

            //LeetCode_1539 classLeetCode = new LeetCode_1539();
            //Console.WriteLine(classLeetCode.FindKthPositive(arr, k));

            ////OR

            //Console.WriteLine(leetCodeAll.FindKthPositive(arr, k));

            ////(1550.) Three Consecutive Odds (EASY)
            //int[] arr = [1, 2, 34, 3, 4, 5, 7, 23, 12];

            //LeetCode_1550 classLeetCode = new LeetCode_1550();
            //Console.WriteLine(classLeetCode.ThreeConsecutiveOdds(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.ThreeConsecutiveOdds(arr));

            ////(1551.) Minimum Operations to Make Array Equal (MEDIUM)
            //int n = 6;

            //LeetCode_1551 classLeetCode = new LeetCode_1551();
            //Console.WriteLine(classLeetCode.MinOperations(n));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperations(n));

            ////(1556.) Thousand Separator (EASY)
            //int n = 1234;

            //LeetCode_1556 classLeetCode = new LeetCode_1556();
            //Console.WriteLine(classLeetCode.ThousandSeparator(n));

            ////OR

            //Console.WriteLine(leetCodeAll.ThousandSeparator(n));

            ////(1561.) Maximum Number of Coins You Can Get (MEDIUM)
            //int[] piles = [2, 4, 1, 2, 7, 8];

            //LeetCode_1561 classLeetCode = new LeetCode_1561();
            //Console.WriteLine(classLeetCode.MaxCoins(piles));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxCoins(piles));

            ////(1572.) Matrix Diagonal Sum (EASY)
            //int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            //LeetCode_1572 classLeetCode = new LeetCode_1572();
            //Console.WriteLine(classLeetCode.DiagonalSum(mat));

            ////OR

            //Console.WriteLine(leetCodeAll.DiagonalSum(mat));

            ////(1578.) Minimum Time to Make Rope Colorful (MEDIUM)
            //string colors = "aabaa";
            //int[] neededTime = [1, 2, 3, 4, 1];

            //LeetCode_1578 classLeetCode = new LeetCode_1578();
            //Console.WriteLine(classLeetCode.MinCost(colors, neededTime));

            ////OR

            //Console.WriteLine(leetCodeAll.MinCost(colors, neededTime));

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

            ////(1582.) Special Positions in a Binary Matrix (EASY)
            //int[][] mat = [[0, 0], [0, 0], [1, 0]];

            //LeetCode_1582 classLeetCode = new LeetCode_1582();
            //Console.WriteLine(classLeetCode.NumSpecial(mat));

            ////OR

            //Console.WriteLine(leetCodeAll.NumSpecial(mat));

            ////(1587.) Bank Account Summary II (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            a.name
            //            ,SUM(b.amount) balance 
            //        From Users a 
            //        left join Transactions b
            //        ON a.account = b.account
            //        Group by a.name
            //        having SUM(b.amount) > 10000     
            //    ";

            //////OR
            //LeetCode_1587 classLeetCode = new LeetCode_1587();

            ////(1588.) Sum of All Odd Length Subarrays (EASY)
            //int[] arr = [1, 4, 2, 5, 3];

            //LeetCode_1588 classLeetCode = new LeetCode_1588();
            //Console.WriteLine(classLeetCode.SumOddLengthSubarrays(arr));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOddLengthSubarrays(arr));

            ////(1598.) Crawler Log Folder (EASY)
            //string[] logs = ["d1/", "d2/", "../", "d21/", "./"];

            //LeetCode_1598 classLeetCode = new LeetCode_1598();
            //Console.WriteLine(classLeetCode.MinOperations(logs));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperations(logs));

            ////(1603.) Design Parking System (EASY)
            //int big = 1;
            //int medium = 1;
            //int small = 0;

            //LeetCode_1603.ParkingSystem classLeetCode = new LeetCode_1603.ParkingSystem(big, medium, small);
            //Console.WriteLine(classLeetCode.AddCar(1));
            //Console.WriteLine(classLeetCode.AddCar(2));
            //Console.WriteLine(classLeetCode.AddCar(3));
            //Console.WriteLine(classLeetCode.AddCar(1));

            ////OR

            //ParkingSystem LeetCodeAll = new ParkingSystem(big, medium, small);
            //Console.WriteLine(LeetCodeAll.AddCar(1));
            //Console.WriteLine(LeetCodeAll.AddCar(2));
            //Console.WriteLine(LeetCodeAll.AddCar(3));
            //Console.WriteLine(LeetCodeAll.AddCar(1));

            ////(1605.) Find Valid Matrix Given Row and Column Sums (MEDIUM)
            //int[] rowSum = [3, 8];
            //int[] colSum = [4, 7];

            //LeetCode_1605 classLeetCode = new LeetCode_1605();
            //int[][] result = classLeetCode.RestoreMatrix(rowSum, colSum);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.RestoreMatrix(rowSum, colSum);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(1614.) Maximum Nesting Depth of the Parentheses (EASY)
            //string s = "(1+(2*3)+((8)/4))+1";

            //LeetCode_1614 classLeetCode = new LeetCode_1614();
            //Console.WriteLine(classLeetCode.MaxDepth(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDepth(s));

            ////(1624.) Largest Substring Between Two Equal Characters (EASY)
            //string s = "abca";

            //LeetCode_1624 classLeetCode = new LeetCode_1624();
            //Console.WriteLine(classLeetCode.MaxLengthBetweenEqualCharacters(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxLengthBetweenEqualCharacters(s));

            ////(1625.) Lexicographically Smallest String After Applying Operations (MEDIUM)
            //string s = "5525";
            //int a = 9;
            //int b = 2;

            //LeetCode_1625 classLeetCode = new LeetCode_1625();
            //Console.WriteLine(classLeetCode.FindLexSmallestString(s, a, b));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLexSmallestString(s, a, b));

            ////(1629.) Slowest Key (EASY)
            //int[] releaseTimes = [9, 29, 49, 50];
            //string keysPressed = "cbcd";

            //LeetCode_1629 classLeetCode = new LeetCode_1629();
            //Console.WriteLine(classLeetCode.SlowestKey(releaseTimes, keysPressed));

            ////OR

            //Console.WriteLine(leetCodeAll.SlowestKey(releaseTimes, keysPressed));

            ////(1630.) Arithmetic Subarrays (MEDIUM)
            //int[] nums = [4, 6, 5, 9, 3, 7];
            //int[] l = [0, 0, 2];
            //int[] r = [2, 3, 5];

            //LeetCode_1630 classLeetCode = new LeetCode_1630();
            //Console.WriteLine(string.Join(',', classLeetCode.CheckArithmeticSubarrays(nums, l, r)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.CheckArithmeticSubarrays(nums, l, r)));

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

            ////(1636.) Sort Array by Increasing Frequency (EASY)
            //int[] nums = [-1, 1, -6, 4, 5, -6, 1, 4, 1];

            //LeetCode_1636 classLeetCode = new LeetCode_1636();
            //Console.WriteLine(string.Join(',', classLeetCode.FrequencySort(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FrequencySort(nums)));

            ////(1637.) Widest Vertical Area Between Two Points Containing No Points (EASY)
            //int[][] points = [[3, 1], [9, 0], [1, 0], [1, 4], [5, 3], [8, 8]];

            //LeetCode_1637 classLeetCode = new LeetCode_1637();
            //Console.WriteLine(classLeetCode.MaxWidthOfVerticalArea(points));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxWidthOfVerticalArea(points));

            ////(1646.) Get Maximum in Generated Array (EASY)
            //int n = 7;

            //LeetCode_1646 classLeetCode = new LeetCode_1646();
            //Console.WriteLine(classLeetCode.GetMaximumGenerated(n));

            ////OR

            //Console.WriteLine(leetCodeAll.GetMaximumGenerated(n));

            ////(1656.) Design an Ordered Stream (EASY)
            //LeetCode_1656.OrderedStream os = new LeetCode_1656.OrderedStream(5);
            //Console.WriteLine(string.Join(',', os.Insert(3, "ccccc"))); // Inserts (3, "ccccc"), returns [].
            //Console.WriteLine(string.Join(',', os.Insert(1, "aaaaa"))); // Inserts (1, "aaaaa"), returns ["aaaaa"].
            //Console.WriteLine(string.Join(',', os.Insert(2, "bbbbb"))); // Inserts (2, "bbbbb"), returns ["bbbbb", "ccccc"].
            //Console.WriteLine(string.Join(',', os.Insert(5, "eeeee"))); // Inserts (5, "eeeee"), returns [].
            //Console.WriteLine(string.Join(',', os.Insert(4, "ddddd"))); // Inserts (4, "ddddd"), returns ["ddddd", "eeeee"].

            ////OR

            //LeetCodeAll.OrderedStreamTask1656 os1 = new LeetCodeAll.OrderedStreamTask1656(5);
            //Console.WriteLine(string.Join(',', os1.Insert(3, "ccccc"))); // Inserts (3, "ccccc"), returns [].
            //Console.WriteLine(string.Join(',', os1.Insert(1, "aaaaa"))); // Inserts (1, "aaaaa"), returns ["aaaaa"].
            //Console.WriteLine(string.Join(',', os1.Insert(2, "bbbbb"))); // Inserts (2, "bbbbb"), returns ["bbbbb", "ccccc"].
            //Console.WriteLine(string.Join(',', os1.Insert(5, "eeeee"))); // Inserts (5, "eeeee"), returns [].
            //Console.WriteLine(string.Join(',', os1.Insert(4, "ddddd"))); // Inserts (4, "ddddd"), returns ["ddddd", "eeeee"].


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

            ////(1662.) Check If Two String Arrays are Equivalent (EASY)
            //string[] word1 = ["ab", "c"];
            //string[] word2 = ["a", "bc"];

            //LeetCode_1662 classLeetCode = new LeetCode_1662();
            //Console.WriteLine(classLeetCode.ArrayStringsAreEqual(word1, word2));

            ////OR

            //Console.WriteLine(leetCodeAll.ArrayStringsAreEqual(word1, word2));

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

            ////(1669.) Merge In Between Linked Lists (MEDIUM)
            //ListNode listNode1 = new ListNode(10);
            //listNode1.next = new ListNode(1);
            //listNode1.next.next = new ListNode(13);
            //listNode1.next.next.next = new ListNode(6);
            //listNode1.next.next.next.next = new ListNode(9);
            //listNode1.next.next.next.next.next = new ListNode(5);
            //int a = 3;
            //int b = 4;
            //ListNode listNode2 = new ListNode(1000000);
            //listNode2.next = new ListNode(1000001);
            //listNode2.next.next = new ListNode(1000002);

            //ListNode listNode1 = new ListNode(0);
            //listNode1.next = new ListNode(1);
            //listNode1.next.next = new ListNode(2);
            //int a = 1;
            //int b = 1;
            //ListNode listNode2 = new ListNode(1000000);
            //listNode2.next = new ListNode(1000001);
            //listNode2.next.next = new ListNode(1000002);


            //LeetCode_1669 classLeetCode = new LeetCode_1669();
            //ListNode resultListNode = classLeetCode.MergeInBetween(listNode1, a, b, listNode2);
            //while (resultListNode != null)
            //{
            //    Console.WriteLine(resultListNode.val);
            //    resultListNode = resultListNode.next;
            //}

            ////OR

            //ListNode resultListNode1 = leetCodeAll.MergeInBetweenTask1669(listNode1, a, b, listNode2);
            //while (resultListNode1 != null)
            //{
            //    Console.WriteLine(resultListNode1.val);
            //    resultListNode1 = resultListNode1.next;


            ////(1672.) Richest Customer Wealth (EASY)
            //int[][] accounts = [[1,2,3], [3,2,1]];

            //LeetCode_1672 classLeetCode = new LeetCode_1672();
            //Console.WriteLine(classLeetCode.MaximumWealth(accounts));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumWealth(accounts));

            ////(1678.) Goal Parser Interpretation (EASY)
            //string command = "(al)G(al)()()G";

            //LeetCode_1678 classLeetCode = new LeetCode_1678();
            //Console.WriteLine(classLeetCode.Interpret(command));

            ////OR

            //Console.WriteLine(leetCodeAll.Interpret(command));

            ////(1683.) Invalid Tweets (EASY)
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

            ////(1688.) Count of Matches in Tournament (EASY)
            //int n = 7;

            //LeetCode_1688 classLeetCode = new LeetCode_1688();
            //Console.WriteLine(classLeetCode.NumberOfMatches(n));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfMatches(n));

            ////(1689.) Partitioning Into Minimum Number Of Deci-Binary Numbers (MEDIUM)
            //string n = "32";

            //LeetCode_1689 classLeetCode = new LeetCode_1689();
            //Console.WriteLine(classLeetCode.MinPartitions(n));

            ////OR

            //Console.WriteLine(leetCodeAll.MinPartitions(n));

            ////(1693.) Daily Leads and Partners (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            date_id,
            //            make_name, 
            //            COUNT(DISTINCT lead_id) as unique_leads,
            //            COUNT(DISTINCT partner_id) as unique_partners 
            //        From DailySales 
            //        GROUP BY date_id, make_name
            //    ";

            ////OR

            //LeetCode_1693 classLeetCode = new LeetCode_1693();

            ////(1695.) Maximum Erasure Value (MEDIUM)
            //int[] nums = [5, 2, 1, 2, 5, 2, 1, 2, 5];

            //LeetCode_1695 classLeetCode = new LeetCode_1695();
            //Console.WriteLine(classLeetCode.MaximumUniqueSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumUniqueSubarray(nums));

            ////(1704.) Determine if String Halves Are Alike (EASY)
            //string s = "book";

            //LeetCode_1704 classLeetCode = new LeetCode_1704();
            //Console.WriteLine(classLeetCode.HalvesAreAlike(s));

            ////OR

            //Console.WriteLine(leetCodeAll.HalvesAreAlike(s));

            ////(1710.) Maximum Units on a Truck (EASY)
            //int[][] boxTypes = [[1, 3], [2, 2], [3, 1]];
            //int truckSize = 4;

            //LeetCode_1710 classLeetCode = new LeetCode_1710();
            //Console.WriteLine(classLeetCode.MaximumUnits(boxTypes, truckSize));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumUnits(boxTypes, truckSize));

            ////(1716.) Calculate Money in Leetcode Bank (EASY)
            //int n = 20;

            //LeetCode_1716 classLeetCode = new LeetCode_1716();
            //Console.WriteLine(classLeetCode.TotalMoney(n));

            ////OR

            //Console.WriteLine(leetCodeAll.TotalMoney(n));

            ////(1717.) Maximum Score From Removing Substrings (MEDIUM)
            //string s = "abbmzgaabtaabsbabhaahabnaeabdbaababbbiabaavababtabwbababzbdabbaaabhbyabdvabbaabbquapaaaaqbbblbuaawlnbbaxaubbbbbpbabbbpaaaacbbaabaaaahbbcoyaauabanqaabpbbbgaawbhabbbbaobsaaababbafbababbbbaaaqbabsbsmabbxqylbbbba";
            //int x = 9421;
            //int y = 8003;

            //LeetCode_1717 classLeetCode = new LeetCode_1717();
            //Console.WriteLine(classLeetCode.MaximumGain(s, x, y));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumGain(s, x, y));

            ////(1720.) Decode XORed Array (EASY)
            //int[] encoded = [6, 2, 7, 3];
            //int first = 4;

            //LeetCode_1720 classLeetCode = new LeetCode_1720();
            //Console.WriteLine(string.Join(',', classLeetCode.Decode(encoded, first)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.Decode(encoded, first)));

            ////(1725.) Number Of Rectangles That Can Form The Largest Square (EASY)
            //int[][] rectangles = [[5,8], [3,9], [5,12], [16,5]];

            //LeetCode_1725 classLeetCode = new LeetCode_1725();
            //Console.WriteLine(classLeetCode.CountGoodRectangles(rectangles));

            ////OR

            //Console.WriteLine(leetCodeAll.CountGoodRectangles(rectangles));

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

            ////(1732.) Find the Highest Altitude (EASY)
            //int[] gain = [-5, 1, 5, 0, -7];

            //LeetCode_1732 classLeetCode = new LeetCode_1732();
            //Console.WriteLine(classLeetCode.LargestAltitude(gain));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestAltitude(gain));

            ////(1733.) Minimum Number of People to Teach (MEDIUM);
            //int n = 2;
            //int[][] languages = [[1], [2], [1, 2]];
            //int[][] friendships = [[1, 2], [1, 3], [2, 3]];

            //LeetCode_1733 classLeetCode = new LeetCode_1733();
            //Console.WriteLine(classLeetCode.MinimumTeachings(n, languages, friendships));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumTeachings(n, languages, friendships));

            ////(1736.) Latest Time by Replacing Hidden Digits (EASY)
            //string time = "0?:3?";

            //LeetCode_1736 classLeetCode = new LeetCode_1736();
            //Console.WriteLine(classLeetCode.MaximumTime(time));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumTime(time));

            ////(1741.) Find Total Time Spent by Each Employee (EASY)
            //string SqlQuery =
            //    @"
            //        Select  
            //            event_day as day,
            //            emp_id,
            //            SUM(total_time) as total_time
            //        From (Select
            //            event_day,
            //            emp_id,
            //            out_time - in_time as total_time
            //        From Employees ) a
            //        Group by event_day, emp_id
            //    ";

            ////OR

            //LeetCode_1741 classLeetCode = new LeetCode_1741();

            ////(1742.) Maximum Number of Balls in a Box (EASY)
            //int lowLimit = 1;
            //int highLimit = 10;

            //LeetCode_1742 classLeetCode = new LeetCode_1742();
            //Console.WriteLine(classLeetCode.CountBalls(lowLimit, highLimit));

            ////OR

            //Console.WriteLine(leetCodeAll.CountBalls(lowLimit, highLimit));

            ////(1748.) Sum of Unique Elements (EASY)
            //int[] nums = [1, 2, 3, 2];

            //LeetCode_1748 classLeetCode = new LeetCode_1748();
            //Console.WriteLine(classLeetCode.SumOfUnique(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfUnique(nums));

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

            ////(1758.) Minimum Changes To Make Alternating Binary String (EASY)
            //string s = "1111";

            //LeetCode_1758 classLeetCode = new LeetCode_1758();
            //Console.WriteLine(classLeetCode.MinOperations(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperationsTask1758(s));

            ////(1768.) Merge Strings Alternately (EASY)
            //string word1 = "abc";
            //string word2 = "pqr";

            //LeetCode_1768 classLeetCode = new LeetCode_1768();
            //Console.WriteLine(classLeetCode.MergeAlternately(word1, word2));

            ////OR

            //Console.WriteLine(leetCodeAll.MergeAlternately(word1, word2));

            ////(1769.) Minimum Number of Operations to Move All Balls to Each Box (MEDIUM)
            //string boxes = "001011";

            //LeetCode_1769 classLeetCode = new LeetCode_1769();
            //Console.WriteLine(string.Join(',', classLeetCode.MinOperations(boxes)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MinOperations(boxes)));

            ////(1773.) Count Items Matching a Rule (EASY)
            //IList<IList<string>> items = [["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]];
            //string ruleKey = "color";
            //string ruleValue = "silver";

            //LeetCode_1773 classLeetCode = new LeetCode_1773();
            //Console.WriteLine(classLeetCode.CountMatches(items, ruleKey, ruleValue));

            ////OR

            //Console.WriteLine(leetCodeAll.CountMatches(items, ruleKey, ruleValue));

            ////(1779.) Find Nearest Point That Has the Same X or Y Coordinate (EASY)
            //int x = 3;
            //int y = 4;
            //int[][] points = [[1, 2], [3, 1], [2, 4], [2, 3], [4, 4]];

            //LeetCode_1779 classLeetCode = new LeetCode_1779();
            //Console.WriteLine(classLeetCode.NearestValidPoint(x, y, points));

            ////OR

            //Console.WriteLine(leetCodeAll.NearestValidPoint(x, y, points));

            ////(1784.) Check if Binary String Has at Most One Segment of Ones (EASY)
            //string s = "110";

            //LeetCode_1784 classLeetCode = new LeetCode_1784();
            //Console.WriteLine(classLeetCode.CheckOnesSegment(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckOnesSegment(s));

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

            ////(1790.) Check if One String Swap Can Make Strings Equal (EASY)
            //string s1 = "kelb";
            //string s2 = "kelb";

            //LeetCode_1790 classLeetCode = new LeetCode_1790();
            //Console.WriteLine(classLeetCode.AreAlmostEqual(s1, s2));

            ////OR

            //Console.WriteLine(leetCodeAll.AreAlmostEqual(s1, s2));

            ////(1791.) Find Center of Star Graph (EASY)
            //int[][] edges = [[1,2], [2, 3], [4, 2]];

            //LeetCode_1791 classLeetCode = new LeetCode_1791();
            //Console.WriteLine(classLeetCode.FindCenter(edges));

            ////OR

            //Console.WriteLine(leetCodeAll.FindCenter(edges));

            ////(1792.) Maximum Average Pass Ratio (MEDIUM)
            //int[][] classes = [[2, 4], [3, 9], [4, 5], [2, 10]];
            //int extraStudents = 4;

            //LeetCode_1792 classLeetCode = new LeetCode_1792();
            //Console.WriteLine(classLeetCode.MaxAverageRatio(classes, extraStudents));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxAverageRatio(classes, extraStudents));

            ////(1795) Rearrange Products Table (EASY)
            //string SqlQuery =
            //    @"
            //        Select 
            //            product_id,
            //            'store1' as store,
            //            store1 as price 
            //        FROM Products
            //        Where store1 is not null
            //        UNION ALL
            //        Select 
            //            product_id,
            //            'store2' as store,
            //            store2 as price 
            //        FROM Products 
            //        Where store2 is not null
            //        UNION ALL
            //        Select 
            //            product_id,
            //            'store3' as store,
            //            store3 as price 
            //        FROM Products 
            //        Where store3 is not null
            //    ";

            ////OR

            //LeetCode_1795 classLeetCode = new LeetCode_1795();

            ////(1800.) Maximum Ascending Subarray Sum (EASY)
            //int[] nums = [10,20,30,5,10,50];

            //LeetCode_1800 classLeetCode = new LeetCode_1800();
            //Console.WriteLine(classLeetCode.MaxAscendingSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxAscendingSum(nums));

            ////(1816.) Truncate Sentence (EASY) 
            //string s = "Hello how are you Contestant";
            //int k = 4;

            //LeetCode_1816 classLeetCode = new LeetCode_1816();
            //Console.WriteLine(classLeetCode.TruncateSentence(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.TruncateSentence(s, k));

            ////(1822.) Sign of the Product of an Array (EASY)
            //int[] nums = [-1, -2, -3, -4, 3, 2, 1];

            //LeetCode_1822 classLeetCode = new LeetCode_1822();
            //Console.WriteLine(classLeetCode.ArraySign(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.ArraySign(nums));

            ////(1823.) Find the Winner of the Circular Game (MEDIUM)
            //int n = 5;
            //int k = 2;

            //LeetCode_1823 classLeetCode = new LeetCode_1823();
            //Console.WriteLine(classLeetCode.FindTheWinner(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.FindTheWinner(n, k));

            ////(1827.) Minimum Operations to Make the Array Increasing (EASY)
            //int[] nums = [1, 5, 2, 4, 1];

            //LeetCode_1827 classLeetCode = new LeetCode_1827();
            //Console.WriteLine(classLeetCode.MinOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperationsTask1827(nums));

            ////(1828.) Queries on Number of Points Inside a Circle (MEDIUM)
            //int[][] points = [[1, 1], [2, 2], [3, 3], [4, 4], [5, 5]];
            //int[][] queries = [[1, 2, 2], [2, 2, 2], [4, 3, 2], [4, 3, 3]];

            //LeetCode_1828 classLeetCode = new LeetCode_1828();
            //Console.WriteLine(string.Join(',', classLeetCode.CountPoints(points, queries)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.CountPoints(points, queries)));

            ////(1832.) Check if the Sentence Is Pangram (EASY)
            //string sentence = "thequickbrownfoxjumpsoverthelazydog";

            //LeetCode_1832 classLeetCode = new LeetCode_1832();
            //Console.WriteLine(classLeetCode.CheckIfPangram(sentence));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckIfPangram(sentence));

            ////(1833.) Maximum Ice Cream Bars (MEDIUM)
            //int[] costs = [6, 2, 8, 8, 5, 6, 6, 2, 2, 2];
            //int coins = 77;

            //LeetCode_1833 classLeetCode = new LeetCode_1833();
            //Console.WriteLine(classLeetCode.MaxIceCream(costs, coins));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxIceCream(costs, coins));

            ////(1837.) Sum of Digits in Base K (EASY)
            //int n = 34;
            //int k = 6;

            //LeetCode_1837 classLeetCode = new LeetCode_1837();
            //Console.WriteLine(classLeetCode.SumBase(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.SumBase(n, k));

            ////(1844.) Replace All Digits with Characters (EASY)
            //string s = "a1b2c3d4e";

            //LeetCode_1844 classLeetCode = new LeetCode_1844();
            //Console.WriteLine(classLeetCode.ReplaceDigits(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ReplaceDigits(s));

            ////(1848.) Minimum Distance to the Target Element (EASY)
            //int[] nums = [1, 2, 3, 4, 5];
            //int target = 5;
            //int start = 3;

            //LeetCode_1848 classLeetCode = new LeetCode_1848();
            //Console.WriteLine(classLeetCode.GetMinDistance(nums, target, start));

            ////OR

            //Console.WriteLine(leetCodeAll.GetMinDistance(nums, target, start));

            ////(1859.) Sorting the Sentence (EASY)
            //string s = "is2 sentence4 This1 a3";

            //LeetCode_1859 classLeetCode = new LeetCode_1859();
            //Console.WriteLine(classLeetCode.SortSentence(s));

            ////OR

            //Console.WriteLine(leetCodeAll.SortSentence(s));

            ////(1863.) Sum of All Subset XOR Totals (EASY)
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

            ////(1869.) Longer Contiguous Segments of Ones than Zeros (EASY)
            //string s = "110100010";

            //LeetCode_1869 classLeetCode = new LeetCode_1869();
            //Console.WriteLine(classLeetCode.CheckZeroOnes(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckZeroOnes(s));

            ////(1876.) Substrings of Size Three with Distinct Characters (EASY)
            //string s = "owuxoelszb";

            //LeetCode_1876 classLeetCode = new LeetCode_1876();
            //Console.WriteLine(classLeetCode.CountGoodSubstrings(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountGoodSubstrings(s));

            ////(1877.) Minimize Maximum Pair Sum in Array (MEDIUM)
            //int[] nums = [3, 5, 4, 2, 4, 6];

            //LeetCode_1877 classLeetCode = new LeetCode_1877();
            //Console.WriteLine(classLeetCode.MinPairSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinPairSum(nums));

            ////(1880.) Check if Word Equals Summation of Two Words (EASY)
            //string firstWord = "acb";
            //string secondWord = "cba";
            //string targetWord = "cdb";

            //LeetCode_1880 classLeetCode = new LeetCode_1880();
            //Console.WriteLine(classLeetCode.IsSumEqual(firstWord, secondWord, targetWord));

            ////OR

            //Console.WriteLine(leetCodeAll.IsSumEqual(firstWord, secondWord, targetWord));

            ////(1888.) Minimum Number of Flips to Make the Binary String Alternating (MEDIUM) 
            //string s = "01001001101";

            //LeetCode_1888 classLeetCode = new LeetCode_1888();
            //Console.WriteLine(classLeetCode.MinFlips(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinFlips(s));

            ////(1890.) The Latest Login in 2020 (EASY)
            //string SqlQuery =
            //    @"
            //        Select
            //            user_id
            //            ,MAX(time_stamp) as last_stamp
            //        From Logins 
            //        WHERE YEAR(time_stamp) = '2020'
            //        GROUP BY user_id
            //    ";

            ////OR

            //LeetCode_1890 classLeetCode = new LeetCode_1890();

            ////(1893.) Check if All the Integers in a Range Are Covered (EASY)
            //int[][] ranges = [[1, 2], [3, 4], [5, 6]];
            //int left = 2;
            //int right = 5;

            //LeetCode_1893 classLeetCode = new LeetCode_1893();
            //Console.WriteLine(classLeetCode.IsCovered(ranges, left, right));

            ////OR

            //Console.WriteLine(leetCodeAll.IsCovered(ranges, left, right));

            ////(1897.) Redistribute Characters to Make All Strings Equal (EASY)
            //string[] words = ["abc", "aabc", "bc"];

            //LeetCode_1897 classLeetCode = new LeetCode_1897();
            //Console.WriteLine(classLeetCode.MakeEqual(words));

            ////OR

            //Console.WriteLine(leetCodeAll.MakeEqual(words));

            ////(1903.) Largest Odd Number in String (EASY)
            //string num = "52";

            //LeetCode_1903 classLeetCode = new LeetCode_1903();
            //Console.WriteLine(classLeetCode.LargestOddNumber(num));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestOddNumber(num));

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

            ////(1913.) Maximum Product Difference Between Two Pairs (EASY)
            //int[] nums = [4, 2, 5, 9, 7, 4, 8];

            //LeetCode_1913 classLeetCode = new LeetCode_1913();
            //Console.WriteLine(classLeetCode.MaxProductDifference(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxProductDifference(nums));

            ////(1920.) Build Array from Permutation (EASY)
            //int[] nums = [0,2,1,5,3,4];

            //LeetCode_1920 classLeetCode = new LeetCode_1920();
            //Console.WriteLine(string.Join(',', classLeetCode.BuildArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.BuildArray(nums)));

            ////(1925.) Count Square Sum Triples (EASY)
            //int n = 10;

            //LeetCode_1925 classLeetCode = new LeetCode_1925();
            //Console.WriteLine(classLeetCode.CountTriples(n));

            ////OR

            //Console.WriteLine(leetCodeAll.CountTriples(n));

            ////(1929.) Concatenation of Array (EASY)
            //int[] nums = [1, 2, 1];

            //LeetCode_1929 classLeetCode = new LeetCode_1929();
            //Console.WriteLine(string.Join(',', classLeetCode.GetConcatenation(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', classLeetCode.GetConcatenation(nums)));

            ////(1930.) Unique Length-3 Palindromic Subsequences (MEDIUM)
            //string s = "bbcbaba";

            //LeetCode_1930 classLeetCode = new LeetCode_1930();
            //Console.WriteLine(classLeetCode.CountPalindromicSubsequence(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPalindromicSubsequence(s));

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

            ////(1935.) Maximum Number of Words You Can Type (EASY)
            //string text = "hello world";
            //string brokenLetters = "ad";

            //LeetCode_1935 classLeetCode = new LeetCode_1935();
            //Console.WriteLine(classLeetCode.CanBeTypedWords(text, brokenLetters));

            ////OR

            //Console.WriteLine(leetCodeAll.CanBeTypedWords(text, brokenLetters));

            ////(1941.) Check if All Characters Have Equal Number of Occurrences (EASY)
            //string s = "abacbc";

            //LeetCode_1941 classLeetCode = new LeetCode_1941();
            //Console.WriteLine(classLeetCode.AreOccurrencesEqual(s));

            ////OR

            //Console.WriteLine(leetCodeAll.AreOccurrencesEqual(s));

            ////(1945.) Sum of Digits of String After Convert (EASY)
            //string s = "iiii";
            //int k = 1;

            //LeetCode_1945 classLeetCode = new LeetCode_1945();
            //Console.WriteLine(classLeetCode.GetLucky(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.GetLucky(s, k));

            ////(1952.) Three Divisors (EASY)
            //int n = 4;

            //LeetCode_1952 classLeetCode = new LeetCode_1952();
            //Console.WriteLine(classLeetCode.IsThree(n));

            ////OR

            //Console.WriteLine(leetCodeAll.IsThree(n));

            ////(1957.) Delete Characters to Make Fancy String (EASY)
            //string s = "leeetcode";

            //LeetCode_1957 classLeetCode = new LeetCode_1957();
            //Console.WriteLine(classLeetCode.MakeFancyString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MakeFancyString(s));

            ////(1961.) Check If String Is a Prefix of Array (EASY)
            //string s = "z";
            //string[] words = ["z"];

            //LeetCode_1961 classLeetCode = new LeetCode_1961();
            //Console.WriteLine(classLeetCode.IsPrefixString(s, words));

            ////OR

            //Console.WriteLine(leetCodeAll.IsPrefixString(s, words));

            ////(1967.) Number of Strings That Appear as Substrings in Word (EASY)
            //string[] patterns = ["a", "abc", "bc", "d"];
            //string word = "abc";

            //LeetCode_1967 classLeetCode = new LeetCode_1967();
            //Console.WriteLine(classLeetCode.NumOfStrings(patterns, word));

            ////OR

            //Console.WriteLine(leetCodeAll.NumOfStrings(patterns, word));

            ////(1975.) Maximum Matrix Sum (MEDIUM)
            //int[][] matrix = [[1, 2, 3], [-1, -2, -3], [1, 2, 3]];

            //LeetCode_1975 classLeetCode = new LeetCode_1975();
            //Console.WriteLine(classLeetCode.MaxMatrixSum(matrix));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxMatrixSum(matrix));

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

            ////(1979.) Find Greatest Common Divisor of Array (EASY)
            //int[] nums = [2, 5, 6, 9, 10];

            //LeetCode_1979 classLeetCode = new LeetCode_1979();
            //Console.WriteLine(classLeetCode.FindGCD(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindGCD(nums));

            ////(1980.) Find Unique Binary String (MEDIUM)
            //string[] nums = ["1010", "0000", "0101", "1111"];

            //LeetCode_1980 classLeetCode = new LeetCode_1980();
            //Console.WriteLine(classLeetCode.FindDifferentBinaryString(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindDifferentBinaryString(nums));

            ////(1984.) Minimum Difference Between Highest and Lowest of K Scores (EASY)
            //int[] nums = [9, 4, 1, 7];
            //int k = 2;

            //LeetCode_1984 classLeetCode = new LeetCode_1984();
            //Console.WriteLine(classLeetCode.MinimumDifference(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumDifference(nums, k));

            ////(1991.) Find the Middle Index in Array (EASY)
            //int[] nums = [1, 1, 1, 1];

            //LeetCode_1991 classLeetCode = new LeetCode_1991();
            //Console.WriteLine(classLeetCode.FindMiddleIndex(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindMiddleIndex(nums));

            ////(2000.) Reverse Prefix of Word (EASY)
            //string word = "abcdefd";
            //char ch = 'd';

            //LeetCode_2000 classLeetCode = new LeetCode_2000();
            //Console.WriteLine(classLeetCode.ReversePrefix(word, ch));

            ////OR

            //Console.WriteLine(leetCodeAll.ReversePrefix(word, ch));

            ////(2006.) Count Number of Pairs With Absolute Difference K (EASY)
            //int[] nums = [3, 2, 1, 5, 4];
            //int k = 2;

            //LeetCode_2006 classLeetCode = new LeetCode_2006();
            //Console.WriteLine(classLeetCode.CountKDifference(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.CountKDifference(nums, k));

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

            ////(2022.) Convert 1D Array Into 2D Array (EASY)
            //int[] original = [1, 2, 3, 4];
            //int m = 2;
            //int n = 2;

            //LeetCode_2022 classLeetCode = new LeetCode_2022();
            //int[][] result = classLeetCode.Construct2DArray(original, m, n);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.Construct2DArray(original, m, n);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2032.) Two Out of Three (EASY)
            //int[] nums1 = [1, 1, 3, 2];
            //int[] nums2 = [2,3];
            //int[] nums3 = [3];

            //LeetCode_2032 classLeetCode = new LeetCode_2032();
            //foreach (var item in classLeetCode.TwoOutOfThree(nums1, nums2, nums3)) 
            //{ 
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.TwoOutOfThree(nums1, nums2, nums3))
            //{
            //    Console.WriteLine(item);
            //}

            ////(2037.) Minimum Number of Moves to Seat Everyone (EASY)
            //int[] seats = [4,1,5,9];
            //int[] students = [1, 3, 2, 6];

            //LeetCode_2037 classLeetCode = new LeetCode_2037();
            //Console.WriteLine(classLeetCode.MinMovesToSeat(seats, students));

            ////OR

            //Console.WriteLine(leetCodeAll.MinMovesToSeat(seats, students));

            ////(2042.) Check if Numbers Are Ascending in a Sentence (EASY)
            //string s = "sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s";

            //LeetCode_2042 classLeetCode = new LeetCode_2042();
            //Console.WriteLine(classLeetCode.AreNumbersAscending(s));

            ////OR

            //Console.WriteLine(leetCodeAll.AreNumbersAscending(s));

            ////(2043.) Simple Bank System (MEDIUM)
            //LeetCode_2043.Bank bank1 = new LeetCode_2043.Bank([10, 100, 20, 50, 30]);
            //bank1.Withdraw(3, 10);    // return true, account 3 has a balance of $20, so it is valid to withdraw $10.
            //                         // Account 3 has $20 - $10 = $10.
            //bank1.Transfer(5, 1, 20); // return true, account 5 has a balance of $30, so it is valid to transfer $20.
            //                         // Account 5 has $30 - $20 = $10, and account 1 has $10 + $20 = $30.
            //bank1.Deposit(5, 20);     // return true, it is valid to deposit $20 to account 5.
            //                          // Account 5 has $10 + $20 = $30.
            //bank1.Transfer(3, 4, 15); // return false, the current balance of account 3 is $10,
            //                          // so it is invalid to transfer $15 from it.
            //bank1.Withdraw(10, 50);   // return false, it is invalid because account 10 does not exist.

            ////OR

            //BankTask2043 bank2 = new BankTask2043([10, 100, 20, 50, 30]);
            //bank2.Withdraw(3, 10);    // return true, account 3 has a balance of $20, so it is valid to withdraw $10.
            //                          // Account 3 has $20 - $10 = $10.
            //bank2.Transfer(5, 1, 20); // return true, account 5 has a balance of $30, so it is valid to transfer $20.
            //                          // Account 5 has $30 - $20 = $10, and account 1 has $10 + $20 = $30.
            //bank2.Deposit(5, 20);     // return true, it is valid to deposit $20 to account 5.
            //                          // Account 5 has $10 + $20 = $30.
            //bank2.Transfer(3, 4, 15); // return false, the current balance of account 3 is $10,
            //                          // so it is invalid to transfer $15 from it.
            //bank2.Withdraw(10, 50);   // return false, it is invalid because account 10 does not exist.

            //(2044.) Count Number of Maximum Bitwise-OR Subsets (MEDIUM)
            //int[] nums = [3, 2, 1, 5];

            //LeetCode_2044 classLeetCode = new LeetCode_2044();
            //Console.WriteLine(classLeetCode.CountMaxOrSubsets(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountMaxOrSubsets(nums));

            ////(2048.) Next Greater Numerically Balanced Number (MEDIUM)
            //int n = 1000;

            //LeetCode_2048 classLeetCode = new LeetCode_2048();
            //Console.WriteLine(classLeetCode.NextBeautifulNumber(n));

            ////OR

            //Console.WriteLine(leetCodeAll.NextBeautifulNumber(n));

            ////(2054.) Two Best Non-Overlapping Events (MEDIUM)
            //int[][] events = [[1, 3, 2], [1000000000, 1000000000, 10]];

            //LeetCode_2054 classLeetCode = new LeetCode_2054();
            //Console.WriteLine(classLeetCode.MaxTwoEvents(events));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxTwoEvents(events));

            ////(2057.) Smallest Index With Equal Value (EASY)
            //int[] nums = [4, 3, 2, 1];

            //LeetCode_2057 classLeetCode = new LeetCode_2057();
            //Console.WriteLine(classLeetCode.SmallestEqual(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestEqual(nums));

            ////(2068.) Check Whether Two Strings are Almost Equivalent (EASY)
            //string word1 = "abcdeef";
            //string word2 = "abaaacc";

            //LeetCode_2068 classLeetCode = new LeetCode_2068();
            //Console.WriteLine(classLeetCode.CheckAlmostEquivalent(word1, word2));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckAlmostEquivalent(word1, word2));

            ////(2078.) Two Furthest Houses With Different Colors (EASY)
            //int[] colors = [6, 6, 6, 6, 6, 6, 6, 6, 6, 19, 19, 6, 6];

            //LeetCode_2078 classLeetCode = new LeetCode_2078();
            //Console.WriteLine(classLeetCode.MaxDistance(colors));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDistance(colors));

            ////(2079.) Watering Plants (MEDIUM)
            //int[] plants = [1, 1, 1, 4, 2, 3];
            //int capacity = 4;

            //LeetCode_2079 classLeetCode = new LeetCode_2079();
            //Console.WriteLine(classLeetCode.WateringPlants(plants, capacity));

            ////OR

            //Console.WriteLine(leetCodeAll.WateringPlants(plants, capacity));

            ////(2085.) Count Common Words With One Occurrence (EASY)
            //string[] words1 = ["leetcode", "is", "amazing", "as", "is"];
            //string[] words2 = ["amazing", "leetcode", "is"];

            //LeetCode_2085 classLeetCode = new LeetCode_2085();
            //Console.WriteLine(classLeetCode.CountWords(words1, words2));

            ////OR

            //Console.WriteLine(leetCodeAll.CountWords(words1, words2));

            ////(2089.) Find Target Indices After Sorting Array (EASY)
            //int[] nums = [1, 2, 5, 2, 3];
            //int target = 2;

            //LeetCode_2089 classLeetCode = new LeetCode_2089();

            //foreach (var item in classLeetCode.TargetIndices(nums, target)) 
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.TargetIndices(nums, target))
            //{
            //    Console.WriteLine(item);
            //}

            ////(2094.) Finding 3-Digit Even Numbers (EASY)
            //int[] digits = [2, 1, 3, 0];

            //LeetCode_2094 classLeetCode = new LeetCode_2094();
            //Console.WriteLine(string.Join(',',classLeetCode.FindEvenNumbers(digits)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindEvenNumbers(digits)));

            ////(2099.) Find Subsequence of Length K With the Largest Sum (EASY)
            //int[] nums = [-1, -2, 3, 4];
            //int k = 3;

            //LeetCode_2099 classLeetCode = new LeetCode_2099();
            //Console.WriteLine(string.Join(',', classLeetCode.MaxSubsequence(nums, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MaxSubsequence(nums, k)));

            ////(2103.) Rings and Rods (EASY)
            //string rings = "B0B6G0R6R0R6G9";

            //LeetCode_2103 classLeetCode = new LeetCode_2103();
            //Console.WriteLine(classLeetCode.CountPoints(rings));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPoints(rings));

            ////(2106.) Maximum Fruits Harvested After at Most K Steps (HARD)
            //int[][] fruits = [[2, 8], [6, 3], [8, 6]];
            //int startPos = 5;
            //int k = 4;

            //LeetCode_2106 classLeetCode = new LeetCode_2106();
            //Console.WriteLine(classLeetCode.MaxTotalFruits(fruits, startPos, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxTotalFruits(fruits, startPos, k));

            //////(2108.) Find First Palindromic String in the Array (EASY)
            //string[] words = ["abc", "car", "ada", "racecar", "cool"];

            //LeetCode_2108 classLeetCode = new LeetCode_2108();
            //Console.WriteLine(string.Join(',',classLeetCode.FirstPalindrome(words)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FirstPalindrome(words)));

            ////(2109.) Adding Spaces to a String (MEDIUM)
            //string s = "LeetcodeHelpsMeLearn";
            //int[] spaces = [8, 13, 15];

            //LeetCode_2109 classLeetCode = new LeetCode_2109();
            //Console.WriteLine(classLeetCode.AddSpaces(s, spaces));

            ////OR

            //Console.WriteLine(leetCodeAll.AddSpaces(s, spaces));

            ////(2110.) Number of Smooth Descent Periods of a Stock (MEDIUM)
            //int[] prices = [3, 2, 1, 4];

            //LeetCode_2110 classLeetCode = new LeetCode_2110();
            //Console.WriteLine(classLeetCode.GetDescentPeriods(prices));

            ////OR

            //Console.WriteLine(leetCodeAll.GetDescentPeriods(prices));

            ////(2114.) Maximum Number of Words Found in Sentences (EASY)
            //string[] sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"];

            //LeetCode_2114 classLeetCode = new LeetCode_2114();
            //Console.WriteLine(classLeetCode.MostWordsFound(sentences));

            ////OR

            //Console.WriteLine(leetCodeAll.MostWordsFound(sentences));

            ////(2119.) A Number After a Double Reversal (EASY)
            //int num = 1800;

            //LeetCode_2119 classLeetCode = new LeetCode_2119();
            //Console.WriteLine(classLeetCode.IsSameAfterReversals(num));

            ////OR

            //Console.WriteLine(leetCodeAll.IsSameAfterReversals(num));

            ////(2124.) Check if All A's Appears Before All B's (EASY)
            //string s = "aaabbb";

            //LeetCode_2124 classLeetCode = new LeetCode_2124();
            //Console.WriteLine(classLeetCode.CheckString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckString(s));

            ////(2125.) Number of Laser Beams in a Bank (MEDIUM)
            //string[] bank = ["011001", "000000", "010100", "001000"];

            //LeetCode_2125 classLeetCode = new LeetCode_2125();
            //Console.WriteLine(classLeetCode.NumberOfBeams(bank));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfBeams(bank));

            ////(2129.) Capitalize the Title (EASY)
            //string title = "First leTTeR of EACH Word";

            //LeetCode_2129 classLeetCode = new LeetCode_2129();
            //Console.WriteLine(classLeetCode.CapitalizeTitle(title));

            ////OR

            //Console.WriteLine(leetCodeAll.CapitalizeTitle(title));

            ////(2130.) Maximum Twin Sum of a Linked List (MEDIUM)
            //ListNode head = new ListNode(5);
            //head.next = new ListNode(4);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(2);
            //head.next.next.next.next = new ListNode(1);

            //LeetCode_2130 classLeetCode = new LeetCode_2130();
            //Console.WriteLine(classLeetCode.PairSum(head));

            ////OR

            //Console.WriteLine(leetCodeAll.PairSum(head));

            ////(2133.) Check if Every Row and Column Contains All Numbers (EASY)
            //int[][] matrix = [[1, 2, 3], [3, 1, 2], [2, 3, 1]];

            //LeetCode_2133 classLeetCode = new LeetCode_2133();
            //Console.WriteLine(classLeetCode.CheckValid(matrix));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckValid(matrix));

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

            ////(2144.) Minimum Cost of Buying Candies With Discount (EASY)
            //int[] cost = [6, 5, 7, 9, 2, 2];

            //LeetCode_2144 classLeetCode = new LeetCode_2144();
            //Console.WriteLine(classLeetCode.MinimumCost(cost));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumCost(cost));

            ////(2148.) Count Elements With Strictly Smaller and Greater Elements (EASY)
            //int[] nums = [-3, 3, 3, 90];

            //LeetCode_2148 classLeetCode = new LeetCode_2148();
            //Console.WriteLine(classLeetCode.CountElements(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountElements(nums));

            ////(2149.) Rearrange Array Elements by Sign (MEDIUM)
            //int[] nums = [3, 1, -2, -5, 2, -4];

            //LeetCode_2149 classLeetCode = new LeetCode_2149();
            //Console.WriteLine(string.Join(',', classLeetCode.RearrangeArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RearrangeArray(nums)));

            ////(2150.) Find All Lonely Numbers in the Array (MEDIUM)
            //int[] nums = [10, 6, 5, 8];

            //LeetCode_2150 classLeetCode = new LeetCode_2150();
            //Console.WriteLine(string.Join(',',classLeetCode.FindLonely(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindLonely(nums)));

            ////(2154.) Keep Multiplying Found Values by Two (EASY)
            //int[] nums = [5, 3, 6, 1, 12];
            //int original = 3;

            //LeetCode_2154 classLeetCode = new LeetCode_2154();
            //Console.WriteLine(classLeetCode.FindFinalValue(nums, original));

            ////OR

            //Console.WriteLine(leetCodeAll.FindFinalValue(nums, original));

            ////(2160.) Minimum Sum of Four Digit Number After Splitting Digits (EASY) 
            //int num = 2932;

            //LeetCode_2160 classLeetCode =  new LeetCode_2160();
            //Console.WriteLine(classLeetCode.MinimumSum(num));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumSum(num));

            ////(2161.) Partition Array According to Given Pivot (MEDIUM)
            //int[] nums = [9,12,5,10,14,3,10];
            //int pivot = 10;

            //LeetCode_2161 classLeetCode = new LeetCode_2161();
            //Console.WriteLine(string.Join(',', classLeetCode.PivotArray(nums, pivot)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.PivotArray(nums, pivot)));

            ////(2164.) Sort Even and Odd Indices Independently (EASY)
            //int[] nums = [5, 39, 33, 5, 12, 27, 20, 45, 14, 25, 32, 33, 30, 30, 9, 14, 44, 15, 21];

            //LeetCode_2164 classLeetCode = new LeetCode_2164();
            //Console.WriteLine(string.Join(',',classLeetCode.SortEvenOdd(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortEvenOdd(nums)));

            ////(2169.) Count Operations to Obtain Zero (EASY)
            //int num1 = 2;
            //int num2 = 3;

            //LeetCode_2169 classLeetCode = new LeetCode_2169();
            //Console.WriteLine(classLeetCode.CountOperations(num1, num2));

            ////OR

            //Console.WriteLine(leetCodeAll.CountOperations(num1, num2));

            ////(2176.) Count Equal and Divisible Pairs in an Array (EASY)
            //int[] nums = [3, 1, 2, 2, 2, 1, 3];
            //int k = 2;

            //LeetCode_2176 classLeetCode = new LeetCode_2176();
            //Console.WriteLine(classLeetCode.CountPairs(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPairs(nums, k));

            ////(2177.) Find Three Consecutive Integers That Sum to a Given Number (MEDIUM)
            //long num = 33;

            //LeetCode_2177 classLeetCode = new LeetCode_2177();
            //Console.WriteLine(string.Join(',',classLeetCode.SumOfThree(num)));

            ////OR

            //Console.WriteLine(string.Join(',',leetCodeAll.SumOfThree(num)));

            ////(2180.) Count Integers With Even Digit Sum (EASY)
            //int num = 30;

            //LeetCode_2180 classLeetCode = new LeetCode_2180();
            //Console.WriteLine(classLeetCode.CountEven(num));

            ////OR

            //Console.WriteLine(leetCodeAll.CountEven(num));

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

            ////(2185.) Counting Words With a Given Prefix (EASY)
            //string[] words = ["pay", "attention", "practice", "attend"];
            //string pref = "at";

            //LeetCode_2185 classLeetCode = new LeetCode_2185();
            //Console.WriteLine(classLeetCode.PrefixCount(words, pref));

            ////OR

            //Console.WriteLine(leetCodeAll.PrefixCount(words, pref));

            ////(2186.) Minimum Number of Steps to Make Two Strings Anagram II (MEDIUM)
            //string s = "leetcode";
            //string t = "coats";

            //LeetCode_2186 classLeetCode = new LeetCode_2186();
            //Console.WriteLine(classLeetCode.MinSteps(s, t));

            ////OR

            //Console.WriteLine(leetCodeAll.MinStepsTask2186(s, t));

            ////(2190.) Most Frequent Number Following Key In an Array (EASY)
            //int[] nums = [1, 100, 200, 1, 100];
            //int key = 1;

            //LeetCode_2190 classLeetCode = new LeetCode_2190();
            //Console.WriteLine(classLeetCode.MostFrequent(nums, key));

            ////OR

            //Console.WriteLine(leetCodeAll.MostFrequent(nums, key));

            ////(2194.) Cells in a Range on an Excel Sheet (EASY)
            //string s = "K1:L2";

            //LeetCode_2194 classLeetCode = new LeetCode_2194();
            //Console.WriteLine(string.Join(',', classLeetCode.CellsInRange(s)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.CellsInRange(s)));

            ////(2197.) Replace Non-Coprime Numbers in Array (HARD)
            //int[] nums = [6, 4, 3, 2, 7, 6, 2];

            //LeetCode_2197 classLeetCode = new LeetCode_2197();
            //Console.WriteLine(string.Join(',', classLeetCode.ReplaceNonCoprimes(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ReplaceNonCoprimes(nums)));

            ////(2200.) Find All K-Distant Indices in an Array (EASY)
            //int[] nums = [2, 1, 1, 1, 2];
            //int key = 2;
            //int k = 1;

            //LeetCode_2200 classLeetCode = new LeetCode_2200();
            //Console.WriteLine(string.Join(',', classLeetCode.FindKDistantIndices(nums, key, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindKDistantIndices(nums, key, k)));

            ////(2206.) Divide Array Into Equal Pairs (EASY)
            //int[] nums = [3, 2, 3, 2, 2, 2];

            //LeetCode_2206 classLeetCode = new LeetCode_2206();
            //Console.WriteLine(classLeetCode.DivideArray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.DivideArray(nums));

            ////(2210.) Count Hills and Valleys in an Array (EASY)
            //int[] nums = [2, 4, 1, 1, 6, 5];

            //LeetCode_2210 classLeetCode = new LeetCode_2210();
            //Console.WriteLine(classLeetCode.CountHillValley(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountHillValley(nums));

            ////(2215.) Find the Difference of Two Arrays (EASY)
            //int[] nums1 = [1, 2, 3];
            //int[] nums2 = [2, 4, 6];

            //LeetCode_2215 classLeetCode = new LeetCode_2215();
            //foreach (var item in classLeetCode.FindDifference(nums1,nums2))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.FindDifference(nums1, nums2))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2220.) Minimum Bit Flips to Convert Number (EASY)
            //int start = 10;
            //int goal = 7;

            //LeetCode_2220 classLeetCode = new LeetCode_2220();
            //Console.WriteLine(classLeetCode.MinBitFlips(start, goal));

            ////OR

            //Console.WriteLine(leetCodeAll.MinBitFlips(start, goal));

            ////(2221.) Find Triangular Sum of an Array (MEDIUM)
            //int[] nums = [1, 2, 3, 4, 5];

            //LeetCode_2221 classLeetCode = new LeetCode_2221();
            //Console.WriteLine(classLeetCode.TriangularSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.TriangularSum(nums));

            ////(2224.) Minimum Number of Operations to Convert Time (EASY)
            //string current = "02:30", correct = "04:35";

            //LeetCode_2224 classLeetCode = new LeetCode_2224();
            //Console.WriteLine(classLeetCode.ConvertTime(current, correct));

            ////OR

            //Console.WriteLine(leetCodeAll.ConvertTime(current, correct));

            ////(2225.) Find Players With Zero or One Losses (MEDIUM)
            //int[][] matches = [[1, 3], [2, 3], [3, 6], [5, 6], [5, 7], [4, 5], [4, 8], [4, 9], [10, 4], [10, 9]];

            //LeetCode_2225 classLeetCode = new LeetCode_2225();
            //foreach (var item in classLeetCode.FindWinners(matches))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.FindWinners(matches))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2235.) Add Two Integers (EASY)
            //int num1 = 12;
            //int num2 = 5;

            //LeetCode_2235 classLeetCode = new LeetCode_2235();
            //Console.WriteLine(classLeetCode.Sum(num1, num2));

            ////OR

            //Console.WriteLine(leetCodeAll.Sum(num1, num2));

            ////(2236.) Root Equals Sum of Children (EASY)
            //TreeNode root = new TreeNode(10);
            //root.left = new TreeNode(4);
            //root.right = new TreeNode(6);

            //LeetCode_2236 classLeetCode = new LeetCode_2236();
            //Console.WriteLine(classLeetCode.CheckTree(root));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckTree(root));

            ////(2239.) Find Closest Number to Zero (EASY)
            //int[] nums = [-4,-2,1,4,8];

            //LeetCode_2239 classLeetCode = new LeetCode_2239();
            //Console.WriteLine(classLeetCode.FindClosestNumber(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindClosestNumber(nums));

            ////(2248.) Intersection of Multiple Arrays (EASY)
            //int[][] nums = [[3, 1, 2, 4, 5], [1, 2, 3, 4], [3, 4, 5, 6]];

            //LeetCode_2248 classLeetCode = new LeetCode_2248();
            //Console.WriteLine(string.Join(',', classLeetCode.Intersection(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.Intersection(nums)));

            ////(2255.) Count Prefixes of a Given String (EASY)
            //string[] words = ["a", "b", "c", "ab", "bc", "abc"];
            //string s = "abc";

            //LeetCode_2255 classLeetCode = new LeetCode_2255();
            //Console.WriteLine(classLeetCode.CountPrefixes(words, s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPrefixes(words, s));

            ////(2257.) Count Unguarded Cells in the Grid (MEDIUM)
            //int m = 4;
            //int n = 6;
            //int[][] guards = [[0, 0], [1, 1], [2, 3]];
            //int[][] walls = [[0, 1], [2, 2], [1, 4]];

            //LeetCode_2257 classLeetCode = new LeetCode_2257();
            //Console.WriteLine(classLeetCode.CountUnguarded(m, n, guards, walls));

            ////OR

            //Console.WriteLine(leetCodeAll.CountUnguarded(m, n, guards, walls));

            ////(2264.) Largest 3-Same-Digit Number in String (EASY)
            //string num = "42352338";

            //LeetCode_2264 classLeetCode = new LeetCode_2264();
            //Console.WriteLine(classLeetCode.LargestGoodInteger(num));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestGoodInteger(num));

            ////(2269.) Find the K-Beauty of a Number (EASY)
            //int num = 430043;
            //int k = 2;

            //LeetCode_2269 classLeetCode = new LeetCode_2269();
            //Console.WriteLine(classLeetCode.DivisorSubstrings(num, k));

            ////OR

            //Console.WriteLine(leetCodeAll.DivisorSubstrings(num, k));

            ////(2273.) Find Resultant Array After Removing Anagrams (EASY)
            //string[] words = ["abba", "baba", "bbaa", "cd", "cd"];

            //LeetCode_2273 classLeetCode = new LeetCode_2273();

            //foreach (var item in classLeetCode.RemoveAnagrams(words))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.RemoveAnagrams(words))
            //{
            //    Console.WriteLine(item);
            //}

            ////(2278.) Percentage of Letter in String (EASY)
            //string s = "foobar";
            //char letter = 'o';

            //LeetCode_2278 classLeetCode = new LeetCode_2278();
            //Console.WriteLine(classLeetCode.PercentageLetter(s, letter));

            ////OR

            //Console.WriteLine(leetCodeAll.PercentageLetter(s, letter));

            ////(2279.) Maximum Bags With Full Capacity of Rocks (MEDIUM)
            //int[] capacity = [2, 3, 4, 5];
            //int[] rocks = [1, 2, 4, 4];
            //int additionalRocks = 2;

            //LeetCode_2279 classLeetCode = new LeetCode_2279();
            //Console.WriteLine(classLeetCode.MaximumBags(capacity, rocks, additionalRocks));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumBags(capacity, rocks, additionalRocks));

            ////(2283.) Check if Number Has Equal Digit Count and Digit Value (EASY)
            //string num = "1210";

            //LeetCode_2283 classLeetCode = new LeetCode_2283();
            //Console.WriteLine(classLeetCode.DigitCount(num));

            ////OR

            //Console.WriteLine(leetCodeAll.DigitCount(num));

            ////(2287.) Rearrange Characters to Make Target String (EASY)
            //string s = "ilovecodingonleetcode";
            //string target = "code";

            //LeetCode_2287 classLeetCode = new LeetCode_2287();
            //Console.WriteLine(classLeetCode.RearrangeCharacters(s, target));

            ////OR

            //Console.WriteLine(leetCodeAll.RearrangeCharacters(s, target));

            ////(2293.) Min Max Game (EASY)
            //int[] nums = [70, 38, 21, 22];

            //LeetCode_2293 classLeetCode = new LeetCode_2293();
            //Console.WriteLine(classLeetCode.MinMaxGame(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinMaxGame(nums));

            ////(2294.) Partition Array Such That Maximum Difference Is K (MEDIUM)
            //int[] nums = [3, 6, 1, 2, 5];
            //int k = 2;

            //LeetCode_2294 classLeetCode = new LeetCode_2294();
            //Console.WriteLine(classLeetCode.PartitionArray(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.PartitionArray(nums, k));

            ////(2299.) Strong Password Checker II (EASY)
            //string password = "IloveLe3tcode!";

            //LeetCode_2299 classLeetCode = new LeetCode_2299();
            //Console.WriteLine(classLeetCode.StrongPasswordCheckerII(password));

            ////OR

            //Console.WriteLine(leetCodeAll.StrongPasswordCheckerII(password));

            ////(2300.) Successful Pairs of Spells and Potions (MEDIUM)
            //int[] spells = [5, 1, 3];
            //int[] potions = [1, 2, 3, 4, 5];
            //long success = 7;

            //LeetCode_2300 classLeetCode = new LeetCode_2300();
            //Console.WriteLine(string.Join(',', classLeetCode.SuccessfulPairs(spells, potions, success)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SuccessfulPairs(spells, potions, success)));

            ////(2303.) Calculate Amount Paid in Taxes (EASY)
            //int[][] backets = [[3, 50], [7, 10], [12, 25]];
            //int income = 10;

            //LeetCode_2303 classLeetCode = new LeetCode_2303();
            //Console.WriteLine(classLeetCode.CalculateTax(backets, income));

            ////OR

            //Console.WriteLine(leetCodeAll.CalculateTax(backets, income));

            ////(2309.) Greatest English Letter in Upper and Lower Case (EASY)
            //string s = "AbCdEfGhIjK";

            //LeetCode_2309 classLeetCode = new LeetCode_2309();
            //Console.WriteLine(classLeetCode.GreatestLetter(s));

            ////OR

            //Console.WriteLine(leetCodeAll.GreatestLetter(s));

            ////(2311.) Longest Binary Subsequence Less Than or Equal to K (MEDIUM)
            //string s = "1001010";
            //int k = 5;

            //LeetCode_2311 classLeetCode = new LeetCode_2311();
            //Console.WriteLine(classLeetCode.LongestSubsequence(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestSubsequence(s, k));

            ////(2315.) Count Asterisks (EASY)
            //string s = "yo|uar|e**|b|e***au|tifu|l";

            //LeetCode_2315 classLeetCode = new LeetCode_2315();
            //Console.WriteLine(classLeetCode.CountAsterisks(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountAsterisks(s));

            ////(2319.) Check if Matrix Is X-Matrix (EASY)
            //int[][] grid = [[2, 0, 0, 1], [0, 3, 1, 0], [0, 5, 2, 0], [4, 0, 0, 2]];

            //LeetCode_2319 classLeetCode = new LeetCode_2319();
            //Console.WriteLine(classLeetCode.CheckXMatrix(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckXMatrix(grid));

            ////(2325.) Decode the Message (EASY) 
            //string key = "the quick brown fox jumps over the lazy dog";
            //string message = "vkbs bs t suepuv";

            //LeetCode_2325 classLeetCode = new LeetCode_2325();
            //Console.WriteLine(classLeetCode.DecodeMessage(key, message));

            ////OR

            //Console.WriteLine(leetCodeAll.DecodeMessage(key, message));

            ////(2327.) Number of People Aware of a Secret (MEDIUM)
            //int n = 4, delay = 1, forget = 3;

            //LeetCode_2327 classLeetCode = new LeetCode_2327();
            //Console.WriteLine(classLeetCode.PeopleAwareOfSecret(n, delay, forget));

            ////OR

            //Console.WriteLine(leetCodeAll.PeopleAwareOfSecret(n, delay, forget));

            ////(2331.) Evaluate Boolean Binary Tree (EASY)
            //TreeNode root = new TreeNode(2);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(3);
            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(1);

            //LeetCode_2331 classLeetCode = new LeetCode_2331();
            //Console.WriteLine(classLeetCode.EvaluateTree(root));

            ////OR

            //Console.WriteLine(leetCodeAll.EvaluateTree(root));

            ////(2341.) Maximum Number of Pairs in Array (EASY)
            //int[] nums = [1, 3, 2, 1, 3, 2, 2];

            //LeetCode_2341 classLeetCode = new LeetCode_2341();
            //Console.WriteLine(string.Join(',',classLeetCode.NumberOfPairs(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.NumberOfPairs(nums)));

            ////(2342.) Max Sum of a Pair With Equal Sum of Digits (MEDIUM)
            //int[] nums = [10, 12, 19, 14];

            //LeetCode_2342 classLEetCode = new LeetCode_2342();
            //Console.WriteLine(classLEetCode.MaximumSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumSum(nums));

            ////(2347.) Best Poker Hand (EASY)
            //int[] ranks = [4, 4, 2, 4, 4];
            //char[] suits = ['d', 'a', 'a', 'b', 'c'];

            //LeetCode_2347 classLeetCode = new LeetCode_2347();
            //Console.WriteLine(classLeetCode.BestHand(ranks, suits));

            ////OR

            //Console.WriteLine(leetCodeAll.BestHand(ranks, suits));

            ////(2348.) Number of Zero-Filled Subarrays (MEDIUM)
            //int[] nums = [0, 0, 0, 2, 0, 0];

            //LeetCode_2348 classLeetCode = new LeetCode_2348();
            //Console.WriteLine(classLeetCode.ZeroFilledSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.ZeroFilledSubarray(nums));                                               

            ////(2351.) First Letter to Appear Twice (EASY)
            //string s = "abccbaacz";

            //LeetCode_2351 classLeetCode = new LeetCode_2351();
            //Console.WriteLine(classLeetCode.RepeatedCharacter(s));

            ////OR

            //Console.WriteLine(leetCodeAll.RepeatedCharacter(s));

            ////(2352.) Equal Row and Column Pairs (MEDIUM)
            //int[][] grid = [[11, 1], [1, 11]];

            //LeetCode_2352 classLeetCode = new LeetCode_2352();
            //Console.WriteLine(classLeetCode.EqualPairs(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.EqualPairs(grid));

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

            ////(2357.) Make Array Zero by Subtracting Equal Amounts (EASY)
            //int[] nums = [1,5,0,3,5];

            //LeetCode_2357 classLeetCode = new LeetCode_2357();
            //Console.WriteLine(classLeetCode.MinimumOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumOperations2357(nums));

            ////(2363.) Merge Similar Items (EASY)
            //int[][] items1 = [[2, 9], [24, 4], [11, 1], [16, 3], [1, 4], [28, 3], [23, 8], [3, 3]];
            //int[][] items2 = [[7, 6], [12, 7], [9, 5], [22, 4], [6, 3], [17, 1]];

            //LeetCode_2363 classLeetCode = new LeetCode_2363();

            //foreach (var item in classLeetCode.MergeSimilarItems(items1, items2))
            //{
            //    foreach (var itemIn in item)
            //    {
            //        Console.WriteLine(itemIn);
            //    }
            //}

            ////OR

            //foreach (var item in leetCodeAll.MergeSimilarItems(items1, items2))
            //{
            //    foreach (var itemIn in item)
            //    {
            //        Console.WriteLine(itemIn);
            //    }
            //}

            ////(2367.) Number of Arithmetic Triplets (EASY)
            //int[] nums = [0, 1, 4, 6, 7, 10];
            //int diff = 3;

            //LeetCode_2367 classLeetCode = new LeetCode_2367();
            //Console.WriteLine(classLeetCode.ArithmeticTriplets(nums, diff));

            ////OR

            //Console.WriteLine(leetCodeAll.ArithmeticTriplets(nums, diff));

            ////(2373.) Largest Local Values in a Matrix (EASY)
            //int[][] grid = [[1, 1, 1, 1, 1], [1, 1, 1, 1, 1], [1, 1, 2, 1, 1], [1, 1, 1, 1, 1], [1, 1, 1, 1, 1]];

            //LeetCode_2373 classLeetCode = new LeetCode_2373();
            //int[][] result = classLeetCode.LargestLocal(grid);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));    
            //}

            ////OR

            //int[][] result1 = leetCodeAll.LargestLocal(grid);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2391.) Minimum Amount of Time to Collect Garbage (MEDIUM)
            //string[] garbage = ["G", "P", "GP", "GG"];
            //int[] travel = [2, 4, 3];

            //LeetCode_2391 classLeetCode = new LeetCode_2391();
            //Console.WriteLine(classLeetCode.GarbageCollection(garbage, travel));

            ////OR

            //Console.WriteLine(leetCodeAll.GarbageCollection(garbage, travel));

            ////(2395.) Find Subarrays With Equal Sum (EASY)
            //int[] nums = [1, 2, 3, 4, 5];

            //LeetCode_2395 classLeetCode = new LeetCode_2395();
            //Console.WriteLine(classLeetCode.FindSubarrays(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindSubarrays(nums));

            ////(2396.) Strictly Palindromic Number (MEDIUM)
            //int n = 9;

            //LeetCode_2396 classLeetCode = new LeetCode_2396();
            //Console.WriteLine(classLeetCode.IsStrictlyPalindromic(n));

            ////OR

            //Console.WriteLine(leetCodeAll.IsStrictlyPalindromic(n));

            ////(2399.) Check Distances Between Same Letters (EASY)
            //string s = "abaccb";
            //int[] distance = [1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            //LeetCode_2399 classLeetCode = new LeetCode_2399();
            //Console.WriteLine(classLeetCode.CheckDistances(s, distance));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckDistances(s, distance));

            ////(2404.) Most Frequent Even Element (EASY)
            //int[] nums = [0, 1, 2, 2, 4, 4, 1];

            //LeetCode_2404 classLeetCode = new LeetCode_2404();
            //Console.WriteLine(classLeetCode.MostFrequentEven(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MostFrequentEven(nums));

            ////(2410.) Maximum Matching of Players With Trainers (MEDIUM)
            //int[] players = [4, 7, 9];
            //int[] trainers = [8, 2, 5, 8];

            //LeetCode_2410 classLeetCode = new LeetCode_2410();
            //Console.WriteLine(classLeetCode.MatchPlayersAndTrainers(players, trainers));

            ////OR

            //Console.WriteLine(leetCodeAll.MatchPlayersAndTrainers(players, trainers));

            ////(2413.) Smallest Even Multiple (EASY)
            //int n = 6;

            //LeetCode_2413 classLeetCode = new LeetCode_2413();
            //Console.WriteLine(classLeetCode.SmallestEvenMultiple(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestEvenMultiple(n));

            ////(2414.) Length of the Longest Alphabetical Continuous Substring (MEDIUM)
            //string s = "abacaba";

            //LeetCode_2414 classLeetCode = new LeetCode_2414();
            //Console.WriteLine(classLeetCode.LongestContinuousSubstring(s));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestContinuousSubstring(s));

            ////(2415.) Reverse Odd Levels of Binary Tree (MEDIUM)
            //TreeNode root = new TreeNode(2);
            //root.left = new TreeNode(3);
            //root.left.left = new TreeNode(8);
            //root.left.right = new TreeNode(13);
            //root.right = new TreeNode(5);
            //root.right.left = new TreeNode(21);
            //root.right.right = new TreeNode(34);

            //LeetCode_2415 classLeetCode = new LeetCode_2415();
            //classLeetCode.ReverseOddLevels(root);

            ////OR

            //leetCodeAll.ReverseOddLevels(root);

            ////(2418.) Sort the People (EASY)
            //string[] names = ["Mary", "John", "Emma"];
            //int[] heigts = [180, 165, 170];

            //LeetCode_2418 classLeetCode = new LeetCode_2418();
            //Console.WriteLine(string.Join(',',classLeetCode.SortPeople(names,heigts)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SortPeople(names, heigts)));

            ////(2419.) Longest Subarray With Maximum Bitwise AND (MEDIUM)
            //int[] nums = [100, 5, 5];

            //LeetCode_2419 classLeetCode = new LeetCode_2419();
            //Console.WriteLine(classLeetCode.LongestSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestSubarray(nums));

            ////(2427.) Number of Common Factors (EASY)
            //int a = 25;
            //int b = 30;

            //LeetCode_2427 classLeetCode = new LeetCode_2427();
            //Console.WriteLine(classLeetCode.CommonFactors(a, b));

            ////OR

            //Console.WriteLine(leetCodeAll.CommonFactors(a, b));

            ////(2428.) Maximum Sum of an Hourglass (MEDIUM)
            //int[][] grid = [[6, 2, 1, 3], [4, 2, 1, 5], [9, 2, 8, 7], [4, 1, 2, 9]];

            //LeetCode_2428 classLeetCode = new LeetCode_2428();
            //Console.WriteLine(classLeetCode.MaxSum(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxSum(grid));

            ////(2432.) The Employee That Worked on the Longest Task (EASY)
            //int n = 10;
            //int[][] logs = [[0,3],[2,5],[0,9],[1,15]];

            //LeetCode_2432 classLeetCode = new LeetCode_2432();
            //Console.WriteLine(classLeetCode.HardestWorker(n, logs));

            ////OR

            //Console.WriteLine(leetCodeAll.HardestWorker(n, logs));

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

            ////(2441.) Largest Positive Integer That Exists With Its Negative (EASY)
            //int[] nums = [-1,2,-3,3];

            //LeetCode_2441 classLeetCode = new LeetCode_2441();
            //Console.WriteLine(classLeetCode.FindMaxK(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindMaxK(nums));

            ////(2442.) Count Number of Distinct Integers After Reverse Operations (MEDIUM)
            //int[] nums = [1,13,10,12,31];

            //LeetCode_2442 classLeetCode = new LeetCode_2442();
            //Console.WriteLine(classLeetCode.CountDistinctIntegers(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountDistinctIntegers(nums));

            ////(2455.) Average Value of Even Numbers That Are Divisible by Three (EASY)
            //int[] nums = [1, 3, 6, 10, 12, 15];

            //LeetCode_2455 classLeetCode = new LeetCode_2455();
            //Console.WriteLine(classLeetCode.AverageValue(nums));

            ////OR

            //Console.WriteLine(lee.AverageValue(nums));

            ////(2460.) Apply Operations to an Array (EASY)
            //int[] nums = [0,1];

            //LeetCode_2460 classLeetCode = new LeetCode_2460();
            //Console.WriteLine(string.Join(',', classLeetCode.ApplyOperations(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ApplyOperations(nums)));

            ////(2465.) Number of Distinct Averages (EASY)
            //int[] nums = [4, 1, 4, 0, 3, 5];

            //LeetCode_2465 classLeetCode = new LeetCode_2465();
            //Console.WriteLine(classLeetCode.DistinctAverages(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.DistinctAverages(nums));

            ////(2469.) Convert the Temperature (EASY)
            //double celsius = 36.5;

            //LeetCode_2469 classLeetCode = new LeetCode_2469();
            //Console.WriteLine(string.Join((':'), classLeetCode.ConvertTemperature(celsius)));

            ////OR

            //Console.WriteLine(string.Join((':'), leetCodeAll.ConvertTemperature(celsius)));

            ////(2475.) Number of Unequal Triplets in Array (EASY)
            //int[] nums = [4,4,2,4,3];

            //LeetCode_2475 classLeetCode = new LeetCode_2475();
            //Console.WriteLine(classLeetCode.UnequalTriplets(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.UnequalTriplets(nums));

            ////(2481.) Minimum Cuts to Divide a Circle (EASY)
            //int n = 4;

            //LeetCode_2481 classLeetCode = new LeetCode_2481();
            //Console.WriteLine(classLeetCode.NumberOfCuts(n));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfCuts(n));

            ////(2482.) Difference Between Ones and Zeros in Row and Column (MEDIUM)
            //int[][] grid = [[0, 1, 1], [1, 0, 1], [0, 0, 1]];

            //LeetCode_2482 classLeetCode = new LeetCode_2482();
            //foreach (var item in classLeetCode.OnesMinusZeros(grid)) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.OnesMinusZeros(grid))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2483.) Minimum Penalty for a Shop (MEDIUM)
            //string customers = "YYNY";

            //LeetCode_2483 classLeetCode = new LeetCode_2483();
            //Console.WriteLine(classLeetCode.BestClosingTime(customers));

            ////OR

            //Console.WriteLine(leetCodeAll.BestClosingTime(customers));

            ////(2485.) Find the Pivot Integer (EASY)
            //int n = 8;

            //LeetCode_2485 classLeetCode = new LeetCode_2485();
            //Console.WriteLine(classLeetCode.PivotInteger(n));

            ////OR

            //Console.WriteLine(leetCodeAll.PivotInteger(n));

            ////(2490.) Circular Sentence (EASY)
            //string sentence = "Leetcode eisc cool";

            //LeetCode_2490 classLeetCode = new LeetCode_2490();
            //Console.WriteLine(classLeetCode.IsCircularSentence(sentence));

            ////OR

            //Console.WriteLine(leetCodeAll.IsCircularSentence(sentence));

            ////(2496.) Maximum Value of a String in an Array (EASY)
            //string[] strs = ["1", "01", "001", "0001"];

            //LeetCode_2496 classLeetCode = new LeetCode_2496();
            //Console.WriteLine(classLeetCode.MaximumValue(strs));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumValue(strs));

            ////(2500.) Delete Greatest Value in Each Row (EASY)
            //int[][] grid = [[1, 2, 4], [3, 3, 1]];

            //LeetCode_2500 classLeetCode = new LeetCode_2500();
            //Console.WriteLine(classLeetCode.DeleteGreatestValue(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.DeleteGreatestValue(grid));

            ////(2520.) Count the Digits That Divide a Number (EASY)
            //int num = 1248;

            //LeetCode_2520 classLeetCode = new LeetCode_2520();
            //Console.WriteLine(classLeetCode.CountDigits(num));

            ////OR

            //Console.WriteLine(leetCodeAll.CountDigits(num));

            //(2525.) Categorize Box According to Criteria (EASY)
            //int length = 1000;
            //int width = 35;
            //int height = 700;
            //int mass = 300;

            //LeetCode_2525 classLeetCode = new LeetCode_2525();
            //Console.WriteLine(classLeetCode.CategorizeBox(length, width, height, mass));

            ////OR

            //Console.WriteLine(leetCodeAll.CategorizeBox(length, width, height, mass));

            ////(2529.) Maximum Count of Positive Integer and Negative Integer (EASY)
            //int[] nums = [-2, -1, -1, 0, 0, 0];

            //LeetCode_2529 classLeetCode = new LeetCode_2529();
            //Console.WriteLine(classLeetCode.MaximumCount(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumCount(nums));

            ////(2535.) Difference Between Element Sum and Digit Sum of an Array (EASY)
            //int[] nums = [1, 15, 6, 3];

            //LeetCode_2535 classLeetCode = new LeetCode_2535();
            //Console.WriteLine(classLeetCode.DifferenceOfSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.DifferenceOfSum(nums));

            ////(2540.) Minimum Common Value (EASY)
            //int[] nums1 = [1, 2, 3, 6];
            //int[] nums2 = [2, 3, 4, 5];

            //LeetCode_2540 classLeetCode = new LeetCode_2540();
            //Console.WriteLine(classLeetCode.GetCommon(nums1, nums2));

            ////OR

            //Console.WriteLine(leetCodeAll.GetCommon(nums1, nums2));

            ////(2544.) Alternating Digit Sum (EASY)
            //int n = 521;

            //LeetCode_2544 classLeetCode = new LeetCode_2544();
            //Console.WriteLine(classLeetCode.AlternateDigitSum(n));

            ////OR

            //Console.WriteLine(leetCodeAll.AlternateDigitSum(n));

            ////(2545.) Sort the Students by Their Kth Score (MEDIUM)
            //int[][] score = [[10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15]];
            //int k = 2;

            //LeetCode_2545 classLeetCode = new LeetCode_2545();

            //int[][] result = classLeetCode.SortTheStudents(score, k);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.SortTheStudents(score, k);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2549.) Count Distinct Numbers on Board (EASY)
            //int n = 5;

            //LeetCode_2549 classLeetCode = new LeetCode_2549();
            //Console.WriteLine(classLeetCode.DistinctIntegers(n));

            ////OR

            //Console.WriteLine(leetCodeAll.DistinctIntegers(n));

            ////(2553.) Separate the Digits in an Array (EASY)
            //int[] nums = [13, 25, 83, 77];

            //LeetCode_2553 classLeetCode = new LeetCode_2553();
            //Console.WriteLine(string.Join(',', classLeetCode.SeparateDigits(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.SeparateDigits(nums)));

            ////(2558.) Take Gifts From the Richest Pile (EASY)
            //int[] gifts = [25, 64, 9, 4, 100];
            //int k = 4;

            //LeetCode_2558 classLeetCode = new LeetCode_2558();
            //Console.WriteLine(classLeetCode.PickGifts(gifts, k));

            ////OR

            //Console.WriteLine(leetCodeAll.PickGifts(gifts, k));

            ////(2561.) Rearranging Fruits (HARD)
            //int[] basket1 = [4, 2, 2, 2];
            //int[] basket2 = [1, 4, 1, 2];

            //LeetCode_2561 classLeetCode = new LeetCode_2561();
            //Console.WriteLine(classLeetCode.MinCost(basket1, basket2));

            ////OR

            //Console.WriteLine(leetCodeAll.MinCost(basket1, basket2));

            ////(2562.) Find the Array Concatenation Value (EASY)
            //int[] nums = [5, 14, 13, 8, 12];

            //LeetCode_2562 classLeetCode = new LeetCode_2562();
            //Console.WriteLine(classLeetCode.FindTheArrayConcVal(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindTheArrayConcVal(nums));

            ////(2566.) Maximum Difference by Remapping a Digit (EASY)
            //int num = 11891;

            //LeetCode_2566 classLeetCode = new LeetCode_2566();
            //Console.WriteLine(classLeetCode.MinMaxDifference(num));

            ////OR

            //Console.WriteLine(leetCodeAll.MinMaxDifference(num));

            ////(2570.) Merge Two 2D Arrays by Summing Values (EASY)
            //int[][] nums1 = [[1, 2], [2, 3], [4, 5]];
            //int[][] nums2 = [[1, 4], [3, 2], [4, 1]];

            //LeetCode_2570 classLeetCode = new LeetCode_2570();
            //foreach (var item in classLeetCode.MergeArrays(nums1, nums2))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.MergeArrays(nums1, nums2))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2574.) Left and Right Sum Differences (EASY)
            //int[] nums = [10, 4, 8, 3];

            //LeetCode_2574 classLeetCode = new LeetCode_2574();
            //Console.WriteLine(string.Join(',', classLeetCode.LeftRightDifference(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.LeftRightDifference(nums)));

            ////(2582.) Pass the Pillow (EASY)
            //int n = 4;
            //int time = 5;

            //LeetCode_2582 classLeetCode = new LeetCode_2582();
            //Console.WriteLine(classLeetCode.PassThePillow(n, time));

            ////OR

            //Console.WriteLine(leetCodeAll.PassThePillow(n, time));

            //////(2586.) Count the Number of Vowel Strings in Range (EASY)
            //string[] words = ["hey", "aeo", "mu", "ooo", "artro"];
            //int left = 1;
            //int right = 4;

            //LeetCode_2586 classLeetCode = new LeetCode_2586();
            //Console.WriteLine(classLeetCode.VowelStrings(words, left, right));

            ////OR

            //Console.WriteLine(leetCodeAll.VowelStrings(words, left, right));

            ////(2595.) Number of Even and Odd Bits (EASY)
            //int n = 5;

            //LeetCode_2595 classLeetCode = new LeetCode_2595();
            //Console.WriteLine(string.Join(',', classLeetCode.EvenOddBit(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.EvenOddBit(n)));

            ////(2605.) Form Smallest Number From Two Digit Arrays (EASY)
            //int[] nums1 = [4, 1, 3];
            //int[] nums2 = [5, 7];

            //LeetCode_2605 classLeetCode = new LeetCode_2605();
            //Console.WriteLine(classLeetCode.MinNumber(nums1, nums2));

            ////OR

            //Console.WriteLine(leetCodeAll.MinNumber(nums1, nums2));

            ////(2610.) Convert an Array Into a 2D Array With Conditions (MEDIUM)
            //int[] nums = [1, 3, 4, 1, 2, 3, 1];

            //LeetCode_2610 classLeetCode = new LeetCode_2610();
            //IList<IList<int>> result = classLeetCode.FindMatrix(nums);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //IList<IList<int>> result1 = leetCodeAll.FindMatrix(nums);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(2616.) Minimize the Maximum Difference of Pairs (MEDIUM)
            //int[] nums = [10,1,2,7,1,3];
            //int p = 2;

            //LeetCode_2616 classLeetCode = new LeetCode_2616();
            //Console.WriteLine(classLeetCode.MinimizeMax(nums, p));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimizeMax(nums, p));

            ////(2639.) Find the Width of Columns of a Grid (EASY)
            //int[][] grid = [[-15, 1, 3], [15, 7, 12], [5, 6, -2]];

            //LeetCode_2639 classLeetCode = new LeetCode_2639();
            //Console.WriteLine(string.Join(',',classLeetCode.FindColumnWidth(grid)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindColumnWidth(grid)));

            ////(2640.) Find the Score of All Prefixes of an Array (MEDIUM)
            //int[] nums = [2,3,7,5,10];

            //LeetCode_2640 classLeetCode = new LeetCode_2640();
            //Console.WriteLine(string.Join(',',classLeetCode.FindPrefixScore(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindPrefixScore(nums)));

            ////(2643.) Row With Maximum Ones (EASY)
            //int[][] mat = [[0, 0], [1, 1], [0, 0]];

            //LeetCode_2643 classLeetCode = new LeetCode_2643();
            //Console.WriteLine(string.Join(',', classLeetCode.RowAndMaximumOnes(mat)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RowAndMaximumOnes(mat)));

            ////(2644.) Find the Maximum Divisibility Score (EASY)
            //int[] nums = [2, 9, 15, 50];
            //int[] divisors = [5,3,7,2];

            //LeetCode_2644 classLeetCode = new LeetCode_2644();
            //Console.WriteLine(classLeetCode.MaxDivScore(nums, divisors));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDivScore(nums, divisors));

            ////(2651.) Calculate Delayed Arrival Time (EASY)
            //int arrivalTime = 15;
            //int delayedTime = 5; 

            //LeetCode_2651 classLeetCode = new LeetCode_2651();
            //Console.WriteLine(classLeetCode.FindDelayedArrivalTime(arrivalTime, delayedTime));

            ////OR

            //Console.WriteLine(leetCodeAll.FindDelayedArrivalTime(arrivalTime, delayedTime));

            ////(2652.) Sum Multiples (EASY)
            //int n = 10;

            //LeetCode_2652 classLeetCode = new LeetCode_2652();
            //Console.WriteLine(classLeetCode.SumOfMultiples(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfMultiples(n));

            ////(2656.) Maximum Sum With Exactly K Elements (EASY)
            //int[] nums = [5, 5, 5];
            //int k = 2;

            //LeetCode_2656 classLeetCode = new LeetCode_2656();
            //Console.WriteLine(classLeetCode.MaximizeSum(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximizeSum(nums, k));

            ////(2657.) Find the Prefix Common Array of Two Arrays (MEDIUM)
            //int[] A = [2, 3, 1];
            //int[] B = [3, 1, 2];

            //LeetCode_2657 classLeetCode = new LeetCode_2657();
            //Console.WriteLine(string.Join(',', classLeetCode.FindThePrefixCommonArray(A, B)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindThePrefixCommonArray(A, B)));

            ////(2670.) Find the Distinct Difference Array (EASY)
            //int[] nums = [1, 2, 3, 4, 5];

            //LeetCode_2670 classLeetCode = new LeetCode_2670();
            //Console.WriteLine(string.Join(',', classLeetCode.DistinctDifferenceArray(nums)));

            ////OR

            //int[] nums1 = [1, 2, 3, 4, 5];
            //Console.WriteLine(string.Join(',', leetCodeAll.DistinctDifferenceArray(nums1)));

            ////(2678.) Number of Senior Citizens (EASY)
            //string[] details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];

            //LeetCode_2678 classLeetCode = new LeetCode_2678();
            //Console.WriteLine(classLeetCode.CountSeniors(details));

            ////OR

            //Console.WriteLine(leetCodeAll.CountSeniors(details));

            ////(2696.) Minimum String Length After Removing Substrings (EASY)
            //string s = "ABFCACDB";

            //LeetCode_2696 classLeetCode = new LeetCode_2696();
            //Console.WriteLine(classLeetCode.MinLength(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinLength(s));

            ////(2697.) Lexicographically Smallest Palindrome (EASY)
            //string s = "egcfe";

            //LeetCode_2697 classLeetCode = new LeetCode_2697();
            //Console.WriteLine(classLeetCode.MakeSmallestPalindrome(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MakeSmallestPalindrome(s));

            ////(2706.) Buy Two Chocolates (EASY)
            //int[] prices = { 1, 2, 2 };
            //int money = 3;

            //LeetCode_2706 classLeetCode = new LeetCode_2706();
            //Console.WriteLine(classLeetCode.BuyChoco(prices, money));

            ////OR

            //Console.WriteLine(leetCodeAll.BuyChoco(prices, money));

            ////(2710.) Remove Trailing Zeros From a String (EASY)
            //string num = "51230100";

            //LeetCode_2710 classLeetCode = new LeetCode_2710();
            //Console.WriteLine(classLeetCode.RemoveTrailingZeros(num));

            ////OR

            //Console.WriteLine(leetCodeAll.RemoveTrailingZeros(num));

            ////(2716.) Minimize String Length (EASY)
            //string s = "baadccab";

            //LeetCode_2716 classLeetCode = new LeetCode_2716();
            //Console.WriteLine(classLeetCode.MinimizedStringLength(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimizedStringLength(s));

            ////(2717.) Semi-Ordered Permutation (EASY)
            //int[] nums = [2, 4, 1, 3];

            //LeetCode_2717 classLeetCode = new LeetCode_2717();
            //Console.WriteLine(classLeetCode.SemiOrderedPermutation(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SemiOrderedPermutation(nums));

            ////(2729.) Check if The Number is Fascinating (EASY)
            //int n = 123;

            //LeetCode_2729 classLeetCode = new LeetCode_2729();
            //Console.WriteLine(classLeetCode.IsFascinating(n));

            ////OR

            //Console.WriteLine(leetCodeAll.IsFascinating(n));

            ////(2733.) Neither Minimum nor Maximum (EASY)
            //int[] nums = [3, 2, 1, 4];

            //LeetCode_2733 classLeetCode = new LeetCode_2733();
            //Console.WriteLine(classLeetCode.FindNonMinOrMax(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindNonMinOrMax(nums));

            ////(2739.) Total Distance Traveled (EASY)
            //int mainTank = 5;
            //int additionalTank = 10;

            //LeetCode_2739 classLeetCode = new LeetCode_2739();
            //Console.WriteLine(classLeetCode.DistanceTraveled(mainTank, additionalTank));

            ////OR

            //Console.WriteLine(leetCodeAll.DistanceTraveled(mainTank, additionalTank));

            ////(2740.) Find the Value of the Partition (MEDIUM)
            //int[] nums = [1, 3, 2, 4];

            //LeetCode_2740 classLeetCode = new LeetCode_2740();
            //Console.WriteLine(classLeetCode.FindValueOfPartition(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.FindValueOfPartition(nums));

            ////(2748.) Number of Beautiful Pairs (EASY)
            //int[] nums = [2,5,1,4]; 

            //LeetCode_2748 classLeetCode = new LeetCode_2748();
            //Console.WriteLine(classLeetCode.CountBeautifulPairs(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountBeautifulPairs(nums));

            ////(2769.) Find the Maximum Achievable Number (EASY)
            //int num = 3;
            //int t = 2;

            //LeetCode_2769 classLeetCode = new LeetCode_2769();
            //Console.WriteLine(classLeetCode.TheMaximumAchievableX(num, t));

            ////OR

            //Console.WriteLine(leetCodeAll.TheMaximumAchievableX(num, t));

            ////(2778.) Sum of Squares of Special Elements (EASY)
            //int[] nums = [1, 2, 3, 4];

            //LeetCode_2778 classLeetCode = new LeetCode_2778();
            //Console.WriteLine(classLeetCode.SumOfSquares(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfSquares(nums));

            ////(2785.) Sort Vowels in a String (MEDIUM)
            //string s = "lEetcOde";

            //LeetCode_2785 classLeetCode = new LeetCode_2785();
            //Console.WriteLine(classLeetCode.SortVowels(s));

            ////OR

            //Console.WriteLine(leetCodeAll.SortVowels(s));

            ////(2788.) Split Strings by Separator (EASY)
            //IList<string> words = ["one.two.three", "four.five", "six"];
            //char separator = '.';

            //LeetCode_2788 classLeetCode = new LeetCode_2788();
            //foreach (string word in classLeetCode.SplitWordsBySeparator(words, separator))
            //{
            //    Console.WriteLine(word);
            //}

            ////OR

            //foreach (string word in leetCodeAll.SplitWordsBySeparator(words, separator))
            //{
            //    Console.WriteLine(word);
            //}

            ////(2798.) Number of Employees Who Met the Target (EASY)
            //int[] hours = [0, 1, 2, 3, 4];
            //int target = 2;

            //LeetCode_2798 classLeetCode = new LeetCode_2798();
            //Console.WriteLine(classLeetCode.NumberOfEmployeesWhoMetTarget(hours, target));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfEmployeesWhoMetTarget(hours, target));

            ////(2806.) Account Balance After Rounded Purchase (EASY)
            //int purchaseAmount = 15;

            //LeetCode_2806 classLeetCode = new LeetCode_2806();
            //Console.WriteLine(classLeetCode.AccountBalanceAfterPurchase(purchaseAmount));

            ////OR

            //Console.WriteLine(leetCodeAll.AccountBalanceAfterPurchase(purchaseAmount));

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

            ////(2810.) Faulty Keyboard (EASY)
            //string s = "string";

            //LeetCode_2810 classLeetCode = new LeetCode_2810();
            //Console.WriteLine(classLeetCode.FinalString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.FinalString(s));

            ////(2815.) Max Pair Sum in an Array (EASY)
            //int[] nums = [2536, 1613, 3366, 162];

            //LeetCode_2815 classLeetCode = new LeetCode_2815();
            //Console.WriteLine(classLeetCode.MaxSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxSumTask2815(nums));

            ////(2824.) Count Pairs Whose Sum is Less than Target (EASY)
            //IList<int> nums = [-1, 1, 2, 3, 1];
            //int target = 2;

            //LeetCode_2824 classLeetCode = new LeetCode_2824();

            //Console.WriteLine(classLeetCode.CountPairs(nums, target));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPairs(nums, target));

            ////(2828.) Check if a String Is an Acronym of Words (EASY)
            //IList<string> words = ["alice", "bob", "charlie"];
            //string s = "abc";

            //LeetCode_2828 classLeetCode = new LeetCode_2828();
            //Console.WriteLine(classLeetCode.IsAcronym(words, s));

            ////OR

            //Console.WriteLine(leetCodeAll.IsAcronym(words, s));

            ////(2833.) Furthest Point From Origin (EASY)
            //string moves = "L_RL__R";

            //LeetCode_2833 classLeetCode = new LeetCode_2833();
            //Console.WriteLine(classLeetCode.FurthestDistanceFromOrigin(moves));

            ////OR

            //Console.WriteLine(leetCodeAll.FurthestDistanceFromOrigin(moves));

            ////(2839.) Check if Strings Can be Made Equal With Operations I (EASY)
            //string s1 = "ifjz";
            //string s2 = "jzfi";

            //LeetCode_2839 classLeetCode = new LeetCode_2839();
            //Console.WriteLine(classLeetCode.CanBeEqual(s1, s2));

            ////OR

            //Console.WriteLine(leetCodeAll.CanBeEqual(s1, s2));

            ////(2843.) Count Symmetric Integers (EASY)
            //int low = 1200;
            //int high = 1230;

            //LeetCode_2843 classLeetCode = new LeetCode_2843();
            //Console.WriteLine(classLeetCode.CountSymmetricIntegers(low, high));

            ////OR

            //Console.WriteLine(leetCodeAll.CountSymmetricIntegers(low, high));

            ////(2848.) Points That Intersect With Cars (EASY)
            //IList<IList<int>> nums = [[2, 5], [8, 8], [1, 6], [4, 4], [4, 5], [2, 4]];

            //LeetCode_2848 classLeetCode = new LeetCode_2848();
            //Console.WriteLine(classLeetCode.NumberOfPoints(nums));

            ////OR

            //Console.WriteLine(classLeetCode.NumberOfPoints(nums));

            ////(2859.) Sum of Values at Indices With K Set Bits (EASY)
            //IList<int> nums = [5, 10, 1, 5, 2];
            //int k = 1;

            //LeetCode_2859 classLeetCode = new LeetCode_2859();
            //Console.WriteLine(classLeetCode.SumIndicesWithKSetBits(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.SumIndicesWithKSetBits(nums, k));

            ////(2864.) Maximum Odd Binary Number (EASY)
            //string s = "010";

            //LeetCode_2864 classLeetCode = new LeetCode_2864();
            //Console.WriteLine(classLeetCode.MaximumOddBinaryNumber(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumOddBinaryNumber(s));

            ////(2869.) Minimum Operations to Collect Elements (EASY)
            //IList<int> nums = [3,1,5,4,2];
            //int k = 5;

            //LeetCode_2869 classLeetCode = new LeetCode_2869();
            //Console.WriteLine(classLeetCode.MinOperations(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperations(nums, k));

            ////(2873.) Maximum Value of an Ordered Triplet I (EASY)
            //int[] nums = [1000000, 1, 1000000];

            //LeetCode_2873 classLeetCode = new LeetCode_2873();
            //Console.WriteLine(classLeetCode.MaximumTripletValue(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumTripletValue(nums));

            ////(2894.) Divisible and Non-divisible Sums Difference (EASY)
            //int n = 10;
            //int m = 3;

            //LeetCode_2894 classLeetCode = new LeetCode_2894();
            //Console.WriteLine(classLeetCode.DifferenceOfSums(n, m));

            ////OR

            //Console.WriteLine(leetCodeAll.DifferenceOfSums(n, m));

            ////(2903.) Find Indices With Index and Value Difference I (EASY)
            //int[] nums = [5, 1, 4, 1];
            //int indexDifference = 2;
            //int valueDifference = 4;

            //LeetCode_2903 classLeetCode = new LeetCode_2903();
            //Console.WriteLine(string.Join(',',classLeetCode.FindIndices(nums, indexDifference, valueDifference)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindIndices(nums, indexDifference, valueDifference)));

            ////(2908.) Minimum Sum of Mountain Triplets I (EASY)
            //int[] nums = [5,4,8,7,10,2];

            //LeetCode_2908 classLeetCode = new LeetCode_2908();
            //Console.WriteLine(classLeetCode.MinimumSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumSum(nums));

            ////(2913.) Subarrays Distinct Element Sum of Squares I (EASY)
            //IList<int> nums = [1, 2, 1];

            //LeetCode_2913 classLeetCode = new LeetCode_2913();
            //Console.WriteLine(classLeetCode.SumCounts(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SumCounts(nums));

            ////(2918.) Minimum Equal Sum of Two Arrays After Replacing Zeros (MEDIUM)
            //int[] nums1 = [1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000, 1000000];
            //int[] nums2 = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1];

            //LeetCode_2918 classLeetCode = new LeetCode_2918();
            //Console.WriteLine(classLeetCode.MinSum(nums1, nums2));

            //OR

            //Console.WriteLine(leetCodeAll.MinSum(nums1, nums2));

            ////(2923.) Find Champion I (EASY)
            //int[][] grid = [[0,0,1], [1,1,1], [0,0,0]];

            //LeetCode_2923 classLeetCode = new LeetCode_2923();
            //Console.WriteLine(classLeetCode.FindChampion(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.FindChampion(grid));

            ////(2932.) Maximum Strong Pair XOR I (EASY)
            //int[] nums = [1, 2, 3, 4, 5];

            //LeetCode_2932 classLeetCode = new LeetCode_2932();
            //Console.WriteLine(classLeetCode.MaximumStrongPairXor(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumStrongPairXor(nums));

            ////(2942.) Find Words Containing Character (EASY)
            //string[] words = ["leet", "code"];
            //char x = 'e';

            //LeetCode_2942 classLeetCode = new LeetCode_2942();
            //Console.WriteLine(string.Join(',', classLeetCode.FindWordsContaining(words, x)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindWordsContaining(words, x)));

            ////(2951.) Find the Peaks (EASY)
            //int[] mountain = [1, 4, 3, 8, 5];

            //LeetCode_2951 classLeetCode = new LeetCode_2951();
            //foreach (var item in classLeetCode.FindPeaks(mountain))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.FindPeaks(mountain))
            //{
            //    Console.WriteLine(item);
            //}

            ////(2956.) Find Common Elements Between Two Arrays (EASY)
            //int[] nums1 = [4, 3, 2, 3, 1]; 
            //int[] nums2 = [2, 2, 5, 2, 3, 6];

            //LeetCode_2956 classLeetCode = new LeetCode_2956();
            //Console.WriteLine(string.Join(',', classLeetCode.FindIntersectionValues(nums1, nums2)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindIntersectionValues(nums1, nums2)));

            ////(2960.) Count Tested Devices After Test Operations (EASY)
            //int[] batteryPercentages = [1, 1, 2, 1, 3];

            //LeetCode_2960 classLeetCode = new LeetCode_2960();
            //Console.WriteLine(classLeetCode.CountTestedDevices(batteryPercentages));

            ////OR

            //Console.WriteLine(leetCodeAll.CountTestedDevices(batteryPercentages));

            ////(2965.) Find Missing and Repeated Values (EASY)
            //int[][] grid = [[9, 1, 7], [8, 9, 2], [3, 4, 6]];

            //LeetCode_2965 classLeetCode = new LeetCode_2965();
            //Console.WriteLine(string.Join(',', classLeetCode.FindMissingAndRepeatedValues(grid)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindMissingAndRepeatedValues(grid)));

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

            ////(2974.) Minimum Number Game (EASY)
            //int[] nums = [5, 4, 2, 3];

            //LeetCode_2974 classLeetCode = new LeetCode_2974();
            //Console.WriteLine(string.Join(',', classLeetCode.NumberGame(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.NumberGame(nums)));

            ////(2980.) Check if Bitwise OR Has Trailing Zeros (EASY)
            //int[] nums = [1, 2, 3, 4, 5];

            //LeetCode_2980 classLeetCode = new LeetCode_2980();
            //Console.WriteLine(classLeetCode.HasTrailingZeros(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.HasTrailingZeros(nums));

            ////(2997.) Minimum Number of Operations to Make Array XOR Equal to K (MEDIUM)
            //int[] nums = [2, 1, 3, 4];
            //int k = 1;

            //LeetCode_2997 classLeetCode = new LeetCode_2997();
            //Console.WriteLine(classLeetCode.MinOperations(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperationsTask2997(nums, k));

            ////(3000.) Maximum Area of Longest Diagonal Rectangle (EASY);
            //int[][] dimensions = [[6, 5], [8, 6], [2, 10], [8, 1], [9, 2], [3, 5], [3, 5]];

            //LeetCode_3000 classLeetCode = new LeetCode_3000();
            //Console.WriteLine(classLeetCode.AreaOfMaxDiagonal(dimensions));

            ////OR

            //Console.WriteLine(leetCodeAll.AreaOfMaxDiagonal(dimensions));

            ////(3005.) Count Elements With Maximum Frequency (EASY)
            //int[] nums = [1, 2, 2, 3, 1, 4];

            //LeetCode_3005 classLeetCode = new LeetCode_3005();
            //Console.WriteLine(classLeetCode.MaxFrequencyElements(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxFrequencyElements(nums));

            ////(3010.) Divide an Array Into Subarrays With Minimum Cost I (EASY)
            //int[] nums = [1, 2, 3, 12];

            //LeetCode_3010 classLeetCode = new LeetCode_3010();
            //Console.WriteLine(classLeetCode.MinimumCost(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumCostTask3010(nums));

            ////(3019.) Number of Changing Keys (EASY)
            //string s = "aAbBcC";

            //LeetCode_3019 classLeetCode = new LeetCode_3019();
            //Console.WriteLine(classLeetCode.CountKeyChanges(s));

            ////OR

            //Console.WriteLine(leetCodeAll.CountKeyChanges(s));

            ////(3021.) Alice and Bob Playing Flower Game (MEDIUM)
            //int n = 3;
            //int m = 2;

            //LeetCode_3021 classLeetCode = new LeetCode_3021();
            //Console.WriteLine(classLeetCode.FlowerGame(n, m));

            ////OR

            //Console.WriteLine(leetCodeAll.FlowerGame(n, m));

            ////(3024.) Type of Triangle (EASY)
            //int[] nums = [8, 4, 2];

            //LeetCode_3024 classLeetCode = new LeetCode_3024();
            //Console.WriteLine(classLeetCode.TriangleType(nums));

            ////OR
            //Console.WriteLine(leetCodeAll.TriangleType(nums));

            ////(3028.) Ant on the Boundary (EASY)
            //int[] nums = [2, 3, -5];

            //LeetCode_3028 classLeetCode = new LeetCode_3028();
            //Console.WriteLine(classLeetCode.ReturnToBoundaryCount(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.ReturnToBoundaryCount(nums));

            ////(3033.) Modify the Matrix (EASY)
            //int[][] matrix = [[1, 2, -1], [4, -1, 6], [7, 8, 9]];

            //LeetCode_3033 classLeetCode = new LeetCode_3033();
            //foreach (var item in classLeetCode.ModifiedMatrix(matrix))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.ModifiedMatrix(matrix))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(3038.) Maximum Number of Operations With the Same Score I (EASY)
            //int[] nums = [1, 5, 3, 3, 4, 1, 3, 2, 2, 3];

            //LeetCode_3038 classLeetCode = new LeetCode_3038();
            //Console.WriteLine(classLeetCode.MaxOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxOperations(nums));

            ////(3042.) Count Prefix and Suffix Pairs I (EASY)
            //string[] words = ["a", "aba", "ababa", "aa"];

            //LeetCode_3042 classLeetCode = new LeetCode_3042();
            //Console.WriteLine(classLeetCode.CountPrefixSuffixPairs(words));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPrefixSuffixPairs(words));

            ////(3046.) Split the Array (EASY)
            //int[] nums = [2, 10, 2, 7, 8, 9, 7, 6, 6, 9];

            //LeetCode_3046 classLeetCode = new LeetCode_3046();
            //Console.WriteLine(classLeetCode.IsPossibleToSplit(nums));

            //OR

            //Console.WriteLine(leetCodeAll.IsPossibleToSplit(nums));

            ////(3065.) Minimum Operations to Exceed Threshold Value I (EASY)
            //int[] nums = [2, 11, 10, 1, 3];
            //int k = 10;

            //LeetCode_3065 classLeetCode = new LeetCode_3065();
            //Console.WriteLine(classLeetCode.MinOperations(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperationsTask3065(nums, k));

            ////(3069.) Distribute Elements Into Two Arrays I (EASY)
            //int[] nums = [5,4,3,8];

            //LeetCode_3069 classLeetCode = new LeetCode_3069();
            //Console.WriteLine(string.Join(',',classLeetCode.ResultArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ResultArray(nums)));

            ////(3074.) Apple Redistribution into Boxes (EASY)
            //int[] apple = [1, 3, 2];
            //int[] capacity = [4,3,1,5,2];

            //LeetCode_3074 classLeetCode = new LeetCode_3074();
            //Console.WriteLine(classLeetCode.MinimumBoxes(apple, capacity));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumBoxes(apple, capacity));

            ////(3079.) Find the Sum of Encrypted Integers (EASY)
            //int[] nums = [10, 21, 31];

            //LeetCode_3079 classLeetCode = new LeetCode_3079();
            //Console.WriteLine(classLeetCode.SumOfEncryptedInt(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfEncryptedInt(nums));

            ////(3083.) Existence of a Substring in a String and Its Reverse (EASY)
            //string s = "abcba";

            //LeetCode_3083 classLeetCode = new LeetCode_3083();
            //Console.WriteLine(classLeetCode.IsSubstringPresent(s));

            ////OR

            //Console.WriteLine(leetCodeAll.IsSubstringPresent(s));

            ////(3085). Minimum Deletions to Make String K-Special (MEDIUM)
            //string word = "gzpgogrg";
            //int k = 1;

            //LeetCode_3085 classLeetCode = new LeetCode_3085();
            //Console.WriteLine(classLeetCode.MinimumDeletions(word, k));

            ////OR

            //Console.WriteLine(classLeetCode.MinimumDeletions(word, k));

            ////(3099.) Harshad Number (EASY)
            //int x = 18;

            //LeetCode_3099 classLeetCode = new LeetCode_3099();
            //Console.WriteLine(classLeetCode.SumOfTheDigitsOfHarshadNumber(x));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfTheDigitsOfHarshadNumber(x));

            ////(3100.) Water Bottles II (MEDIUM)
            //int numBottles = 13;
            //int numExchange = 6;

            //LeetCode_3100 classLeetCode = new LeetCode_3100();
            //Console.WriteLine(classLeetCode.MaxBottlesDrunk(numBottles, numExchange));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxBottlesDrunk(numBottles, numExchange));

            ////(3105.) Longest Strictly Increasing or Strictly Decreasing Subarray (EASY)
            //int[] nums = [1, 4, 3, 3, 2];

            //LeetCode_3105 classLeetCode = new LeetCode_3105();
            //Console.WriteLine(classLeetCode.LongestMonotonicSubarray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestMonotonicSubarray(nums));

            ////(3110.) Score of a String (EASY)
            //string s = "hello";

            //LeetCode_3110 classLeetCode = new LeetCode_3110();
            //Console.WriteLine(classLeetCode.ScoreOfString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ScoreOfString(s));

            ////(3114.) Latest Time You Can Obtain After Replacing Characters (EASY)
            //string s = "0?:59";

            //LeetCode_3114 classLeetCode = new LeetCode_3114();
            //Console.WriteLine(classLeetCode.FindLatestTime(s));

            ////OR

            //Console.WriteLine(leetCodeAll.FindLatestTime(s));

            ////(3115.) Maximum Prime Difference (MEDIUM)
            //int[] nums = [4, 2, 9, 5, 3];

            //LeetCode_3115 classLeetCode = new LeetCode_3115();
            //Console.WriteLine(classLeetCode.MaximumPrimeDifference(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumPrimeDifference(nums));

            ////(3120.) Count the Number of Special Characters I (EASY)
            //string word = "aaAbcBC";

            //LeetCode_3120 classLeetCode = new LeetCode_3120();
            //Console.WriteLine(classLeetCode.NumberOfSpecialChars(word));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfSpecialChars(word));

            ////(3131.) Find the Integer Added to Array I (EASY)
            //int[] nums1 = [2, 6, 4];
            //int[] nums2 = [9, 7, 5];

            //LeetCode_3131 classLeetCode = new LeetCode_3131();
            //Console.WriteLine(classLeetCode.AddedInteger(nums1, nums2));

            ////OR

            //Console.WriteLine(leetCodeAll.AddedInteger(nums1, nums2));

            ////(3136.) Valid Word (EASY)
            //string word = "PO@w8FWZ";

            //LeetCode_3136 classLeetCode = new LeetCode_3136();
            //Console.WriteLine(classLeetCode.IsValid(word));

            ////OR

            //Console.WriteLine(leetCodeAll.IsValid_Task3136(word));

            ////(3146.) Permutation Difference between Two Strings (EASY)
            //string s = "abcde";
            //string t = "edbac";

            //LeetCode_3146 classLeetCode = new LeetCode_3146();
            //Console.WriteLine(classLeetCode.FindPermutationDifference(s, t));

            ////OR

            //Console.WriteLine(leetCodeAll.FindPermutationDifference(s, t));

            ////(3142.) Check if Grid Satisfies Conditions (EASY)
            //int[][] grid = [[1, 0, 2], [1, 0, 2]];

            //LeetCode_3142 classLeetCode = new LeetCode_3142();
            //Console.WriteLine(classLeetCode.SatisfiesConditions(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.SatisfiesConditions(grid));

            ////(3147.) Taking Maximum Energy From the Mystic Dungeon (MEDIUM)
            //int[] energy = [5,2,-10,-5,1];
            //int k = 3;

            //LeetCode_3147 classLeetCode = new LeetCode_3147();
            //Console.WriteLine(classLeetCode.MaximumEnergy(energy, k));
            ////OR

            //Console.WriteLine(leetCodeAll.MaximumEnergy(energy, k));

            ////(3151.) Special Array I (EASY)
            //int[] nums = [4, 3, 1, 6];

            //LeetCode_3151 classLeetCode = new LeetCode_3151();
            //Console.WriteLine(classLeetCode.IsArraySpecial(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.IsArraySpecial(nums));

            ////(3158.) Find the XOR of Numbers Which Appear Twice (EASY)
            //int[] nums = [1, 2, 2, 1];

            //LeetCode_3158 classLeetCode = new LeetCode_3158();
            //Console.WriteLine(classLeetCode.DuplicateNumbersXOR(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.DuplicateNumbersXOR(nums));

            ////(3159.) Find Occurrences of an Element in an Array (MEDIUM)
            //int[] nums = [1, 3, 1, 7];
            //int[] queries = [1, 3, 2, 4];
            //int x = 1;

            //LeetCode_3159 classLeetCode = new LeetCode_3159();
            //Console.WriteLine(string.Join(',', classLeetCode.OccurrencesOfElement(nums, queries, x)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.OccurrencesOfElement(nums, queries, x)));

            ////(3162.) Find the Number of Good Pairs I (EASY)
            //int[] nums1 = [1, 3, 4];
            //int[] nums2 = [1, 3, 4];
            //int k = 1;

            //LeetCode_3162 classLeetCode = new LeetCode_3162();
            //Console.WriteLine(classLeetCode.NumberOfPairs(nums1, nums2, k));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfPairs(nums1, nums2, k));

            ////(3163.) String Compression III (MEDIUM)
            //string word = "aaaaaaaaaaaaaabb";

            //LeetCode_3163 classLeetCode = new LeetCode_3163();
            //Console.WriteLine(classLeetCode.CompressedString(word));

            ////OR

            //Console.WriteLine(leetCodeAll.CompressedString(word));

            ////(3168.) Minimum Number of Chairs in a Waiting Room (EASY)
            //string s = "ELELEEL";

            //LeetCode_3168 classLeetCode = new LeetCode_3168();
            //Console.WriteLine(classLeetCode.MinimumChairs(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumChairs(s));

            ////(3174.) Clear Digits (EASY)
            //string s = "cb34";

            //LeetCode_3174 classLeetCode = new LeetCode_3174();
            //Console.WriteLine(classLeetCode.ClearDigits(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ClearDigits(s));

            ////(3178.) Find the Child Who Has the Ball After K Seconds (EASY)
            //int n = 3;
            //int k = 3;

            //LeetCode_3178 classLeetCode = new LeetCode_3178();
            //Console.WriteLine(classLeetCode.NumberOfChild(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfChild(n, k));

            ////(3184.) Count Pairs That Form a Complete Day I (EASY)
            //int[] hours = [72, 48, 24, 3];

            //LeetCode_3184 classLeetCode = new LeetCode_3184();
            //Console.WriteLine(classLeetCode.CountCompleteDayPairs(hours));

            ////OR

            //Console.WriteLine(leetCodeAll.CountCompleteDayPairs(hours));

            ////(3190.) Find Minimum Operations to Make All Elements Divisible by Three (EASY)
            //int[] nums = [1, 2, 3, 4];

            //LeetCode_3190 classLeetCode = new LeetCode_3190();
            //Console.WriteLine(classLeetCode.MinimumOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumOperations(nums));

            ////(3191.) Minimum Operations to Make Binary Array Elements Equal to One I (MEDIUM)
            //int[] nums = [0, 1, 1, 1, 0, 0];

            //LeetCode_3191 classLeetCode = new LeetCode_3191();
            //Console.WriteLine(classLeetCode.MinOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperationsTask3191(nums));

            ////(3194.) Minimum Average of Smallest and Largest Elements (EASY)
            //int[] nums = [7, 8, 3, 4, 15, 13, 4, 1];

            //LeetCode_3194 classLeetCode = new LeetCode_3194();
            //Console.WriteLine(classLeetCode.MinimumAverage(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumAverage(nums));

            ////(3195.) Find the Minimum Area to Cover All Ones I (MEDIUM)
            //int[][] grid = [[0, 1, 0], [1, 0, 1]];

            //LeetCode_3195 classLeetCode = new LeetCode_3195();
            //Console.WriteLine(classLeetCode.MinimumArea(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumArea(grid));

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

            ////(3206.) Alternating Groups I (EASY)
            //int[] colors = [0, 1, 0, 0, 1];

            //LeetCode_3206 classLeetCode = new LeetCode_3206();
            //Console.WriteLine(classLeetCode.NumberOfAlternatingGroups(colors));

            ////OR

            //Console.WriteLine(leetCodeAll.NumberOfAlternatingGroups(colors));

            ////(3210.) Find the Encrypted String (EASY)
            //string s = "dart";
            //int k = 3;

            //LeetCode_3210 classLeetCode = new LeetCode_3210();
            //Console.WriteLine(classLeetCode.GetEncryptedString(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.GetEncryptedString(s, k));

            ////(3211.) Generate Binary Strings Without Adjacent Zeros (MEDIUM)
            //int n = 3;

            //LeetCode_3211 classLeetCode = new LeetCode_3211();
            //Console.WriteLine(string.Join(',', classLeetCode.ValidStrings(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ValidStrings(n)));

            ////(3216.) Lexicographically Smallest String After a Swap (EASY)
            //string s = "13";

            //LeetCode_3216 classLeetCode = new LeetCode_3216();
            //Console.WriteLine(classLeetCode.GetSmallestString(s));

            ////OR

            //Console.WriteLine(leetCodeAll.GetSmallestString(s));

            ////(3217.) Delete Nodes From Linked List Present in Array (MEDIUM)
            //int[] nums = [1,2,3];
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next = new ListNode(1);
            //head.next.next.next.next.next.next = new ListNode(13);

            //LeetCode_3217 classLeetCode = new LeetCode_3217();
            //ListNode result = classLeetCode.ModifiedList(nums, head);

            //while(result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //}

            ////OR

            //ListNode result1 = leetCodeAll.ModifiedList(nums, head);

            //while (result1 != null)
            //{
            //    Console.WriteLine(result1.val);
            //    result1 = result1.next;
            //}

            ////(3222.) Find the Winning Player in Coin Game (EASY)
            //int x = 4;
            //int y = 11;

            //LeetCode_3222 classLeetCode = new LeetCode_3222();
            //Console.WriteLine(classLeetCode.WinningPlayer(x, y));

            ////OR

            //Console.WriteLine(leetCodeAll.WinningPlayer(x, y));

            ////(3226.) Number of Bit Changes to Make Two Integers Equal (EASY)
            //int n = 54;
            //int k = 4;

            //LeetCode_3226 classLeetCode = new LeetCode_3226();
            //Console.WriteLine(classLeetCode.MinChanges(n, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinChanges(n, k));

            ////(3227.) Vowels Game in a String (MEDIUM)
            //string s = "bbcd";

            //LeetCode_3227 classLeetCode = new LeetCode_3227();
            //Console.WriteLine(classLeetCode.DoesAliceWin(s));

            ////OR

            //Console.WriteLine(leetCodeAll.DoesAliceWin(s));

            ////(3228.) Maximum Number of Operations to Move Ones to the End (MEDIUM)
            //string s = "00111";

            //LeetCode_3228 classLeetCode = new LeetCode_3228();
            //Console.WriteLine(classLeetCode.MaxOperations(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxOperations(s));

            ////(3232.) Find if Digit Game Can Be Won (EASY)
            //int[] nums = [1, 2, 3, 4, 5, 14];

            //LeetCode_3232 classLeetCode = new LeetCode_3232();
            //Console.WriteLine(classLeetCode.CanAliceWin(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CanAliceWin(nums));

            ////(3238.) Find the Number of Winning Players (EASY)
            //int n = 5;
            //int[][] pick = [[1, 1], [1, 2], [1, 3], [1, 4]];

            //LeetCode_3238 classLeetCode = new LeetCode_3238();
            //Console.WriteLine(classLeetCode.WinningPlayerCount(n, pick));

            ////OR

            //Console.WriteLine(leetCodeAll.WinningPlayerCount(n, pick));

            ////(3248.) Snake in Matrix (EASY)
            //int n = 3;
            //IList<string> commands = ["DOWN", "RIGHT", "UP"];

            //LeetCode_3248 classLeetCode = new LeetCode_3248();
            //Console.WriteLine(classLeetCode.FinalPositionOfSnake(n, commands));

            ////OR

            //Console.WriteLine(leetCodeAll.FinalPositionOfSnake(n, commands));

            ////(3254.) Find the Power of K-Size Subarrays I (MEDIUM)
            //int[] nums = [5, 6, 27];
            //int k = 2;

            //LeetCode_3254 clasLeetCode = new LeetCode_3254();
            //Console.WriteLine(string.Join(',', clasLeetCode.ResultsArray(nums, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ResultsArray(nums, k)));

            ////(3258.) Count Substrings That Satisfy K-Constraint I (EASY)
            //string s = "10101";
            //int k = 1;

            //LeetCode_3258 classLeetCode = new LeetCode_3258();
            //Console.WriteLine(classLeetCode.CountKConstraintSubstrings(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.CountKConstraintSubstrings(s, k));

            ////(3264.) Final Array State After K Multiplication Operations I (EASY)
            //int[] nums = [2, 1, 3, 5, 6];
            //int k = 5;
            //int multiplier = 2;

            //LeetCode_3264 classLeetCode = new LeetCode_3264();
            //Console.WriteLine(string.Join(',', classLeetCode.GetFinalState(nums, k, multiplier)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.GetFinalState(nums, k, multiplier)));

            ////(3270.) Find the Key of the Numbers (EASY)
            //int nums1 = 1140;
            //int nums2 = 1851;
            //int nums3 = 2057;

            //LeetCode_3270 classLeetCode = new LeetCode_3270();
            //Console.WriteLine(classLeetCode.GenerateKey(nums1, nums2, nums3));

            ////OR

            //Console.WriteLine(leetCodeAll.GenerateKey(nums1, nums2, nums3));

            ////(3271.) Hash Divided String (MEDIUM)
            //string s = "mxz";
            //int k = 3;

            //LeetCode_3271 classLeetCode = new LeetCode_3271();
            //Console.WriteLine(classLeetCode.StringHash(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.StringHash(s, k));

            ////(3274.) Check if Two Chessboard Squares Have the Same Color (EASY)
            //string coordinate1 = "d1";
            //string coordinate2 = "h4";

            //LeetCode_3274 classLeetCode = new LeetCode_3274();
            //Console.WriteLine(classLeetCode.CheckTwoChessboards(coordinate1, coordinate2));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckTwoChessboards(coordinate1, coordinate2));

            ////(3280.) Convert Date to Binary (EASY)
            //string date = "2080-02-29";

            //LeetCode_3280 classLeetCode = new LeetCode_3280();
            //Console.WriteLine(classLeetCode.ConvertDateToBinary(date));

            ////OR

            //Console.WriteLine(leetCodeAll.ConvertDateToBinary(date));

            ////(3285.) Find Indices of Stable Mountains (EASY)
            //int[] height = [1, 2, 3, 4, 5];
            //int threshold = 2; 

            //LeetCode_3285 classLeetCode = new LeetCode_3285();
            //Console.WriteLine(string.Join(',',classLeetCode.StableMountains(height, threshold)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.StableMountains(height, threshold)));

            ////(3289.) The Two Sneaky Numbers of Digitville (EASY)
            //int[] nums = [7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2];

            //LeetCode_3289 classLeetCode = new LeetCode_3289();
            //Console.WriteLine(string.Join(',',classLeetCode.GetSneakyNumbers(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.GetSneakyNumbers(nums)));

            ////(3295.) Report Spam Message (MEDIUM)
            //string[] message = ["hello", "world", "leetcode"];
            //string[] bannedWords = ["world", "hello"];

            //LeetCode_3295 classLeetCode = new LeetCode_3295();
            //Console.WriteLine(classLeetCode.ReportSpam(message, bannedWords));

            ////OR

            //Console.WriteLine(leetCodeAll.ReportSpam(message, bannedWords));

            ////(3300.) Minimum Element After Replacement With Digit Sum (EASY)
            //int[] nums = [10, 12, 13, 14];

            //LeetCode_3300 classLeetCode = new LeetCode_3300();
            //Console.WriteLine(classLeetCode.MinElement(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinElement(nums));

            ////(3304.) Find the K-th Character in String Game I (EASY)
            //int k = 5;

            //LeetCode_3304 classLeetCode = new LeetCode_3304();
            //Console.WriteLine(classLeetCode.KthCharacter(k));

            ////OR

            //Console.WriteLine(leetCodeAll.KthCharacter(k));

            ////(3314.) Construct the Minimum Bitwise Array I (EASY)
            //IList<int> nums = [2, 3, 5, 7];

            //LeetCode_3314 classLeetCode = new LeetCode_3314();
            //Console.WriteLine(string.Join(',',classLeetCode.MinBitwiseArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MinBitwiseArray(nums)));

            ////(3318.) Find X-Sum of All K-Long Subarrays I (EASY)
            //int[] nums = [1, 1, 2, 2, 3, 4, 2, 3];
            //int k = 6;
            //int x = 2;

            //LeetCode_3318 classLeetcode = new LeetCode_3318();
            //Console.WriteLine(string.Join(',',classLeetcode.FindXSum(nums, k, x)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindXSum(nums, k, x)));

            ////(3324.) Find the Sequence of Strings Appeared on the Screen (MEDIUM)
            //string target = "abc";

            //LeetCode_3324 classLeetCode = new LeetCode_3324();
            //Console.WriteLine(string.Join(',', classLeetCode.StringSequence(target)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.StringSequence(target)));

            ////(3330.) Find the Original Typed String I (EASY)
            //string word = "abbcccc";

            //LeetCode_3330 classLeetCode = new LeetCode_3330();
            //Console.WriteLine(classLeetCode.PossibleStringCount(word));

            ////OR

            //Console.WriteLine(leetCodeAll.PossibleStringCount(word));

            ////(3340.) Check Balanced String (EASY)
            //string num = "24123";

            //LeetCode_3340 classLeetCode = new LeetCode_3340();
            //Console.WriteLine(classLeetCode.IsBalanced(num));

            ////OR

            //Console.WriteLine(leetCodeAll.IsBalanced(num));

            ////(3345.) Smallest Divisible Digit Product I (EASY)
            //int n = 15;
            //int t = 3;

            //LeetCode_3345 classLeetCode = new LeetCode_3345();
            //Console.WriteLine(classLeetCode.SmallestNumber(n, t));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestNumber(n, t));

            ////(3349.) Adjacent Increasing Subarrays Detection I (EASY)
            //IList<int> nums = [-12, 20, 18, 18];
            //int k = 2;

            //LeetCode_3349 classLeetCode = new LeetCode_3349();
            //Console.WriteLine(classLeetCode.HasIncreasingSubarrays(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.HasIncreasingSubarrays(nums, k));

            ////(3350.) Adjacent Increasing Subarrays Detection II
            //IList<int> nums = [0, 8, -19, 4, -19, -6, 17];

            //LeetCode_3350 classLeetCode = new LeetCode_3350();
            //Console.WriteLine(classLeetCode.MaxIncreasingSubarrays(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxIncreasingSubarrays(nums));

            ////(3354.) Make Array Elements Equal to Zero (EASY)
            //int[] nums = [0, 1];

            //LeetCode_3354 classLeetcode = new LeetCode_3354();
            //Console.WriteLine(classLeetcode.CountValidSelections(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountValidSelections(nums));

            ////(3360.) Stone Removal Game (EASY)
            //int n = 12;

            //LeetCode_3360 classLeetCode = new LeetCode_3360();
            //Console.WriteLine(classLeetCode.CanAliceWin(n));

            ////OR

            //Console.WriteLine(leetCodeAll.CanAliceWin(n));

            ////(3364.) Minimum Positive Sum Subarray (EASY)
            //IList<int> nums = [7, 3];
            //int l = 2;
            //int r = 2;

            //LeetCode_3364 classLeetCode = new LeetCode_3364();
            //Console.WriteLine(classLeetCode.MinimumSumSubarray(nums, l, r));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumSumSubarray(nums, l, r));

            ////(3370.) Smallest Number With All Set Bits (EASY)
            //int n = 10;

            //LeetCode_3370 classLeetCode = new LeetCode_3370();
            //Console.WriteLine(classLeetCode.SmallestNumber(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestNumber(n));

            ////(3379.) Transformed Array (EASY)
            //int[] nums = [-10, -10];

            //LeetCode_3379 classLeetCode = new LeetCode_3379();
            //Console.WriteLine(string.Join(',', classLeetCode.ConstructTransformedArray(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ConstructTransformedArray(nums)));

            ////(3386.) Button with Longest Push Time (EASY)
            //int[][] events = [[5, 4], [20, 14]];

            //LeetCode_3386 classLeetCode = new LeetCode_3386();
            //Console.WriteLine(classLeetCode.ButtonWithLongestTime(events));

            ////OR

            //Console.WriteLine(leetCodeAll.ButtonWithLongestTime(events));

            ////(3392.) Count Subarrays of Length Three With a Condition (EASY)
            //int[] nums = [1, 2, 1, 4, 1];

            //LeetCode_3392 classLeetCode = new LeetCode_3392();
            //Console.WriteLine(classLeetCode.CountSubarrays(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountSubarrays(nums));

            ////(3396.) Minimum Number of Operations to Make Elements in Array Distinct (EASY)
            //int[] nums = [4, 5, 6, 4, 4];

            //LeetCode_3396 classLeetCode = new LeetCode_3396();
            //Console.WriteLine(classLeetCode.MinimumOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumOperationsTask3396(nums));

            ////(3397.) Maximum Number of Distinct Elements After Operations (MEDIUM)
            //int[] nums = [1, 2, 2, 3, 3, 4];
            //int k = 2;

            //LeetCode_3397 classLeetCode = new LeetCode_3397();
            //Console.WriteLine(classLeetCode.MaxDistinctElements(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxDistinctElements(nums, k));

            ////(3402.) Minimum Operations to Make Columns Strictly Increasing (EASY)
            //int[][] grid = [[0], [50]];

            //LeetCode_3402 classLeetCode = new LeetCode_3402();
            //Console.WriteLine(classLeetCode.MinimumOperations(grid));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumOperations(grid));

            ////(3417.) Zigzag Grid Traversal With Skip (EASY)
            //int[][] grid = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            //LeetCode_3417 classLeetCode = new LeetCode_3417();
            //Console.WriteLine(string.Join(',', classLeetCode.ZigzagTraversal(grid)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.ZigzagTraversal(grid)));

            ////(3423.) Maximum Difference Between Adjacent Elements in a Circular Array (EASY)
            //int[] nums = [-5, -10, -5];

            //LeetCode_3423 classLeetCode = new LeetCode_3423();
            //Console.WriteLine(classLeetCode.MaxAdjacentDistance(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxAdjacentDistance(nums));

            ////(3427.) Sum of Variable Length Subarrays (EASY)
            //int[] nums = [2,3,1];

            //LeetCode_3427 classLeetCode = new LeetCode_3427();
            //Console.WriteLine(classLeetCode.SubarraySum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SubarraySum(nums));

            ////(3432.) Count Partitions with Even Sum Difference (EASY)
            //int[] nums = [10, 10, 3, 7, 6];

            //LeetCode_3432 classLeetCode = new LeetCode_3432();
            //Console.WriteLine(classLeetCode.CountPartitions(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CountPartitions(nums));

            ////(3438.) Find Valid Pair of Adjacent Digits in String (EASY)
            //string s = "2523533";

            //LeetCode_3438 classLeetCode = new LeetCode_3438();
            //Console.WriteLine(classLeetCode.FindValidPair(s));

            ////OR

            //Console.WriteLine(leetCodeAll.FindValidPair(s));

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

            ////(3446.) Sort Matrix by Diagonals (MEDIUM)
            //int[][] grid = [[1, 2, 5, 0], [3, 4, 0, 4], [4, 1, 0, 0], [4, 2, 4, 1]];

            //LeetCode_3446 classLeetCode = new LeetCode_3446();
            //int[][] result = classLeetCode.SortMatrix(grid);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////OR

            //int[][] result1 = leetCodeAll.SortMatrix(grid);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(3452.) Sum of Good Numbers (EASY)
            //int[] nums = [1, 3, 2, 1, 5, 4];
            //int k = 2;

            //LeetCode_3452 classLeetCode = new LeetCode_3452();
            //Console.WriteLine(classLeetCode.SumOfGoodNumbers(nums,k));

            ////OR

            //Console.WriteLine(leetCodeAll.SumOfGoodNumbers(nums, k));

            ////(3456.) Find Special Substring of Length K (EASY)
            //string s = "jkjhfgg";
            //int k = 2;

            //LeetCode_3456 classLeetCode = new LeetCode_3456();
            //Console.WriteLine(classLeetCode.HasSpecialSubstring(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.HasSpecialSubstring(s, k));

            ////(3461.) Check If Digits Are Equal in String After Operations I (EASY)
            //string s = "323";

            //LeetCode_3461 classLeetCode = new LeetCode_3461();
            //Console.WriteLine(classLeetCode.HasSameDigits(s));

            ////OR

            //Console.WriteLine(leetCodeAll.HasSameDigits(s));

            ////(3467.) Transform Array by Parity (EASY)
            //int[] nums = [4, 3, 2, 1];

            //LeetCode_3467 classLeetCode = new LeetCode_3467();
            //int[] result = classLeetCode.TransformArray(nums);

            //Console.WriteLine(string.Join(',', result));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.TransformArray(nums)));

            ////(3471.) Find the Largest Almost Missing Integer (EASY)
            //int[] nums = [3, 9, 2, 1, 7];
            //int k = 3;

            //LeetCode_3471 classLeetCode = new LeetCode_3471();
            //Console.WriteLine(classLeetCode.LargestInteger(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.LargestInteger(nums, k));

            ////(3475.) DNA Pattern Recognition (MEDIUM)
            //string SqlQuery =
            //        @"
            //        SELECT 
            //            a.sample_id
            //            ,dna_sequence
            //            ,species
            //            ,EXISTS (SELECT 1 FROM Samples b WHERE LEFT(dna_sequence, 3) =  'ATG' and b.sample_id = a.sample_id) as has_start 
            //            ,EXISTS (SELECT 1 FROM Samples b WHERE RIGHT(dna_sequence, 3) IN ('TAA', 'TAG', 'TGA') and b.sample_id = a.sample_id) as has_stop  
            //            ,EXISTS (SELECT 1 FROM Samples b WHERE b.dna_sequence  like '%ATAT%' and b.sample_id = a.sample_id) as has_atat
            //            ,EXISTS (SELECT 1 FROM Samples b WHERE b.dna_sequence  like '%GGG%' and b.sample_id = a.sample_id) as has_ggg
            //        FROM 
            //        Samples a 
            //    ";

            ////OR

            //LeetCode_3475 classLeetCode = new LeetCode_3475();

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

            ////(3483.) Unique 3-Digit Even Numbers (EASY)
            //int[] digits = [1, 2, 3, 4];

            //LeetCode_3483 classLeetCode = new LeetCode_3483();
            //Console.WriteLine(classLeetCode.TotalNumbers(digits));

            ////OR

            //Console.WriteLine(leetCodeAll.TotalNumbers(digits));

            ////(3484.) Design Spreadsheet (MEDIUM)
            //LeetCode_3484.Spreadsheet spreadsheet = new LeetCode_3484.Spreadsheet(3);
            //Console.WriteLine(spreadsheet.GetValue("=5+7")); // returns 12 (5+7)
            //spreadsheet.SetCell("A1", 10); // sets A1 to 10
            //Console.WriteLine(spreadsheet.GetValue("=A1+6")); // returns 16 (10+6)
            //spreadsheet.SetCell("B2", 15); // sets B2 to 15
            //Console.WriteLine(spreadsheet.GetValue("=A1+B2")); // returns 25 (10+15)
            //spreadsheet.ResetCell("A1"); // resets A1 to 0
            //Console.WriteLine(spreadsheet.GetValue("=A1+B2")); // returns 15 (0+15)

            ////OR

            //LeetCodeAll.SpreadsheetTask3484 spreadsheet1 = new LeetCodeAll.SpreadsheetTask3484(3);
            //Console.WriteLine(spreadsheet1.GetValue("=5+7")); // returns 12 (5+7)
            //spreadsheet1.SetCell("A1", 10); // sets A1 to 10
            //Console.WriteLine(spreadsheet1.GetValue("=A1+6")); // returns 16 (10+6)
            //spreadsheet1.SetCell("B2", 15); // sets B2 to 15
            //Console.WriteLine(spreadsheet1.GetValue("=A1+B2")); // returns 25 (10+15)
            //spreadsheet1.ResetCell("A1"); // resets A1 to 0
            //Console.WriteLine(spreadsheet1.GetValue("=A1+B2")); // returns 15 (0+15)

            ////(3487.) Maximum Unique Subarray Sum After Deletion (EASY)
            //int[] nums = [-10, 18, 1, 18, -5];

            //LeetCode_3487 classLeetCode = new LeetCode_3487();
            //Console.WriteLine(classLeetCode.MaxSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxSum(nums));

            ////(3492.) Maximum Containers on a Ship (EASY)
            //int n = 2;
            //int w = 3;
            //int maxWeight = 15;

            //LeetCode_3492 classLeetCode = new LeetCode_3492();
            //Console.WriteLine(classLeetCode.MaxContainers(n, w, maxWeight));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxContainers(n, w, maxWeight));

            ////(3494.) Find the Minimum Amount of Time to Brew Potions (MEDIUM)
            //int[] skill = [1, 5, 2, 4];
            //int[] mana = [5, 1, 4, 2];

            //LeetCode_3494 classLeetCode = new LeetCode_3494();
            //Console.WriteLine(classLeetCode.MinTime(skill, mana));

            ////OR

            //Console.WriteLine(leetCodeAll.MinTime(skill, mana));

            ////(3498.) Reverse Degree of a String (EASY)
            //string s = "abc";

            //LeetCode_3498 classLeetCode = new LeetCode_3498();
            //Console.WriteLine(classLeetCode.ReverseDegree(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ReverseDegree(s));

            ////(3502.) Minimum Cost to Reach Every Position (EASY)
            //int[] cost = [5, 3, 4, 1, 3, 2];

            //LeetCode_3502 classLeetCode = new LeetCode_3502();
            //Console.WriteLine(string.Join(',', classLeetCode.MinCosts(cost)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MinCosts(cost)));

            ////(3507.) Minimum Pair Removal to Sort Array I (EASY)
            //int[] nums = [5, 2, 3, 1];

            //LeetCode_3507 classLeetCode = new LeetCode_3507();
            //Console.WriteLine(classLeetCode.MinimumPairRemoval(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumPairRemoval(nums));

            ////(3512.) Minimum Operations to Make Array Sum Divisible by K (EASY)
            //int[] nums = [3, 9, 7];
            //int k = 5;

            //LeetCode_3512 classLeetCode = new LeetCode_3512();
            //Console.WriteLine(classLeetCode.MinOperations(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperations(nums, k));

            ////(3516.) Find Closest Person (EASY)
            //int x = 2;
            //int y = 7;
            //int z = 4;

            //LeetCode_3516 classLeetCode = new LeetCode_3516();
            //Console.WriteLine(classLeetCode.FindClosest(x, y, z));

            ////OR

            //Console.WriteLine(leetCodeAll.FindClosest(x, y, z));

            ////(3522.) Calculate Score After Performing Instructions (MEDIUM)
            //string[] instructions = ["jump", "add", "add", "jump", "add", "jump"];
            //int[] values = [2, 1, 3, 1, -2, -3];

            //LeetCode_3522 classLeetCode = new LeetCode_3522();
            //Console.WriteLine(classLeetCode.CalculateScore(instructions, values));

            ////OR

            //Console.WriteLine(leetCodeAll.CalculateScore(instructions, values));

            ////(3527.) Find the Most Common Response (MEDIUM)
            //IList<IList<string>> responses = [["good", "ok", "good", "ok"], ["ok", "bad", "good", "ok", "ok"], ["good"], ["bad"]];

            //LeetCode_3527 classLeetCode = new LeetCode_3527();
            //Console.WriteLine(classLeetCode.FindCommonResponse(responses));

            ////OR

            //Console.WriteLine(leetCodeAll.FindCommonResponse(responses));

            ////(3536.) Maximum Product of Two Digits (EASY)
            //int n = 124;

            //LeetCode_3536 classLeetCode = new LeetCode_3536();
            //Console.WriteLine(classLeetCode.MaxProduct(n));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxProduct(n));

            ////(3541.) Find Most Frequent Vowel and Consonant (EASY)
            //string s = "cz";

            //LeetCode_3541 classLeetCode = new LeetCode_3541();
            //Console.WriteLine(classLeetCode.MaxFreqSum(s));

            ////OR

            //Console.WriteLine(leetCodeAll.MaxFreqSum(s));

            ////(3542.) Minimum Operations to Convert All Elements to Zero (MEDIUM)
            //int[] nums = [5, 3, 3];

            //LeetCode_3542 classLeetCode = new LeetCode_3542();
            //Console.WriteLine(classLeetCode.MinOperations(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinOperations(nums));

            ////(3545.) Minimum Deletions for At Most K Distinct Characters (EASY)
            //string s = "aabbccddeeff";
            //int k = 3;

            //LeetCode_3545 classLeetCode = new LeetCode_3545();
            //Console.WriteLine(classLeetCode.MinDeletion(s, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinDeletion(s, k));

            ////(3550.) Smallest Index With Digit Sum Equal to Index (EASY)
            //int[] nums = [1, 10, 11];

            //LeetCode_3550 classLeetCode = new LeetCode_3550();
            //Console.WriteLine(classLeetCode.SmallestIndex(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestIndex(nums));

            ////(3582.) Generate Tag for Video Caption (EASY)
            string caption = "   ";

            LeetCode_3582 classLeetCode = new LeetCode_3582();
            Console.WriteLine(classLeetCode.GenerateTag(caption));

            //OR

            Console.WriteLine(leetCodeAll.GenerateTag(caption));

            ////(3591.) Check if Any Element Has Prime Frequency (EASY)
            //int[] nums = [3, 0, 3, 6, 3, 3];

            //LeetCode_3591 classLeetCode = new LeetCode_3591();
            //Console.WriteLine(classLeetCode.CheckPrimeFrequency(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckPrimeFrequency(nums));

            ////(3602.) Hexadecimal and Hexatrigesimal Conversion (EASY)
            //int n = 36;

            //LeetCode_3602 classLeetCode = new LeetCode_3602();
            //Console.WriteLine(classLeetCode.ConcatHex36(n));

            ////OR

            //Console.WriteLine(leetCodeAll.ConcatHex36(n));

            ////(3606.) Coupon Code Validator (EASY)
            //string[] code = ["SAVE20", "", "PHARMA5", "SAVE@20"];
            //string[] businessLine = ["restaurant", "grocery", "pharmacy", "restaurant"];
            //bool[] isActive = [true, true, true, true];

            //LeetCode_3606 classLeetCode = new LeetCode_3606();
            //foreach (var item in classLeetCode.ValidateCoupons(code, businessLine, isActive))
            //{
            //    Console.WriteLine(item);
            //}

            ////OR

            //foreach (var item in leetCodeAll.ValidateCoupons(code, businessLine, isActive))
            //{
            //    Console.WriteLine(item);
            //}

            ////(3612.) Process String with Special Operations I (MEDIUM)
            //string s = "a#b%*";

            //LeetCode_3612 classLeetCode = new LeetCode_3612();
            //Console.WriteLine(classLeetCode.ProcessStr(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ProcessStr(s));

            ////(3618.) Split Array by Prime Indices (MEDIUM)
            //int[] nums = [-1,5,7,0]; 

            //LeetCode_3618 classLeetCode = new LeetCode_3618();
            //Console.WriteLine(classLeetCode.SplitArray(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SplitArray(nums));

            ////(3622.) Check Divisibility by Digit Sum and Product (EASY)
            //int n = 99;

            //LeetCode_3622 classLeetCode = new LeetCode_3622();
            //Console.WriteLine(classLeetCode.CheckDivisibility(n));

            ////OR

            //Console.WriteLine(leetCodeAll.CheckDivisibility(n));

            ////(3627.) Maximum Median Sum of Subsequences of Size 3 (MEDIUM)
            //int[] nums = [1000000000, 1, 1];

            //LeetCode_3627 classLeetCode = new LeetCode_3627();
            //Console.WriteLine(classLeetCode.MaximumMedianSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumMedianSum(nums));

            ////(3634.) Minimum Removals to Balance Array (MEDIUM)
            //int[] nums = [1, 6, 2, 9];
            //int k = 3;

            //LeetCode_3634 classLeetCode = new LeetCode_3634();
            //Console.WriteLine(classLeetCode.MinRemoval(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MinRemoval(nums, k));

            ////(3637.) Trionic Array I (EASY)
            //int[] nums = [1, 3, 2];

            //LeetCode_3637 classLeetCode = new LeetCode_3637();
            //Console.WriteLine(classLeetCode.IsTrionic(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.IsTrionic(nums));

            ////(3643.) Flip Square Submatrix Vertically (EASY)
            //int[][] grid = [[6, 16, 14], [1, 2, 19], [14, 17, 15], [18, 7, 6], [14, 12, 5]];
            //int x = 2;
            //int y = 1;
            //int k = 2;

            //LeetCode_3643 classLeetCode = new LeetCode_3643();
            //foreach (var item in classLeetCode.ReverseSubmatrix(grid, x, y, k))
            //{
            //    Console.WriteLine(string.Join(',',item));
            //}

            ////OR

            //foreach (var item in leetCodeAll.ReverseSubmatrix(grid, x, y, k))
            //{
            //    Console.WriteLine(string.Join(',', item));
            //}

            ////(3658.) GCD of Odd and Even Sums (EASY)
            //int n = 4;

            //LeetCode_3658 classLeetCode = new LeetCode_3658();
            //Console.WriteLine(classLeetCode.GcdOfOddEvenSums(n));

            ////OR

            //Console.WriteLine(leetCodeAll.GcdOfOddEvenSums(n));

            ////(3663.) Find The Least Frequent Digit (EASY)
            //int n = 723344511;

            //LeetCode_3663 classLeetCode = new LeetCode_3663();
            //Console.WriteLine(classLeetCode.GetLeastFrequentDigit(n));

            ////OR

            //Console.WriteLine(leetCodeAll.GetLeastFrequentDigit(n));

            ////(3668.) Restore Finishing Order (EASY)
            //int[] order = [3, 1, 2, 5, 4];
            //int[] friends = [1, 3, 4];

            //LeetCode_3668 classLeetCode = new LeetCode_3668();
            //Console.WriteLine(string.Join(',', classLeetCode.RecoverOrder(order, friends)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.RecoverOrder(order, friends)));

            ////(3678.) Smallest Absent Positive Greater Than Average (EASY)
            //int[] nums = [3, 5];

            //LeetCode_3678 classLeetCode = new LeetCode_3678();
            //Console.WriteLine(classLeetCode.SmallestAbsent(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.SmallestAbsent(nums));

            ////(3683.) Earliest Time to Finish One Task (EASY)
            //int[][] tasks = [[1,6], [2,3]];

            //LeetCode_3683 classLeetCode = new LeetCode_3683();
            //Console.WriteLine(classLeetCode.EarliestTime((tasks)));

            ////OR

            //Console.WriteLine(leetCodeAll.EarliestTime((tasks)));

            ////(3684.) Maximize Sum of At Most K Distinct Elements (EASY)
            //int[] nums = [84, 93, 100, 77, 90];
            //int k = 3;

            //LeetCode_3684 classLeetCode = new LeetCode_3684();
            //Console.WriteLine(string.Join(',',classLeetCode.MaxKDistinct(nums, k)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.MaxKDistinct(nums, k)));

            ////(3688.) Bitwise OR of Even Numbers in an Array (EASY)
            //int[] nums = [1,2,3,4,5,6];

            //LeetCode_3688 classLeetCode = new LeetCode_3688();
            //Console.WriteLine(classLeetCode.EvenNumberBitwiseORs(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.EvenNumberBitwiseORs(nums));

            ////(3697.) Compute Decimal Representation (EASY)
            //int n = 537;

            //LeetCode_3697 classLeetCode = new LeetCode_3697();
            //Console.WriteLine(string.Join(',',classLeetCode.DecimalRepresentation(n)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.DecimalRepresentation(n)));

            ////(3701.) Compute Alternating Sum (EASY)
            //int[] nums = [1, 3, 5, 7];

            //LeetCode_3701 classLeetCode = new LeetCode_3701();
            //Console.WriteLine(classLeetCode.AlternatingSum(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.AlternatingSum(nums));

            ////(3707.) Equal Score Substrings (EASY)
            //string s = "abdcd";

            //LeetCode_3707 classLeetCode = new LeetCode_3707();
            //Console.WriteLine(classLeetCode.ScoreBalance(s));

            ////OR

            //Console.WriteLine(leetCodeAll.ScoreBalance(s));

            ////(3712.) Sum of Elements With Frequency Divisible by K (EASY)
            //int[] nums = [1, 2, 2, 3, 3, 3, 3, 4];
            //int k = 2;

            //LeetCode_3712 classLeetCode = new LeetCode_3712();
            //Console.WriteLine(classLeetCode.SumDivisibleByK(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.SumDivisibleByK(nums, k));

            ////(3713.) Longest Balanced Substring I (MEDIUM)
            //string s = "zzabccy";

            //LeetCode_3713 classLeetCode = new LeetCode_3713();
            //Console.WriteLine(classLeetCode.LongestBalanced(s));

            ////OR

            //Console.WriteLine(leetCodeAll.LongestBalanced(s));

            ////(3718.) Smallest Missing Multiple of K (EASY)
            //int[] nums = [8, 2, 3, 4, 6];
            //int k = 2;

            //LeetCode_3718 classLeetCode = new LeetCode_3718();
            //Console.WriteLine(classLeetCode.MissingMultiple(nums, k));

            ////OR

            //Console.WriteLine(leetCodeAll.MissingMultiple(nums, k));

            ////(3731.) Find Missing Elements (EASY)
            //int[] nums = [1, 4, 2, 5];

            //LeetCode_3731 classLeetCode = new LeetCode_3731();
            //Console.WriteLine(string.Join(',', classLeetCode.FindMissingElements(nums)));

            ////OR

            //Console.WriteLine(string.Join(',', leetCodeAll.FindMissingElements(nums)));

            ////(3736.) Minimum Moves to Equal Array Elements III (EASY)
            //int[] nums = [2, 1, 3];

            //LeetCode_3736 classLeetCode = new LeetCode_3736();
            //Console.WriteLine(classLeetCode.MinMoves(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinMoves(nums));

            ////(3740.) Minimum Distance Between Three Equal Elements I (EASY)
            //int[] nums = [1, 1, 2, 3, 2, 1, 2];

            //LeetCode_3740 classLeetCode = new LeetCode_3740();
            //Console.WriteLine(classLeetCode.MinimumDistance(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumDistance(nums));

            ////(3750.) Minimum Number of Flips to Reverse Binary String (EASY)
            //int n = 10;

            //LeetCode_3750 classLeetCode = new LeetCode_3750();
            //Console.WriteLine(classLeetCode.MinimumFlips(n));

            ////OR

            //Console.WriteLine(leetCodeAll.MinimumFlips(n));

            ////(3754.) Concatenate Non - Zero Digits and Multiply by Sum I (EASY)
            //int n = 0;

            //LeetCode_3754 classLeetCode = new LeetCode_3754();
            //Console.WriteLine(classLeetCode.SumAndMultiply(n));

            ////OR

            //Console.WriteLine(leetCodeAll.SumAndMultiply(n));

            ////(3788.) Maximum Score of a Split (MEDIUM)
            //int[] nums = [73, 32, 54];

            //LeetCode_3788 classLeetCode = new LeetCode_3788();
            //Console.WriteLine(classLeetCode.MaximumScore(nums));

            ////OR

            //Console.WriteLine(leetCodeAll.MaximumScore(nums));





















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
