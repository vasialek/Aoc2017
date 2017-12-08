using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCode.Bll;
using FluentAssertions;
using System.Linq;

namespace AdventCode.Tests
{
    [TestClass]
    public class CaptchaBllTest
    {
        private CaptchaBll _bll = null;

        [TestInitialize]
        public void TestInit()
        {
            _bll = new CaptchaBll();
        }

        [TestMethod]
        public void GetMatchingDigits_GetNothing()
        {
            var digits = _bll.GetMatchingDigits(new int[] { 1, 2, 3, 4 }, 1);

            // Expecting no matching digits
            digits.Should().HaveCount(0);
        }

        [TestMethod]
        public void GetMatchingDigits_GetTwo1_1122()
        {
            var digits = _bll.GetMatchingDigits("1122");

            // First '1' match second '1'
            digits.Count(x => x == 1).Should().Be(1);
        }

        [TestMethod]
        public void GetMatchingDigits_GetFour1_1111()
        {
            var digits = _bll.GetMatchingDigits("1111");

            // All '1' match next symbol
            digits.Count(x => x == 1).Should().Be(4);
        }

        [TestMethod]
        public void GetMatchingDigits_GetNothing_1234()
        {
            var digits = _bll.GetMatchingDigits("1234");

            digits.Count.Should().Be(0);
        }

        [TestMethod]
        public void GetMatchingDigits_GetOne9_91212129()
        {
            var digits = _bll.GetMatchingDigits("91212129");

            // Last '9' matches first
            digits.Count(x => x == 9).Should().Be(1);
        }

        [TestMethod]
        public void SumMatchingDigits_1111()
        {
            int sum = _bll.SumMatchingDigits("1111");

            sum.Should().Be(4);
        }

        [TestMethod]
        public void SumMatchingDigits_1212_WhenStepIs2()
        {
            int sum = _bll.SumMatchingDigits("1212", 2);

            sum.Should().Be(6);
        }

        [TestMethod]
        public void SumMatchingDigits_1221_WhenStepIs2()
        {
            int sum = _bll.SumMatchingDigits("1221", 2);

            sum.Should().Be(0);
        }

        [TestMethod]
        public void SumMatchingDigits_123425_WhenStepIs3()
        {
            int sum = _bll.SumMatchingDigits("123425", 3);

            sum.Should().Be(4);
        }

        [TestMethod]
        public void SumMatchingDigits_12131415_WhenStepIs4()
        {
            int sum = _bll.SumMatchingDigits("12131415", 4);

            sum.Should().Be(4);
        }
    }
}
