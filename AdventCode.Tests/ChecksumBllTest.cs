using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCode.Bll;
using FluentAssertions;

namespace AdventCode.Tests
{
    [TestClass]
    public class ChecksumBllTest
    {
        private ChecksumBll _bll = new ChecksumBll();

        [TestMethod]
        public void TsvToNumbers_NotNull()
        {
            var ar = _bll.TsvToNumbers("5\t1\t9\t5");

            ar.Should().NotBeNull();
        }

        [TestMethod]
        public void TsvToNumbers_GetFirst()
        {
            var ar = _bll.TsvToNumbers("5\t1\t9\t5");

            ar[0].Should().Be(5);
        }

        [TestMethod]
        public void TsvToNumbers_GetSecond()
        {
            var ar = _bll.TsvToNumbers("5\t1\t9\t5");

            ar[1].Should().Be(1);
        }

        [TestMethod]
        public void GetMinMax_NotNull()
        {
            var t = _bll.GetMinMax(new int[] { 5, 1, 9, 5 });

            t.Should().NotBeNull();
        }

        [TestMethod]
        public void GetMinMax_Min_5195()
        {
            var t = _bll.GetMinMax("5\t1\t9\t5");

            t.Item1.Should().Be(1);
        }

        [TestMethod]
        public void GetMinMax_Max_5195()
        {
            var t = _bll.GetMinMax("5\t1\t9\t5");

            t.Item2.Should().Be(9);
        }

        [TestMethod]
        public void CalculateChecksum_5195()
        {
            int cs = _bll.CalculateChecksum("5\t1\t9\t5");

            cs.Should().Be(8);
        }

        [TestMethod]
        public void CalculateChecksum_753()
        {
            int cs = _bll.CalculateChecksum("7\t5\t3");

            cs.Should().Be(4);
        }

        [TestMethod]
        public void CalculateChecksum_2468()
        {
            int cs = _bll.CalculateChecksum(new int[] { 2, 4, 6, 8 });

            cs.Should().Be(6);
        }


    }
}
