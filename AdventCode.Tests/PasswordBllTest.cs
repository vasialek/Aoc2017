using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCode.Bll;
using FluentAssertions;

namespace AdventCode.Tests
{
    [TestClass]
    public class PasswordBllTest
    {
        private PasswordBll _bll = new PasswordBll();

        #region Has anagrams

        [TestMethod]
        public void HasAnagrams_No_OneWord()
        {
            string s = "aaa";

            bool has = _bll.HasAnagrams(s);

            has.Should().BeFalse();
        }

        [TestMethod]
        public void HasAnagrams_Yes_TwoSame()
        {
            string s = "aaa aaa";

            bool has = _bll.HasAnagrams(s);

            has.Should().BeTrue();
        }

        [TestMethod]
        public void HasAnagrams_Yes2()
        {
            string s = "abcde xyz ecdab";

            bool has = _bll.HasAnagrams(s);

            has.Should().BeTrue();
        }

        [TestMethod]
        public void HasAnagrams_Yes3()
        {
            string s = "oiii ioii iioi iiio";

            bool has = _bll.HasAnagrams(s);

            has.Should().BeTrue();
        }

        #endregion

        #region Is anagram

        [TestMethod]
        public void IsAnagram_No_LengthDifferent()
        {
            bool isAnagram = _bll.IsAnagram("aaaaaa", "bbb");

            isAnagram.Should().BeFalse();
        }

        [TestMethod]
        public void IsAnagram_Yes_SameStrings()
        {
            bool isAnagram = _bll.IsAnagram("aaaaaa", "aaaaaa");

            isAnagram.Should().BeTrue();
        }

        [TestMethod]
        public void IsAnagram_Yes()
        {
            bool isAnagram = _bll.IsAnagram("abcde", "edcba");

            isAnagram.Should().BeTrue();
        }

        #endregion

        #region Has duplicates

        [TestMethod]
        public void HasDuplicateWords_NoDuplicated()
        {
            string s = "aa bb cc dd ee";

            bool hasDuplicates = _bll.HasDuplicateWords(s);

            hasDuplicates.Should().BeFalse();
        }

        [TestMethod]
        public void HasDuplicateWords_Has()
        {
            string s = "aa bb cc dd aa";

            bool hasDuplicates = _bll.HasDuplicateWords(s);

            hasDuplicates.Should().BeTrue();
        }

        [TestMethod]
        public void HasDuplicateWords_NoDuplicated2()
        {
            string s = "aa bb cc dd aaa";

            bool hasDuplicates = _bll.HasDuplicateWords(s);

            hasDuplicates.Should().BeFalse();
        }

        #endregion
    }
}
