using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bowling.Game obj = new Bowling.Game();
            int[] arr1 = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            for (int i = 0; i < arr1.Length; i++)
                obj.Roll(arr1[i]);
            Assert.AreEqual(obj.GetScore(), 300);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bowling.Game obj = new Bowling.Game();
            int[] arr2 = new int[] { 10, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5 };
            for (int i = 0; i < arr2.Length; i++)
                obj.Roll(arr2[i]);
            Assert.AreEqual(obj.GetScore(), 98);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Bowling.Game obj = new Bowling.Game();
            int[] arr3 = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            for (int i = 0; i < arr3.Length; i++)
                obj.Roll(arr3[i]);
            Assert.AreEqual(obj.GetScore(), 200);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //check score is correct till fourth frame
            Bowling.Game obj = new Bowling.Game();
            int[] arr4 = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            for (int i = 0; i < 8; i++)
                obj.Roll(arr4[i]);
            Assert.AreEqual(obj.GetScore(), 70);
        }
        public void TestMethod5()
        {
            //check score is correct till fourth frame
            Bowling.Game obj = new Bowling.Game();
            int[] arr2 = new int[] { 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 10, 3, 5, 3, 5 };
            for (int i = 0; i < arr2.Length; i++)
                obj.Roll(arr2[i]);
            Assert.AreEqual(obj.GetScore(), 98);
        }
    }
}
