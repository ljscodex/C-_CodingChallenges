﻿using ForCodingChallenges.LeetCode;
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ForCodingChallenges.Codility;
using ForCodingChallenges.BenchmarkGeneric;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

    LeetCode_Math lm = new LeetCode_Math();
    LeetCode_TwoPointers lt = new LeetCode_TwoPointers();
    LeetCode_ArrayString larray = new LeetCode_ArrayString();
    Codility codility = new Codility();

// Benchmark examples
    BenchMark_Generic bg = new BenchMark_Generic();

//    bg.TernaryUse();
//    bg.NoTernaryUse();


//LeetCode Examples
//lm.TrailingZeroes(9052);
/*
larray.RomanToInt("III");
larray.RomanToInt("LVIII");
larray.RomanToInt("VII");
larray.RomanToInt("IX");
larray.RomanToInt("M");
larray.RomanToInt("MM");
larray.RomanToInt("MMMCMXCIX");
larray.RomanToInt("MCMLXXXIII");
*/

//int result = larray.SingleNumber([2, 2, 1]);
//result = larray.SingleNumber([4, 1, 2, 1, 2]);
//result = larray.SingleNumber([1]); 


/* TODO Last testcase is wrong on the website.
larray.IsSubsequence("abc", "ahbgdc");
larray.IsSubsequence("aaaaaa", "bbaaaa");
larray.IsSubsequence("ab", "baab");
larray.IsSubsequence("abc", "acb");
larray.IsSubsequence("bcd", "uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu...");
*/

/*
bool result = larray.ContainsDuplicate([1, 2, 3, 1]);
result = larray.ContainsDuplicate([1, 2, 3, 4]);
result = larray.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);
*/


/*bool result = larray.ContainsNearbyDuplicate([1, 2, 3, 1],  3);
result = larray.ContainsNearbyDuplicate([1, 0, 1, 1], 1);
result = larray.ContainsNearbyDuplicate([1, 2, 3, 1, 2, 3], 1);
*/

char[] s =  {'h', 'e', 'l', 'l', 'o' ,};
larray.ReverseString(s);

//codility.MaxsumOfSubArrays([1, 3, 6, 1, 6, 6, 9, 9]);
//codility.TotalWords("We test coders. Give us a Try?");
//codility.TotalWords("Forget  CVs..Save time . x x");
//string palindrome = codility.CreatePalindrome(5, 2);
//string palindrome1 = codility.CreatePalindrome(8, 3);
//string palindrome2 = codility.CreatePalindrome(3, 2);

//Codility Examples 
//var a = codility.longestPassword("test 5 a0A pass007 ?xy1");

//var u = codility.MissingInteger([1, 3, 6, 4, 1, 2]);
//var i = codility.MissingInteger([-1, -3]);
Console.ReadLine();

