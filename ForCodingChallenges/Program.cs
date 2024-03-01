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

    bg.TernaryUse();
    bg.NoTernaryUse();
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
//larray.IsSubsequence("abc", "ahbgdc");
//larray.IsSubsequence("aaaaaa", "bbaaaa");
//larray.IsSubsequence("ab", "baab");
//larray.IsSubsequence("abc", "acb");

//codility.MaxsumOfSubArrays([1, 3, 6, 1, 6, 6, 9, 9]);
//codility.TotalWords("We test coders. Give us a Try?");
//codility.TotalWords("Forget  CVs..Save time . x x");
string palindrome = codility.CreatePalindrome(5, 2);
string palindrome1 = codility.CreatePalindrome(8, 3);
string palindrome2 = codility.CreatePalindrome(3, 2);

//Codility Examples 
//var a = codility.longestPassword("test 5 a0A pass007 ?xy1");

//var u = codility.MissingInteger([1, 3, 6, 4, 1, 2]);
//var i = codility.MissingInteger([-1, -3]);
//Console.ReadLine();

