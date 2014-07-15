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
            for (int i = 0; i < 3; i++)
                obj.Roll(10);
            Assert.AreEqual(obj.GetScore(), 60);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bowling.Game obj = new Bowling.Game();
            obj.Roll(10);
            for (int i = 0; i < 9; i++) { obj.Roll(3); obj.Roll(5); }
            Assert.AreEqual(obj.GetScore(), 98);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Bowling.Game obj = new Bowling.Game();
            for (int i = 0; i < 20; i++)
                obj.Roll(5);
            Assert.AreEqual(obj.GetScore(), 190);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //check score is correct till fourth frame
            Bowling.Game obj = new Bowling.Game();
            for (int i = 0; i < 8; i++)
                obj.Roll(5);
            Assert.AreEqual(obj.GetScore(), 70);
        }
        public void TestMethod5()
        {
            Bowling.Game obj = new Bowling.Game();
            for (int i = 0; i < 9; i++) { obj.Roll(3); obj.Roll(5); }
            obj.Roll(10);
            for (int i = 0; i < 2; i++) { obj.Roll(3); obj.Roll(5); }
            Assert.AreEqual(obj.GetScore(), 98);
        }
        public void TestMethod6()
        {
            Bowling.Game obj = new Bowling.Game();
            for (int i = 0; i < 12; i++)
                obj.Roll(10);
            Assert.AreEqual(obj.GetScore(), 300);
        }
    }
}
