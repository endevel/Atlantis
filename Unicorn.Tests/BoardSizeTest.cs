using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unicorn.BoardSize;

namespace Unicorn.Tests
{
    [TestClass]
    public class BoardSizeTest
    {
        [TestMethod]
        public void TestCreateStandard()
        {
            IBoardSize bs = BoardSizeFactory.CreateStandardBoard();

            Assert.AreEqual(8, bs.Height);
            Assert.AreEqual(8, bs.Width);
        }

        [TestMethod]
        public void TestCreateBig()
        {
            IBoardSize bs = BoardSizeFactory.CreateBigBoard();

            Assert.AreEqual(10, bs.Height);
            Assert.AreEqual(10, bs.Width);
        }

        [TestMethod]
        public void TestCreateLarge()
        {
            IBoardSize bs = BoardSizeFactory.CreateLargeBoard();

            Assert.AreEqual(12, bs.Height);
            Assert.AreEqual(12, bs.Width);
        }

        [TestMethod]
        public void TestCreateRectangle()
        {
            IBoardSize bs = BoardSizeFactory.CreateRectangleBoard();

            Assert.AreEqual(8, bs.Height);
            Assert.AreEqual(10, bs.Width);
        }
    }
}
