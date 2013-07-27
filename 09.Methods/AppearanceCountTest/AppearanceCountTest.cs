using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppearanceCountTest
{
    [TestClass]
    public class AppearanceCountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           int[] array = { 24, 23, 7, 24, 117, 75, 24, 13, 15, };
           int count = NumberOfAppearances.AppearanceCount(array, 24);
           Assert.AreEqual(3, count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 24, 23, 75, 43, 9, 0, 75, 15, 757, 19, 75, 24, 117, 75, 24, 13, 15, };
            int count = NumberOfAppearances.AppearanceCount(array, 75);
            Assert.AreEqual(4, count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 24, 85, 13, 34, 23, 7, 24, 117, 75, 24, 13, 15, };
            int count = NumberOfAppearances.AppearanceCount(array, 7);
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] array = { 24, 23, 7, 24, 117, 75, 24, 13, 15, };
            int count = NumberOfAppearances.AppearanceCount(array, 9);
            Assert.AreEqual(0, count);
        }
    }
}
