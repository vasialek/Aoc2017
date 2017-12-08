using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventCode.Bll;
using FluentAssertions;

namespace AdventCode.Tests
{
    [TestClass]
    public class SpiralBllTest
    {
        private SpiralBll _bll = new SpiralBll();

        #region Get width

        [TestMethod]
        public void GetSpiralWidth_GetFor9()
        {
            /**
             *  5 4 3
             *  6 1 2
             *  7 8 9
             */
            int w = _bll.GetSpiralWidth(9);

            w.Should().Be(3);
        }

        [TestMethod]
        public void GetSpiralWidth_GetFor78()
        {
            /**
             *  5 4 3
             *  6 1 2
             *  7 8 9
             */
            int w = _bll.GetSpiralWidth(78);

            w.Should().Be(9);
        }

        #endregion

        #region Distance

        [TestMethod]
        public void CalculateDistance_For1()
        {
            /**
             *  5 4 3
             *  6 1 2
             *  7 8 9
             */
            var ar = _bll.GenerateSpiralMemory(9);

            // Calculate from center (number 1)
            int distance = _bll.CalculateDistance(ar, 1);

            // Expecting 0
            distance.Should().Be(0);
        }

        [TestMethod]
        public void CalculateDistance_For23()
        {
            /**
             * 17 16 15 14 13
             * 18  5  4  3 12
             * 19  6  1  2 11
             * 20  7  8  9 10
             * 21 22 23 24 25
            */
            var ar = _bll.GenerateSpiralMemory(23);

            // Calculate from center (number 1)
            int distance = _bll.CalculateDistance(ar, 23);

            // Expecting from 23: up, up
            distance.Should().Be(2);
        }

        [TestMethod]
        public void CalculateDistance_From12()
        {
            /**
             * 17 16 15 14 13
             * 18  5  4  3 12
             * 19  6  1  2 11
             * 20  7  8  9 10
             * 21 22 23 24 25
            */
            var ar = _bll.GenerateSpiralMemory(23);

            // Calculate from center (number 1)
            int distance = _bll.CalculateDistance(ar, 12);

            // Expecting from 12: left, left, down
            distance.Should().Be(3);
        }

        [TestMethod]
        public void CalculateDistance_From1024()
        {
            var ar = _bll.GenerateSpiralMemory(1024);

            // Calculate from center (number 1)
            int distance = _bll.CalculateDistance(ar, 1024);

            distance.Should().Be(31);
        }

        #endregion

        [TestMethod]
        public void FindNumberInSpiral_Get4()
        {
            /**
             *  5 4 3
             *  6 1 2
             *  7 8 9
             */
            var ar = _bll.GenerateSpiralMemory(9);

            var pos = _bll.FindNumberInSpiral(ar, 4);

            pos.Item1.Should().Be(1);
            pos.Item2.Should().Be(0);
        }

        [TestMethod]
        public void FindNumberInSpiral_Get1()
        {
            // Array 9x9
            var ar = _bll.GenerateSpiralMemory(121);

            var pos = _bll.FindNumberInSpiral(ar, 1);

            pos.Item1.Should().Be(5);
            pos.Item2.Should().Be(5);
        }
    }
}
