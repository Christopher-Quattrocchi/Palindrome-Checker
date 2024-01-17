using Palindromes.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Palindrome.Tests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void WordCheck_IsPalindrome_ReturnsTrue()
        {
            PalindromeChecker wordCheck = new PalindromeChecker();
            wordCheck.UserWord = "racecar";
            bool result = wordCheck.IsItPalindrome();
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AnotherWordCheck_IsPalindrome_ReturnsTrue()
        {
            PalindromeChecker numStringCheck = new PalindromeChecker();
            numStringCheck.UserWord = "101";
            bool result = numStringCheck.IsItPalindrome();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WordFailCheck_CheckIfWordIsNotPalindrome_Bool()
        {
            PalindromeChecker wordFailCheck = new PalindromeChecker();
            wordFailCheck.UserWord = "hello";

            bool result = wordFailCheck.IsItPalindrome();

            Assert.AreEqual(false, result);
        }
    }
}