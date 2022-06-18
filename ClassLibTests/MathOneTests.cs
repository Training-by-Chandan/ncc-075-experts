using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Tests
{
    [TestClass()]
    public class MathOneTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int a = 2, b = 2, expected = 4;
            MathOne m = new MathOne();
            var actual = m.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTestV2()
        {
            int a = 3, b = 2, expected = 5;
            MathOne m = new MathOne();
            var actual = m.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTestV3()
        {
            int a = 0, b = 2, expected = 5;
            MathOne m = new MathOne();
            Assert.ThrowsException<ArgumentException>(() =>
            {
                m.Add(a, b);
            });
        }

        [TestMethod()]
        public void AddTestV5()
        {
            int a = 2, b = 0;
            MathOne m = new MathOne();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                m.Add(a, b);
            });
        }
    }
}